using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Whatsapp.Data
{
    public class WhatsappContext : DbContext
    {
        public WhatsappContext(DbContextOptions<WhatsappContext> options) : base(options)
        {
        }
       
        

    }
}
