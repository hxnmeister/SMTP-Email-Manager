﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTP_Email_Manager.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public virtual List<Message> Messages { get; set; }
    }
}
