#pragma checksum "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9aeb576df256441956282fdbee45030cd80761f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout_ActorsAndMovies), @"mvc.1.0.view", @"/Views/Shared/_Layout_ActorsAndMovies.cshtml")]
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
#line 1 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\_ViewImports.cshtml"
using Ivanov_ASP.NET_04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\_ViewImports.cshtml"
using Ivanov_ASP.NET_04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9aeb576df256441956282fdbee45030cd80761f", @"/Views/Shared/_Layout_ActorsAndMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684302a393fc3a8db8132d48d0a99ae291cd61b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout_ActorsAndMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Actors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JQueryAjax", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-layout home_page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image: url(/images/about-bg2.jpg)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aeb576df256441956282fdbee45030cd80761f6241", async() => {
                WriteLiteral(@"
    <!-- basic -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- mobile metas -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""viewport"" content=""initial-scale=1, maximum-scale=1"">
    <!-- site metas -->
    <title>Ivanov AjaxDBFirst</title>
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 413, "\"", 423, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 455, "\"", 465, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 492, "\"", 502, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!-- bootstrap css -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 560, "\'", 606, 1);
#nullable restore
#line 17 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 567, Url.Content("~/css/bootstrap.min.css"), 567, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!-- style css -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 660, "\'", 698, 1);
#nullable restore
#line 19 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 667, Url.Content("~/css/style.css"), 667, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!-- Responsive-->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 752, "\'", 795, 1);
#nullable restore
#line 21 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 759, Url.Content("~/css/responsive.css"), 759, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!-- fevicon -->\r\n    <link rel=\"icon\"");
                BeginWriteAttribute("href", " href=\'", 841, "\'", 884, 1);
#nullable restore
#line 23 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 848, Url.Content("~/images/fevicon.png"), 848, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"image/gif\" />\r\n    <!-- Scrollbar Custom CSS -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 968, "\'", 1028, 1);
#nullable restore
#line 25 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 975, Url.Content("~/css/jquery.mCustomScrollbar.min.css"), 975, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!--Bootstrap and CSS from Layout_old-->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 1104, "\'", 1169, 1);
#nullable restore
#line 27 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1111, Url.Content("~/lib/bootstrap/dist/css/bootstrap.min.css"), 1111, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\'", 1201, "\'", 1238, 1);
#nullable restore
#line 28 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1208, Url.Content("~/css/site.css"), 1208, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <!-- Javascript files-->\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1287, "\'", 1327, 1);
#nullable restore
#line 31 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1293, Url.Content("~/js/jquery.min.js"), 1293, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1351, "\'", 1391, 1);
#nullable restore
#line 32 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1357, Url.Content("~/js/popper.min.js"), 1357, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1415, "\'", 1465, 1);
#nullable restore
#line 33 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1421, Url.Content("~/js/bootstrap.bundle.min.js"), 1421, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1489, "\'", 1535, 1);
#nullable restore
#line 34 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1495, Url.Content("~/js/jquery-3.0.0.min.js"), 1495, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1559, "\'", 1595, 1);
#nullable restore
#line 35 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1565, Url.Content("~/js/plugin.js"), 1565, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- sidebar -->\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1641, "\'", 1705, 1);
#nullable restore
#line 37 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1647, Url.Content("~/js/jquery.mCustomScrollbar.concat.min.js"), 1647, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1729, "\'", 1765, 1);
#nullable restore
#line 38 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1735, Url.Content("~/js/custom.js"), 1735, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1789, "\'", 1842, 1);
#nullable restore
#line 39 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1795, Url.Content("~/lib/jquery/dist/jquery.min.js"), 1795, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1866, "\'", 1935, 1);
#nullable restore
#line 40 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 1872, Url.Content("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), 1872, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aeb576df256441956282fdbee45030cd80761f15176", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
     WriteLiteral(Url.Content("~/js/site.js"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 41 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 2043, "\'", 2121, 1);
#nullable restore
#line 42 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 2049, Url.Content("~/lib/jquery-ajax-unobtrusive/jquery.unobtrusive-ajax.js"), 2049, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
#nullable restore
#line 43 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

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
            WriteLiteral("\r\n<!-- body -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aeb576df256441956282fdbee45030cd80761f18890", async() => {
                WriteLiteral(@"
    <header>
        <div class=""header"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-3 col-lg-3 col-md-3 col-sm-3 col logo_section"">
                        <div class=""full"">
                            <div class=""center-desk"">
                                <div class=""logo""> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aeb576df256441956282fdbee45030cd80761f19516", async() => {
                    WriteLiteral("<img");
                    BeginWriteAttribute("src", " src=\'", 2724, "\'", 2762, 1);
#nullable restore
#line 55 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
WriteAttributeValue("", 2730, Url.Content("/images/logo.png"), 2730, 32, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" alt=\"#\">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-9 col-lg-9 col-md-9 col-sm-9"">
                        <div class=""menu-area"">
                            <div class=""limit-box"">
                                <nav class=""main-menu"">
                                    <ul class=""menu-area-main"">
                                        <li class=""active"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aeb576df256441956282fdbee45030cd80761f22077", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aeb576df256441956282fdbee45030cd80761f23766", async() => {
                    WriteLiteral("Actors");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aeb576df256441956282fdbee45030cd80761f25457", async() => {
                    WriteLiteral("Actors JQueryAjax");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aeb576df256441956282fdbee45030cd80761f27159", async() => {
                    WriteLiteral("Movies");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <br /><br /><br /><br /><br />
    <main>
        <div class=""container"">
            <main role=""main"" class=""pb-3"" style=""color: black"">
                ");
#nullable restore
#line 81 "D:\Developer\GitHub\ASP.NET_projects\Ivanov_ASP.NET_04\Ivanov_ASP.NET_04\Views\Shared\_Layout_ActorsAndMovies.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </main>\r\n        </div>\r\n    </main>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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