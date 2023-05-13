using Dto.QuestoesDto;
using System.Text.Json.Serialization;

namespace QuestoesApplication.Models
{
    public class ProvaViewModel
    {
        public ProvaViewModel()
        {
            if (PageIncrement && QuestoesEmPaginas.Count() > PaginaAtual)
                PaginaAtual++;
            if(PageDecrement && PaginaAtual > 1)
                PaginaAtual--;
        }
        [JsonPropertyName("questoes")]
        public QuestaoDto[] Questoes { get; set; }
        public IEnumerable<QuestaoDto[]> QuestoesEmPaginas { get; set; }
        public int PaginaAtual { get; set; } = 1;
        public bool PageIncrement { get; set; } = false;
        public bool PageDecrement { get; set; } = false;
    }
}