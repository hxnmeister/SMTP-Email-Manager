using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTP_Email_Manager.Models;

namespace SMTP_Email_Manager
{
    public partial class Form1 : Form
    {
        private Model1 db = new Model1();

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
        private void FillContactsList()
        {
            var currentContacts = db.Contacts.ToList();

            ContactsComboBox.Items.Clear();
           
            foreach ( Contact contact in currentContacts )
            {
                ContactsComboBox.Items.Add(contact.Email);
            }

            if(ContactsComboBox.Items.Count > 0)
            {
                ContactsComboBox.SelectedIndex = 0;
            }
        }
        private void SendButtonEnableSwitcher()
        {
            SendButton.Enabled = !string.IsNullOrWhiteSpace(MessageTextBox.Text) && !string.IsNullOrWhiteSpace(SubjectTextBox.Text) && !string.IsNullOrWhiteSpace(ToTextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillContactsList();

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
            SubjectTextBox.Clear();
            MessageTextBox.Clear();
            RecipientsListBox.Items.Clear();
            FilesListBox.Items.Clear();
            AttachedListBox.Items.Clear();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage(new MailAddress("SMTP_Email_Manager@testmail.com"), new MailAddress(ToTextBox.Text))
            {
                Subject = SubjectTextBox.Text,
                Body = MessageTextBox.Text
            };

            new SmtpClient("sandbox.smtp.mailtrap.io", 587)
            {
                Credentials = new NetworkCredential("25175f21d8e6ea", "3bc5077ec4f091"),
            }.Send(message);
            SubjectTextBox.Clear();
            MessageTextBox.Clear();

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
                }
                else
                {
                    MessageBox.Show("Contact already added to recipients list!", "Duplicate!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    SendFile sendFile = new SendFile()
                    {
                        FileName = fileDialog.SafeFileName,
                        FilePath = fileDialog.FileName
                    };

                    FilesListBox.Items.Add(sendFile);
                }
            }
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if(FilesListBox.SelectedIndex > -1)
            {
                SendFile sendFile = FilesListBox.SelectedItem as SendFile;

                if(sendFile != null && !AttachedListBox.Items.Contains(sendFile))
                {
                    AttachedListBox.Items.Add(sendFile);
                }
                else
                {
                    MessageBox.Show("File already added to attachments list!", "Duplicate!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
