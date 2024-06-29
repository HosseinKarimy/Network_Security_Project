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
            ListView_Contacts = new ListView();
            Panel_Actions = new Panel();
            Button_EditContact = new Button();
            Button_DeleteContact = new Button();
            Button_AddContact = new Button();
            groupBox1 = new GroupBox();
            TextBox_Number = new TextBox();
            label2 = new Label();
            TextBox_Name = new TextBox();
            label1 = new Label();
            Panel_Records.SuspendLayout();
            Panel_Actions.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Records
            // 
            Panel_Records.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Records.Controls.Add(ListView_Contacts);
            Panel_Records.Location = new Point(12, 12);
            Panel_Records.Name = "Panel_Records";
            Panel_Records.Size = new Size(336, 388);
            Panel_Records.TabIndex = 0;
            // 
            // ListView_Contacts
            // 
            ListView_Contacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListView_Contacts.Location = new Point(0, 0);
            ListView_Contacts.Name = "ListView_Contacts";
            ListView_Contacts.Size = new Size(336, 388);
            ListView_Contacts.TabIndex = 0;
            ListView_Contacts.UseCompatibleStateImageBehavior = false;
            ListView_Contacts.View = View.List;
            ListView_Contacts.ItemActivate += ListView_Contacts_ItemActivate;
            // 
            // Panel_Actions
            // 
            Panel_Actions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Actions.Controls.Add(Button_EditContact);
            Panel_Actions.Controls.Add(Button_DeleteContact);
            Panel_Actions.Controls.Add(Button_AddContact);
            Panel_Actions.Location = new Point(0, 73);
            Panel_Actions.Name = "Panel_Actions";
            Panel_Actions.Size = new Size(336, 39);
            Panel_Actions.TabIndex = 1;
            // 
            // Button_EditContact
            // 
            Button_EditContact.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button_EditContact.Location = new Point(223, 9);
            Button_EditContact.Name = "Button_EditContact";
            Button_EditContact.Size = new Size(100, 23);
            Button_EditContact.TabIndex = 0;
            Button_EditContact.Text = "Edit Contact";
            Button_EditContact.UseVisualStyleBackColor = true;
            Button_EditContact.Click += Button_EditContact_Click;
            // 
            // Button_DeleteContact
            // 
            Button_DeleteContact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Button_DeleteContact.Location = new Point(118, 9);
            Button_DeleteContact.Name = "Button_DeleteContact";
            Button_DeleteContact.Size = new Size(99, 23);
            Button_DeleteContact.TabIndex = 0;
            Button_DeleteContact.Text = "Delete Contact";
            Button_DeleteContact.UseVisualStyleBackColor = true;
            Button_DeleteContact.Click += Button_DeleteContact_Click;
            // 
            // Button_AddContact
            // 
            Button_AddContact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Button_AddContact.Location = new Point(10, 9);
            Button_AddContact.Name = "Button_AddContact";
            Button_AddContact.Size = new Size(102, 23);
            Button_AddContact.TabIndex = 0;
            Button_AddContact.Text = "Add Contact";
            Button_AddContact.UseVisualStyleBackColor = true;
            Button_AddContact.Click += Button_AddContact_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(TextBox_Number);
            groupBox1.Controls.Add(Panel_Actions);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TextBox_Name);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 406);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 112);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contact Info";
            // 
            // TextBox_Number
            // 
            TextBox_Number.Location = new Point(101, 45);
            TextBox_Number.Name = "TextBox_Number";
            TextBox_Number.Size = new Size(162, 23);
            TextBox_Number.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 48);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Number:";
            // 
            // TextBox_Name
            // 
            TextBox_Name.Location = new Point(101, 16);
            TextBox_Name.Name = "TextBox_Name";
            TextBox_Name.Size = new Size(162, 23);
            TextBox_Name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // ShowDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 530);
            Controls.Add(groupBox1);
            Controls.Add(Panel_Records);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowDataForm";
            Text = "ShowDataForm";
            Load += ShowDataForm_Load;
            Panel_Records.ResumeLayout(false);
            Panel_Actions.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Records;
        private Panel Panel_Actions;
        private Button Button_DeleteContact;
        private Button Button_AddContact;
        private Button Button_EditContact;
        private GroupBox groupBox1;
        private TextBox TextBox_Number;
        private Label label2;
        private TextBox TextBox_Name;
        private Label label1;
        private ListView ListView_Contacts;
    }
}