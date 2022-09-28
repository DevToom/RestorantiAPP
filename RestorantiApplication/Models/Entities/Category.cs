using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities
{
    public class Category : ModelBase
    {
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
        [JsonIgnore]
        public byte[]? bytesImage { get; set; }
    }

    public enum EMenuType
    {
        Ambos = 0,
        ALaCarte = 10,
        Rodizio = 20
    }

    public enum ECategoryStatus
    {
        Invativo = 0,
        Ativo = 10
    }
}
