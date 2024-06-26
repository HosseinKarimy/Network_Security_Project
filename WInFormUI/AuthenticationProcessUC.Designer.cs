namespace WInFormUI
{
    partial class AuthenticationProcessUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel_Main = new Panel();
            LinkedLabel_ChangeMode = new LinkLabel();
            Label_Title = new Label();
            Button_Confirm = new Button();
            TextBox_Password = new TextBox();
            label2 = new Label();
            TextBox_Username = new TextBox();
            label1 = new Label();
            Panel_Main.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Main
            // 
            Panel_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Main.Controls.Add(LinkedLabel_ChangeMode);
            Panel_Main.Controls.Add(Label_Title);
            Panel_Main.Controls.Add(Button_Confirm);
            Panel_Main.Controls.Add(TextBox_Password);
            Panel_Main.Controls.Add(label2);
            Panel_Main.Controls.Add(TextBox_Username);
            Panel_Main.Controls.Add(label1);
            Panel_Main.Location = new Point(3, 3);
            Panel_Main.Name = "Panel_Main";
            Panel_Main.Size = new Size(296, 186);
            Panel_Main.TabIndex = 0;
            // 
            // LinkedLabel_ChangeMode
            // 
            LinkedLabel_ChangeMode.AutoSize = true;
            LinkedLabel_ChangeMode.Location = new Point(124, 133);
            LinkedLabel_ChangeMode.Name = "LinkedLabel_ChangeMode";
            LinkedLabel_ChangeMode.Size = new Size(95, 15);
            LinkedLabel_ChangeMode.TabIndex = 9;
            LinkedLabel_ChangeMode.TabStop = true;
            LinkedLabel_ChangeMode.Text = "SignIn or SignUp";
            LinkedLabel_ChangeMode.LinkClicked += LinkedLabel_ChangeMode_LinkClicked_1;
            // 
            // Label_Title
            // 
            Label_Title.AutoSize = true;
            Label_Title.Location = new Point(12, 11);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(60, 15);
            Label_Title.TabIndex = 8;
            Label_Title.Text = "Title Label";
            // 
            // Button_Confirm
            // 
            Button_Confirm.Location = new Point(124, 107);
            Button_Confirm.Name = "Button_Confirm";
            Button_Confirm.Size = new Size(75, 23);
            Button_Confirm.TabIndex = 7;
            Button_Confirm.Text = "button1";
            Button_Confirm.UseVisualStyleBackColor = true;
            Button_Confirm.Click += Button_Confirm_Click;
            // 
            // TextBox_Password
            // 
            TextBox_Password.Location = new Point(106, 78);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.Size = new Size(151, 23);
            TextBox_Password.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // TextBox_Username
            // 
            TextBox_Username.Location = new Point(106, 49);
            TextBox_Username.Name = "TextBox_Username";
            TextBox_Username.Size = new Size(151, 23);
            TextBox_Username.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 52);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // AuthenticationProcessUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel_Main);
            Name = "AuthenticationProcessUC";
            Size = new Size(302, 192);
            Load += AuthenticationProcessUC_Load;
            Panel_Main.ResumeLayout(false);
            Panel_Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Main;
        private Button Button_Confirm;
        private TextBox TextBox_Password;
        private Label label2;
        private TextBox TextBox_Username;
        private Label label1;
        private LinkLabel LinkedLabel_ChangeMode;
        private Label Label_Title;
    }
}
