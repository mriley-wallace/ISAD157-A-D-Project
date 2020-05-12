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
using SMConnect;

namespace SOFT562Week18
{
    public partial class DatabaseForm : Form
    {
       public static string userName;

        public DatabaseForm()
        {

            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

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

            userName = txtUsername.Text;
       
            DBMain f2 = new DBMain();
            f2.Show(); // Shows Form2
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void connectTrue_Click(object sender, EventArgs e)
        {

        }
    }
}
