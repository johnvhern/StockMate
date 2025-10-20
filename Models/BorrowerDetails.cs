using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMate.Models
{
    public class BorrowerDetails
    {
        public int BorrowerId { get; set; }
        public int DepartmentId { get; set; }
        public string BorrowerName { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
