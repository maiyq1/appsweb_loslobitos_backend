using Infraestructure.Context;
using Infraestructure.Models;

namespace Infraestructure;

public class ReservationMotorcycleInfra : IReservationInfraestructure
{
    private GeniusDBContext _geniusDbContext;

    public ReservationMotorcycleInfra(GeniusDBContext geniusDbContext)
    {
        _geniusDbContext = geniusDbContext;
    }
    public List<Reservation> GetAll()
    {
        return _geniusDbContext.Reservations.ToList();
    }
}