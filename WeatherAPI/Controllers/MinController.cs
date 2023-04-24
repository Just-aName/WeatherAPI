using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinController : ControllerBase
    {
        [HttpGet("GetMinPerDay/{from}/{to}")]
        public IEnumerable<MinPerDayTableModel> GetPerDay(DateTime from, DateTime to)
        {
            using (var MinContext = new WeatherContext())
            {
                return MinContext.MinPerDay.Where(x => x.time >= from && x.time <= to).ToArray();
            }
        }

        [HttpGet("GetMinPerHour/{from}/{to}")]
        public IEnumerable<MinPerHourTableModel> GetPerHour(DateTime from, DateTime to)
        {
            using (var MinContext = new WeatherContext())
            {
                return MinContext.MinPerHour.Where(x => x.time >= from && x.time <= to).ToArray();
            }
        }
    }
}
