using Dto.QuestoesDto;
using System.Text.Json.Serialization;

namespace QuestoesApplication.Models;

public class ProvaViewModel
{
    [JsonPropertyName("questoes")]
    public QuestaoDto []  Questoes { get;set; }
}