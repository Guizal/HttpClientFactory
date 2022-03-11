using HttpClientFactoryDemo.Model;
using HttpClientFactoryDemo.Model.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Services
{
    public class TodoService : IToDoService
    {
        private readonly IApiConfig _config;
        private readonly HttpClient _httpClient;

        public TodoService(IApiConfig config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<TodoModel> GetToDo(int id)
        {
            return await _httpClient.GetFromJsonAsync<TodoModel>(
                $"{_config.BaseUrl}/todos/{id}");
        }
    }
}
