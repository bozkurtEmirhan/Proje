#pragma checksum "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d123afe9cef8c5757c89a626392390b05b60911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Add), @"mvc.1.0.view", @"/Views/Author/Add.cshtml")]
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
#line 2 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\_ViewImports.cshtml"
using ProjeVek.WebUI.Management.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\_ViewImports.cshtml"
using ProjeVek.WebUI.Management.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d123afe9cef8c5757c89a626392390b05b60911", @"/Views/Author/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abf4191d96717c1f51db5223c3d399b79e8aab3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Author_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjeVek.Model.Author>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Author/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml"
  
    ViewBag.Title = "Yazar Ekle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">Yazar Ekle</h1>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 253, "\"", 289, 1);
#nullable restore
#line 10 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml"
WriteAttributeValue("", 260, Url.Action("Index","Author"), 260, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary shadow-sm\">Listeye Dön</a>\r\n    </div>\r\n    <p class=\"mb-4\">\r\n        Burada yeni Yazar eklerim\r\n    </p>\r\n\r\n    ");
#nullable restore
#line 16 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml"
Write(Html.Raw(ViewResultExtension.ViewResult(ViewBag.Result)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"card shadow mb-4\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d123afe9cef8c5757c89a626392390b05b609115500", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" class=\"form-control form-control-user\" placeholder=\"Adı Soyadı\" name=\"Fullname\"");
                BeginWriteAttribute("value", " value=\"", 779, "\"", 802, 1);
#nullable restore
#line 22 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml"
WriteAttributeValue("", 787, Model.Fullname, 787, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" class=\"form-control form-control-user\" placeholder=\"Mail\" name=\"Mail\"");
                BeginWriteAttribute("value", " value=\"", 980, "\"", 999, 1);
#nullable restore
#line 25 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml"
WriteAttributeValue("", 988, Model.Mail, 988, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" class=\"form-control form-control-user\" placeholder=\"Username\" name=\"Username\"");
                BeginWriteAttribute("value", " value=\"", 1185, "\"", 1208, 1);
#nullable restore
#line 28 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml"
WriteAttributeValue("", 1193, Model.Username, 1193, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" class=\"form-control form-control-user\" placeholder=\"Password\" name=\"Password\"");
                BeginWriteAttribute("value", " value=\"", 1394, "\"", 1417, 1);
#nullable restore
#line 31 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml"
WriteAttributeValue("", 1402, Model.Password, 1402, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group row\">\r\n                    <label class=\"col-form-label col-lg-2 text-right\">Aktif Mi?</label>\r\n                    <div class=\"col-lg-10\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Author\Add.cshtml"
                   Write(Html.CheckBoxFor(a => a.IsActive, new { @class = "checkbox" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\" class=\"btn btn-success\">Ekle</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ProjeVek.WebUI.Infrastructure.Cache.CacheHelper cache { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjeVek.Model.Author> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591