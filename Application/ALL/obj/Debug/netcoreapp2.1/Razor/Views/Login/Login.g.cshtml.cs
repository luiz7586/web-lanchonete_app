#pragma checksum "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "395d0beed335fd9c20df65dd2a09d8d25a6ef3d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
#line 1 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\_ViewImports.cshtml"
using ALL;

#line default
#line hidden
#line 2 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\_ViewImports.cshtml"
using ALL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"395d0beed335fd9c20df65dd2a09d8d25a6ef3d3", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90597326e78a91b250c66ab392edcec7e0539320", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(62, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 75, "\"", 121, 1);
#line 7 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 81, Url.Content("~/js/jquery-3.2.1.min.js"), 81, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(122, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 145, "\"", 185, 1);
#line 8 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 151, Url.Content("~/js/popper.min.js"), 151, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(186, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 209, "\"", 252, 1);
#line 9 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 215, Url.Content("~/js/bootstrap.min.js"), 215, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(253, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 276, "\"", 322, 1);
#line 10 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 282, Url.Content("~/js/owl.carousel.min.js"), 282, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(323, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 346, "\"", 396, 1);
#line 11 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 352, Url.Content("~/js/jquery.waypoints.min.js"), 352, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(397, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 420, "\"", 453, 1);
#line 12 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 426, Url.Content("~/js/aos.js"), 426, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(454, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 477, "\"", 532, 1);
#line 13 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 483, Url.Content("~/js/jquery.magnific-popup.min.js"), 483, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(533, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 556, "\"", 608, 1);
#line 14 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 562, Url.Content("~/js/magnific-popup-options.js"), 562, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(609, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 632, "\"", 666, 1);
#line 15 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
WriteAttributeValue("", 638, Url.Content("~/js/main.js"), 638, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(667, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
                BeginContext(683, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df2b487add884824ab120d1fd2f6f88c", async() => {
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
                EndContext();
                BeginContext(731, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(736, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 21 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
 if (ViewBag.Usuario == null || ViewBag.UsuarioInvalido == true)
{

#line default
#line hidden
            BeginContext(811, 714, true);
            WriteLiteral(@"    <div>
        <section>
            <div style=""background-image: url('https://images.unsplash.com/photo-1498654896293-37aacf113fd9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80'); background-repeat: no-repeat; background-position: center; background-size: cover"">
                <div class=""container"">
                    <div class=""row slider-text align-items-center justify-content-center"">
                        <div class=""col-md-8 text-center col-sm-12 "">
                            <div class=""limiter"">
                                <div class=""container-login100"">
                                    <div class=""wrap-login100 p-l-50 p-r-50 p-t-77 p-b-30"">
");
            EndContext();
#line 32 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
                                         if (ViewBag.UsuarioInvalido == true)
                                        {

#line default
#line hidden
            BeginContext(1647, 199, true);
            WriteLiteral("                                            <div>\r\n                                                Usuário e/ou senha inválidos. Tente novamente.\r\n                                            </div>\r\n");
            EndContext();
#line 37 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1889, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1929, 2836, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4e9fb383fb490fa9071b45f8b40f80", async() => {
                BeginContext(1985, 2773, true);
                WriteLiteral(@"
                                            <span class=""login100-form-title p-b-55"">
                                                Login
                                            </span>

                                            <div class=""wrap-input100 validate-input m-b-16"" data-validate=""Valid email is required: ex@abc.xyz"">
                                                <input class=""input100"" type=""text"" name=""email"" placeholder=""Email"">
                                                <span class=""focus-input100""></span>
                                                <span class=""symbol-input100"">
                                                    <span class=""lnr lnr-envelope""></span>
                                                </span>
                                            </div>

                                            <div class=""wrap-input100 validate-input m-b-16"" data-validate=""Password is required"">
                                                <input cla");
                WriteLiteral(@"ss=""input100"" type=""password"" name=""pass"" placeholder=""Password"">
                                                <span class=""focus-input100""></span>
                                                <span class=""symbol-input100"">
                                                    <span class=""lnr lnr-lock""></span>
                                                </span>
                                            </div>

                                            <div class=""container-login100-form-btn p-t-25"">
                                                <button class=""login100-form-btn"">
                                                    Login
                                                </button>
                                            </div>
                                            <div class=""google btn"">
                                                <a href=""#"">
                                                    <i class=""fa fa-google fa-fw"">
                            ");
                WriteLiteral(@"                        </i> Google
                                                </a>
                                            </div>

                                            <div class=""text-center w-full p-t-115"">
                                                <span class=""txt1"">
                                                    Não é cadastrado?
                                                </span>

                                                <a class=""txt1 bo1 hov1"" href=""#"">
                                                    Cadastre-se
                                                </a>
                                            </div>
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4765, 287, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- END slider -->
    </div>
");
            EndContext();
#line 91 "D:\Metrocamp\web-lanchonete_app\Application\ALL\Views\Login\Login.cshtml"
}

#line default
#line hidden
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
