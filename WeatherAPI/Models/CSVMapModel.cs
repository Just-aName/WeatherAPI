using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherAPI.Models
{
    public class CSVMapModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        public DateTime datetime { get; set; }
        [MaxLength(500)]
        public string? path { get; set; }
        [MaxLength(500)]
        public string? type { get; set; }
    }
}
