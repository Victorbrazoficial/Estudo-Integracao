using Pokemon.Infrastructure.HTTPClients.ApiObjects;

namespace Pokemon.Infrastructure.HTTPClients.Services
{
    public interface IBerriesServiceExternal
   {
       public Task<BerriesApiObject> Integracao(int id);
   }
}
