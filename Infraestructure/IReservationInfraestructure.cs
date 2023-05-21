using Infraestructure.Models;

namespace Infraestructure;

public interface IReservationInfraestructure
{
   List<Reservation> GetAll();
}