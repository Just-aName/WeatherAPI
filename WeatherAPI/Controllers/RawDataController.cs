using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RawDataController : ControllerBase
    {
        [HttpGet("GetCurrent")]
        public IEnumerable<TodayRawTableModel> GetCurrent()
        {
            using (var rawContext = new WeatherContext())
            {
                try
                {
                    var result = rawContext.TodayRaw.OrderByDescending(x => x.time).FirstOrDefault();
                    TodayRawTableModel[] finalArray = { result ?? new TodayRawTableModel() { } };
                    return finalArray;
                }
                catch(Exception ex)
                {
                    var a = new TodayRawTableModel() { id = -1 };
                    TodayRawTableModel[] b = { a };
                    return b;
                }
            }
        }

        [HttpGet("GetCurrent/{from}")]
        public IEnumerable<TodayRawTableModel> GetCurrentFrom(DateTime from)
        {
            using (var rawContext = new WeatherContext())
            {
                return rawContext.TodayRaw.Where(x => x.time >= from ).OrderByDescending(x => x.time).ToArray();
            }
        }

        [HttpGet("GetRawData/{from}/{to}")]
        public IEnumerable<RawDataTableModel> GetPerHour(DateTime from, DateTime to)
        {
            using (var rawContext = new WeatherContext())
            {
                return rawContext.RawData.Where(x => x.time >= from && x.time <= to).ToArray();
            }
        }
    }
}
