using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;
using ProyectoFinal.Data;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Servicios;

public class AutomovilServicio : IAutomovilServicio
{
    private readonly MysqlConfiguration _configuration;
    private IAutomovilRepositorio automovilRepositorio;

    public AutomovilServicio(MysqlConfiguration configuration)
    {
        _configuration = configuration;
        automovilRepositorio = new AutomovilRepositorio(configuration.CadenaConexion);
    }
    public Task<bool> Actualizar(Automovil automovil)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Automovil automovil)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Automovil>> GetLista()
    {
        return await automovilRepositorio.GetLista();
    }

    public Task<Automovil> GetPorcodigo(string codigo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Nuevo(Automovil automovil)
    {
        throw new NotImplementedException();
    }
}
