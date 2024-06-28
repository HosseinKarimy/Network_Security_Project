using DataAccess.Repositories;
using DataAccess.Repositories.IRepositories;
using Models;
using Models.DTO;
using Models.Models;
using SecurityOperations;

namespace WInFormUI
{
    public partial class ShowDataForm : Form
    {
        private UserModel _user;
        public ShowDataForm(UserModel _user)
        {
            InitializeComponent();
            this._user = _user;
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
           // throw new NotImplementedException();
        }

        private void Button_AddContact_Click(object sender, EventArgs e)
        {
            var newContact = new ContactDTO();

            ISecurityOperator contactOperator = new SecurityOperator();

            newContact.Name = contactOperator.Encryptor(TextBox_Name.Text, _user.Password);
            newContact.Number = contactOperator.Encryptor(TextBox_Number.Text, _user.Password);
            newContact.Owner = contactOperator.Encryptor(_user.Username, _user.Password);
            newContact.Sign = contactOperator.Sign(TextBox_Name.Text + TextBox_Number.Text , _user.Password);

            IContactRepository contactRepo = new ContactRepository();
            contactRepo.Add(newContact);

        }
    }
}
