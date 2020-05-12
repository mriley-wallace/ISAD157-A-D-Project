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
    public partial class DBMain : Form
    {
        public static string firstName;
        public DBMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            userConnection();
            friendshipsConnection();
            messagesConnection();
            educationConnection();
            workplaceConnection();

            // Methods called in their simplest forms to make it more concise //
        }




        private void userConnection()
        {
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                  "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                  DBConnect.USER_NAME + ";" + "PASSWORD=" +
                  DBConnect.PASSWORD + ";" + "SslMode=" +
                  DBConnect.SslMode + ";";
            // Connecting to the database using the credentials found in DBConnect.cs //

            using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
            {

                MySqlConnection cnn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("Select first_name, last_name, hometown, currentTown, gender, relationshipStatus " +
                    "FROM users where users.user_id = @userName", cnn);
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userName", DatabaseForm.userName);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                userIDgrid.DataSource = dt;
                SetGridHeightWidth(userIDgrid, 106, 731);

                // This is user connection so this is purely to fill the userIDgrid for the information like a "Profile Page" //
                // using the open connection we are finding only the relevant information from the users database using the //
                // user_id determined from the login textbox. //


            }
        }
        private void friendshipsConnection()
        {
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                 "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                 DBConnect.USER_NAME + ";" + "PASSWORD=" +
                 DBConnect.PASSWORD + ";" + "SslMode=" +
                 DBConnect.SslMode + ";";

            using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
            {

                MySqlConnection cnn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("Select users.first_name, users.last_name FROM users INNER JOIN friendships " +
                    "ON users.user_id = friendships.friend_id WHERE friendships.user_id = @userName ",cnn);
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userName", DatabaseForm.userName);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgdFriendships.DataSource = dt;
                SetGridHeightWidth(dgdFriendships, 573, 338);

                //This is the first instance of INNER JOIN function to choose a father and child database tables, so the father //
                // is users for the user credentials, and the child is friendships for the friend ID related to the user ID //
            }
        }
        private void messagesConnection()
        {
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                 "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                 DBConnect.USER_NAME + ";" + "PASSWORD=" +
                 DBConnect.PASSWORD + ";" + "SslMode=" +
                 DBConnect.SslMode + ";";

            using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
            {

                MySqlConnection cnn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("Select * FROM messages WHERE messages.user_id = @userName " +
                    "OR messages.friend_id = @userName ", cnn);
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userName", DatabaseForm.userName);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgdMessages.DataSource = dt;
                SetGridHeightWidth(dgdFriendships, 448, 595);
                this.dgdMessages.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        
        private void educationConnection()
        {
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                 "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                 DBConnect.USER_NAME + ";" + "PASSWORD=" +
                 DBConnect.PASSWORD + ";" + "SslMode=" +
                 DBConnect.SslMode + ";";

            using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
            {

                MySqlConnection cnn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("Select education.university, student.start_date, student.end_date  " +
                    "FROM student INNER JOIN education ON student.education_id = education.education_id " +
                    "WHERE student.user_id = @userName", cnn);
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userName", DatabaseForm.userName);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgdEducation.DataSource = dt;
                SetGridHeightWidth(dgdEducation, 142, 338);
            }
        }
        private void workplaceConnection()
        {
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                 "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                 DBConnect.USER_NAME + ";" + "PASSWORD=" +
                 DBConnect.PASSWORD + ";" + "SslMode=" +
                 DBConnect.SslMode + ";";

            using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
            {

                MySqlConnection cnn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand("Select workplace.workplace, worker.start_date, worker.end_date " +
                    "FROM workplace INNER JOIN worker ON worker.workplace_ID = workplace.workplace_ID " +
                    "WHERE worker.user_ID = @userName", cnn);
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@userName", DatabaseForm.userName);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgdWorkplace.DataSource = dt;
                SetGridHeightWidth(dgdWorkplace, 142, 338);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static DataGridView SetGridHeightWidth(DataGridView grd, int maxHeight, int maxWidth)
        {
            var height = 40;
            foreach (DataGridViewRow row in grd.Rows)
            {
                if (row.Visible)
                    height += row.Height;
            }

            if (height > maxHeight)
                height = maxHeight;

            grd.Height = height;

            var width = 60;
            foreach (DataGridViewColumn col in grd.Columns)
            {
                if (col.Visible)
                    width += col.Width;
            }

            if (width > maxWidth)
                width = maxWidth;

            grd.Width = width;

            return grd;

            // This is a simple function to ensure the datagrids are automatically set to the right size based upon the //
            // amount of data that is in them, up to the maximum which was determined from the specs from the [Design] //
        }
    }

}

