using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BelezaNaWebTest.Models
{
    public class Warehouse
    {
        public string Locality { get; set; }
        public decimal Quantity { get; set; }
        public Warehousetypes Type { get; set; }
    }

    public enum Warehousetypes
    {
        ECOMMERCE,
        PHYSICAL_STORE
    }
}