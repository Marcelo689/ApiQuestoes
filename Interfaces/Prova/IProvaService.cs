
using QuestoesApplication.Models;

namespace Interfaces.Prova;

public interface IProvaService
{
    Task<ProvaViewModel> GetQuestoesAsync();
}