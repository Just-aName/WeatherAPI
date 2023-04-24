using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    public class AggregationDataModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        public decimal? cloudbase_meter { get; set; }
        public decimal? outHumidity { get; set; }
        public decimal? pressure_mbar { get; set; }
        public decimal? barometer_mbar { get; set; }
        public decimal? rainRate_mm_per_hour { get; set; }
        public decimal? dewpoint_C { get; set; }
        public decimal? rainTotal { get; set; }
        public decimal? heatindex_C { get; set; }
        public decimal? inDewpoint_C { get; set; }
        public decimal? dayRain_mm { get; set; }
        public decimal? altimeter_mbar { get; set; }
        public decimal? windchill_C { get; set; }
        public decimal? appTemp_C { get; set; }
        public decimal? outTemp_C { get; set; }
        public decimal? maxSolarRad_Wpm2 { get; set; }
        public decimal? humidex_C { get; set; }
        public decimal? hourRain_mm { get; set; }
        public decimal? windGust_mps { get; set; }
        public decimal? inTemp_C { get; set; }
        public decimal? rain_mm { get; set; }
        public decimal? rain24_mm { get; set; }
        public decimal? windDir { get; set; }
        public decimal? windSpeed_mps { get; set; }
        public decimal? inHumidity { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime time { get; set; }

        public AggregationDataModel() { }

        public AggregationDataModel(RawDataModel source)
        {
            id = source.id;
            cloudbase_meter = source.cloudbase_meter;
            outHumidity = source.outHumidity;
            pressure_mbar = source.pressure_mbar;
            barometer_mbar = source.barometer_mbar;
            rainRate_mm_per_hour = source.rainRate_mm_per_hour;
            dewpoint_C = source.dewpoint_C;
            rainTotal = source.rainTotal;
            heatindex_C = source.heatindex_C;
            inDewpoint_C = source.inDewpoint_C;
            dayRain_mm = source.dayRain_mm;
            altimeter_mbar = source.altimeter_mbar;
            windchill_C = source.windchill_C;
            appTemp_C = source.appTemp_C;
            outTemp_C = source.outTemp_C;
            maxSolarRad_Wpm2 = source.maxSolarRad_Wpm2;
            humidex_C = source.humidex_C;
            hourRain_mm = source.hourRain_mm;
            windGust_mps = source.windGust_mps;
            inTemp_C = source.inTemp_C;
            rain_mm = source.rain_mm;
            rain24_mm = source.rain24_mm;
            windDir = source.windDir;
            windSpeed_mps = source.windSpeed_mps;
            inHumidity = source.inHumidity;
            time = source.time;
        }
    }
}
