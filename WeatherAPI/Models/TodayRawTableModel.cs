using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    [Table("TodayRaw")]
    public class TodayRawTableModel : RawDataModel
    {
        public TodayRawTableModel() { }
        public TodayRawTableModel(MqttDataModel data ) : base( data ) { }  
    }
}
