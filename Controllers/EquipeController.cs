using ejogos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ejogos.Controllers
{
    public class EquipeController : Controller
    {

        //ActionResult representam os vários códigos HTTP.
        //Codigos HTTP - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status

        Equipe equipeModel = new Equipe();


        public IActionResult Index()
        {

            //ViewBag = Reserva de espaço para armazenar informações para navegar na View.
            //ViewBag = tem a função de carregar as informações do Controller para a View.
            ViewBag.Equipes = equipeModel.LerEquipes();



            return View();
        }
    }
}
