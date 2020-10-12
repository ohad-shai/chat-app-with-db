using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DataAccess.Entities
{
    /// <summary>
    /// Represents the message entity in the 'ChatServer' database!
    /// </summary>
    public class Message : ChatServerBaseEntity
    {

        #region Properties

        /// <summary>
        /// Holds the text of the message!
        /// </summary>
        public string MessageText { get; set; }

        /// <summary>
        /// Holds the ID of the user who sent the message!
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Holds the date the message sent!
        /// </summary>
        public DateTime Sent { get; set; }

        /// <summary>
        /// Holds the ID of the user who received the message! (for private message)
        /// </summary>
        public int? RecipientID { get; set; }

        /// <summary>
        /// Holds the name of the user who sent the message!
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Holds the name of the user the message sent to! (for private message)
        /// </summary>
        public string SendTo { get; set; }

        #endregion

    }
}
