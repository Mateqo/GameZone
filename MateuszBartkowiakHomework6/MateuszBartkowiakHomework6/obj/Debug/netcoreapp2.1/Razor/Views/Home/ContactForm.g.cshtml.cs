#pragma checksum "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80cb034453aee37815a461762b7b95db1c3c978d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactForm), @"mvc.1.0.view", @"/Views/Home/ContactForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactForm.cshtml", typeof(AspNetCore.Views_Home_ContactForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80cb034453aee37815a461762b7b95db1c3c978d", @"/Views/Home/ContactForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf424596307a6bbf5bd94b054c729f23de338f4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
  
    ViewData["Title"] = "ContactForm";

#line default
#line hidden
            BeginContext(72, 104, true);
            WriteLiteral("\n\n<div class=\"text-center\">\n\n    <h2>Uzupełnij dane:</h2>\n    <br />\n\n    <!-- Formularz kontaktowy -->\n");
            EndContext();
#line 13 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
     using (Html.BeginForm("ContactForm", "Home", FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(259, 23, false);
#line 15 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(284, 70, true);
            WriteLiteral("        <!--Imię-->\n        <div class=\"form-horizontal\">\n            ");
            EndContext();
            BeginContext(355, 39, false);
#line 19 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(394, 35, true);
            WriteLiteral("\n            <div>\n                ");
            EndContext();
            BeginContext(430, 40, false);
#line 21 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(470, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(506, 74, true);
            WriteLiteral("        <!--Nazwisko-->\n        <div class=\"form-horizontal\">\n            ");
            EndContext();
            BeginContext(581, 38, false);
#line 27 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(619, 35, true);
            WriteLiteral("\n            <div>\n                ");
            EndContext();
            BeginContext(655, 39, false);
#line 29 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(694, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(730, 71, true);
            WriteLiteral("        <!--Email-->\n        <div class=\"form-horizontal\">\n            ");
            EndContext();
            BeginContext(802, 35, false);
#line 35 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(837, 35, true);
            WriteLiteral("\n            <div>\n                ");
            EndContext();
            BeginContext(873, 36, false);
#line 37 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(909, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(945, 77, true);
            WriteLiteral("        <!--Miejscowość-->\n        <div class=\"form-horizontal\">\n            ");
            EndContext();
            BeginContext(1023, 38, false);
#line 43 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 35, true);
            WriteLiteral("\n            <div>\n                ");
            EndContext();
            BeginContext(1097, 39, false);
#line 45 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(1172, 73, true);
            WriteLiteral("        <!--Address-->\n        <div class=\"form-horizontal\">\n            ");
            EndContext();
            BeginContext(1246, 37, false);
#line 51 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 35, true);
            WriteLiteral("\n            <div>\n                ");
            EndContext();
            BeginContext(1319, 38, false);
#line 53 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 215, true);
            WriteLiteral("\n            </div>\n        </div>\n        <br />\n        <!--Potwierdzenie formularza-->\n        <div class=\"form-group\">\n\n            <input type=\"submit\" value=\"Wyślij\" class=\"btn btn-success\" />\n\n        </div>\n");
            EndContext();
#line 63 "D:\Users\User\Desktop\mateusz_bartkowiak-master\Laboratorium 6\MateuszBartkowiakHomework6\MateuszBartkowiakHomework6\Views\Home\ContactForm.cshtml"
    }

#line default
#line hidden
            BeginContext(1578, 149, true);
            WriteLiteral("    \n</div>\n<br />\n<br />\n<br />\n<br />\n<br />\n<br />\n\n<!-- Stopka -->\n<div class=\"footer\">\n    Autor strony: Mateusz Bartkowiak &copy; 2020\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
