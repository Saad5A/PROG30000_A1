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
    }
}
