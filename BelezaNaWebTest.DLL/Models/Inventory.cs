using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BelezaNaWebTest.Models
{
    public class Inventory
    {
        public virtual decimal Quantity
        {
            get
            {
                return this.Warehouses.Sum(x => x.Quantity);
            }
        }
        public List<Warehouse> Warehouses { get; set; }
    }
}