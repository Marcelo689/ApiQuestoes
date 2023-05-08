using QuestoesApplication.Models;
using System.Text.Json;

namespace Conversores.Conversor
{
    public static class Conversor
    {
        public static ProvaViewModel JsonTo(string json)
        {
            return JsonSerializer.Deserialize<ProvaViewModel>(json);
        }
    }
}
