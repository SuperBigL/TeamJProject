using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eToolsSystem.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime? DateReleased { get; set; }
        public int PositionID { get; set; }
        public string? LoginID { get; set; }
        //public uniqueidentifier EmployeeUID { get; set; }
    }
}
