using Newtonsoft.Json;


namespace VacuumEditor
{
    internal partial class TestVacuumWarrior
    {
        [JsonProperty("Instances")]
        public Instances Instances { get; set; }

        [JsonProperty("Resources")]
        public Resources Resources { get; set; }

        [JsonProperty("PlayerData")]
        public PlayerData PlayerData { get; set; }

        [JsonProperty("BoostTimers")]
        public BoostTimers BoostTimers { get; set; }

        [JsonProperty("Achievements")]
        public Achievements Achievements { get; set; }

        [JsonProperty("ShopAutomationManager")]
        public ShopAutomationManager ShopAutomationManager { get; set; }

        [JsonProperty("Shops")]
        public Shops Shops { get; set; }

        [JsonProperty("Currencies")]
        public Currencies Currencies { get; set; }

        [JsonProperty("Time")]
        public Time Time { get; set; }

        [JsonProperty("Timers")]
        public Timers Timers { get; set; }

        [JsonProperty("Managers")]
        public Manager Manager { get; set; }

        [JsonProperty("Chests")]
        public Chests Chests { get; set; }

        [JsonProperty("PrestigeStatistics")]
        public PrestigeStatistics PrestigeStatistics { get; set; }

        [JsonProperty("GlobalStatistics")]
        public GlobalStatistics GlobalStatistics { get; set; }
       
        public TestVacuumWarrior()
        {
           
        }
    }
}