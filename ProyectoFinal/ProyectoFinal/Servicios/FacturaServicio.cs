using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;
using ProyectoFinal.Data;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Servicios;

public class FacturaServicio : IFacturaServicio
{
    private readonly MysqlConfiguration _configuration;
    private IFacturaRepositorio facturaRepositorio;

    public FacturaServicio(MysqlConfiguration configuration)
    {
        _configuration = configuration;
        facturaRepositorio = new FacturaRepositorio(configuration.CadenaConexion);
    }


    public Task<IEnumerable<Factura>> GetLista()
    {
        throw new NotImplementedException();
    }

    public Task<Factura> GetPorCodigo(string idFactura)
    {
        throw new NotImplementedException();
    }

    public Task<bool> InsertarDetalle(Factura factura)
    {
        throw new NotImplementedException();
    }

    public Task<bool> InsertarFactura(Factura factura)
    {
        throw new NotImplementedException();
    }
}
