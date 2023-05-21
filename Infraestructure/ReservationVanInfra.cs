using Infraestructure.Context;
using Infraestructure.Models;

namespace Infraestructure;

public class ReservationVanInfra : IReservationInfraestructure
{
    private GeniusDBContext _geniusDbContext;

    public ReservationVanInfra(GeniusDBContext geniusDbContext)
    {
        _geniusDbContext = geniusDbContext;
    }
    public List<Reservation> GetAll()
    {
        return _geniusDbContext.Reservations.ToList();
    }
}