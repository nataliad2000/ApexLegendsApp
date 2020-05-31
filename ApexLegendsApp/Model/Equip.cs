using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApexLegendsApp.Model
{
    public class Equip
    {
        [JsonProperty("name")]
        public string  name { get; set; }
        [JsonProperty("heals")]
        public int heals { get; set; }
        [JsonProperty("cast_time")]
        public int cast_time { get; set; }
        [JsonProperty("stack_size")]
        public int stack_size { get; set; }
        [JsonProperty("restores")]
        public int? restores { get; set; }
        [JsonProperty("ultimate")]
        public int? ultimate { get; set; }

        public string Tostring
        {
            get=>$"{name} {heals} {cast_time} {stack_size} {restores} {ultimate}";
            
        }
    }
}
