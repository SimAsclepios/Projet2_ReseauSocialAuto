#pragma checksum "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f607686fdf4d1754bf87c709dd62d7ee2828ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profil_DetailsEvent), @"mvc.1.0.view", @"/Views/Profil/DetailsEvent.cshtml")]
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
#line 2 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
using Projet2_BDD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f607686fdf4d1754bf87c709dd62d7ee2828ce", @"/Views/Profil/DetailsEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc9a91fe437cbfe5388f91ef2cc4c7afcab136a", @"/Views/_ViewImports.cshtml")]
    public class Views_Profil_DetailsEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projet2_BDD.Models.Evenement_Formation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<section>\r\n\r\n\r\n\r\n    <h1>");
#nullable restore
#line 9 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
   Write(Html.DisplayFor(model => model.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <hr />\r\n    <header>\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 14 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
           Write(Html.DisplayNameFor(model => model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 17 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
           Write(Html.DisplayFor(model => model.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dd>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7f607686fdf4d1754bf87c709dd62d7ee2828ce5083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/uploads/");
#nullable restore
#line 21 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
                        WriteLiteral(Model.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 21 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </header>\r\n    <article>\r\n        ");
#nullable restore
#line 26 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </article>\r\n\r\n\r\n\r\n</section>\r\n<footer>\r\n    ");
#nullable restore
#line 34 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
Write(Html.ActionLink("Modifier la Publication", "ModifierEvent", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  |\r\n\r\n    ");
#nullable restore
#line 36 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
Write(Html.ActionLink("Supprimer la Publication", "SupprimerEvent", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 38 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Profil\DetailsEvent.cshtml"
Write(Html.ActionLink("Retour à la liste", "AfficherPost"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</footer>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet2_BDD.Models.Evenement_Formation> Html { get; private set; }
    }
}
#pragma warning restore 1591