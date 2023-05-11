using DadosHttp.FictionalData;
using Microsoft.AspNetCore.Mvc;
using QuestoesApplication.Models;

namespace DadosHttp.Controllers
{
    //https://localhost:7226/Api/ProvaDados
    [Route("api/[controller]")]
    [ApiController]
    public class ProvaDadosController : ControllerBase
    {

        [HttpGet]
        public ProvaViewModel ProvaDataJson()
        {
            var dados = DadosFalsos.Dados();
            return dados;
        }


        [HttpGet("Palavra")]
        public string Palavra()
        {
            return "nada";
        }

    }
}
