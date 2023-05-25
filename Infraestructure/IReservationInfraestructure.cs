using Infraestructure.Models;

namespace Infraestructure;

public interface IReservationInfraestructure
{
   List<Reservation> GetAll();
   bool Create(string placa);
   bool Update(int id, string name);
   bool Delete(int id);
}