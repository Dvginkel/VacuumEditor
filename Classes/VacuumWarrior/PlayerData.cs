using System.Collections.Generic;

public class PlayerData
    {
        public string CurrentVacuum { get; set; }
        public bool VacuumEnabled { get; set; }
        public string Character { get; set; }
        public string Location { get; set; }
        public List<string> HasBeenUnlockedLocations { get; set; }
    }
