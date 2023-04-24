using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaxController : ControllerBase
    {
        [HttpGet("GetMaxPerDay/{from}/{to}")]
        public IEnumerable<MaxPerDayTableModel> GetPerDay(DateTime from, DateTime to)
        {
            using (var MaxContext = new WeatherContext())
            {
                return MaxContext.MaxPerDay.Where(x => x.time >= from && x.time <= to).ToArray();
            }
        }

        [HttpGet("GetMaxPerHour/{from}/{to}")]
        public IEnumerable<MaxPerHourTableModel> GetPerHour(DateTime from, DateTime to)
        {
            using (var MaxContext = new WeatherContext())
            {
                return MaxContext.MaxPerHour.Where(x => x.time >= from && x.time <= to).ToArray();
            }
        }
    }
}
