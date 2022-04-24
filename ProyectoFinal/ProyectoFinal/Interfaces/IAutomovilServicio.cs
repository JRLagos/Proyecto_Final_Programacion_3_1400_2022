using Modelos;

namespace ProyectoFinal.Interfaces;

public interface IAutomovilServicio
{
    Task<bool> Nuevo(Automovil automovil);
    Task<bool> Actualizar(Automovil automovil);
    Task<bool> Eliminar(Automovil automovil);
    Task<IEnumerable<Automovil>> GetLista();
    Task<Automovil> GetPorcodigo(string codigo);
}
