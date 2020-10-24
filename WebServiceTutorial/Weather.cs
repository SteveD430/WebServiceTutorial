using System;
using Newtonsoft.Json;

namespace WebServiceTutorial
{
    public class Weather
    {
        [JsonProperty("main")]
        public string Visibility { get; set; }
    }
}
