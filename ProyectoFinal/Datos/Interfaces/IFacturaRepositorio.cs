using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces;

public interface IFacturaRepositorio
{
    Task<bool> InsertarFactura(Factura factura);
    Task<bool> InsertarDetalle(Factura factura);

    Task<IEnumerable<Factura>> GetLista();
    Task<Factura> GetPorCodigo(string idFactura);
}
