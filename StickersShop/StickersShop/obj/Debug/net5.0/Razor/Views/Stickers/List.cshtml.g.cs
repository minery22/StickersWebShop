#pragma checksum "C:\Users\selde\source\repos\MountaineeringProject\MountaineeringProject\Views\Stickers\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e177d5ed8aa181c85cac44ca3d2d54ae11006806"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stickers_List), @"mvc.1.0.view", @"/Views/Stickers/List.cshtml")]
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
#line 1 "C:\Users\selde\source\repos\MountaineeringProject\MountaineeringProject\Views\_ViewImports.cshtml"
using StickersShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selde\source\repos\MountaineeringProject\MountaineeringProject\Views\_ViewImports.cshtml"
using StickersShop.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e177d5ed8aa181c85cac44ca3d2d54ae11006806", @"/Views/Stickers/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ab745fa975f4cdf71d524a8c5046177723583f", @"/Views/_ViewImports.cshtml")]
    public class Views_Stickers_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <h1>Все модели</h1>\r\n    <div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 5 "C:\Users\selde\source\repos\MountaineeringProject\MountaineeringProject\Views\Stickers\List.cshtml"
          
            foreach (Sticker sticker in Model.Allstickers) //перебираем обьект
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\selde\source\repos\MountaineeringProject\MountaineeringProject\Views\Stickers\List.cshtml"
        Write(Html.Partial("Allstickers", sticker));

#line default
#line hidden
#nullable disable
            WriteLiteral("     </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
