using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities
{
    public class Category : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Nome da categoria
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Tipos de cardápio
        /// </summary>
        public EMenuType MenuType { get; set; }
        /// <summary>
        /// Status da Categoria
        /// </summary>
        public ECategoryStatus Status { get; set; }
        /// <summary>
        /// Imagem da categoria
        /// </summary>
        public byte[] ImageContent { get; set; }
    }

    public enum EMenuType
    {
        Ambos = 0,
        ÀLaCarte = 1,
        Rodízio = 2
    }

    public enum ECategoryStatus
    {
        Ativo = 0,
        Inativo = 1
    }
}
