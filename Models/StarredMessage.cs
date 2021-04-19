using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Whatsapp.Models
{
    public class StarredMessage
    {
        [Key]
        public int MesssageID { get; set; }
        [Key]
        public int UserID { get; set; }
        public Message Message { get; set; }
        public User User { get; set; }
    }
}
