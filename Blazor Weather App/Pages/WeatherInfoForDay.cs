namespace Blazor_Weather_App.Pages;

public class WeatherInfoForDay
{
    public float TemperatureData;
    public float WindSpeedData;
    public double HumidityData;
    public string description;
    public WeatherInfoForDay(string _description, float _CurrentTemperature, float _CurrentWindSpeed, double _humidity)
    {
        description = _description;
        TemperatureData = _CurrentTemperature;
        WindSpeedData = _CurrentWindSpeed;
        HumidityData = _humidity;
    }
}