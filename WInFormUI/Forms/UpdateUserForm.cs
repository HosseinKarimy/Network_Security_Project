using Models.Models;
using Operations.DomainOperations;

namespace WInFormUI.Forms;

public partial class UpdateUserForm : Form
{
    private readonly UserModel _user;
    private readonly IUserDomainOperator _userDomainOP;
    public UpdateUserForm(UserModel user)
    {
        InitializeComponent();
        _userDomainOP = new UserDomainOperator();
        _user = user;
        TextBox_Username.Text = _user.Username;
        TextBox_Username.ReadOnly = true;
    }

    private void Button_Save_Click(object sender, EventArgs e)
    {
        var user = _userDomainOP.UserValidator(new UserModel() { Username = _user.Username, Password = TextBox_OldPassword.Text });

        if (user is null)
        {
            MessageBox.Show("OldPassword Isn't Correct");
            return;
        }
        var isSuccess = _userDomainOP.ChangeUserPassword(_user, TextBox_NewPassword.Text);
        if (isSuccess)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        } else
        {
            MessageBox.Show("an error occured");
        }
    }
}
