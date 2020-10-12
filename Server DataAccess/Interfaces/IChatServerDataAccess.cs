using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_DataAccess.Entities;

namespace Server_DataAccess.Interfaces
{
    /// <summary>
    /// Defines the methods for the data access to the 'ChatServer' database!
    /// </summary>
    public interface IChatServerDataAccess
    {

        #region Properties

        /// <summary>
        /// Indicates if there's a connection to the database!
        /// </summary>
        bool IsConnected { get; set; }

        #endregion

        /// <summary>
        /// Opens a connection to the database!
        /// </summary>
        void Open();

        /// <summary>
        /// Closes a connection to the database!
        /// </summary>
        void Close();

        /// <summary>
        /// Inserts a new user to the database!
        /// </summary>
        /// <param name="user">The user to insert</param>
        /// <returns>The id of the user inserted</returns>
        int InsertUser(User user);

        /// <summary>
        /// Updates the connection of a user!
        /// </summary>
        /// <param name="userName">The username to update</param>
        /// <param name="lastConnectionDate">The last connection date</param>
        /// <param name="isConnected">Indicator if the user is connected or not</param>
        /// <returns>Indicator if succeeded with updating the user's connection</returns>
        bool UpdateUserConnection(string userName, DateTime lastConnectionDate, bool isConnected);

        /// <summary>
        /// Deletes a user by a username from the database!
        /// </summary>
        /// <param name="userName">The Username of the user to delete</param>
        /// <returns>Indicator if succeeded in deleting the user</returns>
        bool DeleteUser(string userName);

        /// <summary>
        /// Gets all the users in the database!
        /// </summary>
        /// <returns>List of all the users</returns>
        List<User> GetAllUsers();

        /// <summary>
        /// Gets the user by a UserName in the database!
        /// </summary>
        /// <param name="userName">The Username of the user</param>
        /// <returns>The user</returns>
        List<User> GetUserByUserName(string userName);

        /// <summary>
        /// Gets the user by the Id in the database!
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <returns>The user</returns>
        User GetUserById(int id);

        /// <summary>
        /// Checks if a username exists in the database!
        /// </summary>
        /// <param name="userName">The username to check</param>
        /// <returns>True or False, if the username exists in database</returns>
        bool UserExists(string userName);

        /// <summary>
        /// Checks if a username matches a password in the database!
        /// </summary>
        /// <param name="userName">The username to check</param>
        /// <param name="password">The password to check</param>
        /// <returns>True or False, if the username matches the password</returns>
        bool UsernameMatchesPassword(string userName, string password);

        /// <summary>
        /// Inserts a new message to the database!
        /// </summary>
        /// <param name="messageText">The message text</param>
        /// <param name="sender">The name of the message sender user</param>
        /// <param name="sendTo">The name of the message receiver user</param>
        /// <returns>The id of the message inserted</returns>
        int InsertMessage(string messageText, string sender, string sendTo);

        /// <summary>
        /// Gets the messages contains the text provided in the database!
        /// </summary>
        /// <param name="text">The text of the message</param>
        /// <returns>List of messages that implement the condition</returns>
        List<Message> GetMessagesByText(string text);

        /// <summary>
        /// Gets the messages contains the date provided in the database!
        /// </summary>
        /// <param name="date">The date the message sent</param>
        /// <returns>List of messages that implement the condition</returns>
        List<Message> GetMessagesByDate(DateTime date);

    }
}
