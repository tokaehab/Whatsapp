using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Whatsapp.Models
{
    public class Block
    {
        [Key]
        [Column("BlockerID")]
        public int BlockerID { get; set; }

        [Key]
        [Column("BlockedID")]
        public int BlockedID { get; set; }

        public User Blocker { get; set; }
        
        public User Blocked { get; set; }

    }
}
