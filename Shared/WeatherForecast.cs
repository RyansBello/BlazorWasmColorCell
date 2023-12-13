namespace WasmColorCell.Shared
{
    public class WeatherForecast
    {
        public int? nRow { get; set; }
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string? MyChoosenColor { get; set; }
    }
}
