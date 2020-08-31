using PoorManReddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PoorManReddit.Services
{
    public class RedditService : IRedditService
    {
        private readonly HttpClient _client;

        public RedditService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Child>> GetAll()
        {
            // Install NUGET: System.Net.Http.Json
            var response = await _client.GetFromJsonAsync<RedditResponse>("aww/.json");

            return response.Data.Children;
        }
    }
}
