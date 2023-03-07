using Newtonsoft.Json;

namespace MeasurementsAPI.Models
{
    public class Measurement
    {
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        public string applicationUserId { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public double? Value { get; set; }
        public string Unit { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
