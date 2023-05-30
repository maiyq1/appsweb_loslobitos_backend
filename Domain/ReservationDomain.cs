using Infraestructure;
using Infraestructure.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Domain;

public class ReservationDomain : IReservationDomain
{
    private IReservationInfraestructure _reservationInfraestructure;

    public ReservationDomain(IReservationInfraestructure reservationInfraestructure)
    {
        _reservationInfraestructure = reservationInfraestructure;
    }
    public List<Reservation> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Create(Reservation input)
    {
        //Reglas de negocio
        if (input.Placa.Length != 7) throw new Exception("deben ser 7 caracteres");
        return _reservationInfraestructure.Create(input);
    }

    public bool Update(int id, Reservation reservation)
    {
        return _reservationInfraestructure.Update(id, reservation);
    }

    public bool Delete(int id)
    {
        return _reservationInfraestructure.Delete(id);
    }
}