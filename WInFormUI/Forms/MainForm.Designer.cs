namespace WInFormUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel_Main = new Panel();
            panel1 = new Panel();
            LinkLabel_ChangePassword = new LinkLabel();
            Button_LogOut = new Button();
            Label_Username = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Main
            // 
            Panel_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Main.BorderStyle = BorderStyle.Fixed3D;
            Panel_Main.Location = new Point(15, 51);
            Panel_Main.Name = "Panel_Main";
            Panel_Main.Size = new Size(364, 553);
            Panel_Main.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(LinkLabel_ChangePassword);
            panel1.Controls.Add(Button_LogOut);
            panel1.Controls.Add(Label_Username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 33);
            panel1.TabIndex = 1;
            // 
            // LinkLabel_ChangePassword
            // 
            LinkLabel_ChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LinkLabel_ChangePassword.AutoSize = true;
            LinkLabel_ChangePassword.Location = new Point(183, 9);
            LinkLabel_ChangePassword.Name = "LinkLabel_ChangePassword";
            LinkLabel_ChangePassword.Size = new Size(101, 15);
            LinkLabel_ChangePassword.TabIndex = 2;
            LinkLabel_ChangePassword.TabStop = true;
            LinkLabel_ChangePassword.Text = "Change Password";
            LinkLabel_ChangePassword.Visible = false;
            LinkLabel_ChangePassword.LinkClicked += LinkLabel_ChangePassword_LinkClicked;
            // 
            // Button_LogOut
            // 
            Button_LogOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button_LogOut.Location = new Point(290, 5);
            Button_LogOut.Name = "Button_LogOut";
            Button_LogOut.Size = new Size(67, 22);
            Button_LogOut.TabIndex = 1;
            Button_LogOut.Text = "LogOut";
            Button_LogOut.UseVisualStyleBackColor = true;
            Button_LogOut.Visible = false;
            Button_LogOut.Click += Button_LogOut_Click;
            // 
            // Label_Username
            // 
            Label_Username.AutoSize = true;
            Label_Username.Location = new Point(47, 9);
            Label_Username.Name = "Label_Username";
            Label_Username.Size = new Size(0, 15);
            Label_Username.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 616);
            Controls.Add(panel1);
            Controls.Add(Panel_Main);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Main;
        private Panel panel1;
        private LinkLabel LinkLabel_ChangePassword;
        private Button Button_LogOut;
        private Label Label_Username;
        private Label label1;
    }
}
