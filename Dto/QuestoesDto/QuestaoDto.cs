using System.Text.Json.Serialization;

namespace Dto.QuestoesDto
{
    public class QuestaoDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("questao")]
        public QuestaoItem Questao { get; set; }

        [JsonPropertyName("opcaoCorreta")]
        public LettersOptions OpcaoCorreta { get; set; }    
    }
}
