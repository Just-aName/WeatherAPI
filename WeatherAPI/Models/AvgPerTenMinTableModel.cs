using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    [Table("AvgPerTenMin")]
    public class AvgPerTenMinTableModel : AggregationDataModel 
    {
    }
}
