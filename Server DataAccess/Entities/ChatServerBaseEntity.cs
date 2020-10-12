using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_DataAccess.Entities
{
    /// <summary>
    /// Represents basic properties for an entity in the 'ChatServer' database!
    /// </summary>
    public abstract class ChatServerBaseEntity
    {

        #region Properties

        /// <summary>
        /// Holds the Id of the user!
        /// </summary>
        public int Id { get; set; }

        #endregion

    }
}
