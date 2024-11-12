// Models/SimulationResultViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace Cognify.Models
{
    public class SimulationResultViewModel
    {
        // Datos del criminal
        public string Name { get; set; }
        public int Age { get; set; }
        public string CrimeType { get; set; }

        // Opciones de personalización
        public int? EmpathyLevel { get; set; }
        public decimal? LossAmount { get; set; }
        public string DiversityLevel { get; set; }

        // Propiedades adicionales
        public string CrimeTypeDisplay
        {
            get
            {
                switch (CrimeType)
                {
                    case "violent":
                        return "Delito Violento";
                    case "financial":
                        return "Crimen Financiero";
                    case "hate":
                        return "Crimen de Odio";
                    default:
                        return "Desconocido";
                }
            }
        }

        public string DiversityLevelDisplay
        {
            get
            {
                switch (DiversityLevel)
                {
                    case "low":
                        return "Bajo";
                    case "medium":
                        return "Medio";
                    case "high":
                        return "Alto";
                    default:
                        return "Desconocido";
                }
            }
        }
    }
}
