using Newtonsoft.Json;

namespace Cliente_API_REST.Models
{
    public class TiposModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Name { get; set; }

        [JsonProperty("descripcion")]
        public string Description { get; set; }

    }
}
