using System;
using Newtonsoft.Json;

namespace WebServiceTutorial
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public string Direction { get; set; }
    }
}
