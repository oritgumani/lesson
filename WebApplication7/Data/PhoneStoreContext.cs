using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication7.Models
{
    public class PhoneStoreContext : DbContext
    {
        public PhoneStoreContext (DbContextOptions<PhoneStoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication7.Models.Phone> Phone { get; set; }
    }
}
