namespace PROG30000_A1.Models
{
    public class Equipment
    {
        
        public int Id { get; set; }
        public EquipmentType Type { get; set; }

        public string Description { get; set; }
        public bool IsAvailable { get; set; }

        //Constructor for the Equipment class
        public Equipment(int id, EquipmentType type, string description, bool isAvailable)
        {
            Id = id;
            Type = type;
            Description = description;
            IsAvailable = isAvailable;
        }



    }
}
