#pragma checksum "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72e3e99abf59fb7ad6d901b72e3d88c70132df93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
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
#line 2 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\_ViewImports.cshtml"
using ProjeVek.WebUI.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72e3e99abf59fb7ad6d901b72e3d88c70132df93", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb5389188d58f39ec74d16cd10300d13ae788e1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_assets/images/person_1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Free HTML5 by FreeHTMl5.co"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Content\Index.cshtml"
  
    ViewBag.Title = Model.Content.MetaTitle;
    var media = Model.Content.Media;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n\r\n    <style>\r\n        #fh5co-title-box {\r\n            position: relative;\r\n            height: 700px;\r\n            width: 100%;\r\n        }\r\n\r\n        .description img {\r\n            max-width: 100%;\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<div id=\"fh5co-title-box\"");
            BeginWriteAttribute("style", " style=\"", 394, "\"", 522, 4);
            WriteAttributeValue("", 402, "background-image:", 402, 17, true);
            WriteAttributeValue(" ", 419, "url(", 420, 5, true);
#nullable restore
#line 23 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Content\Index.cshtml"
WriteAttributeValue("", 424, Html.Raw(media != null ? "'"+media.MediaUrl+"'" : "/_assets/images/camila-cordeiro-114636.jpg"), 424, 96, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 520, ");", 520, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"overlay\"></div>\r\n    <div class=\"page-title\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72e3e99abf59fb7ad6d901b72e3d88c70132df935358", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span>");
#nullable restore
#line 27 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Content\Index.cshtml"
         Write(Model.Content.PublishDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <h2>");
#nullable restore
#line 28 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Content\Index.cshtml"
       Write(Model.Content.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    </div>
</div>
<div id=""fh5co-single-content"" class=""container-fluid pb-4 pt-4 paddding"">
    <div class=""container paddding"">
        <div class=""row mx-0"">
            <div class=""col-md-8 animate-box description"" data-animate-effect=""fadeInLeft"">
                ");
#nullable restore
#line 35 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Content\Index.cshtml"
           Write(Html.Raw(Model.Content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            ");
#nullable restore
#line 37 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Content\Index.cshtml"
       Write(await Html.PartialAsync("_SideBar"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
