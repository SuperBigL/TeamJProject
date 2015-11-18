using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToolsSystem.Entities
{
    public class StockItem
    {
        public int StockItemID { get; set; }
        public string Description { get; set; }
        public int SellingPrice { get; set; }
        public int PurchasePrice { get; set; }
        public int QuantityOnHand { get; set; }
        public int QuantityOnOrder { get; set; }
        public int ReOrderLevel { get; set; }
        public bool Discounted { get; set; }
        public int VendorID { get; set; }
        public string? VendorStockNumber { get; set; }
        public int CategoryID { get; set; }
    }
}
