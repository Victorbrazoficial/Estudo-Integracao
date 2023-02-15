using Pokemon.Application.Request;
using Pokemon.Application.Response;
using Pokemon.Application.UseCase.IUseCase;
using Pokemon.Infrastructure.HTTPClients.Services;

namespace Pokemon.Application.UseCase
{
    public class BerriesUseCase : IBerriesUseCase
    {
        private readonly IBerriesServiceExternal _berriesServiceExternal;

        public BerriesUseCase(IBerriesServiceExternal berriesServiceExternal)
        {
            _berriesServiceExternal = berriesServiceExternal;
        }
        public async Task<BerriesResponseData> ExecuteAsync(BerriesRequest request)
        {  
            var response = await _berriesServiceExternal.Integracao(request.Id);

            var listaberries = new BerriesResponseData
            {
                Name = response.Name,
                Berries = new List<BerriesResponse>()
                    {
                        new BerriesResponse()
                        { 
                            Berry = new BerryResponse()
                            {
                                Name = response.Berries.ElementAt(0).Berry.Name,
                                url = response.Berries.ElementAt(0).Berry.Url
                            }
                        },
                        new BerriesResponse()
                        {
                            Berry = new BerryResponse()
                            {
                                Name = response.Berries.ElementAt(1).Berry.Name,
                                url = response.Berries.ElementAt(1).Berry.Url
                            }
                        },
                        new BerriesResponse()
                        {
                            Berry = new BerryResponse()
                            {
                                Name = response.Berries.ElementAt(2).Berry.Name,
                                url = response.Berries.ElementAt(2).Berry.Url
                            }
                        }
                    }
            };

            return listaberries;
        }
    }
}
