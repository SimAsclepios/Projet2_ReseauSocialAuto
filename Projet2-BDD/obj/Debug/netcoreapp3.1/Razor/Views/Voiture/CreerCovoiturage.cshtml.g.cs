#pragma checksum "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6ee72fa4e92bd261c399f1ddf9095ab39ab2c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Voiture_CreerCovoiturage), @"mvc.1.0.view", @"/Views/Voiture/CreerCovoiturage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6ee72fa4e92bd261c399f1ddf9095ab39ab2c1", @"/Views/Voiture/CreerCovoiturage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc9a91fe437cbfe5388f91ef2cc4c7afcab136a", @"/Views/_ViewImports.cshtml")]
    public class Views_Voiture_CreerCovoiturage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projet2_BDD.ViewModels.CovoiturageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/portfolio/Covoit.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate-vsdoc.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/Myscript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
  
    Layout = "~/Views/Shared/LayoutTest.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div> <a> ");
#nullable restore
#line 11 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
             Write(Html.ActionLink("Retour", "Index", "Publication"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></div>

        <!--Occupe 6 colonnes-->
        <div class=""col-6 bg-danger"">

            <div class=""card"">
                <div class=""card-header  bg-danger text-justify text-white"">
                    <h5>Covoiturage</h5>
                </div>
                <div class=""card-body"">


");
#nullable restore
#line 23 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                     using (Html.BeginForm("CreerCovoiturage", "Voiture", FormMethod.Post, new { enctype = "multipart/form-data" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"form-group\">\r\n                                    <div class=\"form-input\">\r\n                                        ");
#nullable restore
#line 29 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.Label("ville de départ"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                                        ");
#nullable restore
#line 30 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.TextBoxFor(m => m.VilleDepart, new { @class = "form-control", required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 31 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.VilleDepart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"form-group\">\r\n                                    <div class=\"form-input\">\r\n                                        ");
#nullable restore
#line 41 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.Label("Ville d'arrivée"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                                        ");
#nullable restore
#line 42 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.TextBoxFor(m => m.VilleArrivee, new { @class = "form-control", required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 43 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.VilleArrivee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"form-group\">\r\n                                    <div class=\"form-input\">\r\n                                        ");
#nullable restore
#line 53 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.Label("Ville étape"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                                        ");
#nullable restore
#line 54 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.TextBoxFor(m => m.VilleEtape, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 55 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.VilleEtape));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-8"">
                                <div class=""form-group"">
                                    <div class=""form-input"">
                                        <!-- Ajout de la date et de l'heure -->
                                        ");
#nullable restore
#line 66 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.Label("Date de départ"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                                        ");
#nullable restore
#line 67 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.TextBoxFor(m => m.DateDepart, new { @class = "form-control", Type = "date", placeholder = "01/11/2021", required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 68 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.DateDepart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"form-group\">\r\n                                    <div class=\"form-input\">\r\n                                        ");
#nullable restore
#line 78 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.Label("Nombre de places"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                                        ");
#nullable restore
#line 79 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.TextBoxFor(m => m.NbPlace, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 80 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.NbPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"form-group\">\r\n                                    <div class=\"form-input\">\r\n                                        ");
#nullable restore
#line 90 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.LabelFor(m => m.Prix));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                                        ");
#nullable restore
#line 91 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.TextBoxFor(m => m.Prix, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 92 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.Prix));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"form-group\">\r\n                                    <div class=\"form-input\">\r\n                                        ");
#nullable restore
#line 102 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.Label("Commentaire"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 103 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control", placeholder = "Publiez votre annonce", required = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 104 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"
                                   Write(Html.ValidationMessageFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-8"">
                                <div class=""form-group"">
                                    <div class=""form-input"">
                                        <div class=""submit-button text-lg-right"">
                                            <button type=""submit"" value=""Save"" class="" bg-danger"">Créer Publication</button>
                                            <button type=""reset"" class=""bg-danger"">Effacer</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 124 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Voiture\CreerCovoiturage.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-6 bg-danger\">\r\n            <div class=\"nav-pills\">\r\n");
            WriteLiteral("            </div>\r\n\r\n            <article>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fd6ee72fa4e92bd261c399f1ddf9095ab39ab2c118433", async() => {
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
            WriteLiteral("\r\n                <p></p>\r\n            </article>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd6ee72fa4e92bd261c399f1ddf9095ab39ab2c119651", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd6ee72fa4e92bd261c399f1ddf9095ab39ab2c120691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd6ee72fa4e92bd261c399f1ddf9095ab39ab2c121731", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd6ee72fa4e92bd261c399f1ddf9095ab39ab2c122771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet2_BDD.ViewModels.CovoiturageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
