#pragma checksum "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6568d749962cbde01fd523972605a9353469def"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Acceuil), @"mvc.1.0.view", @"/Views/Home/Acceuil.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6568d749962cbde01fd523972605a9353469def", @"/Views/Home/Acceuil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc9a91fe437cbfe5388f91ef2cc4c7afcab136a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Acceuil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projet2_BDD.Models.Messagerie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
   
    ViewData["Title"] = "Home page";
    Layout = "~/Views/Shared/LayoutTest.cshtml";
    var userName = User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\" jumbotron bg-light\">\r\n    <h2 class=\" \" text-center text-primary\">\r\n        <i class=\"fab fa-facebook-messenger\"></i>&nbsp; Chat\r\n    </h2>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\" id=\"chat\">\r\n");
#nullable restore
#line 14 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
                 foreach (var message in Model.OrderBy(m => m.DateMessage))
                {
                    string containerClass, timePosition, textAlign, contcolor, offset;
                    if (userName == message.UserName)
                    { 

                        containerClass = "container dark";
                        timePosition = "time-right text-light";
                        textAlign = "text-right text-white";
                        contcolor = "bg-primary";
                        offset = "col-md-6 offset-md-6";
                    }
                    else
                    {
                        containerClass = "container";
                        timePosition = "time-left";
                        textAlign = "text-left";
                        contcolor = "bg-light";
                        offset = "";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\" row\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1410, "\"", 1425, 1);
#nullable restore
#line 37 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
WriteAttributeValue("", 1418, offset, 1418, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1453, "\"", 1489, 3);
#nullable restore
#line 38 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
WriteAttributeValue(" ", 1461, containerClass, 1462, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
WriteAttributeValue(" ", 1477, contcolor, 1478, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1488, "", 1489, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <p");
            BeginWriteAttribute("class", " class=\"", 1519, "\"", 1544, 2);
            WriteAttributeValue("", 1527, "sender", 1527, 6, true);
#nullable restore
#line 39 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
WriteAttributeValue(" ", 1533, textAlign, 1534, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
                                                Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p");
            BeginWriteAttribute("class", " class=\"", 1595, "\"", 1614, 1);
#nullable restore
#line 40 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
WriteAttributeValue(" ", 1603, textAlign, 1604, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
                                          Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <span");
            BeginWriteAttribute("class", " class=\"", 1667, "\"", 1689, 1);
#nullable restore
#line 41 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
WriteAttributeValue(" ", 1675, timePosition, 1676, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
                                                Write(message.DateMessage.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-12\">\r\n");
#nullable restore
#line 50 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
              using (Html.BeginForm("Create", "Home", FormMethod.Post)) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
                                                                     Write(Html.Label("Text", "Saissez le message si tu es déja un Adhérent "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
                                                                                                                                            Write(Html.TextBox("Text", null, new { id = "MessageText", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
            WriteLiteral("            <input type=\"submit\" value=\" Envoyer\" id=\"submitButton\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 53 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
       Write(Html.TextBox("username", "@userName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 54 "C:\Developpement\WorkSpace\C_sharp\Projet2-BDD-V8\Projet2-BDD\Views\Home\Acceuil.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    </div>\r\n      \r\n    </div>\r\n\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projet2_BDD.Models.Messagerie>> Html { get; private set; }
    }
}
#pragma warning restore 1591