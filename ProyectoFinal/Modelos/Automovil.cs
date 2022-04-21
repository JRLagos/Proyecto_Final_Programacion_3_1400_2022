using System.ComponentModel.DataAnnotations;

namespace Modelos;

public  class Automovil
{
    [Required(ErrorMessage = "El Campo CodigoAutomovil Es Obligatorio")]
    public string CodigoAutomovil { get; set; }
    [Required(ErrorMessage = "El Campo Marca Es Obligatorio")]
    public string Marca { get; set; }
    public int Año { get; set; }
    public string Color { get; set; }
    public decimal Precio { get; set; }
    public int Existencia { get; set; }
    public byte[] Foto { get; set; }
}
