using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControladorVista()
        {
            ViewBag.nombre = "Alumno";
            ViewBag.edad = 24;
            return View();
        }

        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Knekro";
            persona.Email = "knekro@email.com";
            persona.Edad = 119;

            return View( persona );
        }
    }
}
