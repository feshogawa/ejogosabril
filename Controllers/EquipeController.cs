using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;



namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {


        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.LerEquipes();
            return View();
        }
    }
}
