using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Whatsapp.Models
{
    public class UserChat
    {
        [Key]
        public int ChatID { get; set; }
        [Key]
        public int UserID { get; set; }
        public DateTime ReadAt { get; set; }
        [Required]
        public Boolean IsMuted { get; set; }
        public Chat Chat { get; set; }
        public User User { get; set; }
    }
}
