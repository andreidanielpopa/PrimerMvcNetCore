using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumarNumerosGet(int num1, int num2)
        {

            ViewData["DATA"] = "Suma de " + num1 + " + " + num2 + " = " + (num1+num2);

            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost(int num1, int num2)
        {

            ViewData["DATA"] = "Suma de " + num1 + " + " + num2 + " = " + (num1 + num2);

            return View();
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            List<int> numeros = new List<int>();

            while (numero != 1)
            {
                if (numero%2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }

            return View(numeros);
        }

        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int numero)
        {
            List<int> numeros = new List<int>();

            for (int i = 1; i < 11; i++)
            {
                numeros.Add(numero * i);
            }

            return View(numeros);
        }

        public IActionResult TablaMultiplicarModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarModel(int numero)
        {
            List<FilaTablaMultiplicar> filas = new List<FilaTablaMultiplicar>();

            for (int i = 1; i <= 10; i++)
            {
                FilaTablaMultiplicar fila = new FilaTablaMultiplicar();
                fila.Operacion = numero + " x " + i;
                fila.Resultado = numero * i;
                filas.Add(fila);
            }

            return View(filas);
        }
    }
}
