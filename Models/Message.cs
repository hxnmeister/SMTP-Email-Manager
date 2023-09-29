using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTP_Email_Manager.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SendDate { get; set; }
        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
