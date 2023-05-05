using Dto.QuestoesDto;
using System.Text.Json;

namespace Conversores.Conversor
{
    public static class Conversor
    {
        public static List<QuestaoDto> JsonTo(string json)
        {
            return JsonSerializer.Deserialize<List<QuestaoDto>>(json);
        }
    }
}
