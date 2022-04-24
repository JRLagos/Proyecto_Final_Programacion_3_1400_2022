using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Pages.Automoviles;

partial class Car
{
    [Inject] private IAutomovilServicio _automovilServicio { get; set; }

    private IEnumerable<Automovil> automovilLista { get; set; }

    protected override async Task OnInitializedAsync()
    {
        automovilLista = (IEnumerable<Automovil>)await _automovilServicio.GetLista();
    }
}
