#pragma checksum "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Recherche\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c6b82150d8eb22a5fd67f3e3a0a4fda042c6a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recherche_Index), @"mvc.1.0.view", @"/Views/Recherche/Index.cshtml")]
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
#line 2 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\_ViewImports.cshtml"
using Projet2_BDD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\_ViewImports.cshtml"
using Projet2_BDD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c6b82150d8eb22a5fd67f3e3a0a4fda042c6a9", @"/Views/Recherche/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc9a91fe437cbfe5388f91ef2cc4c7afcab136a", @"/Views/_ViewImports.cshtml")]
    public class Views_Recherche_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projet2_BDD.ViewModels.PostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("bannière de la page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%; max-width: 100%; opacity: .4;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Recherche\Index.cshtml"
  
    Layout = "~/Views/Shared/LayoutTest.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div></div>\r\n\r\n");
            WriteLiteral("\r\n<section>\r\n\r\n    <div class=\"container\" style=\"position: relative\">\r\n        <div class=\"img-responsive\" style=\"width: 100%; max-width: 100%\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3c6b82150d8eb22a5fd67f3e3a0a4fda042c6a94752", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"img-overlay\" style=\"display: inline-block; position: absolute; display: flex; align-items: center; top: 50%; bottom: 50%;\">\r\n\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1236, "\"", 1312, 4);
            WriteAttributeValue("", 1246, "location.href=\'", 1246, 15, true);
#nullable restore
#line 47 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Recherche\Index.cshtml"
WriteAttributeValue("", 1261, Url.Action("Recherche", "Materiel"), 1261, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1297, "\';return", 1297, 8, true);
            WriteAttributeValue(" ", 1305, "false;", 1306, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary mb-2\">Rechercher des Objets à Vendre</button>\r\n\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1407, "\"", 1497, 4);
            WriteAttributeValue("", 1417, "location.href=\'", 1417, 15, true);
#nullable restore
#line 49 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Recherche\Index.cshtml"
WriteAttributeValue("", 1432, Url.Action("AffichageDemandeService", "Services"), 1432, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1482, "\';return", 1482, 8, true);
            WriteAttributeValue(" ", 1490, "false;", 1491, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary mb-2\">Voir les Demandes de service</button>\r\n\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1590, "\"", 1667, 4);
            WriteAttributeValue("", 1600, "location.href=\'", 1600, 15, true);
#nullable restore
#line 51 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Recherche\Index.cshtml"
WriteAttributeValue("", 1615, Url.Action("Evenement", "Evenement"), 1615, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1652, "\';return", 1652, 8, true);
            WriteAttributeValue(" ", 1660, "false;", 1661, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary mb-2\">Voir les prochains évenements et formations</button>\r\n\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1775, "\"", 1862, 4);
            WriteAttributeValue("", 1785, "location.href=\'", 1785, 15, true);
#nullable restore
#line 53 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Recherche\Index.cshtml"
WriteAttributeValue("", 1800, Url.Action("AfficherBienMateriel", "Location"), 1800, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1847, "\';return", 1847, 8, true);
            WriteAttributeValue(" ", 1855, "false;", 1856, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary mb-2\">Offres de location de matériel</button>\r\n\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1957, "\"", 2038, 4);
            WriteAttributeValue("", 1967, "location.href=\'", 1967, 15, true);
#nullable restore
#line 55 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Recherche\Index.cshtml"
WriteAttributeValue("", 1982, Url.Action("AfficherVoiture", "Voiture"), 1982, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2023, "\';return", 2023, 8, true);
            WriteAttributeValue(" ", 2031, "false;", 2032, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary mb-2\">Offres de location de voiture</button>\r\n\r\n");
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet2_BDD.ViewModels.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
