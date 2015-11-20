using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using eToolsSystem.Entities;
using eToolsSystem.BLL;


namespace eToolsSystem.BLL
{
    [DataObject]
    public class SalesController
    {
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddToCart(StockItem item)
        {
            using (eToolsSystemContext context = new eToolsSystemContext())
            {
                StockItem added = null;

                added = context.

            }
        }
        
    }
}
