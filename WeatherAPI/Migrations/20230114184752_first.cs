using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherAPI.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RawDatas");

            migrationBuilder.CreateTable(
                name: "AvgPerDay",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvgPerDay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AvgPerHour",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvgPerHour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AvgPerTenMin",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvgPerTenMin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CSVMap",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    datetime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    path = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    type = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSVMap", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    datetime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    message = table.Column<string>(type: "TEXT", nullable: true),
                    applicationPart = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MaxPerDay",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaxPerDay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MaxPerHour",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaxPerHour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MinPerDay",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinPerDay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MinPerHour",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinPerHour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RawData",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    outTempBatteryStatus = table.Column<decimal>(type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    delay = table.Column<decimal>(type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    status = table.Column<decimal>(type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    rxCheckPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    usUnits = table.Column<decimal>(type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawData", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TodayRaw",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cloudbasemeter = table.Column<decimal>(name: "cloudbase_meter", type: "TEXT", nullable: true),
                    outHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    pressurembar = table.Column<decimal>(name: "pressure_mbar", type: "TEXT", nullable: true),
                    barometermbar = table.Column<decimal>(name: "barometer_mbar", type: "TEXT", nullable: true),
                    rainRatemmperhour = table.Column<decimal>(name: "rainRate_mm_per_hour", type: "TEXT", nullable: true),
                    dewpointC = table.Column<decimal>(name: "dewpoint_C", type: "TEXT", nullable: true),
                    rainTotal = table.Column<decimal>(type: "TEXT", nullable: true),
                    heatindexC = table.Column<decimal>(name: "heatindex_C", type: "TEXT", nullable: true),
                    inDewpointC = table.Column<decimal>(name: "inDewpoint_C", type: "TEXT", nullable: true),
                    outTempBatteryStatus = table.Column<decimal>(type: "TEXT", nullable: true),
                    dayRainmm = table.Column<decimal>(name: "dayRain_mm", type: "TEXT", nullable: true),
                    delay = table.Column<decimal>(type: "TEXT", nullable: true),
                    altimetermbar = table.Column<decimal>(name: "altimeter_mbar", type: "TEXT", nullable: true),
                    windchillC = table.Column<decimal>(name: "windchill_C", type: "TEXT", nullable: true),
                    appTempC = table.Column<decimal>(name: "appTemp_C", type: "TEXT", nullable: true),
                    outTempC = table.Column<decimal>(name: "outTemp_C", type: "TEXT", nullable: true),
                    status = table.Column<decimal>(type: "TEXT", nullable: true),
                    maxSolarRadWpm2 = table.Column<decimal>(name: "maxSolarRad_Wpm2", type: "TEXT", nullable: true),
                    humidexC = table.Column<decimal>(name: "humidex_C", type: "TEXT", nullable: true),
                    hourRainmm = table.Column<decimal>(name: "hourRain_mm", type: "TEXT", nullable: true),
                    windGustmps = table.Column<decimal>(name: "windGust_mps", type: "TEXT", nullable: true),
                    rxCheckPercent = table.Column<decimal>(type: "TEXT", nullable: true),
                    inTempC = table.Column<decimal>(name: "inTemp_C", type: "TEXT", nullable: true),
                    usUnits = table.Column<decimal>(type: "TEXT", nullable: true),
                    rainmm = table.Column<decimal>(name: "rain_mm", type: "TEXT", nullable: true),
                    rain24mm = table.Column<decimal>(name: "rain24_mm", type: "TEXT", nullable: true),
                    windDir = table.Column<decimal>(type: "TEXT", nullable: true),
                    windSpeedmps = table.Column<decimal>(name: "windSpeed_mps", type: "TEXT", nullable: true),
                    inHumidity = table.Column<decimal>(type: "TEXT", nullable: true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodayRaw", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvgPerDay");

            migrationBuilder.DropTable(
                name: "AvgPerHour");

            migrationBuilder.DropTable(
                name: "AvgPerTenMin");

            migrationBuilder.DropTable(
                name: "CSVMap");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MaxPerDay");

            migrationBuilder.DropTable(
                name: "MaxPerHour");

            migrationBuilder.DropTable(
                name: "MinPerDay");

            migrationBuilder.DropTable(
                name: "MinPerHour");

            migrationBuilder.DropTable(
                name: "RawData");

            migrationBuilder.DropTable(
                name: "TodayRaw");

            migrationBuilder.CreateTable(
                name: "RawDatas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawDatas", x => x.id);
                });
        }
    }
}
