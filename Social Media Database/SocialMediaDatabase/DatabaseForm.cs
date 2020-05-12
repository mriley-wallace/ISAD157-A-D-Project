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

      //  private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
       // {
           // if (comboBoxQueryChoice.SelectedIndex == 0)
          //  {


             //   string connectionString = "SERVER=" + SMConnect.DBConnect.SERVER + ";" +
              //      "DATABASE=" + SMConnect.DBConnect.DATABASE_NAME + ";" + "UID=" +
             //       SMConnect.DBConnect.USER_NAME + ";" + "PASSWORD=" +
             //       SMConnect.DBConnect.PASSWORD + ";" + "SslMode=" +
             //       SMConnect.DBConnect.SslMode + ";";


              //  using (MySqlConnection connection =
              //      new MySqlConnection(connectionString))
              //  {
               //     string query = "SELECT * FROM users";
               //     connection.Open();
               //     MySqlCommand cmd = new MySqlCommand(query, connection);

               //     MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
               //     DataTable customerDataTable = new DataTable();
               //     sqlDA.Fill(customerDataTable);

                //    dataGridViewCustomer.DataSource = customerDataTable;

              //  } 
        //    }
         //   else
         //   {
              

              //  string connectionString = "SERVER=" + SMConnect.DBConnect.SERVER + ";" +
              //      "DATABASE=" + SMConnect.DBConnect.DATABASE_NAME + ";" + "UID=" +
             //       SMConnect.DBConnect.USER_NAME + ";" + "PASSWORD=" +
             //       SMConnect.DBConnect.PASSWORD + ";" + "SslMode=" +
             //       SMConnect.DBConnect.SslMode + ";";
            //

               // using (MySqlConnection connection =
              //      new MySqlConnection(connectionString))
              //  {
                    
              //      string query = "SELECT * FROM messages";


                //    connection.Open();


                //    MySqlCommand cmd = new MySqlCommand(query, connection);


               //     MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
               //     DataTable productDataTable = new DataTable();
               //     sqlDA.Fill(productDataTable);
            //
               //     dataGridViewProduct.DataSource = productDataTable;
            //    }
         //   } 
       // } 

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
