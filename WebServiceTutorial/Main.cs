using System;
using Newtonsoft.Json;

namespace WebServiceTutorial
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }
    }
}
