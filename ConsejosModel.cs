using Newtonsoft.Json;

namespace Cliente_API_REST.Models
{
    public class ConsejosModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("contenido")]
        public string Content { get; set; }
        
        [JsonProperty("tipo")]
        public int Type { get; set; }
        
        [JsonProperty("tipo_nombre")]
        public string Type_Name { get; set; }

        
    }
}
