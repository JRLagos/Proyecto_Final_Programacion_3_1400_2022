using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Pages.Usuarios;

partial class EditarUsser
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

    [Parameter] public string Codigo { get; set; }
    Usuario user = new Usuario();

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(Codigo))
        {
            user = await _usuarioServicio.GetPorcodigo(Codigo);
        }
    }
    enum Tipo
    {
        Seleccionar,
        Administrador,
        Vendedor
    }
}
//ProyectoFinal
//1