using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInFormUI
{
    public partial class AuthenticationProcessUC : UserControl
    {
        private AuthMode authMode = AuthMode.SignIn;
        public AuthenticationProcessUC()
        {
            InitializeComponent();
        }

        private void AuthenticationProcessUC_Load(object sender, EventArgs e)
        {
            AuthenticationProcess();
        }

        private void AuthenticationProcess()
        {
            if (authMode == AuthMode.SignIn)
            {
                SignInProcess();
            } else
            {
                SignUpProcess();
            }
        }

        private void SignInProcess()
        {
            Label_Title.Text = "Sign In";
            LinkedLabel_ChangeMode.Text = "or try Sign Up";
            Button_Confirm.Text = "Sign In";
        }

        private void SignUpProcess()
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
    }
}
