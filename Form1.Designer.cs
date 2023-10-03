namespace SMTP_Email_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ContactsComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RecipientsListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.AttachedListBox = new System.Windows.Forms.ListBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(554, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mailing Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(554, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Program for sending emails";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(554, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "For corporate clients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "To:";
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(15, 33);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(377, 26);
            this.ToTextBox.TabIndex = 5;
            this.ToTextBox.TextChanged += new System.EventHandler(this.ToTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subject:";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(15, 93);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(377, 26);
            this.SubjectTextBox.TabIndex = 7;
            this.SubjectTextBox.TextChanged += new System.EventHandler(this.SubjectTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Message:";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(15, 154);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(377, 437);
            this.MessageTextBox.TabIndex = 9;
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(411, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contacts:";
            // 
            // ContactsComboBox
            // 
            this.ContactsComboBox.FormattingEnabled = true;
            this.ContactsComboBox.Location = new System.Drawing.Point(414, 165);
            this.ContactsComboBox.Name = "ContactsComboBox";
            this.ContactsComboBox.Size = new System.Drawing.Size(377, 26);
            this.ContactsComboBox.TabIndex = 11;
            this.ContactsComboBox.SelectedIndexChanged += new System.EventHandler(this.ContactsComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(411, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Recipients:";
            // 
            // RecipientsListBox
            // 
            this.RecipientsListBox.FormattingEnabled = true;
            this.RecipientsListBox.ItemHeight = 18;
            this.RecipientsListBox.Location = new System.Drawing.Point(414, 225);
            this.RecipientsListBox.Name = "RecipientsListBox";
            this.RecipientsListBox.ScrollAlwaysVisible = true;
            this.RecipientsListBox.Size = new System.Drawing.Size(376, 418);
            this.RecipientsListBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(805, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Files:";
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 18;
            this.FilesListBox.Location = new System.Drawing.Point(808, 33);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.ScrollAlwaysVisible = true;
            this.FilesListBox.Size = new System.Drawing.Size(377, 220);
            this.FilesListBox.TabIndex = 15;
            // 
            // AttachedListBox
            // 
            this.AttachedListBox.FormattingEnabled = true;
            this.AttachedListBox.ItemHeight = 18;
            this.AttachedListBox.Location = new System.Drawing.Point(808, 351);
            this.AttachedListBox.Name = "AttachedListBox";
            this.AttachedListBox.ScrollAlwaysVisible = true;
            this.AttachedListBox.Size = new System.Drawing.Size(377, 292);
            this.AttachedListBox.TabIndex = 16;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(808, 274);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(100, 46);
            this.SelectButton.TabIndex = 17;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1085, 274);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 46);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add File";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(15, 597);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 46);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Clear Message";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(292, 597);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 46);
            this.SendButton.TabIndex = 19;
            this.SendButton.Text = "Send  Email";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMTP_Email_Manager.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(428, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 668);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.AttachedListBox);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RecipientsListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ContactsComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ContactsComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox RecipientsListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.ListBox AttachedListBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SendButton;
    }
}

