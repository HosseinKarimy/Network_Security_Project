namespace WInFormUI
{
    partial class ShowDataForm
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
            Panel_Records = new Panel();
            Panel_Actions = new Panel();
            Button_EditContact = new Button();
            Button_DeleteContact = new Button();
            Button_AddContact = new Button();
            Panel_Actions.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Records
            // 
            Panel_Records.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Records.Location = new Point(12, 12);
            Panel_Records.Name = "Panel_Records";
            Panel_Records.Size = new Size(337, 369);
            Panel_Records.TabIndex = 0;
            // 
            // Panel_Actions
            // 
            Panel_Actions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Actions.Controls.Add(Button_EditContact);
            Panel_Actions.Controls.Add(Button_DeleteContact);
            Panel_Actions.Controls.Add(Button_AddContact);
            Panel_Actions.Location = new Point(12, 387);
            Panel_Actions.Name = "Panel_Actions";
            Panel_Actions.Size = new Size(337, 39);
            Panel_Actions.TabIndex = 1;
            // 
            // Button_EditContact
            // 
            Button_EditContact.Location = new Point(224, 9);
            Button_EditContact.Name = "Button_EditContact";
            Button_EditContact.Size = new Size(100, 23);
            Button_EditContact.TabIndex = 0;
            Button_EditContact.Text = "Edit Contact";
            Button_EditContact.UseVisualStyleBackColor = true;
            Button_EditContact.Click += Button_DeleteContact_Click;
            // 
            // Button_DeleteContact
            // 
            Button_DeleteContact.Location = new Point(118, 9);
            Button_DeleteContact.Name = "Button_DeleteContact";
            Button_DeleteContact.Size = new Size(100, 23);
            Button_DeleteContact.TabIndex = 0;
            Button_DeleteContact.Text = "Delete Contact";
            Button_DeleteContact.UseVisualStyleBackColor = true;
            Button_DeleteContact.Click += Button_DeleteContact_Click;
            // 
            // Button_AddContact
            // 
            Button_AddContact.Location = new Point(10, 9);
            Button_AddContact.Name = "Button_AddContact";
            Button_AddContact.Size = new Size(102, 23);
            Button_AddContact.TabIndex = 0;
            Button_AddContact.Text = "Add Contact";
            Button_AddContact.UseVisualStyleBackColor = true;
            // 
            // ShowDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 438);
            Controls.Add(Panel_Actions);
            Controls.Add(Panel_Records);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowDataForm";
            Text = "ShowDataForm";
            Panel_Actions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Records;
        private Panel Panel_Actions;
        private Button Button_DeleteContact;
        private Button Button_AddContact;
        private Button Button_EditContact;
    }
}