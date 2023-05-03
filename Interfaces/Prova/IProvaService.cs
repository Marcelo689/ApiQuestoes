using Dto.QuestoesDto;

namespace Interfaces.Prova;

public interface IProvaService
{
    Task<List<QuestaoDto>> GetQuestoesAsync();
}