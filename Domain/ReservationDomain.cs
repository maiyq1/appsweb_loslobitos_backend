using Infraestructure;

namespace Domain;

//Dominio: Reglas de negocio
//Inyeccion de dependencias
//SQLServre -> MySQL -> OracleInfra -> etc....
public class ReservationDomain : IReservationDomain
{
    private IReservationInfraestructure _reservationInfraestructure;
    public ReservationDomain(IReservationInfraestructure reservationInfraestructure)
    {
        _reservationInfraestructure = reservationInfraestructure;
    }
    public IEnumerable<string> GetAll()
    {
        return _reservationInfraestructure.GetAll();
        //Inyeccion de dependencias
        //SQL Server -> MySQL -> OracleInfra -> etc... 
    }
}