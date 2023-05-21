namespace Infraestructure;

public class ReservationInfraestructure : IReservationInfraestructure
{
    //Comunicacion con database o API
    public IEnumerable<string> GetAll()
    {
        return new string[] { "Carro1", "carro2" };
    }
}