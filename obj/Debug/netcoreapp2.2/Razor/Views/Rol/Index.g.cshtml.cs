#pragma checksum "C:\Users\Otoniel\Downloads\MVCBD\Views\Rol\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ef6d57b212d104acad2b4cb8bd7bd367b9ee48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rol_Index), @"mvc.1.0.view", @"/Views/Rol/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rol/Index.cshtml", typeof(AspNetCore.Views_Rol_Index))]
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
#line 1 "C:\Users\Otoniel\Downloads\MVCBD\Views\_ViewImports.cshtml"
using MVCBD;

#line default
#line hidden
#line 2 "C:\Users\Otoniel\Downloads\MVCBD\Views\_ViewImports.cshtml"
using MVCBD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1ef6d57b212d104acad2b4cb8bd7bd367b9ee48", @"/Views/Rol/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316a38b4d10506dd3c5806f0c1482c9e56381aad", @"/Views/_ViewImports.cshtml")]
    public class Views_Rol_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MVCBD.Db.rol>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Otoniel\Downloads\MVCBD\Views\Rol\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 96, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div class =\"text-center\">\r\n    <h1 class=\"display-4\">Roles</h1>\r\n    <ul>\r\n");
            EndContext();
#line 12 "C:\Users\Otoniel\Downloads\MVCBD\Views\Rol\Index.cshtml"
         foreach(MVCBD.Db.rol item in Model)
        {

#line default
#line hidden
            BeginContext(223, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(240, 10, false);
#line 14 "C:\Users\Otoniel\Downloads\MVCBD\Views\Rol\Index.cshtml"
           Write(item.idRol);

#line default
#line hidden
            EndContext();
            BeginContext(250, 2, true);
            WriteLiteral(" /");
            EndContext();
            BeginContext(253, 14, false);
#line 14 "C:\Users\Otoniel\Downloads\MVCBD\Views\Rol\Index.cshtml"
                        Write(item.nombreRol);

#line default
#line hidden
            EndContext();
            BeginContext(267, 8, true);
            WriteLiteral("></li>\r\n");
            EndContext();
#line 15 "C:\Users\Otoniel\Downloads\MVCBD\Views\Rol\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(286, 17, true);
            WriteLiteral("    </ul>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MVCBD.Db.rol>> Html { get; private set; }
    }
}
#pragma warning restore 1591
