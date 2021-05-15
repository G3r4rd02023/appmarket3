using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appmarket3.Data.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El {0} no puede contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "País")]
        public string Name { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        [DisplayName("Departments Number")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;


    }
}
