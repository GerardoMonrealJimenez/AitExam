using Ait.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.DataAccess
{
    public class AitContext: DbContext
    {
        public AitContext(DbContextOptions<AitContext> options):base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
