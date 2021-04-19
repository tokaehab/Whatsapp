﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Whatsapp.Models
{
    public class Call
    {
        public int ID { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime EndedAt { get; set; }
    }
}
