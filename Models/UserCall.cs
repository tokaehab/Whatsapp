using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Whatsapp.Models
{
    public class UserCall
    {
        [Key]
        public int CallID { get; set; }
        [Key]
        public int UserID { get; set; }
        public Call Call { get; set; }
        public User User { get; set; }

    }
}
