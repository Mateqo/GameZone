#pragma checksum "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d181c5539cd82dacbd48e701e82ad580337f8b27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_XBOX), @"mvc.1.0.view", @"/Views/Home/XBOX.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/XBOX.cshtml", typeof(AspNetCore.Views_Home_XBOX))]
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
#line 1 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\_ViewImports.cshtml"
using MateuszBartkowiakHomework6;

#line default
#line hidden
#line 2 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\_ViewImports.cshtml"
using MateuszBartkowiakHomework6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d181c5539cd82dacbd48e701e82ad580337f8b27", @"/Views/Home/XBOX.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf424596307a6bbf5bd94b054c729f23de338f4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_XBOX : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GameViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Images/up.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
  
    ViewData["Title"] = "XBOX";

#line default
#line hidden
            BeginContext(64, 5, true);
            WriteLiteral("<link");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 69, "\"", 106, 1);
#line 5 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
WriteAttributeValue("", 76, Url.Content("~/css/site.css"), 76, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(107, 95, true);
            WriteLiteral(" rel=\"stylesheet\" />\n\n<!-- Kategorie (filtry) -->\n<div class=\"category\">\n\n    <button>\n        ");
            EndContext();
            BeginContext(203, 155, false);
#line 11 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
   Write(Html.ActionLink("RPG",
               "GetGameByType",
               "Home",
               new { type ="RPG",platform="XBOX ONE"  },
               null));

#line default
#line hidden
            EndContext();
            BeginContext(358, 37, true);
            WriteLiteral("\n    </button>\n\n    <button>\n        ");
            EndContext();
            BeginContext(396, 165, false);
#line 19 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
   Write(Html.ActionLink("SHOOTER",
               "GetGameByType",
               "Home",
               new { type = "Shooter", platform= "XBOX ONE" },
               null));

#line default
#line hidden
            EndContext();
            BeginContext(561, 37, true);
            WriteLiteral("\n    </button>\n\n    <button>\n        ");
            EndContext();
            BeginContext(599, 169, false);
#line 27 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
   Write(Html.ActionLink("ADVENTURE",
               "GetGameByType",
               "Home",
               new { type = "Adventure", platform= "XBOX ONE" },
               null));

#line default
#line hidden
            EndContext();
            BeginContext(768, 51, true);
            WriteLiteral("\n    </button>\n\n</div>\n\n<!-- Wuszukiwanie gier -->\n");
            EndContext();
#line 37 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
 foreach (var game in Model)

{

#line default
#line hidden
            BeginContext(851, 41, true);
            WriteLiteral("    <!-- Jeśli gra na XBOX wypisz ją -->\n");
            EndContext();
#line 41 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
     if (game.Platform == "XBOX ONE")
    {

#line default
#line hidden
            BeginContext(936, 104, true);
            WriteLiteral("        <div class=\"productXbox col-md-12\">\n            <div class=\"game col-md-3\">\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1040, "\"", 1070, 1);
#line 45 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
WriteAttributeValue("", 1046, Url.Content(game.Photo), 1046, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1071, "\"", 1087, 1);
#line 45 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
WriteAttributeValue("", 1077, game.Name, 1077, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1088, 39, true);
            WriteLiteral(" />\n                <h4>Rok produkjci: ");
            EndContext();
            BeginContext(1128, 21, false);
#line 46 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
                              Write(game.YearOfProduction);

#line default
#line hidden
            EndContext();
            BeginContext(1149, 35, true);
            WriteLiteral("</h4>\n                <h4>Gatunek: ");
            EndContext();
            BeginContext(1185, 9, false);
#line 47 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
                        Write(game.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1194, 37, true);
            WriteLiteral("</h4>\n                <h4>Platforma: ");
            EndContext();
            BeginContext(1232, 13, false);
#line 48 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
                          Write(game.Platform);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 129, true);
            WriteLiteral("</h4>\n            </div>\n            <div class=\"info col-md-9\">\n                <div class=\"col-md-12\">\n                    <h2>");
            EndContext();
            BeginContext(1375, 9, false);
#line 52 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
                   Write(game.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1384, 30, true);
            WriteLiteral("</h2>\n                    <h4>");
            EndContext();
            BeginContext(1415, 16, false);
#line 53 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
                   Write(game.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1431, 161, true);
            WriteLiteral("</h4>\n                </div>\n                <div class=\"col-md-12\">\n                    <div class=\"gameplay text-center col-md-8\">\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1592, "\"", 1626, 1);
#line 57 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
WriteAttributeValue("", 1598, Url.Content(game.Gameplay1), 1598, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1627, "\"", 1653, 2);
#line 57 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
WriteAttributeValue("", 1633, game.Name, 1633, 10, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1643, "Gameplay1", 1644, 10, true);
            EndWriteAttribute();
            BeginContext(1654, 32, true);
            WriteLiteral(" />\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1686, "\"", 1720, 1);
#line 58 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
WriteAttributeValue("", 1692, Url.Content(game.Gameplay2), 1692, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1721, "\"", 1747, 2);
#line 58 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
WriteAttributeValue("", 1727, game.Name, 1727, 10, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1737, "Gameplay2", 1738, 10, true);
            EndWriteAttribute();
            BeginContext(1748, 111, true);
            WriteLiteral(" />\n                    </div>\n                    <div class=\"add col-md-3\">\n                        <p>Cena: ");
            EndContext();
            BeginContext(1860, 10, false);
#line 61 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
                            Write(game.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1870, 200, true);
            WriteLiteral(" zł</p>\n                        <!-- użycie ActionLinka który przekierowuje do kontrolera i wysyła dane o grze -->\n                        <button class=\"btn btn-success\">\n                            ");
            EndContext();
            BeginContext(2071, 168, false);
#line 64 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
                       Write(Html.ActionLink("Dodaj do koszyka",
               "Trolley",
               "Home",
               new { platform =game.Platform,name=game.Name },
               null));

#line default
#line hidden
            EndContext();
            BeginContext(2239, 120, true);
            WriteLiteral("\n                        </button>\n                    </div>\n                </div>\n            </div>\n\n        </div>\n");
            EndContext();
#line 75 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
    }

#line default
#line hidden
#line 75 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\XBOX.cshtml"
     
}

#line default
#line hidden
            BeginContext(2367, 148, true);
            WriteLiteral("        <div class=\"col-md-12\">\n            <!-- Scrollowanie w górę -->\n            <div class=\"scroll\">\n                <a id=\"scrollup\" href=\"#\">");
            EndContext();
            BeginContext(2515, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e8f08c710ea24d35ae680026d7fda772", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2552, 153, true);
            WriteLiteral("</a>\n            </div>\n\n            <div class=\"footer\">\n                Autor strony: Mateusz Bartkowiak &copy; 2020\n            </div>\n        </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GameViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
