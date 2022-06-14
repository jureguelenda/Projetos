using GeometriaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CirculoController : Controller
    {
        [HttpGet]
        public ActionResult<string> GetArea(double raio)
        {
            Circulo circulo = new Circulo();

            string[] valores = {raio.ToString()};

            return (circulo.CalcularArea(valores)).ToString();

        }
    }

}