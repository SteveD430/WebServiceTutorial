using System;
using Newtonsoft.Json;

namespace WebServiceTutorial
{
    public class Sys
    {
        private DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sunrise")]
        public long SunriseSecs { get; set; }

        [JsonProperty("sunset")]
        public long SunsetSecs { get; set; }

        public string Sunrise
        {
            get
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, 0)
                    .AddSeconds(SunriseSecs)
                    .ToString("HH:mm");
            }
        }
        public string Sunset
        {
            get
            {
                return new DateTime(1970, 1, 1, 0, 0, 0, 0)
                    .AddSeconds(SunsetSecs)
                    .ToString("HH:mm");
            }
        }
    }
}