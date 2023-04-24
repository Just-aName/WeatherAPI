using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace WeatherAPI.Models
{
    public class RawDataModel
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
        public decimal? outTempBatteryStatus { get; set; }
        public decimal? dayRain_mm { get; set; }
        public decimal? delay { get; set; }
        public decimal? altimeter_mbar { get; set; }
        public decimal? windchill_C { get; set; }
        public decimal? appTemp_C { get; set; }
        public decimal? outTemp_C { get; set; }
        public decimal? status { get; set; }
        public decimal? maxSolarRad_Wpm2 { get; set; }
        public decimal? humidex_C { get; set; }
        public decimal? hourRain_mm { get; set; }
        public decimal? windGust_mps { get; set; }
        public decimal? rxCheckPercent { get; set; }
        public decimal? inTemp_C { get; set; }
        public decimal? usUnits { get; set; }
        public decimal? rain_mm { get; set; }
        public decimal? rain24_mm { get; set; }
        public decimal? windDir { get; set; }
        public decimal? windSpeed_mps { get; set; }
        public decimal? inHumidity { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime time { get; set; }

        public RawDataModel() { }
        public RawDataModel(MqttDataModel source)
        {
            var numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
            id = source.id;
            cloudbase_meter = source.cloudbase_meter == null ? null : decimal.Parse(source.cloudbase_meter, numberFormatInfo);
            outHumidity = source.outHumidity == null ? null : decimal.Parse(source.outHumidity, numberFormatInfo);
            pressure_mbar = source.pressure_mbar == null ? null : decimal.Parse(source.pressure_mbar, numberFormatInfo);
            barometer_mbar = source.barometer_mbar == null ? null : decimal.Parse(source.barometer_mbar, numberFormatInfo);
            rainRate_mm_per_hour = source.rainRate_mm_per_hour == null ? null : decimal.Parse(source.rainRate_mm_per_hour, numberFormatInfo);
            dewpoint_C = source.dewpoint_C == null ? null : decimal.Parse(source.dewpoint_C, numberFormatInfo);
            rainTotal = source.rainTotal == null ? null : decimal.Parse(source.rainTotal, numberFormatInfo);
            heatindex_C = source.heatindex_C == null ? null : decimal.Parse(source.heatindex_C, numberFormatInfo);
            inDewpoint_C = source.inDewpoint_C == null ? null : decimal.Parse(source.inDewpoint_C, numberFormatInfo);
            outTempBatteryStatus = source.outTempBatteryStatus == null ? null : decimal.Parse(source.outTempBatteryStatus, numberFormatInfo);
            dayRain_mm = source.dayRain_mm == null ? null : decimal.Parse(source.dayRain_mm, numberFormatInfo);
            delay = source.delay == null ? null : decimal.Parse(source.delay, numberFormatInfo);
            altimeter_mbar = source.altimeter_mbar == null ? null : decimal.Parse(source.altimeter_mbar, numberFormatInfo);
            windchill_C = source.windchill_C == null ? null : decimal.Parse(source.windchill_C, numberFormatInfo);
            appTemp_C = source.appTemp_C == null ? null : decimal.Parse(source.appTemp_C, numberFormatInfo);
            outTemp_C = source.outTemp_C == null ? null : decimal.Parse(source.outTemp_C, numberFormatInfo);
            status = source.status == null ? null : decimal.Parse(source.status, numberFormatInfo);
            maxSolarRad_Wpm2 = source.maxSolarRad_Wpm2 == null ? null : decimal.Parse(source.maxSolarRad_Wpm2, numberFormatInfo);
            humidex_C = source.humidex_C == null ? null : decimal.Parse(source.humidex_C, numberFormatInfo);
            hourRain_mm = source.hourRain_mm == null ? null : decimal.Parse(source.hourRain_mm, numberFormatInfo);
            windGust_mps = source.windGust_mps == null ? null : decimal.Parse(source.windGust_mps, numberFormatInfo);
            rxCheckPercent = source.rxCheckPercent == null ? null : decimal.Parse(source.rxCheckPercent, numberFormatInfo);
            inTemp_C = source.inTemp_C == null ? null : decimal.Parse(source.inTemp_C, numberFormatInfo);
            usUnits = source.usUnits == null ? null : decimal.Parse(source.usUnits, numberFormatInfo);
            rain_mm = source.rain_mm == null ? null : decimal.Parse(source.rain_mm, numberFormatInfo);
            rain24_mm = source.rain24_mm == null ? null : decimal.Parse(source.rain24_mm, numberFormatInfo);
            windDir = source.windDir == null ? null : decimal.Parse(source.windDir, numberFormatInfo);
            windSpeed_mps = source.windSpeed_mps == null ? null : decimal.Parse(source.windSpeed_mps, numberFormatInfo);
            inHumidity = source.inHumidity == null ? null : decimal.Parse(source.inHumidity, numberFormatInfo);
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0); //Set default date 1/1/1970
            date = date.AddSeconds(int.Parse(source.time)); //add seconds
            time = RoundUp(date, TimeSpan.FromMinutes(5));
        }

        private DateTime RoundUp(DateTime dt, TimeSpan d)
        {
            return new DateTime((dt.Ticks + d.Ticks - 1) / d.Ticks * d.Ticks, dt.Kind);
        }
    }
}
