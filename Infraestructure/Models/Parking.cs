namespace Infraestructure.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        
        public List<Reservation> Reservations { get; set; }
    }
}