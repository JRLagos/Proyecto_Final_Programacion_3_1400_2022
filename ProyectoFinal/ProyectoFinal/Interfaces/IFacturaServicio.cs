using Modelos;

namespace ProyectoFinal.Interfaces
{
    public interface IFacturaServicio
    {
        Task<bool> InsertarFactura(Factura factura);
        Task<bool> InsertarDetalle(Factura factura);

        Task<IEnumerable<Factura>> GetLista();
        Task<Factura> GetPorCodigo(string idFactura);
    }
}
