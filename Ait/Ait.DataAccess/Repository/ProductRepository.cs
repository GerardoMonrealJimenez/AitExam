using Ait.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.DataAccess.Repository
{
    public class ProductRepository : GenericRepository<Products>
    {
        public ProductRepository(AitContext context) : base(context)
        {
        }
    }
}
