using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    [Table("MinPerDay")]
    public class MinPerDayTableModel : AggregationDataModel
    {
    }
}
