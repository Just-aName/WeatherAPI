using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvgController : ControllerBase
    {
        [HttpGet("GetAvgPerMin/{from}/{to}")]
        public IEnumerable<AvgPerTenMinTableModel> GetPerMin(DateTime from, DateTime to)
        {
            using(var avgContext = new WeatherContext())
            {
                return avgContext.AvgPerTenMin.Where(x => x.time >= from && x.time <= to).ToArray();
            }
        }

        [HttpGet("GetAvgPerDay/{from}/{to}")]
        public IEnumerable<AvgPerDayTableModel> GetPerDay(DateTime from, DateTime to)
        {
            using (var avgContext = new WeatherContext())
            {
                return avgContext.AvgPerDay.Where(x => x.time >= from && x.time <= to).ToArray();
            }
        }

        [HttpGet("GetAvgPerHour/{from}/{to}")]
        public IEnumerable<AvgPerHourTableModel> GetPerHour(DateTime from, DateTime to)
        {
            using (var avgContext = new WeatherContext())
            {
                return avgContext.AvgPerHour.Where(x => x.time >= from && x.time <= to).ToArray();
            }
        }
    }
}

