using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Pages.Facturas
{
    partial class Facturas
    {

        [Inject] private IFacturaServicio _facturaServicio { get; set; }

        private IEnumerable<Factura> facturasLista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            facturasLista = await _facturaServicio.GetLista();
        }
    }
}
