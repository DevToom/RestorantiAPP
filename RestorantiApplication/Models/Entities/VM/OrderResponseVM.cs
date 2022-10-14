using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities.VM
{
    /// <summary>
    /// Pedido formatado
    /// </summary>
    public class OrderResponseVM
    {
        public string OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public int? UserId { get; set; }
        public EOrderType Type { get; set; }
        public EStatus Status { get; set; }
        public List<ProductVM> Products { get; set; }
        public bool hasObservation { get; set; }
        public decimal? Total { get; set; }
    }
    public class ProductVM
    {
        /// <summary>
        /// Id do Produto
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Nome do Produto
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Quantidade do produto selecionado
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Valor do Produto
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Tem observação?
        /// </summary>
        public bool hasObservation { get; set; }

        /// <summary>
        /// Caso tenha observação descrever aqui, por produto
        /// </summary>
        public string Observation { get; set; }
    }

}
