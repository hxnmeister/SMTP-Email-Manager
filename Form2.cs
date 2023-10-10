using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTP_Email_Manager
{
    public partial class Form2 : Form
    {
        Regex mailReg;

        public Form2(Regex mailReg)
        {
            InitializeComponent();

            this.mailReg = mailReg;
        }

        public string GetContactToAdd()
        {
            return EmailTextBox.Text;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearButton.Enabled = EmailTextBox.TextLength > 0;
            AddButton.Enabled = mailReg.IsMatch(EmailTextBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
