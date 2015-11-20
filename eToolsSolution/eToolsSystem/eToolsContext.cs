using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eToolsSystem.Entities;

namespace eToolsSystem
{
     public class eToolsContext: DbContext
    {
         public eToolsContext() : base ("name=ETools")
        {

        }

         public DbSet<Category> Categories { get; set; }
         public DbSet<OnlineCustomer> OnlineCustomers { get; set; }
         public DbSet<StockItem> StockItems { get; set; }
         public DbSet<ShoppingCart> ShoppingCarts { get; set; }
         public DbSet<ShoppingCartItem> ShoppingCartIte




    }
}
