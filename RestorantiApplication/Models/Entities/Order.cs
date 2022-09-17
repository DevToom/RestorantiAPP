using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TableNumber { get; set; }
        public int UserId { get; set; }
        public List<Product> Itens { get; set; }
        public bool HasObservation { get; set; }
        public string Observation { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
