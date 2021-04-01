using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="varchar(255)")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }

        public byte PlayerNumber { get; set; }

        public decimal Price { get; set; }

        public List<Image> Images { get; set; } = new List<Image>();
    }
}
