#pragma checksum "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00afa7b338c847ca71bff818f8ec64b1ba85bfdd"
// <auto-generated/>
#pragma warning disable 1591
namespace Complementar20201.Pages.Funcionarios
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
#line 2 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Staffs")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Funcionários!</h1>\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
 if (staffs == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "Nenhum Cliente foi cadastrado no banco de dados");
#nullable restore
#line 9 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
                                                                
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-10");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, @"<thead>
                    <tr>
                        <th>Nome</th>
                        <th>Sobrenome</th>
                        <th>E-mail</th>
                        <th>Telefone</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 25 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
                     foreach (var staff in staffs)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                    ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 28 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
                             staff.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 29 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
                             staff.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 30 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
                             staff.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 31 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
                             staff.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-danger");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
                                                                       () => DeleteStaff(staff.StaffId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 36 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 41 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\wcwil\Desktop\Final Bonilha\FinalWeb20201\Complementar20201\Pages\Funcionarios\Index.razor"
      
    complementar20201Context db = new complementar20201Context();

    private List<Staffs> staffs;

    protected override void OnInitialized()
    {
        staffs = db.Staffs.ToList();
    }

    private async Task DeleteStaff(int Id)
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
