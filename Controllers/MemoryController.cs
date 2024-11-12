// Controllers/MemoryController.cs
using System.Web.Mvc;
using Cognify.Models;

namespace Cognify.Controllers
{
    public class MemoryController : Controller
    {
        [HttpGet]
        public ActionResult Customization()
        {
            var criminal = TempData["Criminal"] as CriminalViewModel;
            if (criminal == null)
            {
                return RedirectToAction("Form", "Criminal");
            }

            MemoryCustomizationViewModel model = new MemoryCustomizationViewModel
            {
                Name = criminal.Name,
                Age = criminal.Age,
                CrimeType = criminal.CrimeType
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Customization(MemoryCustomizationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Guardar datos en TempData para pasar a la siguiente vista
                TempData["Customization"] = model;
                return RedirectToAction("Result", "Simulation");
            }
            return View(model);
        }
    }
}
