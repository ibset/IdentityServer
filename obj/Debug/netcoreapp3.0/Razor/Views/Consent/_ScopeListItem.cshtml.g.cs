#pragma checksum "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e916465fd981ea3155ca4454e1b61acecfd3160"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent__ScopeListItem), @"mvc.1.0.view", @"/Views/Consent/_ScopeListItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e916465fd981ea3155ca4454e1b61acecfd3160", @"/Views/Consent/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer.Web.Models.AccountViewModels.ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 225, "\"", 264, 2);
            WriteAttributeValue("", 246, "scopes_", 246, 7, true);
#nullable restore
#line 8 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
WriteAttributeValue("", 253, Model.Name, 253, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 265, "\"", 300, 1);
#nullable restore
#line 9 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
WriteAttributeValue("", 289, Model.Name, 289, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 301, "\"", 341, 1);
#nullable restore
#line 10 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
WriteAttributeValue("", 327, Model.Checked, 327, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 342, "\"", 384, 1);
#nullable restore
#line 11 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
WriteAttributeValue("", 369, Model.Required, 369, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 506, "\"", 545, 1);
#nullable restore
#line 16 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
WriteAttributeValue("", 534, Model.Name, 534, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line 18 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 19 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
#nullable restore
#line 22 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\r\n");
#nullable restore
#line 24 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\r\n");
#nullable restore
#line 27 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 933, "\"", 957, 2);
            WriteAttributeValue("", 939, "scopes_", 939, 7, true);
#nullable restore
#line 31 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
WriteAttributeValue("", 946, Model.Name, 946, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 33 "/home/ibfm/Documentos/Repositories/ibset.ssoserver/SSO-Server/IdentityServer.Web/Views/Consent/_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer.Web.Models.AccountViewModels.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
