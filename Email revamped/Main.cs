using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_revamped
{
    public partial class MainForm : Form
    {
        //Defining static Connection
        //So it can be reused in many form
        public static String Connection = "datasource=localhost; port=3306; username=root; password=; database=mail; SslMode=none";


        //Defining static user information
        public Boolean LogedIn = false;
        public static String Email, Username;
        public static int Id;

        //Defining children of the mainform
        Login LoginForm;
        Mail MailForm;
        Register RegisterForm;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void Login(object sender, EventArgs e)
        {
            LoginForm = new Login(this);
            LoginForm.Show();            
        }

        private void Register(object sender, EventArgs e)
        {
            RegisterForm = new Register(this);
            RegisterForm.Show();
        }

        public void Launch()
        {
            if (LogedIn)
            {
                MailForm = new Mail(this);
                MailForm.Show();
                this.Hide();
            }            
        }

        public void SetUser(String _Username, String _Email, int _ID)
        {
            Username = _Username;
            Email = _Email;
            Id = _ID;
        }

        public void Logout()
        {
            Username = "";
            Email = "";
            Id = 0;
        }
    }
}
