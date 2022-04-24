using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Factura
{
    [Required(ErrorMessage = "El Campo IdFactura Es Obligatorio")]
    public int IdFactura { get; set; }
    [Required(ErrorMessage = "El Campo IdentidadCliente Es Obligatorio")]
    public string IdentidadCliente { get; set; }
    public DateTime Fecha { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Impuesto { get; set; }
    public decimal Total { get; set; }

}
