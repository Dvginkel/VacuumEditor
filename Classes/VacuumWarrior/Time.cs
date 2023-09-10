using System;

public class Time
    {
        public DateTime LastDailyRewardClaimed { get; set; }
        public DateTime LastLogoutTime { get; set; }
        public DateTime GameStartTime { get; set; }
        public int InGameTime { get; set; }
        public DateTime PrestigeStartTime { get; set; }
        public int InGamePrestigeTime { get; set; }
        public int TotalTimeLapsedMinutes { get; set; }
    }
