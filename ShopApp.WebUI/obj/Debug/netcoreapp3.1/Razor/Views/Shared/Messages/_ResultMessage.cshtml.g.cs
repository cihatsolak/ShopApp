#pragma checksum "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\Shared\Messages\_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f925729da8a0f5253c271ebddfa6e28f8536b6c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Messages__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/Messages/_ResultMessage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Core.Domain.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models.Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models.ResultMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models.Carts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models.Orders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f925729da8a0f5253c271ebddfa6e28f8536b6c5", @"/Views/Shared/Messages/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515e010b38500170981a51a81dac0f7df78fad30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Messages__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\" id=\"result-message\">\r\n    <div class=\"col-md-12\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 104, "\"", 135, 3);
            WriteAttributeValue("", 112, "alert", 112, 5, true);
            WriteAttributeValue(" ", 117, "alert-", 118, 7, true);
#nullable restore
#line 5 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\Shared\Messages\_ResultMessage.cshtml"
WriteAttributeValue("", 124, Model.Type, 124, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h4 class=\"alert-title\">");
#nullable restore
#line 6 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\Shared\Messages\_ResultMessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p>");
#nullable restore
#line 7 "C:\Users\CihatSolak\source\repos\ShopApp\ShopApp.WebUI\Views\Shared\Messages\_ResultMessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
