#pragma checksum "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93eb6cbfbe515c6b97aaa5b0625d6c788a3619d8", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abf4191d96717c1f51db5223c3d399b79e8aab3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/_assets/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/_assets/css/sb-admin-2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/_assets/css/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_assets/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_assets/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_assets/js/jquery.easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_assets/js/sb-admin-2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d88045", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 254, "\"", 264, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 291, "\"", 301, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>");
#nullable restore
#line 12 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d89147", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\"\r\n          rel=\"stylesheet\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d810578", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d811758", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 19 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Shared\_Layout.cshtml"
Write(RenderSection("styles", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d813910", async() => {
                WriteLiteral("\r\n\r\n    <div id=\"wrapper\">\r\n        ");
#nullable restore
#line 26 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("_Menu"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div id=""content-wrapper"" class=""d-flex flex-column"">

            <div id=""content"">

                <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

                    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
                        <i class=""fa fa-bars""></i>
                    </button>


                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item dropdown no-arrow d-sm-none"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-search fa-fw""></i>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                                 aria-labelledby=""searchDropdown"">
                ");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d815576", async() => {
                    WriteLiteral(@"
                                    <div class=""input-group"">
                                        <input type=""text"" class=""form-control bg-light border-0 small""
                                               placeholder=""Search for..."" aria-label=""Search""
                                               aria-describedby=""basic-addon2"">
                                        <div class=""input-group-append"">
                                            <button class=""btn btn-primary"" type=""button"">
                                                <i class=""fas fa-search fa-sm""></i>
                                            </button>
                                        </div>
                                    </div>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </li>

                        <li class=""nav-item dropdown no-arrow mx-1"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-bell fa-fw""></i>
                                <span class=""badge badge-danger badge-counter"">3+</span>
                            </a>
                            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""alertsDropdown"">
                                <h6 class=""dropdown-header"">
                                    Alerts Center
                                </h6>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
");
                WriteLiteral(@"                                        <div class=""icon-circle bg-primary"">
                                            <i class=""fas fa-file-alt text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 12, 2019</div>
                                        <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-success"">
                                            <i class=""fas fa-donate text-white""></i>
                                        </div>
                                    </div>
               ");
                WriteLiteral(@"                     <div>
                                        <div class=""small text-gray-500"">December 7, 2019</div>
                                        $290.29 has been deposited into your account!
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""mr-3"">
                                        <div class=""icon-circle bg-warning"">
                                            <i class=""fas fa-exclamation-triangle text-white""></i>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""small text-gray-500"">December 2, 2019</div>
                                        Spending Alert: We've noticed unusually high spending for your account.
                                    </div>
             ");
                WriteLiteral(@"                   </a>
                                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
                            </div>
                        </li>
                        <li class=""nav-item dropdown no-arrow mx-1"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-envelope fa-fw""></i>
                                <span class=""badge badge-danger badge-counter"">7</span>
                            </a>
                            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""messagesDropdown"">
                                <h6 class=""dropdown-header"">
                                    Message Center
                                </h6>
  ");
                WriteLiteral(@"                              <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""img/undraw_profile_1.svg""
                                             alt=""..."">
                                        <div class=""status-indicator bg-success""></div>
                                    </div>
                                    <div class=""font-weight-bold"">
                                        <div class=""text-truncate"">
                                            Hi there! I am wondering if you can help me with a
                                            problem I've been having.
                                        </div>
                                        <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                                    </div>
                                </a>
                                <");
                WriteLiteral(@"a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""img/undraw_profile_2.svg""
                                             alt=""..."">
                                        <div class=""status-indicator""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            I have the photos that you ordered last month, how
                                            would you like them sent to you?
                                        </div>
                                        <div class=""small text-gray-500"">Jae Chun · 1d</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
    ");
                WriteLiteral(@"                                <div class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""img/undraw_profile_3.svg""
                                             alt=""..."">
                                        <div class=""status-indicator bg-warning""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            Last month's report looks great, I am very happy with
                                            the progress so far, keep up the good work!
                                        </div>
                                        <div class=""small text-gray-500"">Morgan Alvarez · 2d</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                                    <d");
                WriteLiteral(@"iv class=""dropdown-list-image mr-3"">
                                        <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""
                                             alt=""..."">
                                        <div class=""status-indicator bg-success""></div>
                                    </div>
                                    <div>
                                        <div class=""text-truncate"">
                                            Am I a good boy? The reason I ask is because someone
                                            told me that people say this to all dogs, even if they aren't good...
                                        </div>
                                        <div class=""small text-gray-500"">Chicken the Dog · 2w</div>
                                    </div>
                                </a>
                                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a");
                WriteLiteral(@">
                            </div>
                        </li>

                        <div class=""topbar-divider d-none d-sm-block""></div>

                        <li class=""nav-item dropdown no-arrow"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
                               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Douglas McGee</span>
                                <img class=""img-profile rounded-circle""
                                     src=""img/undraw_profile.svg"">
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                                 aria-labelledby=""userDropdown"">
                                <a class=""dropdown-item""");
                BeginWriteAttribute("href", " href=\"", 11869, "\"", 11904, 1);
#nullable restore
#line 190 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 11876, Url.Action("Logout","Home"), 11876, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                    Logout
                                </a>
                            </div>
                        </li>
                    </ul>
                </nav>

                ");
#nullable restore
#line 199 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            </div>
            <footer class=""sticky-footer bg-white"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright &copy; Okan Demir Youtube Kanalına Abone Olmayı Unutmayın</span>
                    </div>
                </div>
            </footer>
        </div>
    </div>

    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d828870", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d829970", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d831070", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93eb6cbfbe515c6b97aaa5b0625d6c788a3619d832170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 221 "C:\Users\Eren\Desktop\Projem\ProjeVek\ProjeVek.WebUI.Management\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
