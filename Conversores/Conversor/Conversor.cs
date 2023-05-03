using System.Text.Json;

namespace Conversores.Conversor
{
    public static class Conversor
    {
        public static ObjetoRetorno JsonTo<ObjetoRetorno>(string json)
        {
            return JsonSerializer.Deserialize<ObjetoRetorno>(json);
        }
    }
}
