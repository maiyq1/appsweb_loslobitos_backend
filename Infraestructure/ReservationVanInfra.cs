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

    public List<Reservation> GetByPlace(string place)
    {
        return _geniusDbContext.Reservations.Where(reserv => reserv.isActive && reserv.Place.Contains(place)).ToList();
    }

    public Reservation GetById(int id)
    {
        return _geniusDbContext.Reservations.Single(reserv => reserv.isActive && reserv.Id == id);
    }

    public bool Create(Reservation reservation)
    {
        try
        {
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

    public bool Update(int id, Reservation input)
    {
        try
        {
            using (var transaction = _geniusDbContext.Database.BeginTransaction())
            {
                try
                {
                    var reservation = _geniusDbContext.Reservations.Find(id);
                    reservation.Place = input.Place;
                    reservation.Placa = input.Placa;
                    reservation.isPaid = input.isPaid;

                    _geniusDbContext.Reservations.Update(reservation);
                    _geniusDbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
            }

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