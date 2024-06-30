using Models.Models;
using Operations.DomainOperations;
using WInFormUI.Forms;

namespace WInFormUI;

public partial class MainForm : Form
{
    private UserModel _user;
    public EventHandler UserAuthenticated;
    public MainForm()
    {
        InitializeComponent();
        UserAuthenticated += UserAuthed;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadAuthenticationForm();
    }

    private void Button_LogOut_Click(object sender, EventArgs e)
    {
        LoadAuthenticationForm();
    }

    private void LoadAuthenticationForm()
    {
        Panel_Main.Controls.Clear();
        Button_LogOut.Visible = false;
        LinkLabel_ChangePassword.Visible = false;
        Label_Username.Text = "<no user>";

        var AuthUC = new AuthenticationProcessUC(UserAuthenticated);
        Panel_Main.Controls.Add(AuthUC);
    }

    private void UserAuthed(object? sender, EventArgs e)
    {
        Panel_Main.Controls.Clear();
        _user = (sender as UserModel)!;

        Label_Username.Text = _user.Username;
        Button_LogOut.Visible = true;
        LinkLabel_ChangePassword.Visible = true;

        var showDataForm = new ShowDataForm(_user)
        {
            TopLevel = false,
            Dock = DockStyle.Fill
        };
        Panel_Main.Controls.Add(showDataForm);
        showDataForm.Show();
    }

    private void LinkLabel_ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var updateUserForm = new UpdateUserForm(_user);
        var result = updateUserForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            MessageBox.Show("Password Changed");
        }
    }
}
