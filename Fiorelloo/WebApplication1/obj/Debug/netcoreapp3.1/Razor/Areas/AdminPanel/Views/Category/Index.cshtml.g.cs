#pragma checksum "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7b9b3642d21977b55115ad155dcdac9718f2327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Category_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7b9b3642d21977b55115ad155dcdac9718f2327", @"/Areas/AdminPanel/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cccbb409348a6e5db2246aa1e093baa1ac1213a9", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/img/team-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar avatar-sm  me-3 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/img/small-logos/logo-spotify.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar avatar-sm bg-gradient-dark  me-3 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link text-danger text-gradient px-3 mb-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link text-dark px-3 mb-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-round create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<main class=""main-content position-relative max-height-vh-100 h-100 border-radius-lg "">
    <!-- Navbar -->
    <nav class=""navbar navbar-main navbar-expand-lg px-0 mx-4 shadow-none border-radius-xl"" id=""navbarBlur"" navbar-scroll=""true"">
        <div class=""container-fluid py-1 px-3"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb bg-transparent mb-0 pb-0 pt-1 px-0 me-sm-6 me-5"">
                    <li class=""breadcrumb-item text-sm""><a class=""opacity-5 text-dark"" href=""javascript:;"">Pages</a></li>
                    <li class=""breadcrumb-item text-sm text-dark active"" aria-current=""page"">Tables</li>
                </ol>
                <h6 class=""font-weight-bolder mb-0"">Tables</h6>
            </nav>
            <div class=""collapse navbar-collapse mt-sm-0 mt-2 me-md-0 me-sm-4"" id=""navbar"">
                <div class=""ms-md-auto pe-md-3 d-flex align-items-center"">
                    <div class=""input-group input-group-outline"">
                        <labe");
            WriteLiteral(@"l class=""form-label"">Type here...</label>
                        <input type=""text"" class=""form-control"">
                    </div>
                </div>
                <ul class=""navbar-nav  justify-content-end"">
                    <li class=""nav-item d-flex align-items-center"">
                        <a href=""javascript:;"" class=""nav-link text-body font-weight-bold px-0"">
                            <i class=""fa fa-user me-sm-1""></i>
                            <span class=""d-sm-inline d-none"">Sign In</span>
                        </a>
                    </li>
                    <li class=""nav-item d-xl-none ps-3 d-flex align-items-center"">
                        <a href=""javascript:;"" class=""nav-link text-body p-0"" id=""iconNavbarSidenav"">
                            <div class=""sidenav-toggler-inner"">
                                <i class=""sidenav-toggler-line""></i>
                                <i class=""sidenav-toggler-line""></i>
                                <i class=""si");
            WriteLiteral(@"denav-toggler-line""></i>
                            </div>
                        </a>
                    </li>
                    <li class=""nav-item px-3 d-flex align-items-center"">
                        <a href=""javascript:;"" class=""nav-link text-body p-0"">
                            <i class=""fa fa-cog fixed-plugin-button-nav cursor-pointer""></i>
                        </a>
                    </li>
                    <li class=""nav-item dropdown pe-2 d-flex align-items-center"">
                        <a href=""javascript:;"" class=""nav-link text-body p-0"" id=""dropdownMenuButton"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""fa fa-bell cursor-pointer""></i>
                        </a>
                        <ul class=""dropdown-menu  dropdown-menu-end  px-2 py-3 me-sm-n4"" aria-labelledby=""dropdownMenuButton"">
                            <li class=""mb-2"">
                                <a class=""dropdown-item border-radius-md"" href=""javascrip");
            WriteLiteral("t:;\">\r\n                                    <div class=\"d-flex py-1\">\r\n                                        <div class=\"my-auto\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b7b9b3642d21977b55115ad155dcdac9718f232710677", async() => {
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
            WriteLiteral(@"
                                        </div>
                                        <div class=""d-flex flex-column justify-content-center"">
                                            <h6 class=""text-sm font-weight-normal mb-1"">
                                                <span class=""font-weight-bold"">New message</span> from Laur
                                            </h6>
                                            <p class=""text-xs text-secondary mb-0"">
                                                <i class=""fa fa-clock me-1""></i>
                                                13 minutes ago
                                            </p>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li class=""mb-2"">
                                <a class=""dropdown-item border-radius-md"" href=""javascript:;"">
                                    <d");
            WriteLiteral("iv class=\"d-flex py-1\">\r\n                                        <div class=\"my-auto\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b7b9b3642d21977b55115ad155dcdac9718f232713000", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                        <div class=""d-flex flex-column justify-content-center"">
                                            <h6 class=""text-sm font-weight-normal mb-1"">
                                                <span class=""font-weight-bold"">New album</span> by Travis Scott
                                            </h6>
                                            <p class=""text-xs text-secondary mb-0"">
                                                <i class=""fa fa-clock me-1""></i>
                                                1 day
                                            </p>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a class=""dropdown-item border-radius-md"" href=""javascript:;"">
                                    <div class=""d-flex p");
            WriteLiteral(@"y-1"">
                                        <div class=""avatar avatar-sm bg-gradient-secondary  me-3  my-auto"">
                                            <svg width=""12px"" height=""12px"" viewBox=""0 0 43 36"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                                                <title>credit-card</title>
                                                <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                                    <g transform=""translate(-2169.000000, -745.000000)"" fill=""#FFFFFF"" fill-rule=""nonzero"">
                                                        <g transform=""translate(1716.000000, 291.000000)"">
                                                            <g transform=""translate(453.000000, 454.000000)"">
                                                                <path class=""color-background"" d=""M43,10.7482083 L43,3.58333333 C43,1.60354167 41.3964583,0 39.4166667");
            WriteLiteral(@",0 L3.58333333,0 C1.60354167,0 0,1.60354167 0,3.58333333 L0,10.7482083 L43,10.7482083 Z"" opacity=""0.593633743""></path>
                                                                <path class=""color-background"" d=""M0,16.125 L0,32.25 C0,34.2297917 1.60354167,35.8333333 3.58333333,35.8333333 L39.4166667,35.8333333 C41.3964583,35.8333333 43,34.2297917 43,32.25 L43,16.125 L0,16.125 Z M19.7083333,26.875 L7.16666667,26.875 L7.16666667,23.2916667 L19.7083333,23.2916667 L19.7083333,26.875 Z M35.8333333,26.875 L28.6666667,26.875 L28.6666667,23.2916667 L35.8333333,23.2916667 L35.8333333,26.875 Z""></path>
                                                            </g>
                                                        </g>
                                                    </g>
                                                </g>
                                            </svg>
                                        </div>
                                        <div class=""d-flex flex-column justif");
            WriteLiteral(@"y-content-center"">
                                            <h6 class=""text-sm font-weight-normal mb-1"">
                                                Payment successfully completed
                                            </h6>
                                            <p class=""text-xs text-secondary mb-0"">
                                                <i class=""fa fa-clock me-1""></i>
                                                2 days
                                            </p>
                                        </div>
                                    </div>
                                </a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- End Navbar -->
    <div class=""container-fluid py-4"">
      
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card my-4"">
                    <div class=""card-head");
            WriteLiteral(@"er p-0 position-relative mt-n4 mx-3 z-index-2"">
                        <div class=""bg-gradient-primary shadow-primary border-radius-lg pt-4 pb-3"">
                            <h6 class=""text-white text-capitalize ps-3"">Categories table</h6>
                        </div>
                    </div>
                    <div class=""card-body px-0 pb-2"">
                        <div class=""table-responsive p-0"">
                            <table class=""table align-items-center justify-content-center mb-0"">
                                <thead>
                                    <tr>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">#</th>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Category Name</th>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Settings</th>
          ");
            WriteLiteral("                              <th></th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 240 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\Category\Index.cshtml"
                                     foreach (var ct in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                              ");
#nullable restore
#line 244 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\Category\Index.cshtml"
                                         Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <p class=\"text-sm font-weight-bold mb-0\">");
#nullable restore
#line 247 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\Category\Index.cshtml"
                                                                                    Write(ct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b9b3642d21977b55115ad155dcdac9718f232721082", async() => {
                WriteLiteral("<i class=\"material-icons text-sm me-2\" >delete</i>Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 250 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\Category\Index.cshtml"
                                                                                                                                   WriteLiteral(ct.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b9b3642d21977b55115ad155dcdac9718f232723532", async() => {
                WriteLiteral("<i class=\"material-icons text-sm me-2\">edit</i>Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 251 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\Category\Index.cshtml"
                                                                                                                   WriteLiteral(ct.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 255 "C:\Users\Hp\OneDrive\İş masası\DBf\Fiorelloo\WebApplication1\Areas\AdminPanel\Views\Category\Index.cshtml"
                                        count++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b9b3642d21977b55115ad155dcdac9718f232726441", async() => {
                WriteLiteral(" Create Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer class=""footer py-4  "">
            <div class=""container-fluid"">
                <div class=""row align-items-center justify-content-lg-between"">
                    <div class=""col-lg-6 mb-lg-0 mb-4"">
                        <div class=""copyright text-center text-sm text-muted text-lg-start"">
                            ©
                            <script>
                                document.write(new Date().getFullYear())
                            </script>,
                            made with <i class=""fa fa-heart""></i> by
                            <a href=""https://www.creative-tim.com"" class=""font-weight-bold"" target=""_blank"">Creative Tim</a>
                            for a better web.
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <ul class=""nav nav-footer justi");
            WriteLiteral(@"fy-content-center justify-content-lg-end"">
                            <li class=""nav-item"">
                                <a href=""https://www.creative-tim.com"" class=""nav-link text-muted"" target=""_blank"">Creative Tim</a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""https://www.creative-tim.com/presentation"" class=""nav-link text-muted"" target=""_blank"">About Us</a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""https://www.creative-tim.com/blog"" class=""nav-link text-muted"" target=""_blank"">Blog</a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""https://www.creative-tim.com/license"" class=""nav-link pe-0 text-muted"" target=""_blank"">License</a>
                            </li>
                        </ul>
                    </div>
                </div>
       ");
            WriteLiteral("     </div>\r\n        </footer>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
