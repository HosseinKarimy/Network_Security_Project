using DataAccess;
using DataAccess.Repositories;
using Models.DTO;
using Models.Enums;
using SecurityOperations;

namespace WInFormUI
{
    public partial class AuthenticationProcessUC : UserControl
    {
        private AuthMode authMode = AuthMode.SignIn;
        private readonly EventHandler UserAuthenticated;

        public AuthenticationProcessUC(EventHandler UserAuthenticated)
        {
            InitializeComponent();
            this.UserAuthenticated = UserAuthenticated;
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
            Label_Title.Text = "Sign In";
            LinkedLabel_ChangeMode.Text = "or try Sign Up";
            Button_Confirm.Text = "Sign In";
        }

        private void ChangeToSignUpMode()
        {
            Label_Title.Text = "Sign Up";
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
            try
            {
                var inputUserDTO = new UserDTO()
                {
                    Username = TextBox_Username.Text,
                    Password = TextBox_Password.Text
                };


                var salt = GetRandomString(10);

                ISecurityOperator secOP = new SecurityOperator();
                var saltedHashedPassword = secOP.Hasher(inputUserDTO.Password, salt);

                inputUserDTO.Password = salt + saltedHashedPassword;

                new UserRepository().Add(inputUserDTO);
                UserAuthenticated.Invoke(inputUserDTO, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SignInProcess()
        {
            try
            {
                var inputUserDTO = new UserDTO()
                {
                    Username = TextBox_Username.Text,
                    Password = TextBox_Password.Text
                };

                var inDbUser = new UserRepository().GetByUsername(inputUserDTO.Username);

                string salt = inDbUser.Password[..10];
                string inDbHashedPassword = inDbUser.Password[10..];

                ISecurityOperator userOP = new SecurityOperator();
                var saltedHashedPassword = userOP.Hasher(inputUserDTO.Password, salt);

                if (saltedHashedPassword == inDbHashedPassword)
                {
                    UserAuthenticated.Invoke(inputUserDTO, EventArgs.Empty);
                } else
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Username or Password is Invalid");
            }
            

        }


        private static string GetRandomString(int length)
        {
            Random random = new();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string randomString = new(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }

    }

}


