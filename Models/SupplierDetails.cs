using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMate.Models
{
    public class SupplierDetails
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
    }
}
