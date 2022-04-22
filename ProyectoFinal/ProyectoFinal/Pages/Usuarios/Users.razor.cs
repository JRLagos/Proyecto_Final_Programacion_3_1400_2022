using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoFinal.Interfaz;

namespace ProyectoFinal.Pages.Usuarios
{
    partial class Users
    {
        [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

        private IEnumerable<Usuario> usuariosLista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }
    }
}




    