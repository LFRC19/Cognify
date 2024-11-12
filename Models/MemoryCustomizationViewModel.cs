// Models/MemoryCustomizationViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace Cognify.Models
{
    public class MemoryCustomizationViewModel
    {
        // Datos del criminal
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string CrimeType { get; set; }

        // Opciones de personalización
        [Display(Name = "Intensidad de Empatía")]
        public int? EmpathyLevel { get; set; }

        [Display(Name = "Monto Simulado de Pérdidas")]
        public decimal? LossAmount { get; set; }

        [Display(Name = "Nivel de Diversidad")]
        public string DiversityLevel { get; set; }
    }
}
