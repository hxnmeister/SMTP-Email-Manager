using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            FillContactsList();
        }
    }
}
