using Dto.QuestoesDto;
using System.Text.Json.Serialization;

namespace QuestoesApplication.Models
{
    public class ProvaViewModel
    {
        [JsonPropertyName("questoes")]
        public QuestaoDto[] Questoes { get; set; }
        public IEnumerable<QuestaoDto[]> QuestoesEmPaginas { get; set; }
        public List<QuestaoDto> QuestoesDaPagina { get; set; }  
        public int PaginaAtual { get; set; } = 0;
        public int NumeroDeQuestaoPorPagina = 2;
        public void NextPage()
        {
            if(QuestoesEmPaginas != null)
            if (QuestoesEmPaginas.Count() > PaginaAtual)
                PaginaAtual++;
        }

        public void PrevPage()
        {
            if (PaginaAtual > 1)
                PaginaAtual--;
        }
    }
}