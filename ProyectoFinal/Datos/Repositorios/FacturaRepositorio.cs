using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios;

public class FacturaRepositorio : IFacturaRepositorio
{
    private string CadenaConexion;

    public FacturaRepositorio(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }

    private MySqlConnection Conexion()
    {
        return new MySqlConnection(CadenaConexion);
    }

    public async Task<bool> InsertarFactura(Factura factura)
    {
        int resultado;
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "INSERT INTO factura (IdFactura, IdentidadCliente, Fecha, SubTotal, Impuesto, Total) VALUES (@IdFactura, @IdentidadCliente, @Fecha, @SubTotal, @Impuesto, @Total)";
            resultado = await conexion.ExecuteAsync(sql, factura);
            return resultado > 0;
        }
        catch (Exception ex)
        {
            return false;
        }
        
    }

    public async Task<bool> InsertarDetalle(Factura factura)
    {
        throw new NotImplementedException();//continuar
    }

    public async Task<IEnumerable<Factura>> GetLista()
    {

        IEnumerable<Factura> lista = new List<Factura>();

        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM factura;";
            lista = await conexion.QueryAsync<Factura>(sql);
        }
        catch (Exception ex)
        {
        }
        return lista;
    }

    public async Task<Factura> GetPorCodigo(string idFactura)
    {
        Factura factura = new Factura();
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM factura WHERE IdFactura = @IdFactura;";
            factura = await conexion.QueryFirstAsync<Factura>(sql, new { idFactura });
        }
        catch (Exception)
        {
        }
        return factura;
    }
}
