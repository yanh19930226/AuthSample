#pragma checksum "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "714fc19f25e0585ba842248f35a3e9b966f16484"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent__Scopelistitem), @"mvc.1.0.view", @"/Views/Consent/_Scopelistitem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/_Scopelistitem.cshtml", typeof(AspNetCore.Views_Consent__Scopelistitem))]
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
#line 1 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\_ViewImports.cshtml"
using MvcCookieSample;

#line default
#line hidden
#line 2 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\_ViewImports.cshtml"
using MvcCookieSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"714fc19f25e0585ba842248f35a3e9b966f16484", @"/Views/Consent/_Scopelistitem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef72596d33c46faa445a11c496b3f2fbb339b136", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent__Scopelistitem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcCookieSample.ViewModels.ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 74, true);
            WriteLiteral("<li>\r\n    <label>\r\n\r\n        <input type=\"checkbox\" name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 125, "\"", 148, 2);
            WriteAttributeValue("", 130, "scopes_", 130, 7, true);
#line 5 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
WriteAttributeValue("", 137, Model.Name, 137, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 149, "\"", 168, 1);
#line 5 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
WriteAttributeValue("", 157, Model.Name, 157, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 169, "\"", 193, 1);
#line 5 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
WriteAttributeValue("", 179, Model.Checked, 179, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("disabled", " disabled=\"", 194, "\"", 220, 1);
#line 5 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
WriteAttributeValue("", 205, Model.Required, 205, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(221, 34, true);
            WriteLiteral("/>\r\n        <strong>\r\n            ");
            EndContext();
            BeginContext(256, 10, false);
#line 7 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(266, 21, true);
            WriteLiteral("\r\n        </strong>\r\n");
            EndContext();
#line 9 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
            BeginContext(328, 55, true);
            WriteLiteral("            <input type=\"hidden\" name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 383, "\"", 402, 1);
#line 11 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
WriteAttributeValue("", 391, Model.Name, 391, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(403, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 12 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
        }

#line default
#line hidden
            BeginContext(419, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 13 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
            BeginContext(461, 72, true);
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
            EndContext();
#line 16 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
        }

#line default
#line hidden
            BeginContext(544, 14, true);
            WriteLiteral("    </label>\r\n");
            EndContext();
#line 18 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
     if (string.IsNullOrEmpty(Model.Descripton))
    {

#line default
#line hidden
            BeginContext(615, 33, true);
            WriteLiteral("        <div>\r\n            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 648, "\"", 672, 2);
            WriteAttributeValue("", 654, "scopes_", 654, 7, true);
#line 21 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
WriteAttributeValue("", 661, Model.Name, 661, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(673, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(693, 16, false);
#line 22 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
           Write(Model.Descripton);

#line default
#line hidden
            EndContext();
            BeginContext(709, 40, true);
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n");
            EndContext();
#line 25 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\_Scopelistitem.cshtml"
    }

#line default
#line hidden
            BeginContext(756, 5, true);
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcCookieSample.ViewModels.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
