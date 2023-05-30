using Infraestructure.Models;

namespace Infraestructure;

public interface IReservationInfraestructure
{
   List<Reservation> GetAll();
   List<Reservation> GetByPlace(string place);
   Reservation GetById(int id);
   bool Create(Reservation input);
   bool Update(int id, Reservation input);
   bool Delete(int id);
}