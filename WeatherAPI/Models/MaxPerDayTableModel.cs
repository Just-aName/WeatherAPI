using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    [Table("MaxPerDay")]
    public class MaxPerDayTableModel : AggregationDataModel 
    {
    }
}
