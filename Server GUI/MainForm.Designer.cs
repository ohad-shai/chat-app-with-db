namespace Server_GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDBControl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServerDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFullWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHowToUse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.virtualForms = new Server_GUI.VirtualForm();
            this.virtualDisconnected = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.virtualConnected = new System.Windows.Forms.TabPage();
            this.tabControlServers = new System.Windows.Forms.TabControl();
            this.tabPageServer = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnDatabaseControl = new System.Windows.Forms.Button();
            this.btnBlockUser = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblNotListening = new System.Windows.Forms.Label();
            this.btnListenOnOff = new System.Windows.Forms.Button();
            this.lblListening = new System.Windows.Forms.Label();
            this.picBoxListening = new System.Windows.Forms.PictureBox();
            this.btnCloseServer = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsersConnected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.colHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.colHeaderEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderHistoryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.virtualForms.SuspendLayout();
            this.virtualDisconnected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.virtualConnected.SuspendLayout();
            this.tabControlServers.SuspendLayout();
            this.tabPageServer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxListening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewServer,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuNewServer
            // 
            this.menuNewServer.Image = global::Server_GUI.Properties.Resources.file3;
            this.menuNewServer.Name = "menuNewServer";
            this.menuNewServer.Size = new System.Drawing.Size(142, 22);
            this.menuNewServer.Text = "New Server...";
            this.menuNewServer.Click += new System.EventHandler(this.menuNewServer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = global::Server_GUI.Properties.Resources.close3;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(142, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDBControl,
            this.menuServerDetails,
            this.toolStripSeparator1,
            this.menuFullWindow});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menuItemDBControl
            // 
            this.menuItemDBControl.Enabled = false;
            this.menuItemDBControl.Image = global::Server_GUI.Properties.Resources.vcard;
            this.menuItemDBControl.Name = "menuItemDBControl";
            this.menuItemDBControl.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuItemDBControl.Size = new System.Drawing.Size(184, 22);
            this.menuItemDBControl.Text = "Database Control";
            this.menuItemDBControl.Click += new System.EventHandler(this.menuItemDBControl_Click);
            // 
            // menuServerDetails
            // 
            this.menuServerDetails.Enabled = false;
            this.menuServerDetails.Image = global::Server_GUI.Properties.Resources.network;
            this.menuServerDetails.Name = "menuServerDetails";
            this.menuServerDetails.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuServerDetails.Size = new System.Drawing.Size(184, 22);
            this.menuServerDetails.Text = "Server Details";
            this.menuServerDetails.Click += new System.EventHandler(this.menuServerDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // menuFullWindow
            // 
            this.menuFullWindow.Image = global::Server_GUI.Properties.Resources.fullscreen;
            this.menuFullWindow.Name = "menuFullWindow";
            this.menuFullWindow.ShortcutKeyDisplayString = "";
            this.menuFullWindow.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.menuFullWindow.Size = new System.Drawing.Size(184, 22);
            this.menuFullWindow.Text = "Full Window";
            this.menuFullWindow.Click += new System.EventHandler(this.menuFullWindow_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHowToUse,
            this.toolStripSeparator3,
            this.menuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuItemHowToUse
            // 
            this.menuItemHowToUse.Image = global::Server_GUI.Properties.Resources.question4;
            this.menuItemHowToUse.Name = "menuItemHowToUse";
            this.menuItemHowToUse.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuItemHowToUse.Size = new System.Drawing.Size(154, 22);
            this.menuItemHowToUse.Text = "How to Use";
            this.menuItemHowToUse.Click += new System.EventHandler(this.menuItemHowToUse_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Image = global::Server_GUI.Properties.Resources.info2;
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(154, 22);
            this.menuItemAbout.Text = "About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // virtualForms
            // 
            this.virtualForms.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.virtualForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.virtualForms.Controls.Add(this.virtualDisconnected);
            this.virtualForms.Controls.Add(this.virtualConnected);
            this.virtualForms.Location = new System.Drawing.Point(0, 27);
            this.virtualForms.Multiline = true;
            this.virtualForms.Name = "virtualForms";
            this.virtualForms.SelectedIndex = 0;
            this.virtualForms.Size = new System.Drawing.Size(784, 538);
            this.virtualForms.TabIndex = 2;
            // 
            // virtualDisconnected
            // 
            this.virtualDisconnected.BackColor = System.Drawing.Color.White;
            this.virtualDisconnected.BackgroundImage = global::Server_GUI.Properties.Resources.backgroundChatServer;
            this.virtualDisconnected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.virtualDisconnected.Controls.Add(this.pictureBox1);
            this.virtualDisconnected.Controls.Add(this.btnStartServer);
            this.virtualDisconnected.Location = new System.Drawing.Point(4, 4);
            this.virtualDisconnected.Name = "virtualDisconnected";
            this.virtualDisconnected.Padding = new System.Windows.Forms.Padding(3);
            this.virtualDisconnected.Size = new System.Drawing.Size(776, 512);
            this.virtualDisconnected.TabIndex = 0;
            this.virtualDisconnected.Text = "(Virtual) Disconnected";
            this.virtualDisconnected.Enter += new System.EventHandler(this.virtualDisconnected_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(163, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 200);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartServer.BackColor = System.Drawing.Color.Transparent;
            this.btnStartServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartServer.FlatAppearance.BorderSize = 2;
            this.btnStartServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStartServer.ForeColor = System.Drawing.Color.Firebrick;
            this.btnStartServer.Location = new System.Drawing.Point(295, 357);
            this.btnStartServer.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(200, 40);
            this.btnStartServer.TabIndex = 5;
            this.btnStartServer.Text = "Start a Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // virtualConnected
            // 
            this.virtualConnected.BackColor = System.Drawing.SystemColors.Control;
            this.virtualConnected.Controls.Add(this.tabControlServers);
            this.virtualConnected.Location = new System.Drawing.Point(4, 4);
            this.virtualConnected.Name = "virtualConnected";
            this.virtualConnected.Padding = new System.Windows.Forms.Padding(3);
            this.virtualConnected.Size = new System.Drawing.Size(776, 512);
            this.virtualConnected.TabIndex = 1;
            this.virtualConnected.Text = "(Virtual) Connected";
            this.virtualConnected.Enter += new System.EventHandler(this.virtualConnected_Enter);
            // 
            // tabControlServers
            // 
            this.tabControlServers.Controls.Add(this.tabPageServer);
            this.tabControlServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlServers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControlServers.ItemSize = new System.Drawing.Size(80, 25);
            this.tabControlServers.Location = new System.Drawing.Point(3, 3);
            this.tabControlServers.Name = "tabControlServers";
            this.tabControlServers.Padding = new System.Drawing.Point(20, 3);
            this.tabControlServers.SelectedIndex = 0;
            this.tabControlServers.Size = new System.Drawing.Size(770, 506);
            this.tabControlServers.TabIndex = 1;
            // 
            // tabPageServer
            // 
            this.tabPageServer.BackColor = System.Drawing.Color.Gray;
            this.tabPageServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageServer.Controls.Add(this.panel1);
            this.tabPageServer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPageServer.Location = new System.Drawing.Point(4, 29);
            this.tabPageServer.Name = "tabPageServer";
            this.tabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServer.Size = new System.Drawing.Size(762, 473);
            this.tabPageServer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 468);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(763, 468);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 42);
            this.panel4.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.Controls.Add(this.btnDatabaseControl);
            this.panel9.Controls.Add(this.btnBlockUser);
            this.panel9.Controls.Add(this.btnSendMessage);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.btnCloseServer);
            this.panel9.Location = new System.Drawing.Point(19, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(724, 34);
            this.panel9.TabIndex = 0;
            // 
            // btnDatabaseControl
            // 
            this.btnDatabaseControl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDatabaseControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatabaseControl.FlatAppearance.BorderSize = 2;
            this.btnDatabaseControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabaseControl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDatabaseControl.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDatabaseControl.Location = new System.Drawing.Point(426, 3);
            this.btnDatabaseControl.Name = "btnDatabaseControl";
            this.btnDatabaseControl.Size = new System.Drawing.Size(74, 27);
            this.btnDatabaseControl.TabIndex = 8;
            this.btnDatabaseControl.Text = "Database";
            this.btnDatabaseControl.UseVisualStyleBackColor = false;
            this.btnDatabaseControl.Click += new System.EventHandler(this.btnDatabaseControl_Click);
            // 
            // btnBlockUser
            // 
            this.btnBlockUser.BackColor = System.Drawing.Color.LightGray;
            this.btnBlockUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockUser.Enabled = false;
            this.btnBlockUser.FlatAppearance.BorderSize = 2;
            this.btnBlockUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBlockUser.ForeColor = System.Drawing.Color.Gray;
            this.btnBlockUser.Location = new System.Drawing.Point(506, 3);
            this.btnBlockUser.Name = "btnBlockUser";
            this.btnBlockUser.Size = new System.Drawing.Size(103, 27);
            this.btnBlockUser.TabIndex = 6;
            this.btnBlockUser.Text = "Block User";
            this.btnBlockUser.UseVisualStyleBackColor = false;
            this.btnBlockUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMessage.FlatAppearance.BorderSize = 2;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSendMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSendMessage.Location = new System.Drawing.Point(13, 3);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(116, 27);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lblNotListening);
            this.panel10.Controls.Add(this.btnListenOnOff);
            this.panel10.Controls.Add(this.lblListening);
            this.panel10.Controls.Add(this.picBoxListening);
            this.panel10.Location = new System.Drawing.Point(136, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(284, 34);
            this.panel10.TabIndex = 7;
            // 
            // lblNotListening
            // 
            this.lblNotListening.AutoSize = true;
            this.lblNotListening.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNotListening.Location = new System.Drawing.Point(43, 1);
            this.lblNotListening.Name = "lblNotListening";
            this.lblNotListening.Size = new System.Drawing.Size(75, 12);
            this.lblNotListening.TabIndex = 5;
            this.lblNotListening.Text = "Not listening...";
            this.lblNotListening.Visible = false;
            // 
            // btnListenOnOff
            // 
            this.btnListenOnOff.BackColor = System.Drawing.Color.LightPink;
            this.btnListenOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListenOnOff.FlatAppearance.BorderSize = 2;
            this.btnListenOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListenOnOff.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnListenOnOff.ForeColor = System.Drawing.Color.DarkRed;
            this.btnListenOnOff.Location = new System.Drawing.Point(159, 4);
            this.btnListenOnOff.Name = "btnListenOnOff";
            this.btnListenOnOff.Size = new System.Drawing.Size(115, 25);
            this.btnListenOnOff.TabIndex = 4;
            this.btnListenOnOff.Text = "Stop Listening";
            this.btnListenOnOff.UseVisualStyleBackColor = false;
            this.btnListenOnOff.Click += new System.EventHandler(this.btnListenOnOff_Click);
            // 
            // lblListening
            // 
            this.lblListening.AutoSize = true;
            this.lblListening.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblListening.Location = new System.Drawing.Point(27, 1);
            this.lblListening.Name = "lblListening";
            this.lblListening.Size = new System.Drawing.Size(107, 12);
            this.lblListening.TabIndex = 1;
            this.lblListening.Text = "Listening to clients...";
            // 
            // picBoxListening
            // 
            this.picBoxListening.BackColor = System.Drawing.Color.Transparent;
            this.picBoxListening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxListening.Image = global::Server_GUI.Properties.Resources.clientsListener;
            this.picBoxListening.Location = new System.Drawing.Point(8, 16);
            this.picBoxListening.Name = "picBoxListening";
            this.picBoxListening.Size = new System.Drawing.Size(143, 12);
            this.picBoxListening.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxListening.TabIndex = 3;
            this.picBoxListening.TabStop = false;
            // 
            // btnCloseServer
            // 
            this.btnCloseServer.BackColor = System.Drawing.Color.Gray;
            this.btnCloseServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseServer.FlatAppearance.BorderSize = 2;
            this.btnCloseServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseServer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCloseServer.Location = new System.Drawing.Point(615, 3);
            this.btnCloseServer.Name = "btnCloseServer";
            this.btnCloseServer.Size = new System.Drawing.Size(97, 27);
            this.btnCloseServer.TabIndex = 4;
            this.btnCloseServer.Text = "Close Server";
            this.btnCloseServer.UseVisualStyleBackColor = false;
            this.btnCloseServer.Click += new System.EventHandler(this.btnCloseServer_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel6);
            this.splitContainer2.Size = new System.Drawing.Size(763, 422);
            this.splitContainer2.SplitterDistance = 215;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(20, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 204);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtUsersConnected);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 202);
            this.panel3.TabIndex = 2;
            // 
            // txtUsersConnected
            // 
            this.txtUsersConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsersConnected.BackColor = System.Drawing.Color.Black;
            this.txtUsersConnected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsersConnected.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtUsersConnected.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtUsersConnected.Location = new System.Drawing.Point(11, 6);
            this.txtUsersConnected.MaximumSize = new System.Drawing.Size(87, 17);
            this.txtUsersConnected.MinimumSize = new System.Drawing.Size(86, 15);
            this.txtUsersConnected.Name = "txtUsersConnected";
            this.txtUsersConnected.ReadOnly = true;
            this.txtUsersConnected.Size = new System.Drawing.Size(86, 16);
            this.txtUsersConnected.TabIndex = 2;
            this.txtUsersConnected.Text = "(0) Users";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(294, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Users";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.listViewUsers);
            this.panel5.Location = new System.Drawing.Point(3, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(714, 169);
            this.panel5.TabIndex = 0;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderUserName,
            this.colHeaderColor,
            this.colHeaderStatus,
            this.colHeaderDate});
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUsers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(0, 0);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(710, 165);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewUsers_ItemSelectionChanged);
            // 
            // colHeaderUserName
            // 
            this.colHeaderUserName.Text = "User Name";
            this.colHeaderUserName.Width = 180;
            // 
            // colHeaderColor
            // 
            this.colHeaderColor.Text = "Color";
            this.colHeaderColor.Width = 100;
            // 
            // colHeaderStatus
            // 
            this.colHeaderStatus.Text = "Status";
            this.colHeaderStatus.Width = 120;
            // 
            // colHeaderDate
            // 
            this.colHeaderDate.Text = "Date";
            this.colHeaderDate.Width = 180;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(20, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(724, 192);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(722, 190);
            this.panel7.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(321, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "History";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.listViewHistory);
            this.panel8.Location = new System.Drawing.Point(3, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(714, 157);
            this.panel8.TabIndex = 0;
            // 
            // listViewHistory
            // 
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderEvent,
            this.colHeaderDescription,
            this.colHeaderHistoryDate});
            this.listViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHistory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.Location = new System.Drawing.Point(0, 0);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(710, 153);
            this.listViewHistory.TabIndex = 0;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // colHeaderEvent
            // 
            this.colHeaderEvent.Text = "Event";
            this.colHeaderEvent.Width = 140;
            // 
            // colHeaderDescription
            // 
            this.colHeaderDescription.Text = "Description";
            this.colHeaderDescription.Width = 400;
            // 
            // colHeaderHistoryDate
            // 
            this.colHeaderHistoryDate.Text = "Date";
            this.colHeaderHistoryDate.Width = 155;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.virtualForms);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = global::Server_GUI.Properties.Resources.favicon;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Ohad\'s Chat - Server Side";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.virtualForms.ResumeLayout(false);
            this.virtualDisconnected.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.virtualConnected.ResumeLayout(false);
            this.tabControlServers.ResumeLayout(false);
            this.tabPageServer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxListening)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuFullWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemHowToUse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripMenuItem menuServerDetails;
        protected System.Windows.Forms.ToolStripMenuItem menuNewServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage virtualConnected;
        private System.Windows.Forms.TabPage virtualDisconnected;
        private VirtualForm virtualForms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TabControl tabControlServers;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TabPage tabPageServer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader colHeaderUserName;
        private System.Windows.Forms.ColumnHeader colHeaderStatus;
        private System.Windows.Forms.ColumnHeader colHeaderDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        internal System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader colHeaderEvent;
        private System.Windows.Forms.ColumnHeader colHeaderDescription;
        private System.Windows.Forms.ColumnHeader colHeaderHistoryDate;
        private System.Windows.Forms.TextBox txtUsersConnected;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnBlockUser;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnListenOnOff;
        private System.Windows.Forms.Label lblListening;
        private System.Windows.Forms.PictureBox picBoxListening;
        private System.Windows.Forms.Button btnCloseServer;
        private System.Windows.Forms.ColumnHeader colHeaderColor;
        private System.Windows.Forms.Label lblNotListening;
        private System.Windows.Forms.ToolStripMenuItem menuItemDBControl;
        private System.Windows.Forms.Button btnDatabaseControl;
    }
}

