using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Whatsapp.Models
{
    public class Chat
    {
        public int ID { get; set; }
        
        [Column("LastMessageId")]
        public int MessageID { get; set; }
        public Message Message { get; set; }

    }
}
