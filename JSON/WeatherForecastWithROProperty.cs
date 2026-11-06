public class WeatherForecastWithROProperty
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
    public int WindSpeedReadOnly { get; private set; } = 35;
}



// {
//   "Date": "2019-08-01T00:00:00-07:00",
//   "TemperatureCelsius": 25,
//   "Summary": "Hot",
// }