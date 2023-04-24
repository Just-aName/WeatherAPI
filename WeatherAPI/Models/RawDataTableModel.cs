using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    [Table("RawData")]
    public class RawDataTableModel : RawDataModel
    {
        public RawDataTableModel() { }
        public RawDataTableModel(MqttDataModel data) : base(data) { }
    }
}
