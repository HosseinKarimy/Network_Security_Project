namespace WInFormUI.Forms
{
    partial class UpdateUserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            TextBox_Username = new TextBox();
            label2 = new Label();
            TextBox_OldPassword = new TextBox();
            label3 = new Label();
            TextBox_NewPassword = new TextBox();
            Button_Save = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Button_Save);
            panel1.Controls.Add(TextBox_NewPassword);
            panel1.Controls.Add(TextBox_OldPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TextBox_Username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 128);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // TextBox_Username
            // 
            TextBox_Username.Location = new Point(98, 6);
            TextBox_Username.Name = "TextBox_Username";
            TextBox_Username.Size = new Size(169, 23);
            TextBox_Username.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "OldPassword:";
            // 
            // TextBox_OldPassword
            // 
            TextBox_OldPassword.Location = new Point(98, 35);
            TextBox_OldPassword.Name = "TextBox_OldPassword";
            TextBox_OldPassword.PasswordChar = '*';
            TextBox_OldPassword.Size = new Size(169, 23);
            TextBox_OldPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 0;
            label3.Text = "NewPassword:";
            // 
            // TextBox_NewPassword
            // 
            TextBox_NewPassword.Location = new Point(98, 67);
            TextBox_NewPassword.Name = "TextBox_NewPassword";
            TextBox_NewPassword.PasswordChar = '*';
            TextBox_NewPassword.Size = new Size(169, 23);
            TextBox_NewPassword.TabIndex = 1;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(98, 96);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(75, 23);
            Button_Save.TabIndex = 2;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 152);
            Controls.Add(panel1);
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button Button_Save;
        private TextBox TextBox_NewPassword;
        private TextBox TextBox_OldPassword;
        private Label label3;
        private Label label2;
        private TextBox TextBox_Username;
    }
}