using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DataAccess.Entities
{
    /// <summary>
    /// Represents the user entity in the 'ChatServer' database!
    /// </summary>
    public class User : ChatServerBaseEntity
    {

        #region Properties

        /// <summary>
        /// Holds the username of the user!
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Holds the password for the user!
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Holds the name of the user!
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Holds the last connection date of the user!
        /// </summary>
        public DateTime? LastConnectionDate { get; set; }

        /// <summary>
        /// Holds indicator if the user is connected!
        /// </summary>
        public bool IsConnected { get; set; }

        #endregion

        /// <summary>
        /// C'tor (Empty)
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// C'tor
        /// </summary>
        /// <param name="userName">The username of the user</param>
        /// <param name="password">The password for the user</param>
        /// <param name="name">The name of the user</param>
        /// <param name="lastConnectionDate">The last connection date of the user</param>
        /// <param name="isConnected">Indicator if the user is connected</param>
        public User(string userName, string password, string name, DateTime lastConnectionDate, bool isConnected)
        {
            UserName = userName;
            Password = password;
            Name = name;
            LastConnectionDate = lastConnectionDate;
            IsConnected = isConnected;
        }

    }
}
