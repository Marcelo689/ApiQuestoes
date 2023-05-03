using Dto.QuestoesDto;

namespace DadosHttp.FictionalData
{
    public static class DadosFalsos
    {
        public static List<QuestaoDto> Dados()
        {
            var dados = new List<QuestaoDto>
            {
                new QuestaoDto
                {
                    Id= 1,
                    OpcaoCorreta = LettersOptions.B,
                    Questao = new QuestaoItem(){Descricao = "Maça ..."}
                },new QuestaoDto
                {
                    Id= 2,
                    OpcaoCorreta = LettersOptions.B,
                    Questao = new QuestaoItem(){Descricao = "abacate ..."}
                },new QuestaoDto
                {
                    Id= 3,
                    OpcaoCorreta = LettersOptions.B,
                    Questao = new QuestaoItem(){Descricao = "sangue ..."}
                },new QuestaoDto
                {
                    Id= 4,
                    OpcaoCorreta = LettersOptions.B,
                    Questao = new QuestaoItem(){Descricao = "mar ..."}
                },
            };
            return dados;
        }
    }

}
