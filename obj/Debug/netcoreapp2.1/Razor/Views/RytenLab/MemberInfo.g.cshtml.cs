#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439101b8d469738905a9f47b50d082b12c51ad3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RytenLab_MemberInfo), @"mvc.1.0.view", @"/Views/RytenLab/MemberInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RytenLab/MemberInfo.cshtml", typeof(AspNetCore.Views_RytenLab_MemberInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"439101b8d469738905a9f47b50d082b12c51ad3f", @"/Views/RytenLab/MemberInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d5f209256c59520799611eb314f91f8cbec80", @"/Views/_ViewImports.cshtml")]
    public class Views_RytenLab_MemberInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
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
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
  
    //View to show 'Member Info' page
    ViewData["Title"] = "Member Info";

#line default
#line hidden
            BeginContext(101, 37, true);
            WriteLiteral("\r\n\r\n<header class=\"header\">\r\n    <h1>");
            EndContext();
            BeginContext(139, 10, false);
#line 9 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(149, 103, true);
            WriteLiteral("</h1>\r\n    <hr />\r\n</header>\r\n<article>\r\n    <div class=\"media-left media-top little-image\" >\r\n        ");
            EndContext();
            BeginContext(252, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2079fbe0b86b43e68b84e2dcd5d594df", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 262, "~/images/modified/filter/", 262, 25, true);
#line 14 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 287, Model.ImagePath, 287, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 312, Model.Name, 312, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 330, Model.Name, 330, 11, false);

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
            BeginContext(377, 131, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"media-body\">\r\n        <address style=\"padding-top:5px;\">\r\n            <strong style=\"font-size:17px\">");
            EndContext();
            BeginContext(509, 10, false);
#line 18 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(519, 32, true);
            WriteLiteral("</strong><br />\r\n            <p>");
            EndContext();
            BeginContext(552, 11, false);
#line 19 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(563, 19, true);
            WriteLiteral("<br/>\r\n            ");
            EndContext();
            BeginContext(583, 9, false);
#line 20 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
       Write(Model.Job);

#line default
#line hidden
            EndContext();
            BeginContext(592, 66, true);
            WriteLiteral("</p>\r\n            <small>\r\n            <strong>E-mail: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 658, "\"", 684, 2);
            WriteAttributeValue("", 665, "mailto:", 665, 7, true);
#line 22 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 672, Model.Email, 672, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(685, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(687, 11, false);
#line 22 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(698, 12, true);
            WriteLiteral("</a><br />\r\n");
            EndContext();
#line 23 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
             if (!String.IsNullOrEmpty(Model.GitHub))
            {

#line default
#line hidden
            BeginContext(780, 43, true);
            WriteLiteral("                <strong>GitHub: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 823, "\"", 862, 2);
            WriteAttributeValue("", 830, "https://github.com/", 830, 19, true);
#line 25 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 849, Model.GitHub, 849, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(863, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(881, 12, false);
#line 25 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                                               Write(Model.GitHub);

#line default
#line hidden
            EndContext();
            BeginContext(893, 12, true);
            WriteLiteral("</a><br />\r\n");
            EndContext();
#line 26 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(920, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 27 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
             if (!String.IsNullOrEmpty(Model.ResearchGate))
            {

#line default
#line hidden
            BeginContext(996, 49, true);
            WriteLiteral("                <strong>ResearchGate: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1045, "\"", 1108, 2);
            WriteAttributeValue("", 1052, "https://www.researchgate.net/profile/", 1052, 37, true);
#line 29 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 1089, Model.ResearchGate, 1089, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1109, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(1127, 18, false);
#line 29 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                                                                             Write(Model.ResearchGate);

#line default
#line hidden
            EndContext();
            BeginContext(1145, 12, true);
            WriteLiteral("</a><br />\r\n");
            EndContext();
#line 30 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(1172, 110, true);
            WriteLiteral("            </small>\r\n        </address>\r\n    </div>\r\n    <br />\r\n\r\n\r\n    <h3>Research Interests</h3>\r\n    <p>");
            EndContext();
            BeginContext(1283, 22, false);
#line 38 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
  Write(Model.ResearchInterest);

#line default
#line hidden
            EndContext();
            BeginContext(1305, 41, true);
            WriteLiteral("</p>\r\n\r\n\r\n    <h3>Biography</h3>\r\n    <p>");
            EndContext();
            BeginContext(1347, 26, false);
#line 42 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
  Write(Html.Raw(@Model.Biography));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 43 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (@Model.Name.Contains("Mina"))
    {

#line default
#line hidden
            BeginContext(1426, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1434, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b2ff9042ceb246d59621da7ba67af330", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 45 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 1474, Model.Name, 1474, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 45 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 1492, Model.Name, 1492, 11, false);

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
            BeginContext(1528, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(1537, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.PreAcceptedPublicationsList.Count > 0 || Model.NCBIPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(1641, 31, true);
            WriteLiteral("        <h3>Publications</h3>\r\n");
            EndContext();
#line 51 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(1679, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 52 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.PreAcceptedPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(1741, 46, true);
            WriteLiteral("        <h4 class=\"year-main\">Pre-print</h4>\r\n");
            EndContext();
#line 55 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         foreach (var publication in Model.PreAcceptedPublicationsList)
        {

#line default
#line hidden
            BeginContext(1871, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(1924, 17, false);
#line 58 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1941, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 61 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {
                            if (i == 22)
                            {

#line default
#line hidden
            BeginContext(2236, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(2275, 22, false);
#line 67 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2297, 12, true);
            WriteLiteral("...</span>\r\n");
            EndContext();
#line 68 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                break;
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2445, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(2484, 22, false);
#line 72 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2506, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 73 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2632, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(2667, 22, false);
#line 77 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2689, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 78 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2748, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(2839, 23, false);
#line 81 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(2862, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2866, 16, false);
#line 81 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2882, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2930, "\"", 2954, 1);
#line 82 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 2937, publication.Link, 2937, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2955, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 84 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
        }

#line default
#line hidden
#line 84 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         
    }

#line default
#line hidden
            BeginContext(3036, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 86 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.NCBIPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(3091, 40, true);
            WriteLiteral("        <h4 class=\"year\">Accepted</h4>\r\n");
            EndContext();
#line 89 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         foreach (var publication in Model.NCBIPublicationsList)
        {

#line default
#line hidden
            BeginContext(3208, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(3261, 17, false);
#line 92 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3278, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 95 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {
                            if (i == 22)
                            {

#line default
#line hidden
            BeginContext(3573, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(3612, 22, false);
#line 101 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3634, 12, true);
            WriteLiteral("...</span>\r\n");
            EndContext();
#line 102 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                break;
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3782, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(3821, 22, false);
#line 106 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3843, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 107 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3969, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(4004, 22, false);
#line 111 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(4026, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 112 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(4085, 108, true);
            WriteLiteral("                </small><br />\r\n                <br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(4194, 23, false);
#line 116 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(4217, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(4221, 16, false);
#line 116 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4237, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 117 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                 if (@publication.Title.Contains("Genetic variability in the regulation of gene expression in ten regions of the human brain"))
                {

#line default
#line hidden
            BeginContext(4407, 115, true);
            WriteLiteral("                    <p class=\"publication\">Supporting <a href=\"http://braineac.org/\" target=\"_blank\">data</a></p>\r\n");
            EndContext();
#line 120 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(4541, 42, true);
            WriteLiteral("                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4583, "\"", 4607, 1);
#line 121 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 4590, publication.Link, 4590, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4608, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 123 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
        }

#line default
#line hidden
#line 123 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         
    }

#line default
#line hidden
            BeginContext(4689, 12, true);
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
