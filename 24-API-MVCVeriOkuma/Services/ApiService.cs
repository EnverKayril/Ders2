using _24_API_MVCVeriOkuma.Models;
using System.Text.Json;

namespace _24_API_MVCVeriOkuma.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PostDb>> GetApiAllPostsAsync()
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Status Code: {response.StatusCode}");
                string responseData = await response.Content.ReadAsStringAsync();

                List<PostDb> posts = JsonSerializer.Deserialize<List<PostDb>>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive=true});

                return posts;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                return null;
            }
        }

        public async Task<PostDb> GetApiById(int id)
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts" + id;

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();

                PostDb post = JsonSerializer.Deserialize<PostDb>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return post;
            }
            return null;
        }
    }
}
