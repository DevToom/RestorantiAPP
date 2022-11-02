using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities
{
    public class Table : ModelBase
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public string TableStatus { get; set; }
        public bool IsActive { get; set; }
    }
}
