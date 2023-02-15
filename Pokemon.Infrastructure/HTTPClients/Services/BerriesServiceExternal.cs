using Newtonsoft.Json;
using Pokemon.Infrastructure.HTTPClients.ApiObjects;
using Pokemon.Infrastructure.HTTPClients.Services;

namespace Pokemon.Infrastructure.Services
{
    public class BerriesServiceExternal : IBerriesServiceExternal
    {
        public async Task<BerriesApiObject> Integracao(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://pokeapi.co/api/v2/berry-flavor/{id}");
            var jsonString = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<BerriesApiObject>(jsonString);

            if (jsonObject is null)
            {
                return jsonObject;
            }

            return jsonObject;
        }       
    }
}
