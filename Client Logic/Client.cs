using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;
using Communicator;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;

namespace Client_Logic
{
    /// <summary>
    /// Represents a client that can connect and communicate with a server!
    /// Registers a new user to a server, or logins to a user in the server!
    /// </summary>
    public class Client : IDisposable
    {
        
        #region Events

        /// <summary>
        /// Event occurs --> when user registration approved by the server!
        /// Event does: Informs the UI that the user is approved!
        /// </summary>
        public event Action UserRegistrationApproved;

        /// <summary>
        /// Event occurs --> when user registration rejected by the server!
        /// Event does: Informs the UI that the user is rejected!
        /// </summary>
        public event Action UserRegistrationRejected;

        /// <summary>
        /// Event occurs --> when this user approved by the server!
        /// Event does: Gets the users connected to the server, and lifts a thread for getting messages, after the user is approved!
        /// </summary>
        public event Action UserApproved;

        /// <summary>
        /// Event occurs --> when a user rejected by the server!
        /// Event does: Displays why the server rejected the user to the GUI!
        /// </summary>
        public event Action UserRejected;

        /// <summary>
        /// Event occurs --> when a user connected to the server!
        /// Event does: Displays the new client connected to the server to the GUI!
        /// </summary>
        /// <param name="User">The user</param>
        public event Action<UserLogin> UserConnected;

        /// <summary>
        /// Event occurs --> when a user disconnected from the server!
        /// Event does: Removes the user from being displayed to the GUI!
        /// </summary>
        /// <param name="User">The user</param>
        public event Action<UserLogin> UserDisconnected;

        /// <summary>
        /// Event occurs --> when a message received from the server!
        /// Event does: Displays the message received to the rich textbox in the GUI!
        /// </summary>
        /// <param name="ChatMessage">The message</param>
        public event Action<ChatMessage> MessageReceived;

        /// <summary>
        /// Event occurs --> when a public message received!
        /// Event does: Displays the message to the GUI!
        /// </summary>
        /// <param name="ChatMessage">The message</param>
        public event Action<ChatMessage> PublicMessageReceived;

        /// <summary>
        /// Event occurs --> when a private message received!
        /// Event does: Displays the message to the GUI!
        /// </summary>
        /// <param name="ChatMessage">The message</param>
        public event Action<ChatMessage> PrivateMessageReceived;

        /// <summary>
        /// Event occurs --> when the server blocked the user!
        /// Event does: Blocks the user from being connected to the server!
        /// </summary>
        /// <param name="ChatMessage">The message</param>
        public event Action<ChatMessage> BlockReceived;

        /// <summary>
        /// Event occurs --> when the server that the client trying to connect, is not found!
        /// Event does: Displays a message that no server is found!
        /// </summary>
        public event Action ServerNotFound;

        /// <summary>
        /// Event occurs --> when connection to the server has been lost!
        /// Event does: Displays a message the connection has been lost, and then selecting the (virtual window) disconnected to the GUI!
        /// </summary>
        public event Action ServerConnectionLost;

        /// <summary>
        /// Event occurs --> when error occurred!
        /// Event does: Displays the error gently to the GUI! closes the application if needed!
        /// </summary>
        /// <param name="string">The error message</param>
        /// <param name="bool">Indicator if to close the application</param>
        public event Action<string, bool> ErrorOccurred;

        #region Implementations of Events!

        /// <summary>
        /// Occurs when the event 'UserApproved' raised!
        /// Event does: Gets the users connected to the server, and lifts a thread for getting messages, after the user is approved!
        /// </summary>
        private void OnUserApproved()
        {
            ConnectedUsers = (List<UserLogin>)binaryFormatter.Deserialize(Stream); // Deserializes the users connected to the server

            IsConnected = true; // Update indicator that the client is connected

            MessagesListener(); // Now, listens to messages on a thread
        }

        /// <summary>
        /// Occurs each time the event 'MessageReceived' raised!
        /// Event does: Finds the type of the message and then raises an event according to it!
        /// </summary>
        /// <param name="message">The message</param>
        private void OnMessageReceived(ChatMessage message)
        {
            if (message.Type == MessageType.Public)
            {
                PublicMessageReceived(message); // Raises an event that the message received is Public
            }
            else if (message.Type == MessageType.Private)
            {
                PrivateMessageReceived(message); // Raises an event that the message received is Private
            }
            else if (message.Type == MessageType.UserConnected)
            {
                UserConnected(message.Sender); // Raises an event that the message received is UserConnected
            }
            else if (message.Type == MessageType.UserDisconnected)
            {
                UserDisconnected(message.Sender); // Raises an event that the message received is UserDisconnected
            }
            else if (message.Type == MessageType.Block)
            {
                BlockReceived(message); // Raises an event that the message received is Block
            }
        }

        /// <summary>
        /// Occurs each time the event 'UserConnected' raised!
        /// Event does: Adds the new user to the connected users list!
        /// </summary>
        /// <param name="user">The user connected</param>
        private void OnUserConnected(UserLogin user)
        {
            ConnectedUsers.Add(user); // Adds the new user to the connected list!
        }

        /// <summary>
        /// Occurs each time the event 'UserDisconnected' raised!
        /// Event does: Removes a user who disconnected from the list of connected users! 
        /// </summary>
        /// <param name="user">The user disconnected</param>
        private void OnUserDisconnected(UserLogin user)
        {
            int indexOfUser = ConnectedUsers.FindIndex(u => u.UserName == user.UserName); // Gets the index of the user in the list
            
            if (indexOfUser > -1)
                ConnectedUsers.RemoveAt(indexOfUser); // Removes the disconnected user from the list
        }

        /// <summary>
        /// Occurs each time the event 'BlockReceived' raised!
        /// Event does: Blocking the user, or displays the user that has blocked from the server!
        /// </summary>
        /// <param name="message">The message information</param>
        private void OnBlockReceived(ChatMessage message)
        {
            int indexOfUser = ConnectedUsers.FindIndex(u => u.UserName == message.SendTo); // Gets the index of the user in the list

            if (indexOfUser > -1)
                ConnectedUsers.RemoveAt(indexOfUser); // Removes the blocked user from the list
        }

        #endregion

        #endregion

        #region Fields

        // Readonly:
        private static readonly object streamLocker = new object(); // Holds a locker for the stream (shared resource)

        // Other:
        private bool isDisposed; // Holds indicator if the client is disposed or not
        private TcpClient client; // Holds the client connection
        private BinaryFormatter binaryFormatter; // Holds the binary formatter for the streams

        #endregion

        #region Properties

        /// <summary>
        /// Holds the information of the user! (Name and Color)
        /// </summary>
        public UserLogin User { get; set; }

        /// <summary>
        /// Holds the stream the client uses!
        /// </summary>
        public NetworkStream Stream { get; set; }

        /// <summary>
        /// Holds the IP Address of the server!
        /// </summary>
        public IPAddress IP { get; set; }

        /// <summary>
        /// Holds the Port of the server!
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Indicates if the client is connected or not!
        /// </summary>
        public bool IsConnected { get; set; }

        /// <summary>
        /// Holds indicators if the login of the user is OK or not!
        /// [First cell] indicates (UserName already logged in)
        /// [Second cell] indicates (FontColor taken by someone else)
        /// [Third cell] indicates (UserName exists in database)
        /// [Fourth cell] indicates (UserName matches Password)
        /// </summary>
        public bool[] IsLoginOK { get; set; }

        /// <summary>
        /// Holds the list of all the users connected to the server!
        /// </summary>
        public List<UserLogin> ConnectedUsers { get; set; }
        
        #endregion

        /// <summary>
        /// C'tor
        /// </summary>
        public Client()
        {
            isDisposed = false;
            IsConnected = false;
            IsLoginOK = new bool[4] { false, false, false, false };
            binaryFormatter = new BinaryFormatter();

            // Registers all the events
            this.UserApproved += new Action(OnUserApproved);
            this.MessageReceived += new Action<ChatMessage>(OnMessageReceived);
            this.UserConnected += new Action<UserLogin>(OnUserConnected);
            this.UserDisconnected += new Action<UserLogin>(OnUserDisconnected);
            this.BlockReceived += new Action<ChatMessage>(OnBlockReceived);
        }

        #region Public API

        /// <summary>
        /// Registers a new user!
        /// (Runs a new thread)
        /// </summary>
        /// <param name="ip">IP Address of the server</param>
        /// <param name="port">Port of the server</param>
        /// <param name="name">Name of the user</param>
        /// <param name="username">UserName of the user</param>
        /// <param name="password">The password for the user</param>
        public void Register(string ip, int port, string name, string username, string password)
        {
            // ==> First, check for null
            if (ip == null || name == null || username == null || password == null)
                throw new ArgumentNullException();

            // ==> Second, check for valid arguments values
            IPAddress goodIP;
            if (!IPAddress.TryParse(ip, out goodIP)) // IP argument
                throw new ArgumentException();

            if (port <= 0 || port > 65535) // Port argument
                throw new ArgumentException();

            // Now, lifts a thread to register the user!
            Thread connectThread = new Thread(() =>
            {
                try
                {
                    using (client = new TcpClient(ip.ToString(), port))
                    {
                        using (Stream = client.GetStream())
                        {
                            binaryFormatter.Serialize(Stream, new UserRegistration(name, username, password)); // Sends the registration information
                            bool isRegistrationOK = (bool)binaryFormatter.Deserialize(Stream); // Deserializes indicator if registration was successful (UserName is unique)

                            if (isRegistrationOK) // If the registration is OK and approved, ('UserName' and 'Color' of the user is OK)
                            {
                                UserRegistrationApproved(); // Raises an event that the user is approved by the server
                            }
                            else // If the server has rejected the registration
                            {
                                UserRegistrationRejected();
                            }
                        }
                    }

                    this.Dispose(); // Disposes after every registration request!
                }
                catch (SocketException)
                {
                    if (ServerNotFound != null)
                        ServerNotFound(); // Raises an event if the server he's trying to connect is not found!
                }
                catch (SerializationException)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred("The server you're trying to connect had a problem with receiving your information.", false); // Raises an event that error occurred
                }
                catch (IOException)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred("The server you're trying to connect had a problem with receiving your information.", false); // Raises an event that error occurred
                }
            });
            connectThread.IsBackground = true;
            connectThread.Name = string.Format("Client registration: {0}", username);
            connectThread.Start(); // Runs the thread!
        }

        /// <summary>
        /// Logins the user to the server!
        /// (Runs a new thread)
        /// </summary>
        /// <param name="ip">IP Address of the server</param>
        /// <param name="port">Port of the server</param>
        /// <param name="username">Name of the client</param>
        /// <param name="password">The password of the client</param>
        /// <param name="color">Font color of the client</param>
        public void Login(string ip, int port, string username, string password, Color color)
        {
            // ==> First, check for null
            if (ip == null || username == null || color == null || color.IsEmpty)
                throw new ArgumentNullException();

            // ==> Second, check for valid arguments values
            IPAddress goodIP;
            if (!IPAddress.TryParse(ip, out goodIP)) // IP argument
                throw new ArgumentException();

            if (port <= 0 || port > 65535) // Port argument
                throw new ArgumentException();

            // Now here we're good
            IP = goodIP;
            Port = port;
            User = new UserLogin(username, password, color);

            // Now, lifts a thread for the client!
            Thread connectThread = new Thread(() =>
            {
                try
                {
                    using (client = new TcpClient(IP.ToString(), Port))
                    {
                        using (Stream = client.GetStream())
                        {
                            binaryFormatter.Serialize(Stream, User); // Send the server the client information
                            IsLoginOK = (bool[])binaryFormatter.Deserialize(Stream); // Deserialize indicators if user connected to the server successfuly

                            if (IsLoginOK[0] && IsLoginOK[1] && IsLoginOK[2] && IsLoginOK[3]) // If the user is OK and approved, all indicators are OK!
                            {
                                UserApproved(); // Raises an event that the user is approved by the server

                                while (!isDisposed)
                                { } // Keeps connection till dispose will be called
                            }
                            else // If the server has rejected the user
                            {
                                UserRejected();
                            }
                        }
                    }
                }
                catch (SocketException)
                {
                    if (ServerNotFound != null)
                        ServerNotFound(); // Raises an event if the server he's trying to connect is not found!
                }
                catch (SerializationException)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred("The server you're trying to connect had a problem with receiving your information.", false); // Raises an event that error occurred
                }
                catch (IOException)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred("The server you're trying to connect had a problem with receiving your information.", false); // Raises an event that error occurred
                }
            });
            connectThread.IsBackground = true;
            connectThread.Name = string.Format("Client {0} - Connect Thread", User.UserName);
            connectThread.Start(); // Runs the thread!
        }

        #region Send Message Methods

        /// <summary>
        /// Sends a public message!
        /// </summary>
        /// <param name="text">The text of the message</param>
        public void SendMessage(string text)
        {
            SendMessageAsync(text, MessageType.Public, null, null);
        }

        /// <summary>
        /// Sends a public image!
        /// </summary>
        /// <param name="text">The text of the message</param>
        public void SendMessage(Image image)
        {
            SendMessageAsync("", MessageType.Public, null, image);
        }

        /// <summary>
        /// Sends a public message with image!
        /// </summary>
        /// <param name="text">The text of the message</param>
        public void SendMessage(string text, Image image)
        {
            SendMessageAsync(text, MessageType.Public, null, image);
        }

        /// <summary>
        /// Sends a public defined message!
        /// </summary>
        /// <param name="type">The type of the message</param>
        public void SendMessage(MessageType type)
        {
            SendMessageAsync("", type, null, null);
        }

        /// <summary>
        /// Sends a public defined message with text!
        /// </summary>
        /// <param name="text">The text of the message</param>
        /// <param name="type">The type of the message</param>
        public void SendMessage(string text, MessageType type)
        {
            SendMessageAsync(text, type, null, null);
        }

        /// <summary>
        /// Sends a defined message, with text, and with option to send the message to a specific client!
        /// </summary>
        /// <param name="text">The text of the message</param>
        /// <param name="type">The type of the message</param>
        /// <param name="sendTo">Who to send the message</param>
        public void SendMessage(string text, MessageType type, string sendTo)
        {
            SendMessageAsync(text, type, sendTo, null);
        }

        /// <summary>
        /// (Full) Sends a defined message, with text, with image, and with option to send the message to a specific client!
        /// (Runs a new thread)
        /// </summary>
        /// <param name="text">The text of the message</param>
        /// <param name="type">The type of the message</param>
        /// <param name="sendTo">Who to send the message</param>
        /// <param name="image">The Image to attach to the message</param>
        public void SendMessageAsync(string text, MessageType type, string sendTo, Image image)
        {
            if (text == null)
                throw new ArgumentNullException();

            // Lifts a thread to send the message!
            Thread sendMessageThread = new Thread(() =>
            {
                try
                {
                    lock (streamLocker)
                    {
                        ChatMessage message = new ChatMessage(User, sendTo, text, type, image); // The message object to send

                        if (Stream.CanWrite)
                            binaryFormatter.Serialize(Stream, message); // Sends the message to the server!
                    }
                }
                catch (SocketException)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred("Error has occurred while sending message.", false); // Raises an event that error occurred
                }
                catch (SerializationException)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred("Error has occurred while sending message.", false); // Raises an event that error occurred
                }
                catch (IOException)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred("Error has occurred while sending message.", false); // Raises an event that error occurred
                }
            });
            sendMessageThread.IsBackground = true;
            sendMessageThread.Name = string.Format("Client {0} - Sending Message Thread", User.UserName);
            sendMessageThread.Start(); // Runs the thread of sending message
        }

        /// <summary>
        /// Sends a disconnect message!
        /// </summary>
        public void SendDisconnectMessage()
        {
            try
            {
                lock (streamLocker)
                {
                    ChatMessage message = new ChatMessage(User, null, "", MessageType.UserDisconnected); // The message object to send

                    if (Stream.CanWrite)
                        binaryFormatter.Serialize(Stream, message); // Sends the message to the server!
                }
            }
            catch (SocketException)
            {
                if (ErrorOccurred != null)
                    ErrorOccurred("Error has occurred while discconecting.", true); // Raises an event that error occurred
            }
            catch (SerializationException)
            {
                if (ErrorOccurred != null)
                    ErrorOccurred("Error has occurred while discconecting.", true); // Raises an event that error occurred
            }
            catch (IOException)
            {
                if (ErrorOccurred != null)
                    ErrorOccurred("Error has occurred while discconecting.", true); // Raises an event that error occurred
            }
        }

        #endregion

        /// <summary>
        /// Sends a message that the client has closed, and then dispose!
        /// </summary>
        public void Close()
        {
            if (this != null && !isDisposed)
            {
                SendDisconnectMessage(); // Sends the disconnect message

                Dispose();
            }
        }

        /// <summary>
        /// Closes the client! clears all resources!
        /// </summary>
        public void Dispose()
        {
            if (this != null && !isDisposed)
            {
                IsConnected = false;

                // Removes registered events!
                this.UserApproved -= OnUserApproved;
                this.MessageReceived -= OnMessageReceived;
                this.UserConnected -= OnUserConnected;
                this.UserDisconnected -= OnUserDisconnected;
                this.BlockReceived -= OnBlockReceived;

                isDisposed = true; // Now the client is disposed!
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Listens to incoming messages!
        /// (Runs a new thread)
        /// </summary>
        private void MessagesListener()
        {
            // Now, lifts a thread for the client to get messages!
            Thread messagesListenerThread = new Thread(() =>
            {
                    try
                    {
                        while (client.Connected) // While client is connected to the server and not disposed
                        {
                            ChatMessage message = (ChatMessage)binaryFormatter.Deserialize(Stream); // Deserializes a message

                            if (MessageReceived != null)
                                MessageReceived(message); // Raises an event that a message received
                        }
                    }
                    catch (SocketException)
                    {
                        if (ServerConnectionLost != null)
                            ServerConnectionLost(); // Raises an event if the conection to server has been lost!

                        this.Dispose();
                    }
                    catch (SerializationException)
                    {
                        if (ServerConnectionLost != null)
                            ServerConnectionLost(); // Raises an event if the conection to server has been lost!

                        this.Dispose();
                    }
                    catch (IOException)
                    {
                        if (ServerConnectionLost != null)
                            ServerConnectionLost(); // Raises an event if the conection to server has been lost!

                        this.Dispose();
                    }
            });
            messagesListenerThread.IsBackground = true;
            messagesListenerThread.Name = string.Format("Client {0} - Messages Listener Thread", User.UserName);
            messagesListenerThread.Start(); // Runs the thread!
        }

        #endregion

    }
}
