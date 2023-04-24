using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    [Table("MaxPerHour")]
    public class MaxPerHourTableModel : AggregationDataModel    
    {
    }
}
