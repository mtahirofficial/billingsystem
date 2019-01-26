using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System.Model
{
    public class StockItems
    {
        [DisplayName]
        public int SrNo { get; set; }
        public string MedicineName { get; set; }
        public string Batch { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public string Date { get; set; }
    }
}
