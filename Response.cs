using Newtonsoft.Json;

namespace Cliente_API_REST.Models
{
    public class Response<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
