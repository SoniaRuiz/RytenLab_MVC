#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d2910e00037cf626de3bf1210e46a83509390b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d2910e00037cf626de3bf1210e46a83509390b", @"/Views/RytenLab/MemberInfo.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "576e599643b54eae9af70955aba060f3", async() => {
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
            BeginContext(377, 108, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"media-body\">\r\n        <address style=\"padding-top:5px;\">\r\n            <strong>");
            EndContext();
            BeginContext(486, 10, false);
#line 18 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(496, 32, true);
            WriteLiteral("</strong><br />\r\n            <p>");
            EndContext();
            BeginContext(529, 11, false);
#line 19 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(540, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(562, 9, false);
#line 20 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
          Write(Model.Job);

#line default
#line hidden
            EndContext();
            BeginContext(571, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
             if (!String.IsNullOrEmpty(Model.GitHub))
            {

#line default
#line hidden
            BeginContext(647, 43, true);
            WriteLiteral("                <strong>GitHub: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 690, "\"", 729, 2);
            WriteAttributeValue("", 697, "https://github.com/", 697, 19, true);
#line 23 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 716, Model.GitHub, 716, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(730, 36, true);
            WriteLiteral(" target=\"_blank\">https://github.com/");
            EndContext();
            BeginContext(767, 12, false);
#line 23 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                                                                  Write(Model.GitHub);

#line default
#line hidden
            EndContext();
            BeginContext(779, 12, true);
            WriteLiteral("</a><br />\r\n");
            EndContext();
#line 24 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(806, 39, true);
            WriteLiteral("            <strong>E-mail: </strong><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 845, "\"", 871, 2);
            WriteAttributeValue("", 852, "mailto:", 852, 7, true);
#line 25 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 859, Model.Email, 859, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(872, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(874, 11, false);
#line 25 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(885, 100, true);
            WriteLiteral("</a><br />\r\n        </address>\r\n    </div>\r\n    <br />\r\n\r\n\r\n    <h3>Research Interests</h3>\r\n    <p>");
            EndContext();
            BeginContext(986, 22, false);
#line 32 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
  Write(Model.ResearchInterest);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 41, true);
            WriteLiteral("</p>\r\n\r\n\r\n    <h3>Biography</h3>\r\n    <p>");
            EndContext();
            BeginContext(1050, 26, false);
#line 36 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
  Write(Html.Raw(@Model.Biography));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 37 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (@Model.Name.Contains("Mina"))
    {

#line default
#line hidden
            BeginContext(1129, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1137, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fda04370a0fd43c1bc7d467a3ce7d164", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 1177, Model.Name, 1177, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
AddHtmlAttributeValue("", 1195, Model.Name, 1195, 11, false);

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
            BeginContext(1231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(1240, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.PreAcceptedPublicationsList.Count > 0 || Model.NCBIPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(1344, 31, true);
            WriteLiteral("        <h3>Publications</h3>\r\n");
            EndContext();
#line 45 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(1382, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 46 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.PreAcceptedPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(1444, 46, true);
            WriteLiteral("        <h4 class=\"year-main\">Pre-print</h4>\r\n");
            EndContext();
#line 49 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         foreach (var publication in Model.PreAcceptedPublicationsList)
        {

#line default
#line hidden
            BeginContext(1574, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(1627, 17, false);
#line 52 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1644, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 55 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {
                            if (i == 22)
                            {

#line default
#line hidden
            BeginContext(1939, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(1978, 22, false);
#line 61 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2000, 12, true);
            WriteLiteral("...</span>\r\n");
            EndContext();
#line 62 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                break;
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2148, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(2187, 22, false);
#line 66 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2209, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 67 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2335, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(2370, 22, false);
#line 71 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2392, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 72 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2451, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(2542, 23, false);
#line 75 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(2565, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2569, 16, false);
#line 75 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(2585, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2633, "\"", 2657, 1);
#line 76 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 2640, publication.Link, 2640, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2658, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 78 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
        }

#line default
#line hidden
#line 78 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2739, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 80 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
     if (Model.NCBIPublicationsList.Count > 0)
    {

#line default
#line hidden
            BeginContext(2794, 40, true);
            WriteLiteral("        <h4 class=\"year\">Accepted</h4>\r\n");
            EndContext();
#line 83 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         foreach (var publication in Model.NCBIPublicationsList)
        {

#line default
#line hidden
            BeginContext(2911, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(2964, 17, false);
#line 86 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2981, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 89 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {
                            if (i == 22)
                            {

#line default
#line hidden
            BeginContext(3276, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(3315, 22, false);
#line 95 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3337, 12, true);
            WriteLiteral("...</span>\r\n");
            EndContext();
#line 96 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                break;
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3485, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(3524, 22, false);
#line 100 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                 Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3546, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 101 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3672, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(3707, 22, false);
#line 105 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(3729, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 106 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3788, 108, true);
            WriteLiteral("                </small><br />\r\n                <br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(3897, 23, false);
#line 110 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(3920, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(3924, 16, false);
#line 110 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(3940, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 111 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                 if (@publication.Title.Contains("Genetic variability in the regulation of gene expression in ten regions of the human brain"))
                {

#line default
#line hidden
            BeginContext(4110, 115, true);
            WriteLiteral("                    <p class=\"publication\">Supporting <a href=\"http://braineac.org/\" target=\"_blank\">data</a></p>\r\n");
            EndContext();
#line 114 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(4244, 42, true);
            WriteLiteral("                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4286, "\"", 4310, 1);
#line 115 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
WriteAttributeValue("", 4293, publication.Link, 4293, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4311, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 117 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
        }

#line default
#line hidden
#line 117 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\MemberInfo.cshtml"
         
    }

#line default
#line hidden
            BeginContext(4392, 12, true);
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
