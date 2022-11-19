using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppShatohin.Models;

namespace WebAirFlightShato.Controllers
{
    [Route("Flightes/[controller]")]
    [ApiController]
    public class AirplanesController : ControllerBase
    {
        private static readonly IList<AirplanesFlight> airplaneFL = new List<AirplanesFlight>();
        [HttpGet]
        public IEnumerable<AirplanesFlight> Get()
        {
            return airplaneFL;
        }
        [HttpGet(template: "Data")]
        public FlightesResult GetData()
        {
            var Quantity = new FlightesResult
            {
                CountFlight = airplaneFL.Count,
                CountPas = airplaneFL.Sum(x => x.ColPas),
                Countcrew = airplaneFL.Sum(x => x.ColBuil),
                CountSum = airplaneFL.Sum(x => x.Result),
            };
            return Quantity;
        }
        [HttpDelete(template: "{id:guid}")]
        public bool Remove(Guid id)
        {
            var targetUser = airplaneFL.FirstOrDefault(x => x.Id == id);
            if (targetUser != null)
            {
                return airplaneFL.Remove(targetUser);
            }
            return false;
        }
        [HttpPut(template: "{id}")]
        public AirplanesFlight Update([FromRoute] Guid id, [FromBody] Flight model)
        {
            var targetfl = airplaneFL.FirstOrDefault(x => x.Id == id);
            if (targetfl != null)
            {
                targetfl.Numfl = model.Numfl;
                targetfl.TypeAir = model.TypeAir;
                targetfl.ColPas = model.ColPas;
                targetfl.ColBuil = model.ColBuil;
                targetfl.Pass = model.Pass;
                targetfl.Build = model.Build;
                targetfl.Percent = model.Percent;
                targetfl.Result = model.ColPas * model.Pass + model.ColBuil * model.Build + model.Percent;
            }
            return targetfl;
        }
        [HttpPost]
        public AirplanesFlight Add(Flight model)
        {
            var Flight = new AirplanesFlight
            {
                Id = Guid.NewGuid(),
                Numfl = model.Numfl,
                TypeAir = model.TypeAir,
                TimeIn = model.TimeIn,
                ColPas = model.ColPas,
                ColBuil = model.ColBuil,
                Pass = model.Pass,
                Build = model.Build,
                Percent = model.Percent,
                Result = model.ColPas * model.Pass + model.ColBuil * model.Build + model.Percent,
            };
            airplaneFL.Add(Flight);
            return Flight;
        }
    }
}
