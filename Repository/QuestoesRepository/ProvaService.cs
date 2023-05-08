using BuscaQuestoes.BuscarJson;
using Dto.QuestoesDto;
using Interfaces.Prova;
using QuestoesApplication.Models;

namespace Repository.QuestoesRepository
{
    public class ProvaService : IProvaService
    {
        private static readonly string _urlQuestoes = "https://localhost:7226/Api/ProvaDados";
        public async Task<ProvaViewModel> GetQuestoesAsync()
        {
            return await Buscar.ObjectFromUrl(_urlQuestoes);
        }
    }
}
