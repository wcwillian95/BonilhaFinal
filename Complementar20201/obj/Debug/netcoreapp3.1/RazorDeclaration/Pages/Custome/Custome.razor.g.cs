#pragma checksum "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Custome\Custome.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cee45d177f598ca8180fadd0411506b451d576e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Complementar20201.Pages.Custome
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using Complementar20201;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\_Imports.razor"
using Complementar20201.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Custome\Custome.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Customer")]
    public partial class Custome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Custome\Custome.razor"
      
    complementar20201Context db = new complementar20201Context();

    private List<Customers> customers;

    protected override void OnInitialized()
    {
        customers = db.Customers.ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
