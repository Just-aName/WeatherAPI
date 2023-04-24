using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    public class MqttDataModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        public string? cloudbase_meter { get; set; }
        public string? outHumidity { get; set; }
        public string? pressure_mbar { get; set; }
        public string? barometer_mbar { get; set; }
        public string? rainRate_mm_per_hour { get; set; }
        public string? dewpoint_C { get; set; }
        public string? rainTotal { get; set; }
        public string? ptr { get; set; }
        public string? heatindex_C { get; set; }
        public string? inDewpoint_C { get; set; }
        public string? outTempBatteryStatus { get; set; }
        public string? dayRain_mm { get; set; }
        public string? delay { get; set; }
        public string? altimeter_mbar { get; set; }
        public string? windchill_C { get; set; }
        public string? appTemp_C { get; set; }
        public string? outTemp_C { get; set; }
        public string? status { get; set; }
        public string? maxSolarRad_Wpm2 { get; set; }
        public string? humidex_C { get; set; }
        public string? hourRain_mm { get; set; }
        public string? windGust_mps { get; set; }
        public string? rxCheckPercent { get; set; }
        public string? inTemp_C { get; set; }
        public string? usUnits { get; set; }
        public string? rain_mm { get; set; }
        public string? rain24_mm { get; set; }
        public string? windDir { get; set; }
        public string? windSpeed_mps { get; set; }
        public string? inHumidity { get; set; }
        [Required]
        public string time { get; set; } = "0";
    }
}

