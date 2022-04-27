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


    public async Task<IEnumerable<Factura>> GetLista()
    {
        return await facturaRepositorio.GetLista();
    }

    public async Task<Factura> GetPorCodigo(string idFactura)
    {
        return await facturaRepositorio.GetPorCodigo(idFactura);
    }

    public Task<bool> InsertarDetalle(Factura factura)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> InsertarFactura(Factura factura)
    {
        return await facturaRepositorio.InsertarFactura(factura);

    }
}
