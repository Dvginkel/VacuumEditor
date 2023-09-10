using System;
using System.Collections.Generic;

public class Manager
    {
        public string Guid { get; set; }
        public string ManagerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LocationId { get; set; }
        public int Slot { get; set; }
        public string PrimaryEffect { get; set; }
        public string SecondaryEffect { get; set; }
        public int Level { get; set; }
        public int Slots { get; set; }
        public FreeManagers FreeManagers { get; set; }
        public List<Manager> Managers { get; set; }
    }
