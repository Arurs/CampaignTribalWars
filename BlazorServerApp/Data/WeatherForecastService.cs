namespace BlazorServerApp.Data
{
    public class WeatherForecastService
    {
        private readonly HttpClient httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return await httpClient.GetFromJsonAsync<WeatherForecast[]>("/weatherForecast");
        }
    }
}