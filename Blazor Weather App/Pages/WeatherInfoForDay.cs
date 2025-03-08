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
    public WeatherInfoForDay(string _description, float _CurrentTemperature, float _CurrentWindSpeed, double _humidity, int ForecastDayNumber)
    {
        description = _description;
        TemperatureData = _CurrentTemperature;
        WindSpeedData = _CurrentWindSpeed;
        HumidityData = _humidity;
        CurrentTemperature = TemperatureData;
        CurrentWindSpeed = WindSpeedData;
        date = DateTime.Today.AddDays(ForecastDayNumber).ToString("dddd, dd MMM yyyy");
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