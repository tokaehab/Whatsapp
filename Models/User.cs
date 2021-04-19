using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Whatsapp.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime LastSeen { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Block> Blocks { get; set; }
        public ICollection<StarredMessage> StarredMessages { get; set; }
        public ICollection<UserChat> UserChats { get; set; }
        public ICollection<UserCall> UserCalls { get; set; }
        public Status Status { get; set; }
        public UserProfile UserProfile { get; set; }

    }
}
