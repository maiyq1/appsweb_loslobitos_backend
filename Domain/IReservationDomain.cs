using Infraestructure.Models;

namespace Domain;

public interface IReservationDomain
{
   List<Reservation> GetAll();
   bool Create(string name);
   bool Update(int id, string name);
   bool Delete(int id);
}