#pragma checksum "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30ac29c3a0fe2abe44bb22475aa0393407729441"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorLeaflet.Samples.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using BlazorLeaflet.Samples;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using BlazorLeaflet.Samples.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using BlazorLeaflet.Samples.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\_Imports.razor"
using BlazorLeaflet.Samples.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href> BlazorWEB.Leaflet </a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> CARGO-S\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\n\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "class", "nav-link");
            __builder.AddAttribute(29, "href", "cargocrud");
            __builder.AddAttribute(30, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 15 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor"
                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\n                <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> Cargo CRUD\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "nav-link");
            __builder.AddAttribute(36, "href", "cargotracking");
            __builder.AddAttribute(37, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor"
                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\n                <span class=\"oi oi-map-marker\" aria-hidden=\"true\"></span> Cargo Tracking\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\n\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "shapes");
            __builder.AddAttribute(44, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 23 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor"
                                                           NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(46, "\n                <span class=\"oi oi-compass\" aria-hidden=\"true\"></span> MAP\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\zehra\OneDrive\Masaüstü\BlazorLeaflet-master - Kopya\BlazorLeaflet-master\BlazorLeaflet\BlazorLeaflet.Samples\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
