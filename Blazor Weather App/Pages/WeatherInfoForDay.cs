namespace Blazor_Weather_App.Pages;

public class WeatherInfoForDay
{
    private float TemperatureData;
    private float WindSpeedData;
    public double HumidityData;
    public float CurrentTemperature;
    public float CurrentWindSpeed;
    public string description;
    public string date;
    public string imageLink;
    public WeatherInfoForDay(string _description, float _CurrentTemperature, float _CurrentWindSpeed, double _humidity, int ForecastDayNumber)
    {
        description = _description;
        TemperatureData = _CurrentTemperature;
        WindSpeedData = _CurrentWindSpeed;
        HumidityData = _humidity;
        CurrentTemperature = TemperatureData;
        CurrentWindSpeed = WindSpeedData;
        date = DateTime.Today.AddDays(ForecastDayNumber).ToString("dddd, dd MMM yyyy");
        imageLink = GetIcon();
    }

    string GetIcon()
    {
        if(description.Contains("clear") )
            return imageLink = "https://cdn2.iconfinder.com/data/icons/weather-682/1024/sun_sunny-512.png";
        if(description.Contains("few clouds"))
            return imageLink = "https://cdn-icons-png.flaticon.com/512/1163/1163661.png";
        if(description.Contains("light rain"))
            return imageLink = "https://cdn-icons-png.flaticon.com/512/1163/1163657.png";
        if(description.Contains("moderate rain") | description.Contains("heavy intensity rain"))
            return imageLink = "https://cdn2.iconfinder.com/data/icons/weather-flat-14/64/weather07-512.png";
        return imageLink = "https://cdn-icons-png.flaticon.com/512/1163/1163624.png";
    }
    public void SwitchToFahrenheit(bool isFahrenheit)
    {
        if(isFahrenheit) {CurrentTemperature = (float)Math.Round(TemperatureData * (9f / 5) , 2) + 32; return; }
        CurrentTemperature = TemperatureData;
    }
    public void SwitchToMph(bool isMph)
    {
        if(isMph) {CurrentWindSpeed = (float)Math.Round(WindSpeedData * 0.621371f,4);return; }
        CurrentWindSpeed = WindSpeedData;
    }
    
}