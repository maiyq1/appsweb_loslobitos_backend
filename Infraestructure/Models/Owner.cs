namespace Infraestructure.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Parking> Parkings { get; set; }
        public List<Rent> Rents { get; set; }
    }
}