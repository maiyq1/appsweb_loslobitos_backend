using System.ComponentModel.DataAnnotations;
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

    public bool Update(int id, string placa)
    {
        try
        {
            var reservation = _geniusDbContext.Reservations.Find(id); //Encontrar el item
            reservation.Placa = placa; //Modificar
            _geniusDbContext.Reservations.Update(reservation); //Actualizar

            _geniusDbContext.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public bool Delete(int id)
    {
        var reservation = _geniusDbContext.Reservations.Find(id);
        reservation.isActive = false;
        _geniusDbContext.Reservations.Update(reservation);
        _geniusDbContext.SaveChanges();
        return true;
    }
}