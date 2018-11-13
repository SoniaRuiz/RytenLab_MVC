#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d6d5b9c0464a4a82716fca576bebf813771c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Publications), @"mvc.1.0.view", @"/Views/Home/Publications.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Publications.cshtml", typeof(AspNetCore.Views_Home_Publications))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d6d5b9c0464a4a82716fca576bebf813771c62", @"/Views/Home/Publications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d5f209256c59520799611eb314f91f8cbec80", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Publications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
  
    ViewData["Title"] = "Publications";

#line default
#line hidden
            BeginContext(63, 33, true);
            WriteLiteral("<header class=\"header\">\r\n    <h1>");
            EndContext();
            BeginContext(97, 17, false);
#line 6 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 101, true);
            WriteLiteral("</h1>\r\n    <hr />\r\n</header>\r\n<article>\r\n    <h2>Accepted</h2>\r\n    <h3 class=\"year-main\">2018</h3>\r\n");
            EndContext();
#line 12 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
     foreach (var publication in Model.NCBIPublicationsList)
    {
        

#line default
#line hidden
#line 14 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Date.Contains("2018"))
        {

#line default
#line hidden
            BeginContext(345, 52, true);
            WriteLiteral("            <div class=\"well\">\r\n                <h4>");
            EndContext();
            BeginContext(398, 17, false);
#line 17 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
               Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(415, 34, true);
            WriteLiteral("</h4>\r\n                <small>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     for (var i = 0; i < publication.Authors.Count; i++)
                    {
                        if (i < publication.Authors.Count - 1)
                        {

#line default
#line hidden
            BeginContext(637, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(672, 22, false);
#line 24 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(694, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 25 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(789, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(824, 22, false);
#line 28 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                             Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(846, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 29 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(905, 90, true);
            WriteLiteral("                </small><br /><br />\r\n                <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(996, 23, false);
#line 32 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                               Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(1019, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1023, 16, false);
#line 32 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                                                          Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 48, true);
            WriteLiteral("</p>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1087, "\"", 1111, 1);
#line 33 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
WriteAttributeValue("", 1094, publication.Link, 1094, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1112, 63, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n            </div>\r\n");
            EndContext();
#line 35 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
#line 35 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1193, 32, true);
            WriteLiteral("    <h3 class=\"year\">2014</h3>\r\n");
            EndContext();
#line 38 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
     foreach (var publication in Model.NCBIPublicationsList)
    {
        

#line default
#line hidden
#line 40 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Date.Contains("2014"))
        {

#line default
#line hidden
            BeginContext(1355, 36, true);
            WriteLiteral("    <div class=\"well\">\r\n        <h4>");
            EndContext();
            BeginContext(1392, 17, false);
#line 43 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
       Write(publication.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1409, 26, true);
            WriteLiteral("</h4>\r\n        <small>\r\n\r\n");
            EndContext();
#line 46 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
             for (var i = 0; i < publication.Authors.Count; i++)
            {
                if (i < publication.Authors.Count - 1)
                {

#line default
#line hidden
            BeginContext(1591, 26, true);
            WriteLiteral("                    <span>");
            EndContext();
            BeginContext(1618, 22, false);
#line 50 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 11, true);
            WriteLiteral(", </span>\r\n");
            EndContext();
#line 51 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1711, 26, true);
            WriteLiteral("                    <span>");
            EndContext();
            BeginContext(1738, 22, false);
#line 54 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                     Write(publication.Authors[i]);

#line default
#line hidden
            EndContext();
            BeginContext(1760, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 55 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1803, 74, true);
            WriteLiteral("        </small><br /><br />\r\n        <p class=\"publication\">Published in ");
            EndContext();
            BeginContext(1878, 23, false);
#line 58 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                       Write(publication.JournalName);

#line default
#line hidden
            EndContext();
            BeginContext(1901, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1905, 16, false);
#line 58 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
                                                                  Write(publication.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1921, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 59 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         if (@publication.Title.Contains("Genetic variability in the regulation of gene expression in ten regions of the human brain"))
        {

#line default
#line hidden
            BeginContext(2075, 87, true);
            WriteLiteral("            <p>Supporting <a href=\"http://braineac.org/\" target=\"_blank\">data</a></p>\r\n");
            EndContext();
#line 62 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
            BeginContext(2173, 34, true);
            WriteLiteral("        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2207, "\"", 2231, 1);
#line 63 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
WriteAttributeValue("", 2214, publication.Link, 2214, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2232, 55, true);
            WriteLiteral(" role=\"button\" target=\"_blank\">View »</a>\r\n    </div>\r\n");
            EndContext();
#line 65 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
        }

#line default
#line hidden
#line 65 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\Home\Publications.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2305, 12, true);
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