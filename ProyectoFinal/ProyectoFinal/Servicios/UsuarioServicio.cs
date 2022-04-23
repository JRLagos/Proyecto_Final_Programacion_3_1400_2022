using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;
using ProyectoFinal.Data;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Servicios;

public class UsuarioServicio : IUsuarioServicio
{
    private readonly MysqlConfiguration _configuration;
    private IUsuarioRepositorio usuarioRepositorio;

    public UsuarioServicio(MysqlConfiguration configuration)
    {
        _configuration = configuration;
        usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }

    public Task<bool> Actualizar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public  async Task<IEnumerable<Usuario>> GetLista()
    {
        return await usuarioRepositorio.GetLista();
    }

    public async Task<Usuario> GetPorcodigo(string codigo)
    {
        return await usuarioRepositorio.GetPorcodigo(codigo);
    }

    public Task<bool> Nuevo(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
//ProyectoFinal
