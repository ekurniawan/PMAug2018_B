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

        public async Task InsertData(TodoItem item)
        {
            var uri = new Uri(Helpers.RestUrl);
            try
            {
                var jsonData = JsonConvert.SerializeObject(item);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(uri, content);
                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Data gagal ditambahkan");

            }
            catch (Exception ex)
            {
                throw new Exception($"Kesalahan:{ex.Message}");
            }
        }

        public async Task UpdateData(TodoItem item)
        {
            var uri = new Uri($"{Helpers.RestUrl}/{item.ID}");
            try
            {
                var jsonData = JsonConvert.SerializeObject(item);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await _client.PutAsync(uri, content);
                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Data gagal diupdate");

            }
            catch (Exception ex)
            {
                throw new Exception($"Kesalahan:{ex.Message}");
            }
        }

        public async Task DeleteData(string id)
        {
            var uri = new Uri($"{Helpers.RestUrl}/{id}");
            try
            {
                var response = await _client.DeleteAsync(uri);
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Delete data gagal !");
            }
            catch (Exception ex)
            {
                throw new Exception($"Kesalahan: {ex.Message}");
            }
        }
    }
}
