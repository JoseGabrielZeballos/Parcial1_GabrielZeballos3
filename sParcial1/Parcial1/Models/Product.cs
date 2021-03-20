using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1.Models
{
    public class Product
    {
        [Key]
        [Range(1, 99999)]
        public int ProductID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Se requiere descripcion del producto entre 30 y 3 caracteres")]

        public string Description { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public string Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastBuy { get; set; }

    }
}