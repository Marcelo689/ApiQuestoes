using Interfaces.Prova;
using Microsoft.AspNetCore.Mvc;
using QuestoesApplication.Models;

namespace QuestoesApplication.Controllers
{
    public class EnemController : Controller
    {

        public IProvaService _provaService { get; }
        public EnemController(IProvaService provaService)
        {
            _provaService = provaService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Prova()
        {
            var viewModel = new ProvaViewModel();
            viewModel.Model = _provaService.GetQuestoesAsync().Result;
            return View(viewModel);  
        }
    }
}
