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
    public partial class Compose : Form
    {



        //Defining SQL requirement
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;



        //Defining Parent
        Mail MailForm;



        //Variables
        int ID_ParentMessage;
        String Subject, Recipient, Message, Placeholder;
        DateTime Created;



        //Constructor
        public Compose(Mail parent)
        {
            InitializeComponent();
            this.MailForm = parent;
        }



        //Constructor for draft and forward message
        public Compose(String _recipient, String _subject, String _message, int _id, Mail parent)
        {
            InitializeComponent();
            RtbRecipient.Text = _recipient;
            RtbSubject.Text = _subject;
            RtbMessage.Text = _message;
            ID_ParentMessage = _id;
            this.MailForm = parent;
        }



        //Constructor for reply message
        public Compose(String _recipient, int _id, Mail parent)
        {
            InitializeComponent();            
            RtbRecipient.Text = _recipient;            
            ID_ParentMessage = _id;
            this.MailForm = parent;
        }        



        //Method for get value from Rich Text Box
        private void GetValue()
        {            
            this.Subject = RtbSubject.Text;
            this.Recipient = RtbRecipient.Text;
            this.Message = RtbMessage.Text;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Sent("Send");
            this.Close();
        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            Sent("Draft");
            this.Close();
        }




        //Method for clearing the field
        private void Flush()
        {            
            RtbSubject.Text = "";
            RtbRecipient.Text = "";
            RtbMessage.Text = "";
        }




        //This is the Query Code
        //1. Adding to the sent or draft table
        //2. Adding to insert table
        private void Sent(String value)
        {
            //Calling GetValue method
            GetValue();

            //Initialize Time
            Created = DateTime.Now;

            String Msbox = "";
            String query = "";

            //Initialize Query
            if (value.Equals("Draft"))
            {
                query = "INSERT INTO draft (author_id, sender, recipient, subject, body, created, parent_id) VALUES (@author, @sender, @recipient, @subject, @body, @created, @parent)";
                Msbox = "Added to Draft";
            }
            else
            {
                query = "INSERT INTO outbox (author_id, sender, recipient, subject, body, created, parent_id) VALUES (@author, @sender, @recipient, @subject, @body, @created, @parent)";
                Msbox = "Email has been Sent";
            }


            try
            {
                //Declaring parameter of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@author", MainForm.Id);
                Command.Parameters.AddWithValue("@sender", MainForm.Email);
                Command.Parameters.AddWithValue("@recipient", Recipient);
                Command.Parameters.AddWithValue("@subject", Subject);
                Command.Parameters.AddWithValue("@body", Message);
                Command.Parameters.AddWithValue("@created", Created);
                Command.Parameters.AddWithValue("@parent", ID_ParentMessage);

                if (Recipient.Contains('@'))
                {
                    //Opening Connection
                    Connect.Open();
                    Reader = Command.ExecuteReader();

                    //Closing Connection
                    Connect.Close();

                    //Adding to inbox
                    if (value.Equals("Send"))
                    {
                        AddToInbox();
                    }

                    //Show Message on Success
                    MessageBox.Show(Msbox);
                }
                else
                {
                    MessageBox.Show("Email recipient is not valid");
                }
            }
            catch (Exception ex)
            {
                Connect.Close();

                //Show Message on Fail
                MessageBox.Show(ex.Message);
            }
        }




        //Query to add message into inbox table.
        private void AddToInbox()
        {
            try
            {
                //Declaring Query
                String query = "INSERT INTO inbox (author_id, sender, recipient, subject, body, created, parent_id) VALUES (@author, @sender, @recipient, @subject, @body, @created, @parent)";

                //Declaring parameter of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@author", MainForm.Id);
                Command.Parameters.AddWithValue("@sender", MainForm.Email);
                Command.Parameters.AddWithValue("@recipient", Recipient);
                Command.Parameters.AddWithValue("@subject", Subject);
                Command.Parameters.AddWithValue("@body", Message);
                Command.Parameters.AddWithValue("@created", Created);
                Command.Parameters.AddWithValue("@parent", ID_ParentMessage);

                //Opening Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                //Closing Connection
                Connect.Close();
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }
        }

    }
}
