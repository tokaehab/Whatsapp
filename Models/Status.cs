using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whatsapp.Models
{
    public class Status
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; }
    }
}
