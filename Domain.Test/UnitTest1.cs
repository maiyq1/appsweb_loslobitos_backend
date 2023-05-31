using Infraestructure;
using Infraestructure.Models;
using Moq;

namespace Domain.Test;

public class UnitTest1
{
    [Fact]
    public void Create_ValidReservation_ReturnSuccess()
    {
        //Arrage
        Reservation reservation = new Reservation()
        {
            Place = "Place1",
            Placa = "1234567",
            isPaid = true
        };
        var mockReservationInfraestructure = new Mock<IReservationInfraestructure>();
        mockReservationInfraestructure.Setup(r => r.Create(reservation)).Returns(true);
        ReservationDomain reservationDomain = new ReservationDomain(mockReservationInfraestructure.Object);
        
        //Act
        var returnValue = reservationDomain.Create(reservation);
        
        //Assert
        Assert.True(returnValue);
    }

    [Fact]
    public void Create_InvalidReservation_ReturnError()
    {
        //Arrage
        Reservation reservation = new Reservation()
        {
            Place = "Place1",
            Placa = "1234567",
            isPaid = true
        };
        var mockReservationInfraestructure = new Mock<IReservationInfraestructure>();
        mockReservationInfraestructure.Setup(r => r.Create(reservation)).Returns(false);
        ReservationDomain reservationDomain = new ReservationDomain(mockReservationInfraestructure.Object);
        
        //Act
        var returnValue = reservationDomain.Create(reservation);
        
        //Assert
        Assert.False(returnValue);
    }
    
    [Fact]
    public void Create_InvalidReservation_ReturnException()
    {
        //Arrage
        Reservation reservation = new Reservation()
        {
            Place = "Place1",
            Placa = "1234567", //Poner cantidades distintas de caracteres para validar el test
            isPaid = true
        };
        var mockReservationInfraestructure = new Mock<IReservationInfraestructure>();
        mockReservationInfraestructure.Setup(r => r.Create(reservation)).Returns(false);
        ReservationDomain reservationDomain = new ReservationDomain(mockReservationInfraestructure.Object);
        
        //Act
        var ex = Assert.Throws<Exception>(() => reservationDomain.Create(reservation));
        
        //Assert
        Assert.Equal("deben ser 7 caracteres", ex.Message);
    }
    
    [Fact]
        public void Update_ValidReservation_ReturnSuccess() {

        //Arrange
        Reservation reservation = new Reservation()
        {
            Id = 1,
            Place = "Place1",
            Placa = "1234567",
            isPaid = true
        };
        var mockReservationInfraestructure = new Mock<IReservationInfraestructure>();
        mockReservationInfraestructure.Setup(r => r.Update(reservation)).Returns(true);
        ReservationDomain reservationDomain = new ReservationDomain(mockReservationInfraestructure.Object);
            
        //Act
        var returnValue = reservationDomain.Update(reservation);

        //Assert
        Assert.True(returnValue);
     }
}
