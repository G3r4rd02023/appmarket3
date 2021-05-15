using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Appmarket3.Data.Entities
{
    public class City
    {
       [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El {0} no puede contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Ciudad")]
        public string Name { get; set; }

        [NotMapped]
        public int IdDepartment { get; set; }

        public virtual Department Department { get; set; }

    }
}
