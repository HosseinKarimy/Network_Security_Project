using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using Models;
using Models.DTO;
using Models.Models;
using Operations;
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
            this._contactDomainOperator = new ContactDomainOperator();
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
                Owner = _user.Username,
                Sign = TextBox_Name.Text + TextBox_Number.Text + _user.Username
            };

            var resault = _contactDomainOperator.AddNewContact(newContact, _user.Password);
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
            var selectedItem = ListView_Contacts.SelectedItems[0].Tag as ContactModel;

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
                Sign = TextBox_Name.Text + TextBox_Number.Text + _user.Username
            };

            var resault = _contactDomainOperator.EditContact(editedContact, _user.Password);
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
            var selectedItem = ListView_Contacts.SelectedItems[0].Tag as ContactModel;

            var resault = _contactDomainOperator.DeleteContact(selectedItem , _user.Password);
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
            var selectedItem = ListView_Contacts.SelectedItems[0].Tag as ContactModel;
            TextBox_Name.Text = selectedItem!.Name;
            TextBox_Number.Text = selectedItem!.Number;
        }

        private void LoadDataInList()
        {
            var contacts = _contactDomainOperator.GetAllContancts(_user.Username, _user.Password);
            ListView_Contacts.Clear();
            contacts.ForEach(
                contact =>
                {
                    var newItem = new ListViewItem() { Text = $"{contact.Name} {contact.Number}", Tag = contact };
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
        }
        
    }
}
