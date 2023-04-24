using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    [Table("AvgPerDay")]
    public class AvgPerDayTableModel : AggregationDataModel
    {
    }
}
