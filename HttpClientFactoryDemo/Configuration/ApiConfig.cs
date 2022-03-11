using HttpClientFactoryDemo.Model.Interfaces;

namespace HttpClientFactoryDemo.Configuration
{
    public class ApiConfig : IApiConfig
    {
        public string BaseUrl { get; set; } 
    }
}
