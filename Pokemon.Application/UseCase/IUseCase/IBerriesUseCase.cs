using Pokemon.Application.Request;
using Pokemon.Application.Response;

namespace Pokemon.Application.UseCase.IUseCase
{
    public interface IBerriesUseCase
    {
        Task<BerriesResponseData> ExecuteAsync(BerriesRequest request);
    }
}
