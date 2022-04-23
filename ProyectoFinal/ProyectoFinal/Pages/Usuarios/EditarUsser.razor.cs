using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Pages.Usuarios;

partial class EditarUsser
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

    [Inject] NavigationManager _navigationManager { get; set; }

    [Parameter] public string Codigo { get; set; }
    Usuario user = new Usuario();

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(Codigo))
        {
            user = await _usuarioServicio.GetPorcodigo(Codigo);
        }
    }

    protected async Task Guardar()
    {
        if (string.IsNullOrEmpty(user.CodigoUsuario) || string.IsNullOrEmpty(user.Nombre) || string.IsNullOrEmpty(user.TipoUsuario) || user.TipoUsuario=="Seleccionar")
        {
            return;
        }

        bool edito = await _usuarioServicio.Actualizar(user);

        if (edito)
        {

        }
        else
        {

        }
        _navigationManager.NavigateTo("/usser");   
    }
    protected async Task Cancelar()
    {
        _navigationManager.NavigateTo("/usser");

    }
    protected async Task Eliminar()
    {

    }

    enum Tipo
    {
        Seleccionar,
        Administrador,
        Vendedor,
        Gerente,
        Contador
    }
}
//ProyectoFinal
//1