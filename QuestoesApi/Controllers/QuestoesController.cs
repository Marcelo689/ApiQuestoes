using Dto.QuestoesDto;
using Interfaces.Prova;
using Microsoft.AspNetCore.Mvc;

namespace QuestoesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestoesController : ControllerBase
    {
        public IProvaService _provaservice { get; }
        public QuestoesController(IProvaService provaservice)
        {
            _provaservice = provaservice;
        }

        [HttpGet("RetornaQuestoes")]
        public async Task<List<QuestaoDto>> RetornaQuestoesFromService()
        {
            var lista = await _provaservice.GetQuestoesAsync();
            return lista;
        }

        [HttpGet]
        public List<QuestaoDto> DadosQuestoes()
        {
            var questao = new QuestaoDto();
            questao.Questao = new QuestaoItem();
            questao.Questao.Descricao = "Qual o preto?";
            questao.Id = 3;
            questao.OpcaoCorreta = LettersOptions.D;

            return new List<QuestaoDto>()
            {
                new QuestaoDto (),
                questao
            };
        }
    }
}
