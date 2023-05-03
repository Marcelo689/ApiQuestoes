using Conversores.Conversor;

namespace BuscaQuestoes.BuscarJson
{
    public static class Buscar
    {
        private static HttpClient _client = new HttpClient();
        private static async Task<string> HttpsString(string url)
        {
            return await _client.GetStringAsync(url); 
        }

        public static async Task<List<ObjetoRetorno>> ObjectFromUrl<ObjetoRetorno>(string url)
        {
            var jsonFromUrl = HttpsString(url).Result;
            var lista = Conversor.JsonTo<List<ObjetoRetorno>>(jsonFromUrl);
            return lista;
        }
    }
}
