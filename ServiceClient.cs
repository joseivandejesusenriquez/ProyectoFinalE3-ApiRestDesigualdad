using System;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Cliente_API_REST
{
    public class ServiceClient
    {
        #region Post
        public async Task<T> Post<T>(string serializer, string url, string token = null)
        {
            try
            {
                T deserializer = default(T);
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Settings.URL);
                HttpContent content = new StringContent(serializer, Encoding.UTF8, "application/json");
                if (!string.IsNullOrWhiteSpace(token))
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PostAsync(url, content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    deserializer = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseString);
                } else{
                    var responseString = await response.Content.ReadAsStringAsync();
                    deserializer = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseString);
                }
                return deserializer;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
        #endregion

        #region Get
        public async Task<T> Get<T>(string url, string token = null)
        {
            try
            {
                T deserializer = default(T);
                HttpClient client = new HttpClient();
                var urlType = Settings.URL + url;
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (!string.IsNullOrWhiteSpace(token))
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(urlType);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    deserializer = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseString);
                }
                else
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    deserializer = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseString);
                }
                return deserializer;
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
        #endregion
    }
}
