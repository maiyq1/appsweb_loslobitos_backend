using System.ComponentModel.DataAnnotations;

namespace API.Input;

public class ReservationInput
{
    public string Place { get; set; }
    [Required]
    [MaxLength(7)]
    [MinLength(7)]
    public string Placa { get; set; }
    public bool isPaid { get; set; }
}