namespace Email_revamped
{
    partial class Mail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDeleteTrash = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnWrite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Inbox = new System.Windows.Forms.TabPage();
            this.ListInbox = new System.Windows.Forms.ListView();
            this.ColID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColRecipient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Outbox = new System.Windows.Forms.TabPage();
            this.ListOutbox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Draft = new System.Windows.Forms.TabPage();
            this.ListDraft = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trash = new System.Windows.Forms.TabPage();
            this.ListBin = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.CurrentUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnInbox = new System.Windows.Forms.Button();
            this.BtnOutbox = new System.Windows.Forms.Button();
            this.BtnDraft = new System.Windows.Forms.Button();
            this.BtnTrash = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Inbox.SuspendLayout();
            this.Outbox.SuspendLayout();
            this.Draft.SuspendLayout();
            this.Trash.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.BtnTrash);
            this.panel1.Controls.Add(this.BtnDraft);
            this.panel1.Controls.Add(this.BtnOutbox);
            this.panel1.Controls.Add(this.BtnInbox);
            this.panel1.Controls.Add(this.BtnDeleteTrash);
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnWrite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 498);
            this.panel1.TabIndex = 0;
            // 
            // BtnDeleteTrash
            // 
            this.BtnDeleteTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnDeleteTrash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDeleteTrash.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDeleteTrash.FlatAppearance.BorderSize = 0;
            this.BtnDeleteTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteTrash.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteTrash.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteTrash.ImageIndex = 1;
            this.BtnDeleteTrash.ImageList = this.imageList1;
            this.BtnDeleteTrash.Location = new System.Drawing.Point(0, 403);
            this.BtnDeleteTrash.Name = "BtnDeleteTrash";
            this.BtnDeleteTrash.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BtnDeleteTrash.Size = new System.Drawing.Size(61, 45);
            this.BtnDeleteTrash.TabIndex = 14;
            this.BtnDeleteTrash.UseVisualStyleBackColor = false;
            this.BtnDeleteTrash.Click += new System.EventHandler(this.DeleteMessage);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Muli", 7F, System.Drawing.FontStyle.Bold);
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.ImageIndex = 2;
            this.BtnLogout.ImageList = this.imageList1;
            this.BtnLogout.Location = new System.Drawing.Point(0, 448);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BtnLogout.Size = new System.Drawing.Size(61, 50);
            this.BtnLogout.TabIndex = 10;
            this.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close_wht.png");
            this.imageList1.Images.SetKeyName(1, "delete_wht.png");
            this.imageList1.Images.SetKeyName(2, "signout_wht.png");
            this.imageList1.Images.SetKeyName(3, "user_wht.png");
            this.imageList1.Images.SetKeyName(4, "inbox_wht.png");
            this.imageList1.Images.SetKeyName(5, "draft_wht.png");
            this.imageList1.Images.SetKeyName(6, "sent_wht.png");
            this.imageList1.Images.SetKeyName(7, "bin_wht.png");
            // 
            // BtnWrite
            // 
            this.BtnWrite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(15)))), ((int)(((byte)(116)))));
            this.BtnWrite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnWrite.BorderRadius = 0;
            this.BtnWrite.ButtonText = "";
            this.BtnWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWrite.DisabledColor = System.Drawing.Color.Gray;
            this.BtnWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWrite.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnWrite.Iconimage = null;
            this.BtnWrite.Iconimage_right = global::Email_revamped.Properties.Resources.compose_wht;
            this.BtnWrite.Iconimage_right_Selected = null;
            this.BtnWrite.Iconimage_Selected = null;
            this.BtnWrite.IconMarginLeft = 0;
            this.BtnWrite.IconMarginRight = 20;
            this.BtnWrite.IconRightVisible = true;
            this.BtnWrite.IconRightZoom = 0D;
            this.BtnWrite.IconVisible = true;
            this.BtnWrite.IconZoom = 40D;
            this.BtnWrite.IsTab = false;
            this.BtnWrite.Location = new System.Drawing.Point(0, 0);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnWrite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.BtnWrite.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnWrite.selected = false;
            this.BtnWrite.Size = new System.Drawing.Size(61, 48);
            this.BtnWrite.TabIndex = 1;
            this.BtnWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnWrite.Textcolor = System.Drawing.Color.White;
            this.BtnWrite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(61, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 450);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Inbox);
            this.tabControl1.Controls.Add(this.Outbox);
            this.tabControl1.Controls.Add(this.Draft);
            this.tabControl1.Controls.Add(this.Trash);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // Inbox
            // 
            this.Inbox.BackColor = System.Drawing.Color.White;
            this.Inbox.Controls.Add(this.ListInbox);
            this.Inbox.Location = new System.Drawing.Point(4, 34);
            this.Inbox.Name = "Inbox";
            this.Inbox.Padding = new System.Windows.Forms.Padding(3);
            this.Inbox.Size = new System.Drawing.Size(615, 412);
            this.Inbox.TabIndex = 0;
            this.Inbox.Text = "Inbox";
            // 
            // ListInbox
            // 
            this.ListInbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColID,
            this.ColSender,
            this.ColRecipient,
            this.ColSubject,
            this.ColMessage});
            this.ListInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListInbox.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListInbox.FullRowSelect = true;
            this.ListInbox.Location = new System.Drawing.Point(3, 3);
            this.ListInbox.MultiSelect = false;
            this.ListInbox.Name = "ListInbox";
            this.ListInbox.Size = new System.Drawing.Size(609, 406);
            this.ListInbox.TabIndex = 1;
            this.ListInbox.UseCompatibleStateImageBehavior = false;
            this.ListInbox.View = System.Windows.Forms.View.Details;
            this.ListInbox.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListInbox_ColumnWidthChanging);
            this.ListInbox.SelectedIndexChanged += new System.EventHandler(this.ListInbox_SelectedIndexChanged);
            this.ListInbox.DoubleClick += new System.EventHandler(this.ViewMessage);
            // 
            // ColID
            // 
            this.ColID.Text = "ID";
            this.ColID.Width = 0;
            // 
            // ColSender
            // 
            this.ColSender.Text = "From";
            this.ColSender.Width = 100;
            // 
            // ColRecipient
            // 
            this.ColRecipient.Text = "Recipient";
            this.ColRecipient.Width = 100;
            // 
            // ColSubject
            // 
            this.ColSubject.Text = "Subject";
            this.ColSubject.Width = 100;
            // 
            // ColMessage
            // 
            this.ColMessage.Text = "Message";
            this.ColMessage.Width = 300;
            // 
            // Outbox
            // 
            this.Outbox.BackColor = System.Drawing.Color.White;
            this.Outbox.Controls.Add(this.ListOutbox);
            this.Outbox.Location = new System.Drawing.Point(4, 34);
            this.Outbox.Margin = new System.Windows.Forms.Padding(0);
            this.Outbox.Name = "Outbox";
            this.Outbox.Size = new System.Drawing.Size(615, 412);
            this.Outbox.TabIndex = 1;
            this.Outbox.Text = "Outbox";
            // 
            // ListOutbox
            // 
            this.ListOutbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListOutbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListOutbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOutbox.Font = new System.Drawing.Font("Muli", 8F);
            this.ListOutbox.FullRowSelect = true;
            this.ListOutbox.Location = new System.Drawing.Point(0, 0);
            this.ListOutbox.MultiSelect = false;
            this.ListOutbox.Name = "ListOutbox";
            this.ListOutbox.Size = new System.Drawing.Size(615, 412);
            this.ListOutbox.TabIndex = 10;
            this.ListOutbox.UseCompatibleStateImageBehavior = false;
            this.ListOutbox.View = System.Windows.Forms.View.Details;
            this.ListOutbox.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListOutbox_ColumnWidthChanging);
            this.ListOutbox.SelectedIndexChanged += new System.EventHandler(this.ListInbox_SelectedIndexChanged);
            this.ListOutbox.DoubleClick += new System.EventHandler(this.ViewMessage);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Recipient";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subject";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Message";
            this.columnHeader4.Width = 350;
            // 
            // Draft
            // 
            this.Draft.BackColor = System.Drawing.Color.White;
            this.Draft.Controls.Add(this.ListDraft);
            this.Draft.Location = new System.Drawing.Point(4, 34);
            this.Draft.Name = "Draft";
            this.Draft.Size = new System.Drawing.Size(615, 412);
            this.Draft.TabIndex = 2;
            this.Draft.Text = "Draft";
            // 
            // ListDraft
            // 
            this.ListDraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListDraft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ListDraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListDraft.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDraft.FullRowSelect = true;
            this.ListDraft.Location = new System.Drawing.Point(0, 0);
            this.ListDraft.MultiSelect = false;
            this.ListDraft.Name = "ListDraft";
            this.ListDraft.Size = new System.Drawing.Size(615, 412);
            this.ListDraft.TabIndex = 12;
            this.ListDraft.UseCompatibleStateImageBehavior = false;
            this.ListDraft.View = System.Windows.Forms.View.Details;
            this.ListDraft.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListDraft_ColumnWidthChanging);
            this.ListDraft.SelectedIndexChanged += new System.EventHandler(this.ListInbox_SelectedIndexChanged);
            this.ListDraft.DoubleClick += new System.EventHandler(this.ViewMessage);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Recipient";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Subject";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Message";
            this.columnHeader8.Width = 350;
            // 
            // Trash
            // 
            this.Trash.BackColor = System.Drawing.Color.White;
            this.Trash.Controls.Add(this.ListBin);
            this.Trash.Location = new System.Drawing.Point(4, 5);
            this.Trash.Name = "Trash";
            this.Trash.Size = new System.Drawing.Size(615, 441);
            this.Trash.TabIndex = 3;
            this.Trash.Text = "Trash";
            // 
            // ListBin
            // 
            this.ListBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader13,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.ListBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBin.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBin.FullRowSelect = true;
            this.ListBin.Location = new System.Drawing.Point(0, 0);
            this.ListBin.MultiSelect = false;
            this.ListBin.Name = "ListBin";
            this.ListBin.Size = new System.Drawing.Size(615, 441);
            this.ListBin.TabIndex = 13;
            this.ListBin.UseCompatibleStateImageBehavior = false;
            this.ListBin.View = System.Windows.Forms.View.Details;
            this.ListBin.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListBin_ColumnWidthChanging);
            this.ListBin.SelectedIndexChanged += new System.EventHandler(this.ListInbox_SelectedIndexChanged);
            this.ListBin.DoubleClick += new System.EventHandler(this.ViewMessage);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Recipient";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Subject";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Message";
            this.columnHeader12.Width = 300;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panel3.Controls.Add(this.CurrentUser);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.LblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(61, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 48);
            this.panel3.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Muli Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(15, 11);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(70, 26);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Inbox.";
            // 
            // CurrentUser
            // 
            this.CurrentUser.Font = new System.Drawing.Font("Muli ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUser.ForeColor = System.Drawing.Color.White;
            this.CurrentUser.Location = new System.Drawing.Point(396, 14);
            this.CurrentUser.Name = "CurrentUser";
            this.CurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentUser.Size = new System.Drawing.Size(190, 20);
            this.CurrentUser.TabIndex = 1;
            this.CurrentUser.Text = "Ayikfour4@mail";
            this.CurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ImageIndex = 3;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(581, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Sender";
            this.columnHeader13.Width = 100;
            // 
            // BtnInbox
            // 
            this.BtnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.BtnInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInbox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInbox.FlatAppearance.BorderSize = 0;
            this.BtnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInbox.Font = new System.Drawing.Font("Muli", 7F, System.Drawing.FontStyle.Bold);
            this.BtnInbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnInbox.ImageIndex = 4;
            this.BtnInbox.ImageList = this.imageList1;
            this.BtnInbox.Location = new System.Drawing.Point(0, 48);
            this.BtnInbox.Name = "BtnInbox";
            this.BtnInbox.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BtnInbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnInbox.Size = new System.Drawing.Size(61, 45);
            this.BtnInbox.TabIndex = 15;
            this.BtnInbox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnInbox.UseVisualStyleBackColor = false;
            this.BtnInbox.Click += new System.EventHandler(this.BtnInbox_Click);
            // 
            // BtnOutbox
            // 
            this.BtnOutbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.BtnOutbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOutbox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnOutbox.FlatAppearance.BorderSize = 0;
            this.BtnOutbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOutbox.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOutbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnOutbox.ImageIndex = 6;
            this.BtnOutbox.ImageList = this.imageList1;
            this.BtnOutbox.Location = new System.Drawing.Point(0, 93);
            this.BtnOutbox.Name = "BtnOutbox";
            this.BtnOutbox.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BtnOutbox.Size = new System.Drawing.Size(61, 45);
            this.BtnOutbox.TabIndex = 16;
            this.BtnOutbox.UseVisualStyleBackColor = false;
            this.BtnOutbox.Click += new System.EventHandler(this.BtnOutbox_Click);
            // 
            // BtnDraft
            // 
            this.BtnDraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.BtnDraft.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDraft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDraft.FlatAppearance.BorderSize = 0;
            this.BtnDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDraft.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnDraft.ImageIndex = 5;
            this.BtnDraft.ImageList = this.imageList1;
            this.BtnDraft.Location = new System.Drawing.Point(0, 138);
            this.BtnDraft.Name = "BtnDraft";
            this.BtnDraft.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BtnDraft.Size = new System.Drawing.Size(61, 45);
            this.BtnDraft.TabIndex = 17;
            this.BtnDraft.UseVisualStyleBackColor = false;
            this.BtnDraft.Click += new System.EventHandler(this.BtnDraft_Click);
            // 
            // BtnTrash
            // 
            this.BtnTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.BtnTrash.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTrash.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnTrash.FlatAppearance.BorderSize = 0;
            this.BtnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrash.Font = new System.Drawing.Font("Muli", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))));
            this.BtnTrash.ImageIndex = 7;
            this.BtnTrash.ImageList = this.imageList1;
            this.BtnTrash.Location = new System.Drawing.Point(0, 183);
            this.BtnTrash.Name = "BtnTrash";
            this.BtnTrash.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BtnTrash.Size = new System.Drawing.Size(61, 45);
            this.BtnTrash.TabIndex = 18;
            this.BtnTrash.UseVisualStyleBackColor = false;
            this.BtnTrash.Click += new System.EventHandler(this.BtnTrash_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Inbox.ResumeLayout(false);
            this.Outbox.ResumeLayout(false);
            this.Draft.ResumeLayout(false);
            this.Trash.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnWrite;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Inbox;
        private System.Windows.Forms.ListView ListInbox;
        private System.Windows.Forms.ColumnHeader ColID;
        private System.Windows.Forms.ColumnHeader ColSender;
        private System.Windows.Forms.ColumnHeader ColRecipient;
        private System.Windows.Forms.ColumnHeader ColSubject;
        private System.Windows.Forms.ColumnHeader ColMessage;
        private System.Windows.Forms.TabPage Outbox;
        private System.Windows.Forms.ListView ListOutbox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage Draft;
        private System.Windows.Forms.ListView ListDraft;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage Trash;
        private System.Windows.Forms.Button BtnDeleteTrash;
        private System.Windows.Forms.ListView ListBin;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label CurrentUser;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button BtnTrash;
        private System.Windows.Forms.Button BtnDraft;
        private System.Windows.Forms.Button BtnOutbox;
        private System.Windows.Forms.Button BtnInbox;
    }
}