#pragma checksum "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7318449ce7a985eafa459b12057b7134bc8d28b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7318449ce7a985eafa459b12057b7134bc8d28b5", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef72596d33c46faa445a11c496b3f2fbb339b136", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcCookieSample.ViewModels.ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 71, true);
            WriteLiteral("\r\n<p>Consent Page</p>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-10\">\r\n");
            EndContext();
#line 6 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
         if (!string.IsNullOrEmpty(Model.ClientLogoUrl))
        {

#line default
#line hidden
            BeginContext(192, 21, true);
            WriteLiteral("            <div><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 213, "\"", 239, 1);
#line 8 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
WriteAttributeValue("", 219, Model.ClientLogoUrl, 219, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(240, 11, true);
            WriteLiteral(" /></div>\r\n");
            EndContext();
#line 9 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(262, 26, true);
            WriteLiteral("        <h1>\r\n            ");
            EndContext();
            BeginContext(289, 16, false);
#line 11 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
       Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(305, 129, true);
            WriteLiteral("\r\n            <small>希望使用你的账户</small>\r\n        </h1>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-8\">\r\n        ");
            EndContext();
            BeginContext(434, 2197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7318449ce7a985eafa459b12057b7134bc8d28b56693", async() => {
                BeginContext(473, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(487, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7318449ce7a985eafa459b12057b7134bc8d28b57087", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 19 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(530, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(619, 63, true);
                WriteLiteral("            <div class=\"alert alert-danger\" >\r\n                ");
                EndContext();
                BeginContext(682, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7318449ce7a985eafa459b12057b7134bc8d28b59080", async() => {
                    BeginContext(731, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 25 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(755, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 28 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
             if (Model.IdentityScopes.Any())
            {

#line default
#line hidden
                BeginContext(838, 311, true);
                WriteLiteral(@"                <div class=""panel"">
                    <div class=""panel-heading"">
                        <span class=""glyphicon glyphicon-user"">
                            用户信息
                        </span>
                    </div>
                </div>
                <ul class=""list-group"">
");
                EndContext();
#line 38 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                     foreach (var item in Model.IdentityScopes)
                    {
                        

#line default
#line hidden
                BeginContext(1262, 35, false);
#line 40 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                   Write(Html.Partial("_Scopelistitem",item));

#line default
#line hidden
                EndContext();
#line 40 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                                                            ;

                    }

#line default
#line hidden
                BeginContext(1325, 23, true);
                WriteLiteral("                </ul>\r\n");
                EndContext();
#line 44 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1363, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 45 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
             if (Model.ResourceScopes.Any())
            {


#line default
#line hidden
                BeginContext(1426, 312, true);
                WriteLiteral(@"                <div class=""panel"">
                    <div class=""panel-heading"">
                        <span class=""glyphicon glyphicon-tasks"">
                            应用权限
                        </span>
                    </div>
                </div>
                <ul class=""list-group"">
");
                EndContext();
#line 56 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                     foreach (var item in Model.ResourceScopes)
                    {
                        

#line default
#line hidden
                BeginContext(1851, 35, false);
#line 58 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                   Write(Html.Partial("_Scopelistitem",item));

#line default
#line hidden
                EndContext();
#line 58 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                                                            ;

                    }

#line default
#line hidden
                BeginContext(1914, 23, true);
                WriteLiteral("                </ul>\r\n");
                EndContext();
#line 62 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1952, 52, true);
                WriteLiteral("        <div>\r\n            <label>\r\n                ");
                EndContext();
                BeginContext(2004, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7318449ce7a985eafa459b12057b7134bc8d28b514471", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 65 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2056, 274, true);
                WriteLiteral(@"
                <strong>记住我的选择</strong>
            </label>
        </div>
            <div>
                <button name=""button"" value=""yes"" class=""btn btn-primary"" >同意</button>
                <button name=""button"" value=""no"" class=""btn btn-default"">取消</button>
");
                EndContext();
#line 72 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                 if (!string.IsNullOrEmpty(Model.ClientUrl))
                {

#line default
#line hidden
                BeginContext(2411, 87, true);
                WriteLiteral("                    <a>\r\n                        <strong>\r\n                            ");
                EndContext();
                BeginContext(2499, 15, false);
#line 76 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                       Write(Model.ClientUrl);

#line default
#line hidden
                EndContext();
                BeginContext(2514, 63, true);
                WriteLiteral("\r\n                        </strong>\r\n                    </a>\r\n");
                EndContext();
#line 79 "E:\Project\Core\IdentityServer\MvcCookieSample\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2596, 28, true);
                WriteLiteral("            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2631, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcCookieSample.ViewModels.ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
