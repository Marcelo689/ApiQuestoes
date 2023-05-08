using Conversores.Conversor;
using Dto.QuestoesDto;
using QuestoesApplication.Models;

namespace BuscaQuestoes.BuscarJson
{
    public static class Formatar
    {
        internal static string StringParaJson(string stringJson)
        {
            return stringJson.Replace(@"\","");
        }
    }
    public static class Buscar
    {
        private static HttpClient _client = new HttpClient();
        private static async Task<string> HttpsString(string url)
        {
            return await _client.GetStringAsync(url); 
        }

        public static async Task<ProvaViewModel> ObjectFromUrl(string url)
        {
            var stringJson = await HttpsString(url);

            //stringJson = Formatar.StringParaJson(stringJson);
            var lista = Conversor.JsonTo(stringJson);
            return lista;
        }
    }
}
