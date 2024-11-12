// Controllers/SimulationController.cs
using System.Web.Mvc;
using Cognify.Models;

namespace Cognify.Controllers
{
    public class SimulationController : Controller
    {
        public ActionResult Result()
        {
            var customization = TempData["Customization"] as MemoryCustomizationViewModel;
            if (customization == null)
            {
                return RedirectToAction("Form", "Criminal");
            }

            SimulationResultViewModel model = new SimulationResultViewModel
            {
                Name = customization.Name,
                Age = customization.Age,
                CrimeType = customization.CrimeType,
                EmpathyLevel = customization.EmpathyLevel,
                LossAmount = customization.LossAmount,
                DiversityLevel = customization.DiversityLevel
            };

            return View(model);
        }
    }
}
