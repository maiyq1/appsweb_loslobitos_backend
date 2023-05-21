namespace Infraestructure;

public class ReservationMotorcycleInfra : IReservationInfraestructure
{
    public IEnumerable<string> GetAll()
    {
        return new string[] {"Indian Scout", "Vespa"};
    }
}