using Dto.QuestoesDto;
using QuestoesApplication.Models;

namespace DadosHttp.FictionalData
{
    public static class DadosFalsos
    {
        public static ProvaViewModel Dados()
        {
            var dados = new ProvaViewModel()
            {
                Questoes = new List<QuestaoDto>()
                {
                    new QuestaoDto
                    {
                        Id= 1,
                        OpcaoCorreta = LettersOptions.B,
                        Questao = new QuestaoItem(){Descricao = "Maça ..."}
                    },
                    new QuestaoDto
                    {
                        Id= 2,
                        OpcaoCorreta = LettersOptions.B,
                        Questao = new QuestaoItem(){Descricao = "abacate ..."}
                    },
                    new QuestaoDto
                    {
                        Id= 3,
                        OpcaoCorreta = LettersOptions.B,
                        Questao = new QuestaoItem(){Descricao = "sangue ..."}
                    },
                    new QuestaoDto
                    {
                        Id= 4,
                        OpcaoCorreta = LettersOptions.B,
                        Questao = new QuestaoItem(){Descricao = "mar ..."}
                    },
                    }.ToArray()
            };
            return dados;
        }
    }

}
