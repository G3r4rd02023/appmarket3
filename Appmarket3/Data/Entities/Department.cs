using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appmarket3.Data.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El {0} no puede contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Departamento")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual Country Country { get; set; }

        [DisplayName("No Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

    }
}
