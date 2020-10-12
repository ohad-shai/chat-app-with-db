using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Common
{
    /// <summary>
    /// Represents configuration properties for the application!
    /// </summary>
    public static class AppConfiguration
    {

        #region Properties

        /// <summary>
        /// Holds the connection string to the database!
        /// </summary>
        public static string DataSourceConnection { get; set; }

        #endregion

    }
}
