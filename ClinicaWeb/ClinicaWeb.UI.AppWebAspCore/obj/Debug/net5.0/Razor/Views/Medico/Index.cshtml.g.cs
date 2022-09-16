#pragma checksum "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b291d0b0e22678bb936ce57726ee2e77dc38f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medico_Index), @"mvc.1.0.view", @"/Views/Medico/Index.cshtml")]
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
#line 1 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\_ViewImports.cshtml"
using ClinicaWeb.UI.AppWebAspCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\_ViewImports.cshtml"
using ClinicaWeb.UI.AppWebAspCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b291d0b0e22678bb936ce57726ee2e77dc38f4", @"/Views/Medico/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02650245d6e45f792e789e593fa16de3395c8add", @"/Views/_ViewImports.cshtml")]
    public class Views_Medico_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicaWeb.EntidadesDeNegocio.Medico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int numPage = 1;
    int numRegistros = 0;
    int numRegistrosPorPage = 10;
    int[] tops = { 10, 20, 50, 100, 500, 1000, 10000, -1 };
    int topActual = Convert.ToInt32(ViewBag.Top);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de Medicos</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b291d0b0e22678bb936ce57726ee2e77dc38f45169", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""form-group"">
                        <label class=""control-label"">Nombre</label>
                        <input type=""text"" class=""form-control"" name=""Nombre"" />
                    </div>
                </div>
                <div class=""col-md-2"">
                    <div class=""form-group"">
                        <label class=""control-label"">Top</label>
                        <select name=""Top_aux"" class=""form-control"">
");
#nullable restore
#line 28 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                             foreach (var item in tops)
                            {
                                string strItem = item != -1 ? item.ToString() : "Todos";
                                if (item != topActual)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b291d0b0e22678bb936ce57726ee2e77dc38f46524", async() => {
#nullable restore
#line 33 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                                     Write(strItem);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                       WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b291d0b0e22678bb936ce57726ee2e77dc38f48836", async() => {
#nullable restore
#line 37 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                                              Write(strItem);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                                WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Buscar\" class=\"btn btn-primary\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b291d0b0e22678bb936ce57726ee2e77dc38f411672", async() => {
                    WriteLiteral("Agregar Medico");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<table class=\"table table-striped paginationjs\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Especialidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Acciones\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 73 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr data-page=\"");
#nullable restore
#line 75 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                      Write(numPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Especialidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"botonestabla\">\r\n                    ");
#nullable restore
#line 89 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
               Write(Html.ActionLink("Modificar", "Edit", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 90 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
               Write(Html.ActionLink("Detalles", "Details", new { id = item.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 91 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
               Write(Html.ActionLink("Eliminar", "Delete", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 94 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
            numRegistros++;
            if (numRegistros == numRegistrosPorPage)
            {
                numPage++;
                numRegistros = 0;
            }

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
          
            if (numRegistros == 0)
            {
                numPage--;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 111 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
 if (numPage > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"overflow: auto\">\r\n        <div class=\"col-md-12\">\r\n            <ul class=\"pagination paginationjs\" data-numpage=\"");
#nullable restore
#line 115 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                                         Write(numPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                data-pageactive=\"1\">\r\n                <li class=\"page-item\" data-typepage=\"Previous\">\r\n                    <a class=\"page-link\" href=\"#\">Anterior</a>\r\n                </li>\r\n");
#nullable restore
#line 120 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                 for (var i = 1; i <= numPage; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\" data-page=\"");
#nullable restore
#line 122 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-typepage=\"Item\">\r\n                        <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 123 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n");
#nullable restore
#line 125 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\" data-typepage=\"Next\">\r\n                    <a class=\"page-link\" href=\"#\">Siguiente</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 132 "C:\Users\marlo\OneDrive\Escritorio\ClinicaWeb\ClinicaWeb\ClinicaWeb.UI.AppWebAspCore\Views\Medico\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicaWeb.EntidadesDeNegocio.Medico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
