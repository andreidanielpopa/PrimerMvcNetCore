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

        public IActionResult VistaControllerPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControllerPost(Persona persona, string aficiones)
        {
            ViewData["DATA"] = "Nombre: " + persona.Nombre + ", Email: " + persona.Email + ", Edad: " + persona.Edad + ", Aficiones: " + aficiones;

            return View();
        }

        public IActionResult VistaControllerGet(string saludo, int? year)
        {
            if (year != null)
            {
                ViewData["DATA"] = "Hola " + saludo + " en el año " + year;
            }
            else 
            {
                ViewData["DATA"] = saludo + " Aqui no hay tiempo";
            }
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
