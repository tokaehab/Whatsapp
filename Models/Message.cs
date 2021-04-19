using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Whatsapp.Models
{
    public class Message
    {
        public int ID { get; set; }
        [Column("SenderID")]
        public int UserID { get; set; }
        public int ChatID { get; set; }
        [Required]
        public bool IsForwarded { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDelivered { get; set; }
        
        public string MessageType { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }


    }
}
