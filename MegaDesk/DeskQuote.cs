using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk
{
    internal class DeskQuote
    {
        public string customerName { get; set; }
        public string orderDate { get; set; }
        public Desk desk { get; set; }
        public string shippingDays { get; set; }
        public double price { get; set; }
        public DeskQuote()
        {
            customerName = string.Empty;
            desk = new Desk();
        }
    }
}
