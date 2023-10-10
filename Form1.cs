using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTP_Email_Manager.Models;

namespace SMTP_Email_Manager
{
    public partial class Form1 : Form
    {
        private Model1 db = new Model1();
        private MailMessage message;
        private readonly Regex mailReg = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        public Form1()
        {
            InitializeComponent();
        }

        private void InitData()
        {
            db.Contacts.Add(new Contact() { Email = "justi@ukr.net"} );
            db.Contacts.Add(new Contact() { Email = "const@ukr.net"} );
            db.Contacts.Add(new Contact() { Email = "konfi@ukr.net"} );
            db.Contacts.Add(new Contact() { Email = "zeno@ukr.net"} );
            db.Contacts.Add(new Contact() { Email = "casda@ukr.net"} );

            db.SaveChanges();
            MessageBox.Show("InitData - OK");
        }
        private void ClearAllData()
        {
            message.To.Clear();
            message.CC.Clear();
            message.Attachments.Clear();

            ToTextBox.Clear();
            SubjectTextBox.Clear();
            MessageTextBox.Clear();
            FilesListBox.Items.Clear();
            AttachedListBox.Items.Clear();
            RecipientsListBox.Items.Clear();
            ContactsComboBox.Text = ContactsComboBox.Items.Count > 0 ? "Choose contact" : "No contacts";
        }
        private void FillContactsList()
        {
            List<Contact> currentContacts = db.Contacts.ToList();

            ContactsComboBox.Items.Clear();
           
            foreach (Contact contact in currentContacts)
            {
                ContactsComboBox.Items.Add(contact.Email);
            }

            ContactsComboBox.Text = ContactsComboBox.Items.Count > 0 ? "Choose contact" : "No contacts";
        }
        private void SendButtonEnableSwitcher()
        {
            SendButton.Enabled = !string.IsNullOrWhiteSpace(MessageTextBox.Text) && !string.IsNullOrWhiteSpace(SubjectTextBox.Text) && mailReg.IsMatch(ToTextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillContactsList();

            message = new MailMessage();

            AttachedListBox.DisplayMember = "FileName";
            FilesListBox.DisplayMember = "FileName";
        }

        private void ContactsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToTextBox.Text = ContactsComboBox.SelectedItem.ToString() ?? string.Empty;
        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            SendButtonEnableSwitcher();
        }

        private void SubjectTextBox_TextChanged(object sender, EventArgs e)
        {
            SendButtonEnableSwitcher();
        }

        private void ToTextBox_TextChanged(object sender, EventArgs e)
        {
            SendButtonEnableSwitcher();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("After confirmation, all information will be cleared.\nAre you sure you want to continue?", "Confirmation of deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Deletion cancelled!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            message.From = new MailAddress("SMTP_Email_Manager@testmail.com");
            message.To.Add(new MailAddress(ToTextBox.Text));
            message.Body = MessageTextBox.Text;
            message.Subject = SubjectTextBox.Text;

            new SmtpClient("sandbox.smtp.mailtrap.io", 587)
            {
                Credentials = new NetworkCredential("0ae306c1e8fc46", "9e91ebe4298d46"),
            }.Send(message);

            ClearAllData();

            MessageBox.Show($"Message successfully sended to {ToTextBox.Text}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            if(ContactsComboBox.SelectedIndex > -1)
            {
                string contact = ContactsComboBox.SelectedItem.ToString();

                if (!RecipientsListBox.Items.Contains(contact))
                {
                    RecipientsListBox.Items.Add(contact);

                    message.CC.Add(contact);
                }
                else
                {
                    MessageBox.Show("Contact already added to recipients list!", "Duplicate!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("To add a recipient you need to choose it first!", "No recipients selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Multiselect = true;

                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < fileDialog.FileNames.Length; i++)
                    {
                        FilesListBox.Items.Add(new SendFile() 
                        { 
                            FileName = fileDialog.SafeFileNames[i], 
                            FilePath = fileDialog.FileNames[i] 
                        });
                    }
                }
            }
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if(FilesListBox.SelectedIndex > -1)
            {
                if (FilesListBox.SelectedItem is SendFile sendFile && !AttachedListBox.Items.Contains(sendFile))
                {
                    AttachedListBox.Items.Add(sendFile);

                    message.Attachments.Add(new Attachment(sendFile.FilePath));
                }
                else
                {
                    MessageBox.Show("File already added to attachments list!", "Duplicate!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("To attach a file to an email, first select it!", "No file selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
