using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;

namespace ApexLegendsApp.Model
{
    public class Weapon : BaseGameData
    {
        public decimal Damage { get; set; }

        [JsonProperty("damage_modifier")]
        public decimal DamageModifier { get; set; }
        
        [JsonProperty("headshot_damage")]
        public decimal HeadshotDamage { get; set; }

        [JsonProperty("legshot_damage")]
        public decimal LegshotDamage { get; set; }

        [JsonProperty("rate_of_fire")]
        public decimal RateOfFire { get; set; }

        [JsonProperty("ammo_capacity")]
        public decimal AmmoCapacity { get; set; }

        [JsonProperty("tactical_reload")]
        public decimal TacticalReload { get; set; }

        [JsonProperty("empty_reload")]
        public decimal EmptyReload { get; set; }

        [JsonProperty("ammo_type")]
        public string AmmoType { get; set; }

        [JsonProperty("projectile_speed")]
        public decimal ProjectileSpeed { get; set; }

        [JsonProperty("draw_time")]
        public decimal DrawTime { get; set; }

        [JsonProperty("holster_time")] 
        public decimal HolsterTime { get; set; }

        public override string ToString()
            => Name;
    }
}