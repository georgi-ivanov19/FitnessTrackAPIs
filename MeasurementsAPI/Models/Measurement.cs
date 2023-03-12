using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeasurementsAPI.Models
{
    [Table("Measurements")]
    public class Measurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string applicationUserId { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public double? Value { get; set; }
        public string Unit { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
