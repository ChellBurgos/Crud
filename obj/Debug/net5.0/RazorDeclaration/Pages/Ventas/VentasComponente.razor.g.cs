// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TiendaArtesaniasMarielos.Pages.Ventas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using TiendaArtesaniasMarielos.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\burgo\OneDrive\Pictures\Proyecto\_Imports.razor"
using Sotsera.Blazor.Toaster;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/facturas/{IdFactura:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/facturas/add")]
    public partial class VentasComponente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 161 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\VentasComponente.razor"
       

    [Parameter]
    public int? IdFactura { get; set; }

    public VentaModel Model { get; set; }
    public ItemFacturaModel ItemFactura { get; set; } = new ItemFacturaModel();

    public List<ClienteModel> ListaClientes { get; set; }

    protected override void OnInitialized()
    {
        CargarFactura();

        ListaClientes = clientesService.ListaClientes();
    }

    protected void CargarFactura()
    {
        if (IdFactura == null)
        {
            Model = new VentaModel()
            {
                Id = -1,
                Fecha = DateTime.Now,
            };
            ItemFactura.IdVenta = -1;
        }
        else
        {
            Model = facturaService.Factura(Convert.ToInt32(IdFactura));
            ItemFactura.IdVenta = Convert.ToInt32(IdFactura);
        }
    }

    protected void GuardarFactura()
    {
        var res = new MsgResult();

        if (Model.Id == -1)
        {
            res = CrearFactura();

            if (res.IsSuccess)
            {
                Model.Id = res.Code;
                ItemFactura.IdVenta = res.Code;
            }
        }
        else
        {
            res = ModificarFactura();
        }

        if (res.IsSuccess)
        {
            toaster.Success(res.Message, "OK");

        }
        else
        {
            toaster.Error(res.Message, "Error");
        }
    }

    protected MsgResult CrearFactura()
    {
        return facturaService.Crear(Model);
    }

    protected MsgResult ModificarFactura()
    {
        return facturaService.Modificar(Model);
    }

    protected void BuscarProducto(ChangeEventArgs e)
    {
        if (string.IsNullOrEmpty(e.Value.ToString()))
        {
            return;
        }

        var producto = productoService.Articulo(e.Value.ToString());
        if (producto == null)
        {
            toaster.Info("Producto no encontrado", "Info");
            return;
        }

        ItemFactura = new ItemFacturaModel
        {
            Cantidad = 1,
            Costo = producto.Costo,
            IdVenta = Model.Id,
            IdArticulo = producto.Id,
            NombreArticulo = producto.Nombre,
            Precio = producto.Precio,
            Codigo = producto.Codigo,
        };
    }

    protected void AgregarItemFactura()
    {
        var res = facturaService.AgregarProducto(ItemFactura);
        if (res.IsSuccess)
        {
            ItemFactura.Id = res.Code;
            Model.Items.Add(ItemFactura);
            ItemFactura = new ItemFacturaModel();
        }
        else
        {
            toaster.Error(res.Message, "Error");
        }
    }

    protected void EliminarProducto(ItemFacturaModel item)
    {
        var res = facturaService.EliminarProducto(item);
        if (res.IsSuccess)
        {
            toaster.Success(res.Message, "OK");
            Model.Items.Remove(item);
        }
        else
        {
            toaster.Error(res.Message, "OK");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArticuloService productoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService clientesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VentaService facturaService { get; set; }
    }
}
#pragma warning restore 1591
