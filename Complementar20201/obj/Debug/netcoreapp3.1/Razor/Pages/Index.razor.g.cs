#pragma checksum "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da3b3596e078d51040a3feee9f82551af71beb6c"
// <auto-generated/>
#pragma warning disable 1591
namespace Complementar20201.Pages
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
#line 2 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-10");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, @"<thead>
                <tr>
                    <th>Product Id</th>
                    <th>Product Name</th>
                    <th>Brand</th>
                    <th>Category</th>
                    <th>Model Year</th>
                    <th>List Price</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 20 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
                 foreach (var product in products)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                    ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 23 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
                             product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 24 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
                             product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 25 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
                             product.BrandId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 26 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
                             product.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 27 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
                             product.ModelYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 28 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
                             product.ListPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 30 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Index.razor"
      
    complementar20201Context db = new complementar20201Context();

    private List<Products> products;

    protected override void OnInitialized()
    {
        products = db.Products.ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
