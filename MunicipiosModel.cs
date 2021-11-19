using Newtonsoft.Json;

namespace Cliente_API_REST.Models
{
    public class MunicipiosModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nombre")]
        public string Name { get; set; }
    }
}
