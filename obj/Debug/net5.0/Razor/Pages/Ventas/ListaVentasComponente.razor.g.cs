#pragma checksum "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f45d3be9a51eea4fc0f40417202a4e2d0853e25d"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/facturas")]
    public partial class ListaVentasComponente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><h4>Facturas</h4></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row mb-3");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-4");
            __builder.AddMarkupContent(11, "<label>Cliente</label>\r\n                    ");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                        IdCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IdCliente = __value, IdCliente));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value");
            __builder.AddContent(18, "Todos");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                         if (ListaClientes != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                             foreach (var item in ListaClientes)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 18 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, 
#nullable restore
#line 18 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                          item.NombreCompleto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-3");
            __builder.AddMarkupContent(25, "<label>Desde</label>\r\n                    ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "date");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                                   Desde

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Desde = __value, Desde, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-3");
            __builder.AddMarkupContent(34, "<label>Hasta</label>\r\n                    ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "date");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                                   Hasta

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Hasta = __value, Hasta, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-2");
            __builder.AddMarkupContent(43, "<label>Opciones</label><br>\r\n                    ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-success");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                                            CargarFacturas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.AddMarkupContent(50, "<a href=\"/facturas/add\" class=\"btn btn-primary\">Nueva</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "row");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-12");
            __builder.OpenElement(56, "table");
            __builder.AddAttribute(57, "class", "table table-sm table-bordered");
            __builder.AddMarkupContent(58, @"<thead><tr><th>Número</th>
                                <th>Nombre del cliente</th>
                                <th>Fecha</th>
                                <th>Valor Total</th>
                                <th>Articulos</th>
                                <th>Utilidad</th>
                                <th>Opciones</th></tr></thead>
                        ");
            __builder.OpenElement(59, "tbody");
#nullable restore
#line 53 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                             foreach (var factura in ListaFacturas)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "tr");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 56 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                         factura.Numero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                    ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 57 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                         factura.NombreCliente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                    ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 58 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                         factura.Fecha.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                    ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "class", "text-right");
            __builder.AddContent(72, 
#nullable restore
#line 59 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                            factura.Total.ToString("c2")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                    ");
            __builder.OpenElement(74, "td");
            __builder.AddAttribute(75, "class", "text-right");
            __builder.AddContent(76, 
#nullable restore
#line 60 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                            factura.Items.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                                    ");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "class", "text-right");
            __builder.AddContent(80, 
#nullable restore
#line 61 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                            factura.Ganancia.ToString("c2")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                    ");
            __builder.OpenElement(82, "td");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "href", "/facturas/" + (
#nullable restore
#line 63 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                            factura.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "class", "btn btn-success");
            __builder.AddContent(86, "Abrir");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                                        ");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "type", "button");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
                                                          (()=>EliminarFactura(factura))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "class", "btn btn-danger");
            __builder.AddMarkupContent(92, "\r\n                                            Eliminar\r\n                                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"

                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
            __builder.OpenComponent<Sotsera.Blazor.Toaster.ToastContainer>(94);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\burgo\OneDrive\Pictures\Proyecto\Pages\Ventas\ListaVentasComponente.razor"
       

    public DateTime Desde { get; set; } = DateTime.Now.AddDays(-365);
    public DateTime Hasta { get; set; } = DateTime.Now;

    public int? IdCliente { get; set; }

    public List<VentaModel> ListaFacturas { get; set; } = new List<VentaModel>();
    public List<ClienteModel> ListaClientes { get; set; }

    protected override void OnInitialized()
    {
        ListaClientes = clientesService.ListaClientes();
        CargarFacturas();
    }

    protected void CargarFacturas()
    {
        var hasta = Hasta.AddHours(23).AddMinutes(59).AddSeconds(59);
        ListaFacturas = facturaService.ListaFacturas(Desde, hasta, IdCliente);
    }

    protected async Task EliminarFactura(VentaModel model)
    {
        var confirm = await swal.FireAsync(new SweetAlertOptions
        {
            Title = "¿Confirma que desea eliminar esta factura?",
            Text = "Si la elimina, no podrá recuperarla",
            ShowConfirmButton = true,
            ConfirmButtonText = "Si, eliminar",
            ShowCancelButton = true,
            CancelButtonText = "No, no la elimine"
        });

        if (!confirm.IsConfirmed)
        {
            return;
        }

        var res = facturaService.Eliminar(model.Id);
        if (res.IsSuccess)
        {
            toaster.Success(res.Message, "OK");
            ListaFacturas.Remove(model);
        }
        else
        {
            toaster.Error(res.Message, "Error");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClienteService clientesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VentaService facturaService { get; set; }
    }
}
#pragma warning restore 1591
