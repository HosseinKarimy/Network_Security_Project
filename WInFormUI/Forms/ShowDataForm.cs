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
            var newContact = new ContactModel
            {
                Name = TextBox_Name.Text,
                Number = TextBox_Number.Text,
                Owner = _user.Username,
                Sign = TextBox_Name.Text + TextBox_Number.Text + _user.Username
            };

            var contactDto = new ContactSecurityOperator().EncrypteContact(newContact, _user.Password);
            try
            {
                new ContactRepository().Add(contactDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
