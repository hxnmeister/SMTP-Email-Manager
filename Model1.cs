using System;
using System.Data.Entity;
using System.Linq;
using SMTP_Email_Manager.Models;

namespace SMTP_Email_Manager
{
    public class Model1 : DbContext
    {
        public Model1(): base("name=Model1")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}