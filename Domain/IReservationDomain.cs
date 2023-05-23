using Infraestructure.Models;

namespace Domain;

public interface IReservationDomain
{
   List<Reservation> GetAll();
   bool Create(string name);
}