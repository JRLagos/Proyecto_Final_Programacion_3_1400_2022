using Modelos;

namespace Datos.Interfaces;

    public interface IAutomovilRepositorio
    {
    Task<bool> Nuevo(Automovil automovil);
    Task<bool> Actualizar(Automovil automovil);
    Task<bool> Eliminar(Automovil automovil);
    Task<IEnumerable<Automovil>> GetLista();
    Task<Automovil> GetPorcodigo(string codigo);
    }


