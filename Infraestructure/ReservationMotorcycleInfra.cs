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

    public bool Create(string placa)
    {
        try
        {
            Reservation reservation = new Reservation();
            reservation.Placa = placa;
            _geniusDbContext.Reservations.Add(reservation);
            _geniusDbContext.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public bool Update(int id, string name)
    {
        throw new NotImplementedException();
    }
}