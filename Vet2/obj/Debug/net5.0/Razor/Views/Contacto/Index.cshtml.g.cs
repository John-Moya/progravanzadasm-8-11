#pragma checksum "C:\Users\jmari\Desktop\SC-701 Programación Avanzada en Web_Ajustado\Proyectos\Vet2\Vet2\Views\Contacto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f2074120f136aa24c010b16c9579a14fe561e7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacto_Index), @"mvc.1.0.view", @"/Views/Contacto/Index.cshtml")]
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
#line 1 "C:\Users\jmari\Desktop\SC-701 Programación Avanzada en Web_Ajustado\Proyectos\Vet2\Vet2\Views\_ViewImports.cshtml"
using Vet2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jmari\Desktop\SC-701 Programación Avanzada en Web_Ajustado\Proyectos\Vet2\Vet2\Views\_ViewImports.cshtml"
using Vet2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2074120f136aa24c010b16c9579a14fe561e7c", @"/Views/Contacto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af1d407e11c5a130f16b61c8a14e0badc47ece5", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jmari\Desktop\SC-701 Programación Avanzada en Web_Ajustado\Proyectos\Vet2\Vet2\Views\Contacto\Index.cshtml"
  
    ViewData["Title"] = "Contacto";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Contacto</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2074120f136aa24c010b16c9579a14fe561e7c3902", async() => {
                WriteLiteral("\r\n    <h3>\r\n        Contactenos\r\n    </h3>\r\n    <div>\r\n        <br><br>\r\n        <div id=\"caption\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f2074120f136aa24c010b16c9579a14fe561e7c4285", async() => {
                    WriteLiteral(@"
                <div>
                    <div>
                        <label for=""inputComentarias"">Email</label>
                        <input type=""email"" class=""form-control"" id=""inputEmail4"" placeholder=""Email"">
                    </div>
                </div>
                <div>
                    <div>
                        <label for=""inputComentarias"">Nombre</label>
                        <input type=""text"" class=""form-control"" placeholder=""Nombre"">
                    </div>
                </div>
                <div>
                    <div>
                        <label for=""inputComentarias"">Telefono</label>
                        <input type=""text"" class=""form-control"" placeholder=""Telefono"">
                    </div>
                </div>
                <div>
                    <div>
                        <label for=""inputComentarias"">Comentarios/Dudas/Consultas</label>
                        <input type=""text"" class=""form-control"" id=""inputComentarias");
                    WriteLiteral("\">\r\n                    </div>\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <br><br>
        <h3>Localizanos</h3>
        <div id=""caption"">
            <br>
            <iframe id=""ayuda"" src=""https://www.google.com/maps/embed?pb=!1m21!1m12!1m3!1d832.4422828853802!2d-84.24497218309762!3d10.075022625738624!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!4m6!3e6!4m0!4m3!3m2!1d10.0749335!2d-84.2450118!5e1!3m2!1sen!2sus!4v1457613297629"" width=""400"" height=""200"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
        </div>
        <br><br>
        <h3>Redes Sociales</h3>
        <div id=""caption"">
            <br>
            <img id=""ayuda"" src=""https://www.pinclipart.com/picdir/middle/2-21918_download-transparent-background-facebook-logo-clipart-facebook-logo.png"" width=""50"" height=""50""></img>
        </div>
        <br><br>
        <h3>Correo Electronico</h3>
        <div id=""caption"">
            <p id=""text"">vetmaskoteando@gmail.com</p>
        </div>
        <br><br>
        <h3>Telefono</h3>
        <div id=""caption"">
            <");
                WriteLiteral("p id=\"text\">Cel: 84093337</p>\r\n        </div>\r\n        <br><br>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
