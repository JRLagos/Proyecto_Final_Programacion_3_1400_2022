using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios;

public class AutomovilRepositorio : IAutomovilRepositorio
{
    private string CadenaConexion;

    public AutomovilRepositorio(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }

    private MySqlConnection Conexion()
    {
        return new MySqlConnection(CadenaConexion);
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
        IEnumerable<Automovil> lista = new List<Automovil>();

        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM automovil;";
            lista = await conexion.QueryAsync<Automovil>(sql);
        }
        catch (Exception)
        {
        }
        return lista;
    }

    public Task<Automovil> GetPorcodigo(string automovil)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Nuevo(Automovil automovil)
    {
        throw new NotImplementedException();
    }
}
