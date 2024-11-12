// Controllers/CriminalController.cs
using System.Web.Mvc;
using Cognify.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Cognify.Controllers
{
    public class CriminalController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Form()
        {
            // Obtener datos aleatorios de RandomUser
            CriminalViewModel model = new CriminalViewModel();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync("https://randomuser.me/api/?nat=es");
                var data = JObject.Parse(response);
                var user = data["results"][0];

                model.Name = $"{user["name"]["first"]} {user["name"]["last"]}";
                model.Age = (int)user["dob"]["age"];
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Form(CriminalViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Guardar datos en TempData para pasar a la siguiente vista
                TempData["Criminal"] = model;
                return RedirectToAction("Customization", "Memory");
            }
            return View(model);
        }
    }
}
