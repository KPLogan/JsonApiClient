using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace JsonAPIClient
{
    public static class WeatherApiClient
    {
        public static void GetWeatherForcast()
        {
            // Mystic
            var url = "http://api.openweathermap.org/data/2.5/forecast/city?id=4839141&APPID=5e1d873c8dd42dd8c87a0cf2905a9810";
            
            //New London
            //var url = "http://api.openweathermap.org/data/2.5/forecast?q=New London,us&APPID=5e1d873c8dd42dd8c87a0cf2905a9810";
            
            //synchronous consumption
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);
        }
    }
}
