using Dto.QuestoesDto;
using Interfaces.Prova;
using Microsoft.AspNetCore.Mvc;
using QuestoesApplication.Models;

namespace QuestoesApplication.Controllers
{
    public class EnemController : Controller
    {
        public IProvaService _provaService { get; }

        private ProvaViewModel provaVMBase { get; set; }   
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
            var viewModel = provaVMBase = _provaService.GetQuestoesAsync().Result;
            return View(viewModel);  
        }

        public IActionResult QuestoesPaginadas(ProvaViewModel? viewModel)
        {
            if(viewModel.Questoes == null)
                viewModel = provaVMBase = _provaService.GetQuestoesAsync().Result;
            viewModel.Questoes = viewModel.Questoes.Skip(viewModel.NumeroDeQuestaoPorPagina * viewModel.PaginaAtual).ToArray();
            var pageQuestoes = viewModel.Questoes.Take(viewModel.NumeroDeQuestaoPorPagina);
            viewModel.QuestoesDaPagina = pageQuestoes.ToList();

            return View(viewModel);
        }
        public IActionResult QuestoesPaginadasNext(ProvaViewModel provaViewModel)
        {
            provaVMBase.NextPage();
            return RedirectToAction("QuestoesPaginadas", provaViewModel);
        }
        public IActionResult QuestoesPaginadasPrev(ProvaViewModel provaViewModel)
        {
            provaViewModel.PrevPage();
            return RedirectToAction(nameof(QuestoesPaginadas), provaViewModel);
        }
    }
}
