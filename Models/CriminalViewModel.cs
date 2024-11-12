// Models/CriminalViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace Cognify.Models
{
    public class CriminalViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Edad debe estar entre 1 y 120.")]
        [Display(Name = "Edad")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Tipo de Crimen")]
        public string CrimeType { get; set; }
    }
}
