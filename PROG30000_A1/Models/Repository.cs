namespace PROG30000_A1.Models
{
    public class Repository
    {
        private static List<EquipmentRequest> requests = new List<EquipmentRequest>();

        private static int nextId = 1;

        public static void AddRequest(EquipmentRequest request)
        {
            request.Id = nextId;
            nextId++;
            requests.Add(request);
           

        }
        
        public static List<EquipmentRequest> GetRequests()
        {
            return requests;
        }


        //MileStone 4: 

        private static List<Equipment> equipment = new()
        {
 // Laptops
    new Equipment(1, EquipmentType.Laptop, "Dell Latitude 7490", true),
    new Equipment(2, EquipmentType.Laptop, "HP EliteBook 840", false),
    new Equipment(3, EquipmentType.Laptop, "Lenovo ThinkPad T14", true),

    // Projectors
    new Equipment(4, EquipmentType.Projector, "Epson PowerLite 1781W", true),
    new Equipment(5, EquipmentType.Projector, "BenQ MW560", false),
    new Equipment(6, EquipmentType.Projector, "ViewSonic PA503W", true),

    // Cameras
    new Equipment(7, EquipmentType.Camera, "Canon EOS Rebel T7", true),
    new Equipment(8, EquipmentType.Camera, "Sony Alpha A6400", false),
    new Equipment(9, EquipmentType.Camera, "Nikon D3500", true),

    // Microphones
    new Equipment(10, EquipmentType.Microphone, "Blue Yeti USB Microphone", true),
    new Equipment(11, EquipmentType.Microphone, "Shure SM58", false),
    new Equipment(12, EquipmentType.Microphone, "Rode NT-USB", true),

    // Speakers
    new Equipment(13, EquipmentType.Speaker, "JBL Flip 6", true),
    new Equipment(14, EquipmentType.Speaker, "Bose SoundLink Flex", false),
    new Equipment(15, EquipmentType.Speaker, "Sony SRS-XB33", true),

    // Tablets
    new Equipment(16, EquipmentType.Tablet, "Apple iPad 10th Gen", true),
    new Equipment(17, EquipmentType.Tablet, "Samsung Galaxy Tab S9", false),
    new Equipment(18, EquipmentType.Tablet, "Microsoft Surface Go 3", true),

    // Other Equipment
    new Equipment(19, EquipmentType.Other, "Logitech C920 Webcam", true),
    new Equipment(20, EquipmentType.Other, "Wacom Intuos Drawing Tablet", false),
    new Equipment(21, EquipmentType.Other, "Logitech Wireless Presenter", true)
        };

        // Return all equipment
        public static IEnumerable<Equipment> AllEquipment
        {
            get { return equipment; }
        }


        public static IEnumerable<Equipment> AvailableEquipment()
        {
            return equipment.Where(e => e.IsAvailable);
        }

    }
}
