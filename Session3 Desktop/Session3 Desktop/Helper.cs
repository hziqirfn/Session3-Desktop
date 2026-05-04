using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Session3_Desktop
{
    public class Helper
    {
        public static HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7067/api/")
        };

        public static async Task<T> get<T>(string url)
        {
            try
            {
                var req = await client.GetAsync(url);
                var content = await req.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(content,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public static async Task<T> post<T>(string url, object data)
        {
            try
            {
                var req = await client.PostAsJsonAsync(url, data);
                var content = await req.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(content);
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public static async Task<T> put<T>(string url, object data)
        {
            try
            {
                var req = await client.PutAsJsonAsync(url, data);
                var content = await req.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(content);
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public static async Task<int> postres(string url, object data)
        {
            try
            {
                var req = await client.PostAsJsonAsync(url, data);
                return (int)req.StatusCode;
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public static async Task<int> putres(string url, object data)
        {
            try
            {
                var req = await client.PutAsJsonAsync(url, data);
                return (int)req.StatusCode;
            }
            catch (Exception ex)
            {
                return default;
            }
        }
    }
}
