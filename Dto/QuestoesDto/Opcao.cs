namespace Dto.QuestoesDto
{
    public enum LettersOptions
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
    }

    public class QuestaoItem
    {
        public string Descricao { get; set; }
        public Dictionary<string, LettersOptions> Opcoes { get; set; }

        public QuestaoItem()
        {
            FillOptions();
        }

        private void FillOptions()
        {
            Opcoes = new Dictionary<string, LettersOptions>();
            Opcoes.Add("é amarela", LettersOptions.A);
            Opcoes.Add("é verde", LettersOptions.B);
            Opcoes.Add("é azul", LettersOptions.C);
            Opcoes.Add("é preto", LettersOptions.D);
            Opcoes.Add("é vermelho", LettersOptions.E);
        }
    }

}