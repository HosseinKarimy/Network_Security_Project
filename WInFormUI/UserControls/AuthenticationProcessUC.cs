using DataAccess.Repositories;
using Models.DTO;
using Models.Enums;
using Models.Models;
using Operations.DomainOperations;
using Operations.SecurityOperations;

namespace WInFormUI
{
    public partial class AuthenticationProcessUC : UserControl
    {
        private AuthMode authMode = AuthMode.SignIn;
        private readonly EventHandler UserAuthenticated;
        private readonly IUserDomainOperator _userDomainOperator;

        public AuthenticationProcessUC(EventHandler UserAuthenticated)
        {
            InitializeComponent();
            this.UserAuthenticated = UserAuthenticated;
            this._userDomainOperator = new UserDomainOperator();
        }

        private void AuthenticationProcessUC_Load(object sender, EventArgs e)
        {
            AuthenticationProcess();
        }

        private void AuthenticationProcess()
        {
            if (authMode == AuthMode.SignIn)
            {
                ChangeToSignInMode();
            } else
            {
                ChangeToSignUpMode();
            }
        }

        private void ChangeToSignInMode()
        {
            Label_Title.Text = "Sign In Form";
            LinkedLabel_ChangeMode.Text = "or try Sign Up";
            Button_Confirm.Text = "Sign In";
        }

        private void ChangeToSignUpMode()
        {
            Label_Title.Text = "Sign Up Form";
            LinkedLabel_ChangeMode.Text = "or try Sign In";
            Button_Confirm.Text = "Sign Up";
        }

        private void LinkedLabel_ChangeMode_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            authMode = authMode == AuthMode.SignIn ? AuthMode.SignUp : AuthMode.SignIn;
            AuthenticationProcess();
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if (authMode == AuthMode.SignIn)
            {
                SignInProcess();
            } else
            {
                SignUpProcess();
            }
        }

        private void SignUpProcess()
        {
            var inputUser = new UserModel()
            {
                Username = TextBox_Username.Text,
                Password = TextBox_Password.Text
            };

            var isAdded = _userDomainOperator.AddNewUser(inputUser);

            if (isAdded)
            {
                MessageBox.Show("User Added Successfully");
            } else
            {
                MessageBox.Show("Error while adding user");
            }            
        }

        private void SignInProcess()
        {
            var inputUser = new UserModel()
            {
                Username = TextBox_Username.Text,
                Password = TextBox_Password.Text
            };

            var isvalid = _userDomainOperator.IsValidUser(inputUser);

            if (isvalid)
            {
                UserAuthenticated.Invoke(inputUser, EventArgs.Empty);
            } else
            {
                MessageBox.Show("Username or Password is Invalid");
            }
        }       

    }

}


