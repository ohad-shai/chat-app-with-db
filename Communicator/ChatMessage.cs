using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Communicator
{
    /// <summary>
    /// Holds the information and data of a message in the chat!
    /// </summary>
    [Serializable]
    public sealed class ChatMessage
    {

        #region Properties
        
        /// <summary>
        /// Holds information about the user who sends the message!
        /// </summary>
        public UserLogin Sender { get; set; }

        /// <summary>
        /// Holds the name of the user who will receive the message!
        /// </summary>
        public string SendTo { get; set; }

        /// <summary>
        /// Holds the time the message sent!
        /// </summary>
        public DateTime SentAt { get; set; }

        /// <summary>
        /// Holds the content of the message!
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Holds the type of the message!
        /// </summary>
        public MessageType Type { get; set; }

        /// <summary>
        /// Holds the image attached to the message!
        /// </summary>
        public Image Image { get; set; }

        #endregion

        /// <summary>
        /// C'tor (Without image attached)
        /// </summary>
        /// <param name="sender">The user who sends the message</param>
        /// <param name="sendTo">The user who will receive the message</param>
        /// <param name="text">The content of the message</param>
        /// <param name="type">The type of the message</param>
        public ChatMessage(UserLogin sender, string sendTo, string text, MessageType type)
            : this(sender, sendTo, text, type, null)
        {
        }

        /// <summary>
        /// C'tor (Full - with image attached)
        /// </summary>
        /// <param name="sender">The user who sends the message</param>
        /// <param name="sendTo">The user who will receive the message</param>
        /// <param name="text">The content of the message</param>
        /// <param name="type">The type of the message</param>
        /// <param name="image">The image attached with the message</param>
        public ChatMessage(UserLogin sender, string sendTo, string text, MessageType type, Image image)
        {
            Sender = sender;
            SendTo = sendTo;
            SentAt = DateTime.Now;
            Text = text;
            Type = type;
            Image = image;
        }

    }
}
