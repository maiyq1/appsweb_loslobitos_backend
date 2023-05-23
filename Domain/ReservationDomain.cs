using Infraestructure;
using Infraestructure.Models;

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

    public bool Create(string name)
    {
        //Reglas de negocio
        if (name.Length != 7) throw new Exception("deben ser 7 caracteres");
        return _reservationInfraestructure.Create(name);
    }
}