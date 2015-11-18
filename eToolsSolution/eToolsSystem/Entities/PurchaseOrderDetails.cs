using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToolsSystem.Entities
{
    public class PurchaseOrderDetails
    {
        public int PurchaseOrderDetailID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int StockItemID { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
    }
}
