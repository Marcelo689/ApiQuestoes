using BuscaQuestoes.BuscarJson;
using Dto.QuestoesDto;
using Interfaces.Prova;

namespace Repository.QuestoesRepository
{
    public class ProvaService : IProvaService
    {
        private static readonly string _urlQuestoes = "https://localhost:7226/Api/ProvaDados";
        public async Task<List<QuestaoDto>> GetQuestoesAsync()
        {
            return await Buscar.ObjectFromUrl<QuestaoDto>(_urlQuestoes);
        }
    }
}
