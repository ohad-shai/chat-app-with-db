using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicator
{
    /// <summary>
    /// Holds enumeration types of a message
    /// </summary>
    public enum MessageType
    {
        UserConnected,
        UserDisconnected,
        Error,
        Block,
        Public,
        Private
    }
}
