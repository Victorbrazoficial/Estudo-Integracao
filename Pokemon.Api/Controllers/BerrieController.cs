using Microsoft.AspNetCore.Mvc;
using Pokemon.Application.Request;
using Pokemon.Application.UseCase.IUseCase;

namespace Pokemon.Api.Controllers
{
    [Route("api/berries")]
    [ApiController]
    public class BerrieController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBerries([FromRoute]BerriesRequest request, [FromServices]IBerriesUseCase berriesUseCase)
        {
            var result = await berriesUseCase.ExecuteAsync(request);
            return Ok(result);
        }
    }
}
