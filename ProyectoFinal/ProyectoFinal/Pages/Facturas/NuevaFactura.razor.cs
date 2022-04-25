using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoFinal.Interfaces;

namespace ProyectoFinal.Pages.Facturas
{
    partial class NuevaFactura
    {
        [Inject] private IFacturaServicio facturaServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] SweetAlertService Swal { get; set; }

        private Factura factura = new Factura();

        protected async Task Agregar()
        {
            if (string.IsNullOrEmpty(Convert.ToString(factura.IdFactura)) || string.IsNullOrEmpty(factura.IdentidadCliente) || (string.IsNullOrEmpty(Convert.ToString(factura.Fecha))) || (string.IsNullOrEmpty(Convert.ToString(factura.SubTotal))) || (string.IsNullOrEmpty(Convert.ToString(factura.Total))))
            {
                return;
            }

            bool inserto = await facturaServicio.InsertarFactura(factura);
            if (inserto)
            {
                await Swal.FireAsync("Listo", "Factura creada con exito", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "La factura no se pudo crear", SweetAlertIcon.Error);
            }
            navigationManager.NavigateTo("/Facturas");

        }

        protected async Task Cancelar()
        {
            navigationManager.NavigateTo("/Facturas");
        }

    }
}
