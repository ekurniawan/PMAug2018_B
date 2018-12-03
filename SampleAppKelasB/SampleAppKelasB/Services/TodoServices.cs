using Newtonsoft.Json;
using SampleAppKelasB.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SampleAppKelasB.Services
{
    public class TodoServices
    {
        private HttpClient _client;
        public TodoServices()
        {
            _client = new HttpClient();
        }

        public async Task<List<TodoItem>> GetAllData()
        {
            var items = new List<TodoItem>();
            var uri = new Uri(Helpers.RestUrl);
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<List<TodoItem>>(content);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Kesalahan: {ex.Message}");
            }
            return items;
        }
    }
}
