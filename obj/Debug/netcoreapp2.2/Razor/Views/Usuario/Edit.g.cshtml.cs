#pragma checksum "C:\Users\Otoniel\Downloads\MVCBD\Views\Usuario\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae141add43c6f7b2ef3970982512fed4f72b3e33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Edit), @"mvc.1.0.view", @"/Views/Usuario/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Edit.cshtml", typeof(AspNetCore.Views_Usuario_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae141add43c6f7b2ef3970982512fed4f72b3e33", @"/Views/Usuario/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316a38b4d10506dd3c5806f0c1482c9e56381aad", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCBD.Db.user>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditSave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Otoniel\Downloads\MVCBD\Views\Usuario\Edit.cshtml"
  
    ViewData["Title"] = "Editar Rol Page";

#line default
#line hidden
            BeginContext(51, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(77, 109, true);
            WriteLiteral("\r\n<h1>Title</h1>\r\n\r\n    <div class =\"text-center\">\r\n        <h1 class=\"display-4\">Editar Rol</h1>\r\n\r\n        ");
            EndContext();
            BeginContext(186, 403, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae141add43c6f7b2ef3970982512fed4f72b3e334241", async() => {
                BeginContext(228, 60, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"userid\" id=\"userid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 288, "\"", 312, 1);
#line 14 "C:\Users\Otoniel\Downloads\MVCBD\Views\Usuario\Edit.cshtml"
WriteAttributeValue("", 296, Model.idUsuario, 296, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(313, 71, true);
                WriteLiteral(">\r\n            Nombre: <input type=\"text\" name=\"username\" id=\"username\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 384, "\"", 412, 1);
#line 15 "C:\Users\Otoniel\Downloads\MVCBD\Views\Usuario\Edit.cshtml"
WriteAttributeValue("", 392, Model.nombreUsuario, 392, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(413, 73, true);
                WriteLiteral(">\r\n            Password: <input type=\"text\" name=\"userpass\" id=\"userpass\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 486, "\"", 518, 1);
#line 16 "C:\Users\Otoniel\Downloads\MVCBD\Views\Usuario\Edit.cshtml"
WriteAttributeValue("", 494, Model.contraseñaUsuario, 494, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(519, 63, true);
                WriteLiteral(">\r\n            <button type=\"submit\">Guardar</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(589, 14, true);
            WriteLiteral("\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCBD.Db.user> Html { get; private set; }
    }
}
#pragma warning restore 1591