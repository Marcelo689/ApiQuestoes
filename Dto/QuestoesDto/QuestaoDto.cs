namespace Dto.QuestoesDto
{
    public class QuestaoDto
    {
        public int Id { get; set; } 
        public QuestaoItem Questao { get; set; }    
        public LettersOptions OpcaoCorreta { get; set; }    
    }
}
