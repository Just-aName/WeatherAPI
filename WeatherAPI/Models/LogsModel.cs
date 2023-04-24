using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    public class LogsModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        public DateTime datetime { get; set; }

        public string? message { get; set; }
        [MaxLength(500)]
        public string? applicationPart { get; set; }
    }
}
