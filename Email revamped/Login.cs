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
    public partial class Login : Form
    {
        //Defining SQL requirement
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Defining variables
        private String Email, Username, Password;
        private int IDuser;

        //Defining Parent
        MainForm main;
        
        public Login(MainForm parent)
        {
            InitializeComponent();
            this.main = parent;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {            
            if (Authentication())
            {
                this.Close();
                main.LogedIn = true;
                main.Launch();
            }
        }
        
        private Boolean Authentication()
        {
            Boolean Status = false;
            try
            {
                //Declaring Query
                String query = "SELECT * FROM author WHERE mail_name=@mail";
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@mail", LoginUsername.Text);                

                //Opening Connection            
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        IDuser = Reader.GetInt32(0);
                        Username = Reader.GetString(1);
                        Email = Reader.GetString(2);
                        Password = Reader.GetString(3);

                        if (Email.Equals(LoginUsername.Text))
                        {
                            if (Password.Equals(LoginPassword.Text))
                            {
                                main.SetUser(Username, Email, IDuser);                                
                                Status = true;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email address not found");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Email Address not Found");
                    Status = false;
                }
                Connect.Close();
                return Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
