using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server_Logic;
using Server_DataAccess.Entities;

namespace Server_GUI
{
    public partial class DatabaseControl : Form
    {

        #region Fields

        Server server; // Holds the server logic
        string usernameSelected = null; // Holds the username if selected in the ListView!

        #endregion

        /// <summary>
        /// C'tor
        /// </summary>
        public DatabaseControl(Server server)
        {
            InitializeComponent();

            if (server != null)
                this.server = server;
        }

        /// <summary>
        /// Updates the ListView of users by adding a user!
        /// </summary>
        /// <param name="user">The user to add</param>
        private void AddUserToListView(User user)
        {
            ListViewItem item = new ListViewItem(user.Id.ToString());
            item.SubItems.Add(user.UserName);
            item.SubItems.Add(user.Name);
            item.SubItems.Add(user.LastConnectionDate.ToString());
            item.SubItems.Add(user.IsConnected.ToString());

            listViewUsers.Items.Add(item);
        }

        /// <summary>
        /// Updates the ListView of messages by adding list of messages!
        /// </summary>
        /// <param name="messages"></param>
        private void AddMessagesToListView(List<Server_DataAccess.Entities.Message> messages)
        {
            listViewMessages.Items.Clear(); // Clears items from last session!

            foreach (var message in messages)
            {
                ListViewItem item = new ListViewItem(message.Id.ToString());
                item.SubItems.Add(message.MessageText);
                item.SubItems.Add(message.UserID.ToString());
                item.SubItems.Add(message.Sent.ToString());
                item.SubItems.Add(message.RecipientID.ToString());

                listViewMessages.Items.Add(item);
            }
        }

        /// <summary>
        /// Button: (Show All Users)
        /// </summary>
        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // Shows 'wait cursor' while loading!
            listViewUsers.Items.Clear(); // Resets ListView from last session!

            // Making the relevant ListView being displayed:
            listViewUsers.Visible = true;
            listViewMessages.Visible = false;

            List<User> users = server.DataController.GetAllUsers(); // List of all users in database!

            foreach (User user in users)
            {
                AddUserToListView(user);
            }
        }

        /// <summary>
        /// When selecting an item in the ListView of users!
        /// </summary>
        private void listViewUsers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnDeleteUser.Enabled = false; // Resets the enabling of the delete button!
            usernameSelected = null; // Resets username selected from last session!

            if (e.IsSelected)
            {
                usernameSelected = listViewUsers.Items[e.ItemIndex].SubItems[1].Text; // Assigns the name of the selected user
                btnDeleteUser.Enabled = true; // Enables the delete button!
            }
        }

        /// <summary>
        /// Button: (Delete User)
        /// </summary>
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (listViewUsers.Visible != true || listViewUsers.SelectedItems.Count == 0) // If ListView of users is not visible
            {
                btnDeleteUser.Enabled = false; // Can not delete a user
            }
            else if (usernameSelected != null) // Can delete a user
            {
                server.DataController.DeleteUser(usernameSelected); // Deletes the user from database!

                // Removes the user from the ListView:
                for (int i = 0; i < listViewUsers.Items.Count; i++)
                {
                    if (listViewUsers.Items[i].SubItems[1].Text == usernameSelected)
                    {
                        listViewUsers.Items[i].Remove(); // Removes the user from the GUI list
                        break; // Stops to find the item column
                    }
                }
            }
        }

        #region Search User

        /// <summary>
        /// ComboBox: Search User By
        /// </summary>
        private void comboBoxSearchUserBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxSearchUserBy.SelectedItem.ToString() == "ID" ||
                comboBoxSearchUserBy.SelectedItem.ToString() == "UserName")
            {
                txtSearchUser.Enabled = true;
            }
            else
            {
                txtSearchUser.Enabled = false;
            }
        }

        /// <summary>
        /// TextBox: Value of search user
        /// </summary>
        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUser.Text != string.Empty) // If there's a value to search
            {
                btnSearchUser.Enabled = true; // Can search (enable button)
            }
            else // If there's no value to search
            {
                btnSearchUser.Enabled = false; // Can not search (disable button)
            }
        }

        /// <summary>
        /// Button: Search User
        /// </summary>
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            listViewUsers.Items.Clear(); // Resets ListView of users from last session!

            // Making the relevant ListView being displayed:
            listViewUsers.Visible = true;
            listViewMessages.Visible = false;
            
            // Displays the content for the ListView:
            if (comboBoxSearchUserBy.SelectedItem.ToString() == "ID") // If search is by ID
            {
                if (txtSearchUser.Text != string.Empty) // If there's a value to search
                {
                    int id;
                    if (int.TryParse(txtSearchUser.Text, out id)) // If the string is numeric!
                    {
                        User user = server.DataController.GetUserById(id); // Grabs the user from the database!

                        if (user.Id > 0) // If user found
                            AddUserToListView(user); // Assigns the user to the ListView!
                    }
                    else // If the string is not numeric!
                    {
                        MessageBox.Show("Enter only numeric values to search ID.",
                                        "Attention",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
            else if (comboBoxSearchUserBy.SelectedItem.ToString() == "UserName") // If search is by UserName
            {
                if (txtSearchUser.Text != string.Empty) // If there's a value to search
                {
                    User user = server.DataController.GetUserByUserName(txtSearchUser.Text).FirstOrDefault(); // Grabs the user from the database!

                    if (user != null) // If user found
                        AddUserToListView(user); // Assigns the user to the ListView!
                }
            }
        }

        #endregion

        #region Search Message

        /// <summary>
        /// ComboBox: Search Message By
        /// </summary>
        private void comboBoxSearchMessageBy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxSearchMessageBy.SelectedItem.ToString() == "Text")
            {
                txtSearchMessage.Visible = true; // Visible textBox
                txtSearchMessage.Enabled = true; // Enable textBox
                dateTimePickerSearchMessage.Visible = false; // Disable datePicker
                btnSearchMessage.Enabled = false; // Disable search button
            }
            else if (comboBoxSearchMessageBy.SelectedItem.ToString() == "Date")
            {
                txtSearchMessage.Visible = false; // Not Visible textBox
                txtSearchMessage.Enabled = false; // Disable textBox
                dateTimePickerSearchMessage.Visible = true; // Enable datePicker
                btnSearchMessage.Enabled = true; // Enable search button
            }
            else
            {
                txtSearchMessage.Visible = true; // Visible textBox
                txtSearchMessage.Enabled = false; // Disable textBox
                dateTimePickerSearchMessage.Visible = false; // Disable datePicker
                btnSearchMessage.Enabled = false; // Disable search button
            }
        }

        /// <summary>
        /// TextBox: Value of search message
        /// </summary>
        private void txtSearchMessage_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchMessage.Text != string.Empty) // If there's a value to search
            {
                btnSearchMessage.Enabled = true; // Can search (enable button)
            }
            else // If there's no value to search
            {
                btnSearchMessage.Enabled = false; // Can not search (disable button)
            }
        }

        /// <summary>
        /// Button: Search Message
        /// </summary>
        private void btnSearchMessage_Click(object sender, EventArgs e)
        {
            listViewMessages.Items.Clear(); // Resets ListView of messages from last session!

            // Making the relevant ListView being displayed:
            listViewMessages.Visible = true;
            listViewUsers.Visible = false;

            // Displays the content for the ListView:
            if (comboBoxSearchMessageBy.SelectedItem.ToString() == "Text") // If search is by Text
            {
                if (txtSearchMessage.Text != string.Empty) // If there's a value to search
                {
                    var messages = server.DataController.GetMessagesByText(txtSearchMessage.Text); // Getting the messages from database
                    AddMessagesToListView(messages); // Displays the messages to the GUI
                }
            }
            else if (comboBoxSearchMessageBy.SelectedItem.ToString() == "Date") // If search is by Date
            {
                var messages = server.DataController.GetMessagesByDate(dateTimePickerSearchMessage.Value.Date); // Getting the messages from database
                AddMessagesToListView(messages); // Displays the messages to the GUI
            }
        }

        #endregion

    }
}
