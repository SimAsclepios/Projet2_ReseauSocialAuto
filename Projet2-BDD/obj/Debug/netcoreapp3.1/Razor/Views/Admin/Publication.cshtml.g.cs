#pragma checksum "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4b2d5020fe0dfa441c13e6181f311e369f72d72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Publication), @"mvc.1.0.view", @"/Views/Admin/Publication.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b2d5020fe0dfa441c13e6181f311e369f72d72", @"/Views/Admin/Publication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc9a91fe437cbfe5388f91ef2cc4c7afcab136a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Publication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projet2_BDD.ViewModels.AllPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsDmd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsMat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsAuto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsMatLoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
   Layout = "~/Views/Shared/LayoutTest.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b2d5020fe0dfa441c13e6181f311e369f72d725038", async() => {
                WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 7 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
   Write(Html.ActionLink("Accueil Admin", "Index", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 7 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                                                         Write(Html.ActionLink("Voir les Litiges", "PublicationLitige", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>

    <table classe=""table"">
        <thead>
            <tr>

                <th>
                    Id Adhérent
                </th>

                <th>
                    Type Publication
                </th>

                <th>
                    Catégorie / Date Démarrage
                </th>
                <th>
                    Date de Création
                </th>

            </tr>
        </thead>


        <tbody>

");
#nullable restore
#line 35 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
              
                int dmdCount = 0;
                int matCount = 0;
                int eventCount = 0;
                int autoCount = 0;
                int matLoc = 0;
                int covoit = 0;

                for (int i = 0; i < (Model.Dmd.Count + Model.Event.Count + Model.Mat.Count + Model.Auto.Count + Model.LocMat.Count); i++)
                {

                    int choix = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral(" <!-- 1 : dmd    /   2 : Mat     3 : Event   4 : Location-->\r\n");
#nullable restore
#line 47 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                    DateTime dateMin = new DateTime(3000, 1, 1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <!-- Si erreur date null, declarer une date an 3000 ici, et remplacer les condition null en bas par cette date -->\r\n");
#nullable restore
#line 48 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                    DateTime compDate = new DateTime(3000, 1, 1);


                    try
                    {
                        if (dmdCount < Model.Dmd.Count)
                        {
                            dateMin = Model.Dmd[dmdCount].DatePub;
                            choix = 1;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    try
                    {
                        if (matCount < Model.Mat.Count)
                        {
                            if (Model.Mat[matCount].DatePub < dateMin || dateMin == compDate)
                            {
                                dateMin = Model.Mat[matCount].DatePub;
                                choix = 2;
                            }

                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    try
                    {
                        if (eventCount < Model.Event.Count)
                        {
                            if (Model.Event[eventCount].DatePub < dateMin || dateMin == compDate)
                            {
                                dateMin = Model.Event[eventCount].DatePub;
                                choix = 3;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }



                    try
                    {
                        if (autoCount < Model.Auto.Count)
                        {
                            if (Model.Auto[autoCount].DatePub < dateMin || dateMin == compDate)
                            {
                                dateMin = Model.Auto[autoCount].DatePub;
                                choix = 4;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    try
                    {
                        if (matCount < Model.LocMat.Count)
                        {
                            if (Model.LocMat[matLoc].DatePub < dateMin || dateMin == compDate)
                            {
                                dateMin = Model.LocMat[matCount].DatePub;
                                choix = 5;
                            }

                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                          

            if (choix == 0)
            {
                return;
            }

            if (choix == 1)
            {
                dmdCount++;


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 162 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Model.Dmd[dmdCount - 1].UtilisateurId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                Demande Service |\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 169 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.Dmd[dmdCount - 1].Categorie));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 173 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.Dmd[dmdCount - 1].DatePub));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n");
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b2d5020fe0dfa441c13e6181f311e369f72d7212426", async() => {
                    WriteLiteral("Détails");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 178 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                                                             WriteLiteral(Model.Dmd[dmdCount-1].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 183 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                        continue;
                    }
                    if (choix == 2)
                    {
                        matCount++;


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 192 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Model.Mat[matCount - 1].UtilisateurId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                Vente Matériel |\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 199 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.Mat[matCount - 1].Categorie));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 203 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.Mat[matCount - 1].DatePub));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n");
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b2d5020fe0dfa441c13e6181f311e369f72d7216682", async() => {
                    WriteLiteral("Détails");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 208 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                                                             WriteLiteral(Model.Mat[matCount-1].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 212 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                        continue;
                    }

                    if (choix == 3)
                    {
                        eventCount++;


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 222 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Model.Event[eventCount - 1].UtilisateurId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                Evenement |\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 229 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.Event[eventCount - 1].DateEvent));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 233 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.Event[eventCount - 1].DatePub));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n");
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b2d5020fe0dfa441c13e6181f311e369f72d7220945", async() => {
                    WriteLiteral("Détails");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 238 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                                                               WriteLiteral(Model.Event[eventCount-1].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 242 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                        continue;

                    }

                    if (choix == 4)
                    {
                        autoCount++;


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 253 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Model.Auto[autoCount - 1].UtilisateurId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                Location de voiture |\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 260 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.Auto[autoCount - 1].DispoDebut));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 264 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.Auto[autoCount - 1].DatePub));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n");
                WriteLiteral("  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b2d5020fe0dfa441c13e6181f311e369f72d7225190", async() => {
                    WriteLiteral("Détails");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 269 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                                                                    WriteLiteral(Model.Auto[autoCount-1].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 274 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                        continue;
                    }
                    if (choix == 5)
                    {
                        matCount++;


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 283 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Model.LocMat[matLoc - 1].UtilisateurId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                Location Matériel |\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 290 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.LocMat[matLoc - 1].Titre));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 294 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.LocMat[matLoc - 1].DatePub));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            </td>\r\n\r\n                            <td>\r\n");
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b2d5020fe0dfa441c13e6181f311e369f72d7229457", async() => {
                    WriteLiteral("Détails");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 299 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                                                                WriteLiteral(Model.LocMat[matCount-1].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 303 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                        continue;
                    }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 335 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Admin\Publication.cshtml"
                      
                }


            

#line default
#line hidden
#nullable disable
                WriteLiteral("            }\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet2_BDD.ViewModels.AllPost> Html { get; private set; }
    }
}
#pragma warning restore 1591