using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using Models;
using Models.DTO;
using Models.Models;
using Operations;
using Operations.DominOperations;

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

        private void Button_DeleteContact_Click(object sender, EventArgs e)
        {

        }

        private void ShowDataForm_Load(object sender, EventArgs e)
        {
            LoadDataInList();
        }

        private void LoadDataInList()
        {
            var contacts = _contactDomainOperator.GetAllContancts(_user.Username, _user.Password);
            ListView_Contacts.Clear();
            contacts.ForEach(contact => { ListView_Contacts.Items.Add($"{contact.Name} {contact.Number}"); });
        }

        private void Button_AddContact_Click(object sender, EventArgs e)
        {
            var newContact = new ContactModel
            {
                Name = TextBox_Name.Text,
                Number = TextBox_Number.Text,
                Owner = _user.Username,
                Sign = TextBox_Name.Text + TextBox_Number.Text + _user.Username
            };

            _contactDomainOperator.AddNewContact(newContact, _user.Password);
        }
    }
}
