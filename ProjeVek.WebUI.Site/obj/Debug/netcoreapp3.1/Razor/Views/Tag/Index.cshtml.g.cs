#pragma checksum "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75283205f3622f350d8710cb363e4e041a967e14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_Index), @"mvc.1.0.view", @"/Views/Tag/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75283205f3622f350d8710cb363e4e041a967e14", @"/Views/Tag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb5389188d58f39ec74d16cd10300d13ae788e1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TagViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
  
    ViewBag.Title = "Kategori";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid pb-4 pt-4 paddding"">
    <div class=""container paddding"">
        <div class=""row mx-0"">
            <div class=""col-md-8 animate-box"" data-animate-effect=""fadeInLeft"">
                <div>
                    <div class=""fh5co_heading fh5co_heading_border_bottom py-2 mb-4"">");
#nullable restore
#line 11 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                                                                Write(Model.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                 foreach (var item in Model.Contents)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row pb-4\">\r\n                        <div class=\"col-md-5\">\r\n                            <div class=\"fh5co_hover_news_img\">\r\n                                <div class=\"fh5co_news_img\">\r\n");
#nullable restore
#line 20 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                     if (item.Media != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 858, "\"", 884, 1);
#nullable restore
#line 22 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
WriteAttributeValue("", 864, item.Media.MediaUrl, 864, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 885, "\"", 891, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 23 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img src=\"images/nathan-mcbride-229637.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1100, "\"", 1106, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 27 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div></div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-7 animate-box\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1394, "\"", 1457, 1);
#nullable restore
#line 33 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
WriteAttributeValue("", 1401, Url.Action("Index","Content", new { slug = item.Slug }), 1401, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fh5co_magna py-2\">\r\n                                ");
#nullable restore
#line 34 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a> <a");
            BeginWriteAttribute("href", " href=\"", 1566, "\"", 1629, 1);
#nullable restore
#line 35 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
WriteAttributeValue("", 1573, Url.Action("Index","Content", new { slug = item.Slug }), 1573, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fh5co_mini_time py-3\">\r\n");
#nullable restore
#line 36 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                 if (item.Author != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                               Write(item.Author.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>-</span>\r\n");
#nullable restore
#line 39 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 40 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                           Write(item.PublishDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                            <div class=\"fh5co_consectetur\">\r\n                                ");
#nullable restore
#line 43 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                           Write(item.MetaDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            ");
#nullable restore
#line 49 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
       Write(await Html.PartialAsync("_SideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
         if (Model.TotalPage > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mx-0\">\r\n                <div class=\"col-12 text-center pb-4 pt-4\">\r\n\r\n");
#nullable restore
#line 57 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                     if (Model.CurrentPage == 1)
                    {
                        var next = Model.CurrentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\" class=\"btn_pagging\">");
#nullable restore
#line 60 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                                   Write(Model.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2676, "\"", 2753, 1);
#nullable restore
#line 61 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
WriteAttributeValue("", 2683, Url.Action("Index","Tag", new { page = next, slug = Model.Tag.Slug }), 2683, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn_mange_pagging\">İleri <i class=\"fa fa-long-arrow-right\"></i></a>\r\n");
#nullable restore
#line 62 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                    }
                    else
                    {
                        if (Model.TotalPage > Model.CurrentPage)
                        {
                            var next = Model.CurrentPage + 1;
                            var prev = Model.CurrentPage - 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 3154, "\"", 3231, 1);
#nullable restore
#line 70 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
WriteAttributeValue("", 3161, Url.Action("Index","Tag", new { page = prev, slug = Model.Tag.Slug }), 3161, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn_mange_pagging\"><i class=\"fa fa-long-arrow-left\"></i> Geri</a>\r\n                            <a href=\"#\" class=\"btn_pagging\">");
#nullable restore
#line 71 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                                       Write(Model.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3421, "\"", 3498, 1);
#nullable restore
#line 72 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
WriteAttributeValue("", 3428, Url.Action("Index","Tag", new { page = next, slug = Model.Tag.Slug }), 3428, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn_mange_pagging\">İleri <i class=\"fa fa-long-arrow-right\"></i></a>\r\n");
#nullable restore
#line 73 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                        }
                        else
                        {
                            var prev = Model.CurrentPage - 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 3755, "\"", 3832, 1);
#nullable restore
#line 78 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
WriteAttributeValue("", 3762, Url.Action("Index","Tag", new { page = prev, slug = Model.Tag.Slug }), 3762, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn_mange_pagging\"><i class=\"fa fa-long-arrow-left\"></i> Geri</a>\r\n                            <a href=\"#\" class=\"btn_pagging\">");
#nullable restore
#line 79 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                                                       Write(Model.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 80 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 84 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Site\Views\Tag\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TagViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
