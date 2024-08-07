﻿using Models.Models;
using Operations.DomainOperations;

namespace WInFormUI
{
    public partial class ShowDataForm : Form
    {
        private readonly UserModel _user;
        private readonly IContactDomainOperator _contactDomainOperator;
        public ShowDataForm(UserModel _user)
        {
            InitializeComponent();
            this._user = _user;
            this._contactDomainOperator = new ContactDomainOperator(_user.Key);
        }

        private void ShowDataForm_Load(object sender, EventArgs e)
        {
            LoadDataInList();
        }

        private void Button_AddContact_Click(object sender, EventArgs e)
        {
            if (!ValidationForm())
            {
                MessageBox.Show("Name or Number Can't be empty.");
                return;
            }

            var newContact = new ContactModel
            {
                Name = TextBox_Name.Text,
                Number = TextBox_Number.Text,
                Owner = _user.Username
            };

            var resault = _contactDomainOperator.AddNewContact(newContact);
            if (resault)
            {
                ClearForm();
                LoadDataInList();
            } else
            {
                MessageBox.Show("an error occured");
            }
        }

        private void Button_EditContact_Click(object sender, EventArgs e)
        {
            if (ListView_Contacts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one contact to show details");
                return;
            }

            ContactModel? selectedItem = ListView_Contacts.SelectedItems[0].Tag as ContactModel;

            if (!ValidationForm())
            {
                MessageBox.Show("Name or Number Can't be empty.");
                return;
            }

            var editedContact = new ContactModel
            {
                ID = selectedItem.ID,
                Name = TextBox_Name.Text,
                Number = TextBox_Number.Text,
                Owner = _user.Username,
            };

            var resault = _contactDomainOperator.EditContact(editedContact);
            if (resault)
            {
                ClearForm();
                LoadDataInList();
            } else
            {
                MessageBox.Show("an error occured");
            }
        }

        private void Button_DeleteContact_Click(object sender, EventArgs e)
        {
            if (ListView_Contacts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one contact to show details");
                return;
            }

            var selectedItem = ListView_Contacts.SelectedItems[0].Tag as ContactModel;
            
            var resault = _contactDomainOperator.DeleteContact(selectedItem);
            if (resault)
            {
                ClearForm();
                LoadDataInList();
            } else
            {
                MessageBox.Show("an error occured");
            }
        }

        private void ListView_Contacts_ItemActivate(object sender, EventArgs e)
        {
            Button_EditContact.Enabled = true;
            Button_DeleteContact.Enabled = true;
            var selectedItem = ListView_Contacts.SelectedItems[0].Tag as ContactModel;
            TextBox_Name.Text = selectedItem!.Name;
            TextBox_Number.Text = selectedItem!.Number;
        }

        private void LoadDataInList()
        {
            var contacts = _contactDomainOperator.GetAllContancts(_user.Username);
            ListView_Contacts.Clear();
            ListView_Contacts.View = View.Details;
            ListView_Contacts.Columns.Add("Name", 100);
            ListView_Contacts.Columns.Add("Numer", 100);
            ListView_Contacts.Columns.Add("IsManipulated", 100);
            contacts.ForEach(
                contact =>
                {
                    var newItem = new ListViewItem([contact.Name, contact.Number, contact.IsManipulated.ToString()]) { Tag = contact };
                    ListView_Contacts.Items.Add(newItem);
                }
                );
        }

        private bool ValidationForm()
        {
            return !string.IsNullOrEmpty(TextBox_Name.Text) && !string.IsNullOrEmpty(TextBox_Name.Text);
        }

        private void ClearForm()
        {
            TextBox_Name.Clear();
            TextBox_Number.Clear();
            Button_EditContact.Enabled = false;
            Button_DeleteContact.Enabled = false;
        }

        private void ListView_Contacts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var selectedItem = ListView_Contacts.SelectedItems[0]?.Tag as ContactModel;
            TextBox_Name.Text = selectedItem?.Name;
            TextBox_Number.Text = selectedItem?.Number;
        }
    }
}
