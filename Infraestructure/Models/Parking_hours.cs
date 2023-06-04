namespace Infraestructure.Models
{
    public class Parking_hours
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ParkingId { get; set; }
        public Parking Parking { get; set; }
    }
}