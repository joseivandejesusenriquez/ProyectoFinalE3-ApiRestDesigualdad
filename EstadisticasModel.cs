using Newtonsoft.Json;

namespace Cliente_API_REST.Models
{
    public class EstadisticasModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tipo")]
        public int Type { get; set; }

        [JsonProperty("tipo_nombre")]
        public string Type_Name { get; set; }

        [JsonProperty("municipio")]
        public int Municipality { get; set; }

        [JsonProperty("municipio_nombre")]
        public string Municipality_Name { get; set; }

        [JsonProperty("porcentaje")]
        public decimal Percentage { get; set; }
    }
}
