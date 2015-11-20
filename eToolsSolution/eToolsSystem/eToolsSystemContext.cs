using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eToolsSystem.Entities;
using System.Data.Entity;

namespace eToolsSystem
{
    public class eToolsSystemContext: DbContext
    {
        public eToolsSystemContext() : base ("name=ETools")
        {

        }


        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<StockItem> StockItems { get; set; }
        



    }
}
