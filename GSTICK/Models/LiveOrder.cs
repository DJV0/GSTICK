using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Models
{
    public class LiveOrder
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        public string Phone { get; set; }
        public DateTime DateTime { get; set; }
    }
}
