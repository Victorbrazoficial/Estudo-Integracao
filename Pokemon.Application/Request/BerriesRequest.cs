using Microsoft.AspNetCore.Mvc;

namespace Pokemon.Application.Request
{
    public class BerriesRequest
    {
            [FromRoute(Name = "id")]
            public int Id { get; set; }
    };      
}
