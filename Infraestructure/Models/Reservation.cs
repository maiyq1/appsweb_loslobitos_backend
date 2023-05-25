namespace Infraestructure.Models;

public class Reservation
{
    public int Id { get; set; }
    public string Place { get; set; }
    public string Placa { get; set; }
    public bool isPaid { get; set; }
    //Delete -> Desactivar o activar una tabla booleana
    public bool isActive { get; set; }
}