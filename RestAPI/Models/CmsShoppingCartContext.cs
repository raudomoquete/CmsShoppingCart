using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class CmsShoppingCartContext : DbContext
    {
        public CmsShoppingCartContext(DbContextOptions<CmsShoppingCartContext> options)
           : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }
    }
}
