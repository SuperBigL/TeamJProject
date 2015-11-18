using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToolsSystem
{
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public char ProvinceID { get; set; }
        public char PostalCode { get; set; }
    }
}
