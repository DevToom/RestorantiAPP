using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities
{
    public class Product : ModelBase
    {
        /// <summary>
        /// Id do Produto
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Id da categoria vinculado ao produto
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Nome do Produto
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Preço do produto no sistema À La Carte
        /// </summary>
        public decimal PriceALaCarte { get; set; }
        /// <summary>
        /// Preço do produto no sistema Rodizio
        /// </summary>
        public decimal PriceRodizio { get; set; }
        /// <summary>
        /// Status do Produto
        /// </summary>
        public EProductStatus Status { get; set; }
        /// <summary>
        /// Imagem da categoria
        /// </summary>
        public byte[]? ImageContent { get; set; }
    }

    public enum EProductStatus
    {
        Ativo = 0,
        Inativo = 1
    }


}
