namespace Infraestructure;

public class ReservationVanInfra : IReservationInfraestructure
{
   public IEnumerable<string> GetAll()
   {
      return new string[] { "Van Toyota Hiux", "Van Ford Ranger" };
   }
}