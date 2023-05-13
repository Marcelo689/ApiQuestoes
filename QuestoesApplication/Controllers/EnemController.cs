using Interfaces.Prova;
using Microsoft.AspNetCore.Mvc;

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
            var viewModel = _provaService.GetQuestoesAsync().Result;
            return View(viewModel);  
        }

        public IActionResult QuestoesPaginadas()
        {
            var viewModel = _provaService.GetQuestoesAsync().Result;
            var pageQuestoes = viewModel.Questoes.Chunk(2);
            viewModel.QuestoesEmPaginas = pageQuestoes;
            return View(viewModel);
        }
    }
}
