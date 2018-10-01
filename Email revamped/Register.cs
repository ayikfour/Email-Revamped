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

namespace Email_revamped
{
    public partial class Register : Form
    {
        //Defining SQL requirement
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Defining variables
        private String Email, Username, Password;                

        //Defining parent form
        MainForm main;

        public Register(MainForm Parent)
        {
            InitializeComponent();
            this.main = Parent;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                RegisterMe();
                this.Close();
            }
            else
            {
                MessageBox.Show("Form Can't be Blank");
            }
        }

        private void RegisterMe()
        {
            try
            {
                Username = RegisterUsername.Text;
                Email = RegisterEmail.Text;
                Password = RegisterPassword.Text;

                //Declaring Query
                String query = "INSERT INTO author (name, mail_name, password) VALUES (@name, @mail, @password)";
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@name", Username);
                Command.Parameters.AddWithValue("@mail", Email);
                Command.Parameters.AddWithValue("@password", Password);

                //Opening Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                //Closing Connection
                Connect.Close();

                MessageBox.Show("Registration Success!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean CheckForm()
        {
            if (!RegisterUsername.Text.Equals("")
                && !RegisterEmail.Text.Equals("")
                && !RegisterPassword.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
