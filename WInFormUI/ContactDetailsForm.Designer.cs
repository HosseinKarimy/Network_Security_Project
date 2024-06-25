namespace WInFormUI
{
    partial class ContactDetailsForm
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
            label1 = new Label();
            TextBox_ContactName = new TextBox();
            label2 = new Label();
            TextBox_ContactNumber = new TextBox();
            Button_Confirm = new Button();
            Button_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Contact Name:";
            // 
            // TextBox_ContactName
            // 
            TextBox_ContactName.Location = new Point(128, 12);
            TextBox_ContactName.Name = "TextBox_ContactName";
            TextBox_ContactName.Size = new Size(197, 23);
            TextBox_ContactName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 44);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Contact Number:";
            // 
            // TextBox_ContactNumber
            // 
            TextBox_ContactNumber.Location = new Point(128, 41);
            TextBox_ContactNumber.Name = "TextBox_ContactNumber";
            TextBox_ContactNumber.Size = new Size(197, 23);
            TextBox_ContactNumber.TabIndex = 1;
            // 
            // Button_Confirm
            // 
            Button_Confirm.Location = new Point(23, 76);
            Button_Confirm.Name = "Button_Confirm";
            Button_Confirm.Size = new Size(75, 23);
            Button_Confirm.TabIndex = 2;
            Button_Confirm.Text = "button1";
            Button_Confirm.UseVisualStyleBackColor = true;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(104, 76);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(75, 23);
            Button_Cancel.TabIndex = 2;
            Button_Cancel.Text = "button1";
            Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // ContactDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 106);
            Controls.Add(Button_Cancel);
            Controls.Add(Button_Confirm);
            Controls.Add(TextBox_ContactNumber);
            Controls.Add(label2);
            Controls.Add(TextBox_ContactName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContactDetailsForm";
            Text = "ContactDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBox_ContactName;
        private Label label2;
        private TextBox TextBox_ContactNumber;
        private Button Button_Confirm;
        private Button Button_Cancel;
    }
}