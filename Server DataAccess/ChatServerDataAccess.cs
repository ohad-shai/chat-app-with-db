using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_Common;
using Server_DataAccess.Interfaces;
using Server_DataAccess.Entities;

namespace Server_DataAccess
{
    /// <summary>
    /// Represents the data access to the 'ChatServer' database!
    /// </summary>
    public class ChatServerDataAccess : IChatServerDataAccess
    {

        #region Fields

        private SqlConnection connection; // Holds the connection of the database!
        private SqlCommand command; // Holds the sql command to the database!
        
        #endregion

        #region Properties

        /// <summary>
        /// Indicates if there's a connection to the database!
        /// </summary>
        public bool IsConnected { get; set; }

        #endregion

        #region Public API

        /// <summary>
        /// Opens a connection to the database via configuration file!
        /// </summary>
        public void Open()
        {
            if (AppConfiguration.DataSourceConnection == null)
                throw new Exception("You must declare the connection string in the app.config file, and assign it to the 'DataSourceConnection' before opening a connection to the database!");

            Open(AppConfiguration.DataSourceConnection);
        }

        /// <summary>
        /// Opens a connection to the database by a connection string!
        /// </summary>
        /// <param name="connectionString">The connection string to the database</param>
        public void Open(string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException();

            if (IsConnected)
                throw new Exception("You can't open a connection to the database while a connection is already opened!");

            connection = new SqlConnection(connectionString);
            connection.Open();

            IsConnected = true; // Updates indicator that connection to the database has been made!
        }

        /// <summary>
        /// Closes a connection to the database! and clears all resources!
        /// </summary>
        public void Close()
        {
            //throw new Exception("You can't close a connection to the database while no connection is opened!");
            if (IsConnected)
            {
                connection.Close();
                IsConnected = false; // Updates indicator that connection to the database has been closed!
                connection.Dispose();
            }
        }

        /// <summary>
        /// Inserts a new user to the database!
        /// </summary>
        /// <param name="user">The user to insert</param>
        /// <returns>The id of the user inserted</returns>
        public int InsertUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException();

            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "AddUser";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Sending parameters for the stored procedure:
            AddParameter(command, new SqlParameter("@UserName", SqlDbType.NVarChar, 50), user.UserName);
            AddParameter(command, new SqlParameter("@Password", SqlDbType.NVarChar), user.Password);
            AddParameter(command, new SqlParameter("@Name", SqlDbType.NVarChar), user.Name);
            AddParameter(command, new SqlParameter("@LastConnectionDate", SqlDbType.DateTime), user.LastConnectionDate);
            AddParameter(command, new SqlParameter("@IsConnected", SqlDbType.Bit), user.IsConnected);
            // Receiving parameters from the stored procedure:
            AddParameter(command, new SqlParameter("@newId", SqlDbType.Int), null, ParameterDirection.Output);

            var reader = command.ExecuteNonQuery(); // Execute procedure!

            int newId = (int)command.Parameters["@newId"].Value; // Assigns the returned parameter (ID)

            return newId;
        }

        /// <summary>
        /// Updates the connection of a user!
        /// </summary>
        /// <param name="userName">The username to update</param>
        /// <param name="lastConnectionDate">The last connection date</param>
        /// <param name="isConnected">Indicator if the user is connected or not</param>
        /// <returns>Indicator if succeeded with updating the user's connection</returns>
        public bool UpdateUserConnection(string userName, DateTime lastConnectionDate, bool isConnected)
        {
            if (userName == null || lastConnectionDate == null)
                throw new ArgumentNullException();

            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "UpdateUserConnection";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Sending parameters for the stored procedure:
            AddParameter(command, new SqlParameter("@UserName", SqlDbType.NVarChar, 50), userName);
            AddParameter(command, new SqlParameter("@LastConnectionDate", SqlDbType.DateTime), lastConnectionDate);
            AddParameter(command, new SqlParameter("@IsConnected", SqlDbType.Bit), isConnected);
            // Receiving parameters from the stored procedure:
            AddParameter(command, new SqlParameter("@Id", SqlDbType.Int), null, ParameterDirection.Output);

            var reader = command.ExecuteNonQuery(); // Execute procedure!

            int idOfUser = (int)command.Parameters["@Id"].Value; // Assigns the returned parameter (ID)

            if (idOfUser > -1) // If the value returned from database is not null
                return true; // Succeeded with updating the user!

            return false; // Not succeeded with updating the user!
        }

        /// <summary>
        /// Deletes a user by a username from the database!
        /// </summary>
        /// <param name="userName">The Username of the user to delete</param>
        /// <returns>Indicator if succeeded in deleting the user</returns>
        public bool DeleteUser(string userName)
        {
            if (userName == null)
                throw new ArgumentNullException();

            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "DeleteUser";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Sending parameters for the stored procedure:
            AddParameter(command, new SqlParameter("@UserName", SqlDbType.NVarChar, 50), userName);
            // Receiving parameters from the stored procedure:
            AddParameter(command, new SqlParameter("@Id", SqlDbType.Int), null, ParameterDirection.Output);

            var reader = command.ExecuteNonQuery(); // Execute procedure!

            int idOfUser = (int)command.Parameters["@Id"].Value; // Assigns the returned parameter (ID)

            if (idOfUser > 0) // If the value returned from database is not null
                return true; // Succeeded with deleting the user!

            return false; // Not succeeded with deleting the user!
        }

        /// <summary>
        /// Gets all the users in the database!
        /// </summary>
        /// <returns>List of all the users</returns>
        public List<User> GetAllUsers()
        {
            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "GetAllUsers";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            List<User> users = new List<User>();

            using (var reader = command.ExecuteReader()) // Execute procedure!
            {
                while (reader.Read())
                {
                    users.Add(CreateUserFromReader(reader, false));
                }
            }

            return users;
        }

        /// <summary>
        /// Gets the user by a UserName in the database!
        /// </summary>
        /// <param name="userName">The username of the user</param>
        /// <returns>The user</returns>
        public List<User> GetUserByUserName(string userName)
        {
            if (userName == null)
                throw new ArgumentNullException();

            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "GetUserByUsername";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Sending parameters for the stored procedure:
            AddParameter(command, new SqlParameter("@UserName", SqlDbType.NVarChar, 50), userName);

            List<User> users = new List<User>();

            using (var reader = command.ExecuteReader()) // Execute procedure!
            {
                while (reader.Read())
                {
                    users.Add(CreateUserFromReader(reader, true));
                }
            }

            return users;
        }

        /// <summary>
        /// Gets the user by the Id in the database!
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <returns>The user</returns>
        public User GetUserById(int id)
        {
            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "GetUserById";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Sending parameters for the stored procedure:
            AddParameter(command, new SqlParameter("@Id", SqlDbType.Int), id);

            User user = new User();

            using (var reader = command.ExecuteReader()) // Execute procedure!
            {
                while (reader.Read())
                {
                    user = CreateUserFromReader(reader, false);
                }
            }

            return user;
        }

        /// <summary>
        /// Checks if a username exists in the database!
        /// </summary>
        /// <param name="userName">The username to check</param>
        /// <returns>True or False, if the username exists in database</returns>
        public bool UserExists(string userName)
        {
            if (userName == null)
                throw new ArgumentNullException();

            if (GetUserByUserName(userName).Count > 0)
            {
                return true; // UserName exists!
            }

            return false; // UserName not exists!
        }

        /// <summary>
        /// Checks if a username matches a password in the database!
        /// </summary>
        /// <param name="userName">The username to check</param>
        /// <param name="password">The password to check</param>
        /// <returns>True or False, if the username matches the password</returns>
        public bool UsernameMatchesPassword(string userName, string password)
        {
            if (userName == null || password == null)
                throw new ArgumentNullException();

            User user = GetUserByUserName(userName).FirstOrDefault(); // Gets the user by the username!

            if (user != null && user.Password == password)
            {
                return true; // UserName does match the password!
            }

            return false; // UserName does not match the password!
        }

        /// <summary>
        /// Inserts a new message to the database!
        /// </summary>
        /// <param name="messageText">The message text</param>
        /// <param name="sender">The name of the message sender user</param>
        /// <param name="sendTo">The name of the message receiver user</param>
        /// <returns>The id of the message inserted</returns>
        public int InsertMessage(string messageText, string sender, string sendTo)
        {
            if (messageText == null || sender == null)
                throw new ArgumentNullException();

            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "AddMessage";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Sending parameters for the stored procedure:
            AddParameter(command, new SqlParameter("@MessageText", SqlDbType.NVarChar), messageText);
            AddParameter(command, new SqlParameter("@Sender", SqlDbType.NVarChar, 50), sender);
            AddParameter(command, new SqlParameter("@SendTo", SqlDbType.NVarChar, 50), sendTo);
            AddParameter(command, new SqlParameter("@Sent", SqlDbType.DateTime), DateTime.Now);
            // Receiving parameters from the stored procedure:
            AddParameter(command, new SqlParameter("@newId", SqlDbType.Int), null, ParameterDirection.Output);

            var reader = command.ExecuteNonQuery(); // Execute procedure!

            int newId = (int)command.Parameters["@newId"].Value; // Assigns the returned parameter (ID)

            return newId;
        }

        /// <summary>
        /// Gets the messages contains the text provided in the database!
        /// </summary>
        /// <param name="text">The text of the message</param>
        /// <returns>List of messages that implement the condition</returns>
        public List<Message> GetMessagesByText(string text)
        {
            if (text == null)
                throw new ArgumentNullException();

            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "GetMessagesByText";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Sending parameters for the stored procedure:
            AddParameter(command, new SqlParameter("@Text", SqlDbType.NVarChar), text);

            List<Message> messages = new List<Message>();

            using (var reader = command.ExecuteReader()) // Execute procedure!
            {
                while (reader.Read())
                {
                    messages.Add(CreateMessageFromReader(reader));
                }
            }

            return messages;
        }

        /// <summary>
        /// Gets the messages contains the date provided in the database!
        /// </summary>
        /// <param name="date">The date the message sent</param>
        /// <returns>List of messages that implement the condition</returns>
        public List<Message> GetMessagesByDate(DateTime date)
        {
            if (date == null)
                throw new ArgumentNullException();

            ValidateOpenConnection();

            // Declaring the stored procedure:
            command = connection.CreateCommand();
            command.CommandText = "GetMessagesByDate";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Sending parameters for the stored procedure:
            AddParameter(command, new SqlParameter("@Date", SqlDbType.DateTime), date);

            List<Message> messages = new List<Message>();

            using (var reader = command.ExecuteReader()) // Execute procedure!
            {
                while (reader.Read())
                {
                    messages.Add(CreateMessageFromReader(reader));
                }
            }

            return messages;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates if a connection to the database is open!
        /// </summary>
        private void ValidateOpenConnection()
        {
            if (!IsConnected)
                throw new Exception("You must open a connection before using DataAccess API");
        }

        /// <summary>
        /// Adds a parameter to the command!
        /// </summary>
        /// <param name="command">The command to add the parameter</param>
        /// <param name="param">The parameter to add</param>
        /// <param name="value">The value of the parameter</param>
        /// <param name="direction">The direction of the parameter</param>
        private static void AddParameter(SqlCommand command, SqlParameter param, object value, ParameterDirection direction = ParameterDirection.Input)
        {
            param.Direction = direction;
            command.Parameters.Add(param);
            command.Parameters[param.ParameterName].Value = value;
        }

        /// <summary>
        /// Creates a user from the reader when a reader command executes!
        /// </summary>
        /// <param name="reader">The reader executed</param>
        /// <param name="includePassword">Indicator if to include the password of the user</param>
        /// <returns>The user created</returns>
        private User CreateUserFromReader(SqlDataReader reader, bool includePassword)
        {
            User user = new User();

            user.Id = (int)reader["Id"];
            user.UserName = reader["UserName"].ToString();

            if (includePassword)
                user.Password = reader["Password"].ToString();

            user.Name = reader["Name"].ToString();
            user.LastConnectionDate = MapLastConnectionDate(reader["LastConnectionDate"]);
            user.IsConnected = (bool)reader["IsConnected"];

            return user;
        }

        /// <summary>
        /// Creates a message from the reader when a reader command executes!
        /// </summary>
        /// <param name="reader">The reader executed</param>
        /// <returns>The message created</returns>
        private Message CreateMessageFromReader(SqlDataReader reader)
        {
            Message msg = new Message();

            msg.Id = (int)reader["MessageID"];
            msg.MessageText = (string)reader["MessageText"];
            msg.UserID = (int)reader["UserID"];
            msg.Sent = (DateTime)reader["Sent"];
            msg.RecipientID = MapRecipientID(reader["RecipientID"]);
            
            return msg;
        }

        /// <summary>
        /// Maps last connection date according to the value from database!
        /// </summary>
        /// <param name="dbValue">The value from the database</param>
        /// <returns>The mapped date value</returns>
        private DateTime? MapLastConnectionDate(object dbValue)
        {
            if (dbValue == DBNull.Value)
                return null;
            return (DateTime)dbValue;
        }

        /// <summary>
        /// Maps RecipientID according to the value from database!
        /// </summary>
        /// <param name="dbValue">The value received from the database</param>
        /// <returns>The mapped value</returns>
        private int? MapRecipientID(object dbValue)
        {
            if (dbValue == DBNull.Value)
                return null;
            return (int)dbValue;
        }

        #endregion

    }
}
