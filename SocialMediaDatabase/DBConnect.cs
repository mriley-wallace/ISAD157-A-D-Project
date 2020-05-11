using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SocialMediaDatabase
{
    class DBConnect
    {
            /// <summary>
            /// The username that we use when connecting to the server. It has the form
            /// soft562_<your name>.
            /// </summary>
            internal const string USER_NAME = "ISAD157_MRiley-Wallace";

            /// <summary>
            /// The name or network address of the server. The default value is
            /// 'localhost', but in our case this will be proj-mysql.uopnet.plymouth.ac.uk.
            /// </summary>
            internal const string SERVER = "proj-mysql.uopnet.plymouth.ac.uk";

            /// <summary>
            /// The name of the database to use. Recall that the names of databases
            /// on Xserve have the form isad157_<your name>.
            /// </summary>
            internal const string DATABASE_NAME = "isad157_mriley-wallace";

            /// <summary>
            /// The password for the MySQL account being used.
            /// </summary>
            internal const string PASSWORD = "ISAD157_22215887";

            /// <summary>
            /// Security state of connection to server.
            /// </summary>
            internal const string SslMode = "none";

        } // End of class DBConnect
    }

