using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Communicator;

namespace Server_Logic
{
    /// <summary>
    /// Represents a connected client in the server!
    /// </summary>
    public class ChatClient
    {

        #region Properties

        public UserLogin User { get; set; }
        public TcpClient Client { get; set; }
        public NetworkStream Stream { get; private set; }
        public DateTime ConnectionTime { get; set; }

        #endregion

        /// <summary>
        /// C'tor
        /// </summary>
        /// <param name="user">The user which holds Name and Color</param>
        /// <param name="client">Client connection which holds information and stream of the user</param>
        public ChatClient(UserLogin user, TcpClient client)
        {
            // ==> Check for null
            if (user == null || user.UserName == null || user.FontColor == null || user.FontColor.IsEmpty || client == null)
                throw new ArgumentNullException();

            User = user;
            Client = client;
            Stream = client.GetStream();
            ConnectionTime = DateTime.Now;
        }

    }
}
