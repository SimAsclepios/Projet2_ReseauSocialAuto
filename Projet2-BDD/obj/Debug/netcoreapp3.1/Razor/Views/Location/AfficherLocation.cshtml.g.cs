#pragma checksum "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfb027567fc06da981d03f11e945ffdb5209c492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_AfficherLocation), @"mvc.1.0.view", @"/Views/Location/AfficherLocation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb027567fc06da981d03f11e945ffdb5209c492", @"/Views/Location/AfficherLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc9a91fe437cbfe5388f91ef2cc4c7afcab136a", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_AfficherLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projet2_BDD.Models.Location>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r");
#nullable restore
#line 3 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
   Layout = "~/Views/Shared/LayoutTest.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\r<section>\r\r    <!-- ? Mettre les liens sous forme de boutons alignés, pour faire comme une sous-entete de formulaire ? -->\r    <div>\r        <div>\r            <h5>\r                ");
#nullable restore
#line 13 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
           Write(Html.ActionLink(" Demandes de service ", "AffichageDemandeService", "Services"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /\r                ");
#nullable restore
#line 14 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
           Write(Html.ActionLink(" Objets à vendre ", "Liste", "Materiel"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /\r                ");
#nullable restore
#line 15 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
           Write(Html.ActionLink(" Evénements et formations ", "Evenement", "Evenement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /\r");
            WriteLiteral("            </h5>\r        </div>\r    </div>\r\r\r    <table classe=\"table\">\r        <thead>\r            <tr>\r\r                <th>\r                    ");
#nullable restore
#line 27 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
               Write(Html.DisplayNameFor(model => model.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r                </th>\r\r                <th>\r                    ");
#nullable restore
#line 31 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
               Write(Html.DisplayNameFor(model => model.Rubrique));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r                </th>\r\r            </tr>\r        </thead>\r\r\r        <tbody>\r\r");
#nullable restore
#line 40 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
             foreach (var item in Model)

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\r    <td>\r        ");
#nullable restore
#line 46 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
   Write(Html.DisplayFor(modelItem => item.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r    </td>\r\r    <td>\r        ");
#nullable restore
#line 50 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
   Write(Html.DisplayFor(modelItem => item.Rubrique));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r    </td>\r\r</tr>            ");
#nullable restore
#line 53 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Location\AfficherLocation.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r        </tbody>\r\r    </table>\r</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projet2_BDD.Models.Location>> Html { get; private set; }
    }
}
#pragma warning restore 1591