#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0408cfeb89f23d3651b9ba0333d9c166b23f2e03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MemberInfo), @"mvc.1.0.view", @"/Views/Home/MemberInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MemberInfo.cshtml", typeof(AspNetCore.Views_Home_MemberInfo))]
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
#line 1 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\_ViewImports.cshtml"
using RytenLab_Web;

#line default
#line hidden
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\_ViewImports.cshtml"
using RytenLab_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0408cfeb89f23d3651b9ba0333d9c166b23f2e03", @"/Views/Home/MemberInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d5f209256c59520799611eb314f91f8cbec80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MemberInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("media-object little-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/mina-bio.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mina-biography"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
  
    ViewData["Title"] = "Member Info";

#line default
#line hidden
            BeginContext(62, 37, true);
            WriteLiteral("\r\n\r\n<header class=\"header\">\r\n    <h1>");
            EndContext();
            BeginContext(100, 10, false);
#line 8 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(110, 89, true);
            WriteLiteral("</h1>\r\n    <hr />\r\n</header>\r\n<article>\r\n    <div class=\"media-left media-top\">\r\n        ");
            EndContext();
            BeginContext(199, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fafb7a0a54ba4a56a52702091d5fb63d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 209, "~/images/modified/filter/", 209, 25, true);
#line 13 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
AddHtmlAttributeValue("", 234, Model.ImagePath, 234, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
AddHtmlAttributeValue("", 259, Model.Name, 259, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
AddHtmlAttributeValue("", 277, Model.Name, 277, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(324, 108, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"media-body\">\r\n        <address style=\"padding-top:5px;\">\r\n            <strong>");
            EndContext();
            BeginContext(433, 10, false);
#line 17 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(443, 32, true);
            WriteLiteral("</strong><br />\r\n            <p>");
            EndContext();
            BeginContext(476, 9, false);
#line 18 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
          Write(Model.Job);

#line default
#line hidden
            EndContext();
            BeginContext(485, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 19 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
             if (!String.IsNullOrEmpty(Model.GitHub))
            {

#line default
#line hidden
            BeginContext(561, 43, true);
            WriteLiteral("                <strong>GitHub: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 604, "\"", 643, 2);
            WriteAttributeValue("", 611, "https://github.com/", 611, 19, true);
#line 21 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
WriteAttributeValue("", 630, Model.GitHub, 630, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(644, 36, true);
            WriteLiteral(" target=\"_blank\">https://github.com/");
            EndContext();
            BeginContext(681, 12, false);
#line 21 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                                                                                                  Write(Model.GitHub);

#line default
#line hidden
            EndContext();
            BeginContext(693, 12, true);
            WriteLiteral("</a><br />\r\n");
            EndContext();
#line 22 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(720, 39, true);
            WriteLiteral("            <strong>E-mail: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 759, "\"", 785, 2);
            WriteAttributeValue("", 766, "mailto:", 766, 7, true);
#line 23 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
WriteAttributeValue("", 773, Model.Email, 773, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(786, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(788, 11, false);
#line 23 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                                              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(799, 100, true);
            WriteLiteral("</a><br />\r\n        </address>\r\n    </div>\r\n    <br />\r\n\r\n\r\n    <h3>Research Interests</h3>\r\n    <p>");
            EndContext();
            BeginContext(900, 22, false);
#line 30 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
  Write(Model.ResearchInterest);

#line default
#line hidden
            EndContext();
            BeginContext(922, 41, true);
            WriteLiteral("</p>\r\n\r\n\r\n    <h3>Biography</h3>\r\n    <p>");
            EndContext();
            BeginContext(964, 15, false);
#line 34 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
  Write(Model.Biography);

#line default
#line hidden
            EndContext();
            BeginContext(979, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 35 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
     if (@Model.Name.Contains("Mina"))
    {

#line default
#line hidden
            BeginContext(1032, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1040, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1762d12e74344b01bc6fe0e41fc46854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 37 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
AddHtmlAttributeValue("", 1080, Model.Name, 1080, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 37 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
AddHtmlAttributeValue("", 1098, Model.Name, 1098, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(1143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
     if (Model.CrossRefPublicationsList.Count > 0 || Model.NCBIPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(1244, 31, true);
            WriteLiteral("        <h3>Publications</h3>\r\n");
            EndContext();
#line 43 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(1282, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 44 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
     if (Model.CrossRefPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(1341, 46, true);
            WriteLiteral("        <h4 class=\"year-main\">Pre-print</h4>\r\n");
            EndContext();
#line 47 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
         foreach (var publication in Model.CrossRefPublicationsList)
        {

#line default
#line hidden
            BeginContext(1468, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(1521, 17, false);
#line 50 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1538, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 53 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {
                            if (i == 22)
                            {

#line default
#line hidden
            BeginContext(1833, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(1872, 22, false);
#line 59 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 12, true);
            WriteLiteral("...</span>\r\n");
            EndContext();
#line 60 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                break;
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2042, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(2081, 22, false);
#line 64 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2103, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 65 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2229, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(2264, 22, false);
#line 69 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2286, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 70 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2345, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(2436, 23, false);
#line 73 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(2459, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2463, 16, false);
#line 73 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2479, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2527, "\"", 2551, 1);
#line 74 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
WriteAttributeValue("", 2534, publication.Link, 2534, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2552, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 76 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
        }

#line default
#line hidden
#line 76 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2633, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 78 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
     if (Model.NCBIPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(2688, 40, true);
            WriteLiteral("        <h4 class=\"year\">Accepted</h4>\r\n");
            EndContext();
#line 81 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
         foreach (var publication in Model.NCBIPublicationsList)
        {

#line default
#line hidden
            BeginContext(2805, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(2858, 17, false);
#line 84 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2875, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 87 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {
                            if (i == 22)
                            {

#line default
#line hidden
            BeginContext(3170, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(3209, 22, false);
#line 93 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3231, 12, true);
            WriteLiteral("...</span>\r\n");
            EndContext();
#line 94 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                break;
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3379, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(3418, 22, false);
#line 98 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3440, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 99 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3566, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(3601, 22, false);
#line 103 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3623, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 104 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3682, 108, true);
            WriteLiteral("                </small><br />\r\n                <br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(3791, 23, false);
#line 108 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(3814, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(3818, 16, false);
#line 108 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(3834, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 109 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                 if (@publication.Title.Contains("Genetic variability in the regulation of gene expression in ten regions of the human brain"))
                {

#line default
#line hidden
            BeginContext(4004, 115, true);
            WriteLiteral("                    <p class=\"publication\">Supporting <a href=\"http://braineac.org/\" target=\"_blank\">data</a></p>\r\n");
            EndContext();
#line 112 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(4138, 42, true);
            WriteLiteral("                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4180, "\"", 4204, 1);
#line 113 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
WriteAttributeValue("", 4187, publication.Link, 4187, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4205, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 115 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
        }

#line default
#line hidden
#line 115 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\MemberInfo.cshtml"
         
    }

#line default
#line hidden
            BeginContext(4286, 12, true);
            WriteLiteral("</article>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
