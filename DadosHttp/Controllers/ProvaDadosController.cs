using DadosHttp.FictionalData;
using Dto.QuestoesDto;
using Microsoft.AspNetCore.Mvc;

namespace DadosHttp.Controllers
{
    //https://localhost:7226/Api/ProvaDados
    [Route("api/[controller]")]
    [ApiController]
    public class ProvaDadosController : ControllerBase
    {

        [HttpGet]
        public List<QuestaoDto> ProvaDataJson()
        {
            var dados = DadosFalsos.Dados();
            return dados;
        }
    }
}
