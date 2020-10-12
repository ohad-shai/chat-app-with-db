namespace Server_GUI
{
    partial class DatabaseControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSearchUserBy = new System.Windows.Forms.ComboBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerSearchMessage = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchMessage = new System.Windows.Forms.TextBox();
            this.comboBoxSearchMessageBy = new System.Windows.Forms.ComboBox();
            this.btnSearchMessage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.colHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderLastConnectionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderIsConnected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.colHeaderMessageID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderSent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderRecipientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(434, 481);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnShowAllUsers);
            this.panel3.Controls.Add(this.btnDeleteUser);
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 37);
            this.panel3.TabIndex = 7;
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.BackColor = System.Drawing.Color.Silver;
            this.btnShowAllUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllUsers.ForeColor = System.Drawing.Color.Green;
            this.btnShowAllUsers.Location = new System.Drawing.Point(10, 6);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(124, 23);
            this.btnShowAllUsers.TabIndex = 2;
            this.btnShowAllUsers.Text = "Show All Users";
            this.btnShowAllUsers.UseVisualStyleBackColor = true;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteUser.Location = new System.Drawing.Point(325, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(434, 425);
            this.splitContainer2.SplitterDistance = 53;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearchUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxSearchUserBy);
            this.panel1.Controls.Add(this.btnSearchUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 35);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Enabled = false;
            this.txtSearchUser.Location = new System.Drawing.Point(235, 7);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(103, 20);
            this.txtSearchUser.TabIndex = 6;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "value:";
            // 
            // comboBoxSearchUserBy
            // 
            this.comboBoxSearchUserBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSearchUserBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchUserBy.FormattingEnabled = true;
            this.comboBoxSearchUserBy.Items.AddRange(new object[] {
            "ID",
            "UserName"});
            this.comboBoxSearchUserBy.Location = new System.Drawing.Point(115, 7);
            this.comboBoxSearchUserBy.Name = "comboBoxSearchUserBy";
            this.comboBoxSearchUserBy.Size = new System.Drawing.Size(72, 21);
            this.comboBoxSearchUserBy.TabIndex = 3;
            this.comboBoxSearchUserBy.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSearchUserBy_SelectionChangeCommitted);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchUser.Enabled = false;
            this.btnSearchUser.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchUser.Location = new System.Drawing.Point(344, 5);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(56, 23);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search user by:";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer3.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer3.Panel2.Controls.Add(this.listViewMessages);
            this.splitContainer3.Panel2.Controls.Add(this.listViewUsers);
            this.splitContainer3.Size = new System.Drawing.Size(434, 368);
            this.splitContainer3.SplitterDistance = 52;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePickerSearchMessage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSearchMessage);
            this.panel2.Controls.Add(this.comboBoxSearchMessageBy);
            this.panel2.Controls.Add(this.btnSearchMessage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 37);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePickerSearchMessage
            // 
            this.dateTimePickerSearchMessage.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearchMessage.Location = new System.Drawing.Point(235, 8);
            this.dateTimePickerSearchMessage.Name = "dateTimePickerSearchMessage";
            this.dateTimePickerSearchMessage.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerSearchMessage.TabIndex = 1;
            this.dateTimePickerSearchMessage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "value:";
            // 
            // txtSearchMessage
            // 
            this.txtSearchMessage.Enabled = false;
            this.txtSearchMessage.Location = new System.Drawing.Point(235, 8);
            this.txtSearchMessage.Name = "txtSearchMessage";
            this.txtSearchMessage.Size = new System.Drawing.Size(103, 20);
            this.txtSearchMessage.TabIndex = 4;
            this.txtSearchMessage.TextChanged += new System.EventHandler(this.txtSearchMessage_TextChanged);
            // 
            // comboBoxSearchMessageBy
            // 
            this.comboBoxSearchMessageBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSearchMessageBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchMessageBy.FormattingEnabled = true;
            this.comboBoxSearchMessageBy.Items.AddRange(new object[] {
            "Text",
            "Date"});
            this.comboBoxSearchMessageBy.Location = new System.Drawing.Point(115, 8);
            this.comboBoxSearchMessageBy.Name = "comboBoxSearchMessageBy";
            this.comboBoxSearchMessageBy.Size = new System.Drawing.Size(72, 21);
            this.comboBoxSearchMessageBy.TabIndex = 3;
            this.comboBoxSearchMessageBy.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSearchMessageBy_SelectionChangeCommitted);
            // 
            // btnSearchMessage
            // 
            this.btnSearchMessage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearchMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMessage.Enabled = false;
            this.btnSearchMessage.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchMessage.Location = new System.Drawing.Point(344, 6);
            this.btnSearchMessage.Name = "btnSearchMessage";
            this.btnSearchMessage.Size = new System.Drawing.Size(56, 23);
            this.btnSearchMessage.TabIndex = 1;
            this.btnSearchMessage.Text = "Search";
            this.btnSearchMessage.UseVisualStyleBackColor = true;
            this.btnSearchMessage.Click += new System.EventHandler(this.btnSearchMessage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search message by:";
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderID,
            this.colHeaderUserName,
            this.colHeaderName,
            this.colHeaderLastConnectionDate,
            this.colHeaderIsConnected});
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(0, 0);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(432, 310);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewUsers_ItemSelectionChanged);
            // 
            // colHeaderID
            // 
            this.colHeaderID.Text = "ID";
            this.colHeaderID.Width = 50;
            // 
            // colHeaderUserName
            // 
            this.colHeaderUserName.Text = "UserName";
            this.colHeaderUserName.Width = 80;
            // 
            // colHeaderName
            // 
            this.colHeaderName.Text = "Name";
            this.colHeaderName.Width = 80;
            // 
            // colHeaderLastConnectionDate
            // 
            this.colHeaderLastConnectionDate.Text = "Last Connection Date";
            this.colHeaderLastConnectionDate.Width = 140;
            // 
            // colHeaderIsConnected
            // 
            this.colHeaderIsConnected.Text = "Is Connected";
            this.colHeaderIsConnected.Width = 75;
            // 
            // listViewMessages
            // 
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderMessageID,
            this.colHeaderText,
            this.colHeaderUserID,
            this.colHeaderSent,
            this.colHeaderRecipientID});
            this.listViewMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMessages.FullRowSelect = true;
            this.listViewMessages.GridLines = true;
            this.listViewMessages.Location = new System.Drawing.Point(0, 0);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(432, 310);
            this.listViewMessages.TabIndex = 1;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Details;
            this.listViewMessages.Visible = false;
            // 
            // colHeaderMessageID
            // 
            this.colHeaderMessageID.Text = "ID";
            this.colHeaderMessageID.Width = 50;
            // 
            // colHeaderText
            // 
            this.colHeaderText.Text = "Message Text";
            this.colHeaderText.Width = 115;
            // 
            // colHeaderUserID
            // 
            this.colHeaderUserID.Text = "UserID";
            this.colHeaderUserID.Width = 50;
            // 
            // colHeaderSent
            // 
            this.colHeaderSent.Text = "Sent";
            this.colHeaderSent.Width = 140;
            // 
            // colHeaderRecipientID
            // 
            this.colHeaderRecipientID.Text = "RecipientID";
            this.colHeaderRecipientID.Width = 70;
            // 
            // DatabaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 481);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 520);
            this.Name = "DatabaseControl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Control";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSearchUserBy;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchMessage;
        private System.Windows.Forms.ComboBox comboBoxSearchMessageBy;
        private System.Windows.Forms.Button btnSearchMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader colHeaderID;
        private System.Windows.Forms.ColumnHeader colHeaderUserName;
        private System.Windows.Forms.ColumnHeader colHeaderName;
        private System.Windows.Forms.ColumnHeader colHeaderLastConnectionDate;
        private System.Windows.Forms.ColumnHeader colHeaderIsConnected;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowAllUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchMessage;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ColumnHeader colHeaderMessageID;
        private System.Windows.Forms.ColumnHeader colHeaderText;
        private System.Windows.Forms.ColumnHeader colHeaderUserID;
        private System.Windows.Forms.ColumnHeader colHeaderSent;
        private System.Windows.Forms.ColumnHeader colHeaderRecipientID;
    }
}