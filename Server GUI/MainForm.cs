using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Communicator;
using System.Configuration;
using Server_Logic;
using Server_Common;

namespace Server_GUI
{
    public partial class MainForm : Form
    {

        #region Fields

        private Server server; // Holds the server logic
        private string nameOfSelectedUser = null; // Holds the name of the user, if he was selected in the ListView
        private DatabaseControl dbControl; // Holds the database dialog!

        #endregion

        /// <summary>
        /// C'tor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeConfiguration();

            dbControl = new DatabaseControl(null);

            // Events registration:
            this.HistoryChanged += new Action<string, string, DateTime>(form_HistoryChanged); // Register to HistoryChanged event
        }

        #region Private Methods

        /// <summary>
        /// Initializes the configuration from the 'App.config' file!
        /// </summary>
        private void InitializeConfiguration()
        {
            AppConfiguration.DataSourceConnection = GetConnectionString();
        }

        /// <summary>
        /// Gets the connection string from the 'App.config' file!
        /// </summary>
        /// <returns>The connection string to the database</returns>
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OhadsChatDatabase"].ConnectionString;
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs each time an event makes the history change!
        /// Arguments: (string) name of event, (string) description of the event, (DateTime) time event raised
        /// </summary>
        private event Action<string, string, DateTime> HistoryChanged;

        /// <summary>
        /// Registers all the events raised by the server!
        /// </summary>
        private void ServerEventsRegistration()
        {
            server.UserConnected += new Action<ChatClient>(form_UserConnected);
            server.UserDisconnected += new Action<UserLogin>(form_UserDisconnected);
            server.MessageReceived += new Action<ChatMessage>(form_OnMessageReceived);
            server.MessageSent += new Action<ChatMessage>(form_OnMessageSent);
            server.ErrorOccurred += new Action<string, bool>(form_OnErrorOccurred);
            server.UserRegistered += new Action<string>(form_OnUserRegistered);
        }

        /// <summary>
        /// Removes all the events registrations raised by the server!
        /// </summary>
        private void ServerEventsRegistrationRemove()
        {
            server.UserConnected -= form_UserConnected;
            server.UserDisconnected -= form_UserDisconnected;
            server.MessageReceived -= form_OnMessageReceived;
            server.MessageSent -= form_OnMessageSent;
            server.ErrorOccurred -= form_OnErrorOccurred;
            server.UserRegistered -= form_OnUserRegistered;
        }

        #region Implementations of Events!

        /// <summary>
        /// Occurs each time an event makes the history change!
        /// Event does: Displays the event occurred information to the History ListView!
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <param name="eventDescription">The description of the event</param>
        /// <param name="time">The time the event occurred</param>
        private void form_HistoryChanged(string eventName, string eventDescription, DateTime time)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, string, DateTime>(form_HistoryChanged), eventName, eventDescription, time);
                return;
            }

            // Update the GUI
            ListViewItem item = new ListViewItem(eventName); // Create a new item with the (Event name)
            item.SubItems.Add(eventDescription); // Subitem (Description)
            item.SubItems.Add(time.ToString()); // Subitem (time)

            listViewHistory.Items.Add(item); // Add the item to the ListView

            listViewHistory.Items[listViewHistory.Items.Count - 1].EnsureVisible(); // Scrolls down the list view
        }

        /// <summary>
        /// Event occurs --> when a user registered to the server!
        /// Event does: Displays the username of the new client registered to the GUI!
        /// </summary>
        /// <param name="userName">The username of the user who registered</param>
        private void form_OnUserRegistered(string userName)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(form_OnUserRegistered), userName);
                return;
            }

            // Update the GUI
            HistoryChanged("User Registered", string.Format("User: \"{0}\", has registered to the server.", userName), DateTime.Now);
        }

        /// <summary>
        /// Event occurs --> when a user connected to the server!
        /// Event does: Displays a new client added to the GUI!
        /// </summary>
        /// <param name="client">The user information</param>
        private void form_UserConnected(ChatClient client)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ChatClient>(form_UserConnected), client);
                return;
            }

            // Update the GUI
            ListViewItem item = new ListViewItem(client.User.UserName); // Create a new item with the (User Name)
            item.SubItems.Add(client.User.FontColor.Name); // Subitem (Color)
            item.SubItems[1].BackColor = client.User.FontColor; // Makes the background color looks like the user font color
            item.UseItemStyleForSubItems = false;
            item.SubItems.Add("Connected"); // Subitem (Status)
            item.SubItems.Add(DateTime.Now.ToString()); // Subitem (Time)

            listViewUsers.Items.Add(item); // Add the item to the ListView

            listViewUsers.Items[listViewUsers.Items.Count - 1].EnsureVisible(); // Scrolls down the ListView

            txtUsersConnected.Text = string.Format("({0}) Users", server.AllClients.Count); // Displays how many users are connected

            HistoryChanged("User Connected", string.Format("User: \"{0}\", has connect to the server.", client.User.UserName), client.ConnectionTime);
        }

        /// <summary>
        /// Event occurs --> when a user disconnected from the server!
        /// Event does: Removes the client from being displayed to the GUI!
        /// </summary>
        /// <param name="user">The name user who disconnected</param>
        private void form_UserDisconnected(UserLogin user)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<UserLogin>(form_UserDisconnected), user);
                return;
            }

            // Update the GUI
            for (int i = 0; i < listViewUsers.Items.Count; i++)
			{
                if (listViewUsers.Items[i].Text == user.UserName)
                {
                    listViewUsers.Items[i].Remove(); // Removes the user from the GUI list

                    txtUsersConnected.Text = string.Format("({0}) Users", server.AllClients.Count); // Displays how many users are connected

                    HistoryChanged("User Disconnected", string.Format("User: \"{0}\", has disconnect from the server.", user.UserName), DateTime.Now);

                    break; // Stops to find the user disconnected
                }			 
			}
        }

        /// <summary>
        /// Occurs each time the event 'MessageReceived' raised!
        /// This message a user sends!
        /// Event does: Displays the message in the 'History ListView' in the GUI!
        /// </summary>
        /// <param name="message">The message</param>
        private void form_OnMessageReceived(ChatMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ChatMessage>(form_OnMessageReceived), message);
                return;
            }

            // Update the GUI
            if (message.Type == MessageType.Public)
            {
                if (message.Text != string.Empty && message.Image == null) // If there's only text
                {
                    HistoryChanged("Message Received", string.Format("{0} sent a public message: {1}", message.Sender.UserName, message.Text), message.SentAt);
                }
                else if (message.Text != string.Empty && message.Image != null) // If there's text and image!
                {
                    HistoryChanged("Message Received", string.Format("{0} sent a public message with image: {1}", message.Sender.UserName, message.Text), message.SentAt);
                }
                else if (message.Text == string.Empty && message.Image != null) // If there's only image
                {
                    HistoryChanged("Message Received", string.Format("{0} sent a public image.", message.Sender.UserName), message.SentAt);
                }
            }
            else if (message.Type == MessageType.Private)
            {
                if (message.Text != string.Empty && message.Image == null) // If there's only text
                {
                    HistoryChanged("Message Received", string.Format("{0} sent a private message to {1}: {2}", message.Sender.UserName, message.SendTo, message.Text), message.SentAt);
                }
                else if (message.Text != string.Empty && message.Image != null) // If there's text and image!
                {
                    HistoryChanged("Message Received", string.Format("{0} sent a private message with image to {1}: {2}", message.Sender.UserName, message.SendTo, message.Text), message.SentAt);
                }
                else if (message.Text == string.Empty && message.Image != null) // If there's only image
                {
                    HistoryChanged("Message Received", string.Format("{0} sent a private image to {1}.", message.Sender.UserName, message.SendTo), message.SentAt);
                }
            }
        }

        /// <summary>
        /// Occurs each time the event 'MessageSent' raised!
        /// This message the server sends!
        /// Event does: Displays the message the server sent in the 'History ListView' in the GUI!
        /// </summary>
        /// <param name="message">The message</param>
        private void form_OnMessageSent(ChatMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ChatMessage>(form_OnMessageSent), message);
                return;
            }

            // Update the GUI
            HistoryChanged("Message Sent", string.Format("The server sent a message: {0}", message.Text), message.SentAt);
        }

        /// <summary>
        /// Occurs each time the event 'ErrorOccurred' raised!
        /// Event does: Displays the error message, and closes the application if needed!
        /// </summary>
        /// <param name="text">The error message to display</param>
        /// <param name="close">Indicator if to close the application</param>
        private void form_OnErrorOccurred(string text, bool close)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, bool>(form_OnErrorOccurred), text, close);
                return;
            }

            // Update the GUI
            // Displays the error message:
            MessageBox.Show(
                text,
                "Error occurred",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

            // If the error must close the application:
            if (close)
                this.Close();
        }

        #endregion

        #endregion

        #region Application Window

        /// <summary>
        /// When closing the form
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (virtualForms.SelectedIndex == 1) // Asks the admin to validate closing if server is connected!
            {
                DialogResult exit = MessageBox.Show(
                    "Server is running, are you sure to exit?",
                    "Are you sure?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (exit == DialogResult.No) // Server stays running!
                {
                    e.Cancel = true;
                }
                else if (exit == DialogResult.Yes) // Server close --> Clear all resources!
                {
                    if (!dbControl.IsDisposed)
                        dbControl.Close(); // Closes the database dialog if it's visible!

                    if (server != null)
                    {
                        ServerEventsRegistrationRemove(); // Removes registered events

                        server.Dispose();
                        server = null;
                    }
                }
            }
        }

        /// <summary>
        /// Menu strip: (Exit)
        /// </summary>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Menu strip: (About)
        /// </summary>
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        /// <summary>
        /// Menu strip: (How To Use)
        /// </summary>
        private void menuItemHowToUse_Click(object sender, EventArgs e)
        {
            HowToUse howToUse = new HowToUse();
            howToUse.Show();
        }

        /// <summary>
        /// Menu strip: (Full Window)
        /// </summary>
        private void menuFullWindow_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.Sizable) // Means we are not in full screen
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            }
            else if (this.FormBorderStyle == FormBorderStyle.None) // Means we are in full screen
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            }
        }

        /// <summary>
        /// Menu strip: (New Server)
        /// </summary>
        private void menuNewServer_Click(object sender, EventArgs e)
        {
            if (virtualForms.SelectedIndex == 0) // If current virtual display is disconnected
            {
                btnStartServer_Click(sender, e); // Sends to (Button: Start Server) event to handle it
            }
            else if (virtualForms.SelectedIndex == 1) // If current virtual display is connected
            {
                if (server != null)
                {
                    server.Dispose();
                    server = null;
                }
                virtualForms.SelectTab(0); // Select: (Virtual Form) --> Disconnected
            }
        }

        /// <summary>
        /// Menu strip: (Database Control)
        /// </summary>
        private void menuItemDBControl_Click(object sender, EventArgs e)
        {
            dbControl = new DatabaseControl(server);
            dbControl.Show();
        }

        #endregion

        #region (Virtual Form) ---> Disconnected

        /// <summary>
        /// On Load event for (virtual form) Disconnected, setting things for diconnected mode!
        /// </summary>
        private void virtualDisconnected_Enter(object sender, EventArgs e)
        {            
            menuServerDetails.Enabled = false; // Disable menu item "Server Details" when there's no connection!
            menuItemDBControl.Enabled = false; // Disable menu item "Database Control" when there's no connection!

            if (!dbControl.IsDisposed)
                dbControl.Close(); // Closes the database dialog if it's visible!

            listViewUsers.Items.Clear(); // Clears UI Users (For connecting several times)
            listViewHistory.Items.Clear(); // Clears UI History (For connecting several times)
            txtUsersConnected.Text = string.Format("(0) Users"); // Clears connected users
        }

        /// <summary>
        /// Button: Start Server
        /// </summary>
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            StartServerDialog startServer = new StartServerDialog(); // Sends the server object to the dialog
            startServer.ShowDialog();

            // If succeeded with opening the server
            if (startServer.DialogResult == DialogResult.OK && startServer.Server != null) 
            {
                server = startServer.Server; // Assigns the server logic property from the dialog, to this MainForm server logic field!
                ServerEventsRegistration();

                virtualForms.SelectTab(1); // Select: (Virtual Form) --> Connected
                tabPageServer.Text = server.Name; // Assigns the server name to the tab title!

                HistoryChanged("Server Started", string.Format("\"{0}\" is started.", server.Name), DateTime.Now); // Raises an event that history changed (Server Started)
            }
        }

        #endregion

        #region (Virtual Form) ---> Connected
        
        /// <summary>
        /// On Load event for (virtual form) Connected, setting things for connected mode!
        /// </summary>
        private void virtualConnected_Enter(object sender, EventArgs e)
        {
            menuServerDetails.Enabled = true; // Enable menu item "Server Details" after connection!
            menuItemDBControl.Enabled = true; // Enable menu item "Database Control" after connection!
            menuNewServer.Text = "Close Server...";
        }

        /// <summary>
        /// Menu strip: (Server Details)
        /// </summary>
        private void menuServerDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Server Name: {0}\nServer IP: {1}\nServer Port: {2}\n",
                                           server.Name , server.IP ,server.Port),
                                           "Server details");
        }

        /// <summary>
        /// Button: Database Control
        /// </summary>
        private void btnDatabaseControl_Click(object sender, EventArgs e)
        {
            dbControl = new DatabaseControl(server);
            dbControl.Show();
        }

        /// <summary>
        /// Button: Listen to clients (On / Off)
        /// </summary>
        private void btnListenOnOff_Click(object sender, EventArgs e)
        {
            if (server.IsListening) // If server is listening
            {
                lblListening.Visible = false;
                lblNotListening.Visible = true;
                picBoxListening.Image = global::Server_GUI.Properties.Resources._2stop;
                
                server.StopListening();

                btnListenOnOff.Text = "Start Listening";
                btnListenOnOff.BackColor = Color.DarkGreen;
                btnListenOnOff.ForeColor = Color.LimeGreen;
            }
            else // If server is not listening
            {
                lblListening.Visible = true;
                lblNotListening.Visible = false;
                picBoxListening.Image = global::Server_GUI.Properties.Resources.clientsListener;

                server.StartListening();

                btnListenOnOff.Text = "Stop Listening";
                btnListenOnOff.BackColor = Color.LightPink;
                btnListenOnOff.ForeColor = Color.DarkRed;
            }
        }

        /// <summary>
        /// When selecting an item from the ListView Users!
        /// </summary>
        private void listViewUsers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Button: Remove appearance disable, if no item is selected
            btnBlockUser.BackColor = Color.LightGray;
            btnBlockUser.ForeColor = Color.Gray;
            btnBlockUser.Enabled = false;

            nameOfSelectedUser = null; // Resets the name of selected user

            // Now, if a user is selected in the ListView
            if (e.IsSelected)
            {
                // Button: Remove appearance enable
                btnBlockUser.BackColor = Color.DarkGray;
                btnBlockUser.ForeColor = Color.Black;
                btnBlockUser.Enabled = true;

                nameOfSelectedUser = listViewUsers.Items[e.ItemIndex].Text; // Assigns the name of the selected user
            }
        }

        /// <summary>
        /// Button: Send Message
        /// </summary>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessageDialog sendMessage = new SendMessageDialog();
            sendMessage.ShowDialog();

            if (sendMessage.DialogResult == DialogResult.OK) // If dialog returned with valid fields to send message
            {
                server.WriteMessage(sendMessage.MessageText, sendMessage.Color); // Sends the message
            }
        }

        /// <summary>
        /// Blocks a user from the server!
        /// </summary>
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (nameOfSelectedUser != null)
            {
                server.BlockClient(nameOfSelectedUser);

                HistoryChanged("User Blocked", string.Format("User: \"{0}\", has been blocked from the server.", nameOfSelectedUser), DateTime.Now);
            }
        }

        /// <summary>
        /// Button: Close Server
        /// </summary>
        private void btnCloseServer_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show(
                "Server is running, are you sure to exit?",
                "Are you sure?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (exit == DialogResult.Yes) // Server close --> Clear all resources!
            {
                if (server != null)
                {
                    ServerEventsRegistrationRemove(); // Removes registered events

                    server.Dispose();
                    server = null;

                    virtualForms.SelectTab(0); // Select: (Virtual Form) --> Disconnected
                }
            }
        }

        #endregion

    }
}
