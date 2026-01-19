using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterData.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoController : ControllerBase
    {
        //[HttpGet("countries")]
        //public async Task<List<CountryDto>> GetCountries() => await Mediator.Send(new GetCountriesQuery());

        //[HttpGet("countries/{code}/states")]
        //public async Task<List<StateDto>> GetStates(string code) => await Mediator.Send(new GetStatesQuery(code));
    }
}
