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
    public partial class Mail : Form
    {
        //Defining SQL requirement
        MySqlConnection Connect = new MySqlConnection(MainForm.Connection);
        MySqlCommand Command;
        MySqlDataReader Reader;

        //Defining Children
        MainForm Main;
        Detail DetailForm;
        Compose ComposeForm;

        //Defining variables
        int IDmessage;
        String CurrentTab;
        String xID, xAuthor, xSender, xRecipient, xSubject, xBody, xCreated, xParentId;


        //Constructor
        public Mail(MainForm parent)
        {
            InitializeComponent();
            this.Main = parent;
            UpdateInbox();
            CurrentUser.Text = MainForm.Email;
        }




        //Adding Shadow to Mail Form
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }




        //Button action as tab group control
        //this button onclick will change tab group page.
  

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Main.Logout();
            Main.Show();
            this.Close();                        
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            ComposeForm = new Compose(this);
            ComposeForm.Show();
        }


        private void BtnInbox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Inbox;
            LblTitle.Text = "Inbox.";
            BtnDeleteTrash.Enabled = true;            
            UpdateInbox();
        }

        private void BtnOutbox_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Outbox;
            LblTitle.Text = "Outbox.";
            BtnDeleteTrash.Enabled = true;
            UpdateSent("outbox");
        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Draft;
            LblTitle.Text = "Draft.";
            BtnDeleteTrash.Enabled = true;
            UpdateSent("draft");
        }

        private void BtnTrash_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Trash;
            LblTitle.Text = "Trash.";
            BtnDeleteTrash.Enabled = false;
            UpdateTrash();
        }




        //Prevent ListView to resize it's column
        //So the size would not change
        private void ListInbox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ListInbox.Columns[e.ColumnIndex].Width;
        }

        private void ListOutbox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ListOutbox.Columns[e.ColumnIndex].Width;
        }

        private void ListDraft_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ListDraft.Columns[e.ColumnIndex].Width;
        }

        private void ListBin_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ListBin.Columns[e.ColumnIndex].Width;
        }




        //Query Control Start Here
        //This will be very long Query
        //---------------------------------------------------------------------------

        //Inbox Query
        public void UpdateInbox()
        {
            ListInbox.Items.Clear();

            try
            {
                //Declaring Query
                String query = "SELECT * FROM inbox WHERE recipient=@recipient";

                //Declaring parameters of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@recipient", MainForm.Email);
                Command.CommandTimeout = 60;

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        String[] row = {
                            Reader.GetString(0),
                            Reader.GetString(2),
                            "Me",
                            Reader.GetString(4),
                            Reader.GetString(5)
                        };
                        var listItems = new ListViewItem(row);
                        ListInbox.Items.Add(listItems);
                    }
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }
        }




        //Draft Query
        //Retrieving Draft from database
        public void UpdateSent(String value)
        {
            if (value.Equals("draft"))
            {
                ListDraft.Items.Clear();
            }
            else
            {
                ListOutbox.Items.Clear();
            }
            
                        
            try
            {
                //Declaring Query
                String query = "SELECT * FROM "+value+" WHERE author_id=@author";

                //Declaring parameters of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@author", MainForm.Id);
                Command.CommandTimeout = 60;

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        String[] row = {
                            Reader.GetString(0),
                            Reader.GetString(3),
                            Reader.GetString(4),
                            Reader.GetString(5)
                        };
                        var listItems = new ListViewItem(row);
                        if (value.Equals("draft"))
                        {
                            ListDraft.Items.Add(listItems);
                        }
                        else
                        {
                            ListOutbox.Items.Add(listItems);
                        }
                    }
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }
        }



        //Trash Query
        //Retrieving Trash from database
        public void UpdateTrash()
        {
            ListBin.Items.Clear();

            try
            {
                //Declaring Query
                String query = "SELECT * FROM trash WHERE author_id=@author";

                //Declaring parameters of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@author", MainForm.Id);
                Command.CommandTimeout = 60;

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        String[] row = {
                            Reader.GetString(0),
                            Reader.GetString(2),
                            Reader.GetString(3),
                            Reader.GetString(4),
                            Reader.GetString(5)
                        };
                        var listItems = new ListViewItem(row);
                        ListBin.Items.Add(listItems);
                    }
                }
                Connect.Close();
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }
        }



        //START OF DELETE QUERY
        //-------------------------------------------//        
        public void DeleteMessage(object sender, EventArgs e)
        {            
            try
            {
                //Declaring Query
                String query = "SELECT * FROM "+CurrentTab.ToLower()+" WHERE id=@ID";
                //String query = "INSERT INTO trash (@author_id, sender, recipient, subject, body, created, parent_id) SELECT sender, recipient, subject, body, created, parent_id FROM "+CurrentTab.ToLower()+" WHERE id=@ID;";

                //Declaring parameters of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@ID", IDmessage);
                Command.Parameters.AddWithValue("@author_id", MainForm.Id);
                Command.CommandTimeout = 60;

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        xID = Reader.GetString(0);
                        xAuthor = Reader.GetString(1);
                        xSender = Reader.GetString(2);
                        xRecipient = Reader.GetString(3);
                        xSubject = Reader.GetString(4);
                        xBody = Reader.GetString(5);
                        xCreated = Reader.GetString(6);
                        xParentId = Reader.GetString(7);
                    }
                }
                Connect.Close();
                DeleteByID();
                InsertToTrash();
                UpdateCurrentTab();
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private Boolean DeleteByID()
        {
            Boolean status = false;
            try
            {
                //Declaring Query
                String query = "DELETE FROM " + CurrentTab.ToLower() + " WHERE id=@ID";

                //Declaring parameters of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@ID", IDmessage);
                Command.CommandTimeout = 60;

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();
                Connect.Close();
                status = true;
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }
            return status;
        }

        private Boolean InsertToTrash()
        {
            Boolean status = false;
            try
            {
                String query = "INSERT INTO trash (author_id, sender, recipient, subject, body, created, parent_id) VALUES (@author, @sender, @recipient, @subject, @body, @created, @parent)";

                //Declaring parameter of the query
                Command = new MySqlCommand(query, Connect);                
                Command.Parameters.AddWithValue("@author", MainForm.Id);
                Command.Parameters.AddWithValue("@sender", xSender);
                Command.Parameters.AddWithValue("@recipient", xRecipient);
                Command.Parameters.AddWithValue("@subject", xSubject);
                Command.Parameters.AddWithValue("@body", xBody);
                Command.Parameters.AddWithValue("@created", xCreated);
                Command.Parameters.AddWithValue("@parent", xParentId);                

                //Opening Connection
                Connect.Open();
                Reader = Command.ExecuteReader();

                //Closing Connection
                Connect.Close();
                status = true;
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }
            return status;
        }


        public void PermanentDelete(int _ID)
        {            
            try
            {
                //Declaring Query
                String query = "DELETE FROM trash WHERE id=@ID";

                //Declaring parameters of the query
                Command = new MySqlCommand(query, Connect);
                Command.Parameters.AddWithValue("@ID", _ID);
                Command.CommandTimeout = 60;

                //Openning Connection
                Connect.Open();
                Reader = Command.ExecuteReader();
                Connect.Close();
                UpdateTrash();
            }
            catch (Exception ex)
            {
                Connect.Close();
                MessageBox.Show(ex.Message);
            }            
        }

        //END OF DELETE QUERY
        //--------------------------------------------------------//


        
        //Retrieving current Selection from ListView
        //And set selected ID
        private void ListInbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView CurrentList = (ListView)sender;
            if (CurrentList.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem items = CurrentList.SelectedItems[0];
            IDmessage = int.Parse(items.SubItems[0].Text);
            CurrentTab = tabControl1.SelectedTab.Text;            
        }



        //Calling window for replying 
        //and forwarding message
        public void Reply(String _Recipient, int _ParentID)
        {
            ComposeForm = new Compose(_Recipient, _ParentID, this);
            ComposeForm.Show();
        }

        public void Send(String _Recipient, String _Subject, String _Message, int _ParentID)
        {
            ComposeForm = new Compose(_Recipient, _Subject, _Message, _ParentID, this);
            ComposeForm.Show();
        }
       


        //Calling Action for a button
        public void ViewMessage(object sender, EventArgs e)
        {
            DetailForm = new Detail(CurrentTab.ToLower(), IDmessage, this);
            DetailForm.Show();
        }


        //Update Current Active Tab
        private void UpdateCurrentTab()
        {
            if (CurrentTab.Equals("Inbox"))
            {
                UpdateInbox();
            }
            else if (CurrentTab.Equals("Draft"))
            {
                UpdateSent("draft");
            }
            else if (CurrentTab.Equals("Outbox"))
            {
                UpdateSent("outbox");
            }
            else
            {
                UpdateTrash();
            }
        }
    }
}
