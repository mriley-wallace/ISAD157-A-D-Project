using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOFT562Week18
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQueryChoice.SelectedIndex == 0)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM users";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable customerDataTable = new DataTable();
                    sqlDA.Fill(customerDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewCustomer.DataSource = customerDataTable;

                } // End of using (MySqlConnection connection = ...
            }
            else
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM messages";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable productDataTable = new DataTable();
                    sqlDA.Fill(productDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewProduct.DataSource = productDataTable;
                }
            } // End of else...
        } // End of private void comboBoxQueryChoice_SelectedIndexChanged

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
