using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product: Entity<Guid>
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int StockAmount { get; set; }


        public Product()
        {
            Name = string.Empty;
        }

        public Product(string name, double unitPrice, int stockAmount)
        {
            Name = name;
            UnitPrice = unitPrice;
            StockAmount = stockAmount;
        }
    }
}
