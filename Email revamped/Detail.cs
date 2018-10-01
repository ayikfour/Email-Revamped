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
    public partial class Detail : Form
    {



        //Defining SQL requirement
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;



        //Defining Parent
        Mail MailForm;



        //Variables
        int IDmessage, IDParentMessage;
        String Placeholder, Action;        




        public Detail(String _type, int _IDmessage, Mail parent)
        {
            InitializeComponent();
            this.MailForm = parent;
            this.IDmessage = _IDmessage;
            SetButton(_type);
            SetComponent(_type);            
        }

        
        private void SetComponent(String table)
        {
            try
            {
                //Declaring Query
                String Query = "SELECT * FROM " + table.ToLower() + " WHERE id=@id";
                Command = new MySqlCommand(Query, Connect);
                Command.Parameters.AddWithValue("@id", IDmessage);

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        IDmessage = int.Parse(Reader.GetString(0));
                        LabelSender.Text = Reader.GetString(2);
                        LabelRecipient.Text = Reader.GetString(3);
                        LabelSubject.Text = Reader.GetString(4);
                        RtbMessage.Text = Reader.GetString(5);
                        IDParentMessage = int.Parse(Reader.GetString(7));                      
                    }
                }

                //Closing Connection
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void SetAction(object sender, EventArgs e)
        {
            if (Action.Equals("Reply"))
            {
                MailForm.Reply(LabelSender.Text, IDParentMessage);
                this.Close();
            }
            else if (Action.Equals("Forward") || Action.Equals("Send"))
            {
                MailForm.Send(LabelRecipient.Text, LabelSubject.Text, RtbMessage.Text, IDParentMessage);
                this.Close();
            }
            else if (Action.Equals("Delete"))
            {
                MailForm.PermanentDelete(IDmessage);
                this.Close();
            }
        }



        public void SetButton(String name)
        {
            if (name.ToLower().Equals("inbox"))
            {
                BtnAction.Text = "Reply";
                this.Action = "Reply";
            }
            else if (name.ToLower().Equals("outbox"))
            {
                BtnAction.Text = "Forward";
                this.Action = "Forward";
            }
            else if (name.ToLower().Equals("draft"))
            {
                BtnAction.Text = "Send";
                this.Action = "Send";
            }
            else
            {
                BtnAction.Text = "Delete";
                this.Action = "Delete";
            }
        }


    }
}
