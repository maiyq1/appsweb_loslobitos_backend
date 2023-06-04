namespace Infraestructure.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public int ParkingId { get; set; }
        public Parking Parking { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}