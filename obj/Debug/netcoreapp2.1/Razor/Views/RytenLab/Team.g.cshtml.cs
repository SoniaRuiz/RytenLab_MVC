#pragma checksum "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22df986d949b5f1234d1e76e86064a9c1f348bc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RytenLab_Team), @"mvc.1.0.view", @"/Views/RytenLab/Team.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RytenLab/Team.cshtml", typeof(AspNetCore.Views_RytenLab_Team))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22df986d949b5f1234d1e76e86064a9c1f348bc9", @"/Views/RytenLab/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d5f209256c59520799611eb314f91f8cbec80", @"/Views/_ViewImports.cshtml")]
    public class Views_RytenLab_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/album.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
  
    //View for 'Team' page
    ViewData["Title"] = "Team";

#line default
#line hidden
            BeginContext(81, 35, true);
            WriteLiteral("\r\n<header class=\"header\">\r\n    <h1>");
            EndContext();
            BeginContext(117, 17, false);
#line 8 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(134, 41, true);
            WriteLiteral("</h1>\r\n    <hr />\r\n</header>\r\n<article>\r\n");
            EndContext();
            BeginContext(207, 134, true);
            WriteLiteral("    <h4>While our transcriptomes may have changed, our childlike curiosity remains the same.</h4>\r\n    <br />\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 16 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
         foreach (var person in Model.TeamMembers)
        {
            

#line default
#line hidden
#line 18 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
             using (Html.BeginForm("MemberInfo", "RytenLab", FormMethod.Post, new { @id = @person.ID }))
            {

#line default
#line hidden
            BeginContext(525, 159, true);
            WriteLiteral("                <div class=\"cardColumn\">\r\n                    <div class=\"cardData\">\r\n                        <figure>\r\n                            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 684, "\"", 704, 1);
#line 23 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
WriteAttributeValue("", 692, person.Name, 692, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 705, "\"", 747, 3);
            WriteAttributeValue("", 715, "javascript:sendForm(", 715, 20, true);
#line 23 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
WriteAttributeValue("", 735, person.ID, 735, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 745, ");", 745, 2, true);
            EndWriteAttribute();
            BeginContext(748, 39, true);
            WriteLiteral(">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 787, "\"", 834, 2);
            WriteAttributeValue("", 793, "/images/modified/filter/", 793, 24, true);
#line 24 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
WriteAttributeValue("", 817, person.ImagePath, 817, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 835, "\"", 853, 1);
#line 24 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
WriteAttributeValue("", 841, person.Name, 841, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(854, 224, true);
            WriteLiteral(" class=\"card-img\">\r\n                            </a>\r\n                        </figure>\r\n                        <div class=\"cardMember\">\r\n                            <h3 style=\"font-size: 21px !important;\" class=\"cardName\">");
            EndContext();
            BeginContext(1079, 11, false);
#line 28 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                                                                                Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 90, true);
            WriteLiteral("</h3>\r\n                            <p class=\"cardTitle\">\r\n                                ");
            EndContext();
            BeginContext(1181, 21, false);
#line 30 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                           Write(Html.Raw(@person.Job));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 57, true);
            WriteLiteral("</p>\r\n                            <p class=\"cardEmail\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1259, "\"", 1286, 2);
            WriteAttributeValue("", 1266, "mailto:", 1266, 7, true);
#line 31 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
WriteAttributeValue("", 1273, person.Email, 1273, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1287, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1289, 12, false);
#line 31 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                                                                           Write(person.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1301, 127, true);
            WriteLiteral("</a></p>\r\n                            <p>\r\n                                <input type=\"submit\" value=\"View\" class=\"cardButton\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1428, "\"", 1469, 3);
            WriteAttributeValue("", 1438, "javascript:sendForm(", 1438, 20, true);
#line 33 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
WriteAttributeValue("", 1458, person.ID, 1458, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1468, ")", 1468, 1, true);
            EndWriteAttribute();
            BeginContext(1470, 67, true);
            WriteLiteral(" />\r\n                            </p>\r\n                            ");
            EndContext();
            BeginContext(1538, 32, false);
#line 35 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1601, 37, false);
#line 36 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1669, 33, false);
#line 37 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1733, 31, false);
#line 38 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.Job));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1795, 33, false);
#line 39 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1828, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1859, 46, false);
#line 40 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.NCBIPublicationsID));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1936, 44, false);
#line 41 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.ResearchInterest));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2011, 34, false);
#line 42 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2076, 40, false);
#line 43 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.ResearchGate));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                             for (int i = 0; i < person.PreAcceptedPublicationsTitles.Count; i++)
                            {
                                

#line default
#line hidden
            BeginContext(2281, 60, false);
#line 46 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                           Write(Html.HiddenFor(m => person.PreAcceptedPublicationsTitles[i]));

#line default
#line hidden
            EndContext();
#line 46 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                                                                                             
                            }

#line default
#line hidden
            BeginContext(2374, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 48 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                             for (int i = 0; i < person.PreAcceptedPublicationsList.Count; i++)
                            {
                                

#line default
#line hidden
            BeginContext(2535, 64, false);
#line 50 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                           Write(Html.HiddenFor(m => person.PreAcceptedPublicationsList[i].Title));

#line default
#line hidden
            EndContext();
            BeginContext(2634, 70, false);
#line 51 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                           Write(Html.HiddenFor(m => person.PreAcceptedPublicationsList[i].JournalName));

#line default
#line hidden
            EndContext();
            BeginContext(2739, 63, false);
#line 52 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                           Write(Html.HiddenFor(m => person.PreAcceptedPublicationsList[i].Link));

#line default
#line hidden
            EndContext();
#line 53 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                                 for (int x = 0; x < person.PreAcceptedPublicationsList[i].Authors.Count; x++)
                                {
                                    

#line default
#line hidden
            BeginContext(2988, 69, false);
#line 55 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                               Write(Html.HiddenFor(m => person.PreAcceptedPublicationsList[i].Authors[x]));

#line default
#line hidden
            EndContext();
#line 55 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                                                                                                          
                                }

#line default
#line hidden
            BeginContext(3127, 63, false);
#line 57 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                           Write(Html.HiddenFor(m => person.PreAcceptedPublicationsList[i].Date));

#line default
#line hidden
            EndContext();
#line 57 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                                                                                                
                            }

#line default
#line hidden
            BeginContext(3223, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3252, 37, false);
#line 59 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
                       Write(Html.HiddenFor(m => person.Biography));

#line default
#line hidden
            EndContext();
            BeginContext(3289, 86, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 63 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
            }

#line default
#line hidden
#line 63 "C:\Users\skgtsg0\source\repos\RytenLab_Web\RytenLab_Web\Views\RytenLab\Team.cshtml"
             
        }

#line default
#line hidden
            BeginContext(3401, 174, true);
            WriteLiteral("    </div>\r\n</article>\r\n<script type=\"text/javascript\">\r\n    function sendForm(memberID) {\r\n        $(\"#\" + memberID).submit();\r\n        return false;\r\n    }\r\n\r\n\r\n</script>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3592, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3598, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36d545b5fdb74c61938035bd7eb6522d", async() => {
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
                BeginContext(3646, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
