#pragma checksum "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "357ac1e3fda8a9dd906b20abecb3084fbcadb32f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"357ac1e3fda8a9dd906b20abecb3084fbcadb32f", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7753acc99ce0d5d4a34e6aebf16bf4c2cb725d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.TopMenuModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Shared\Components\TopMenu\Default.cshtml"
 foreach (var item in Model.ListMenu)
{

#line default
#line hidden
            BeginContext(72, 49, true);
            WriteLiteral("    <li class=\"nav-item\"><a class=\"pl-3 nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 121, "\"", 152, 2);
            WriteAttributeValue("", 128, "/Category/", 128, 10, true);
#line 5 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 138, item.MenuName, 138, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(153, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(155, 13, false);
#line 5 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                             Write(item.MenuName);

#line default
#line hidden
            EndContext();
            BeginContext(168, 40, true);
            WriteLiteral("<span class=\"sr-only\"></span></a></li>\r\n");
            EndContext();
#line 6 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Shared\Components\TopMenu\Default.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.TopMenuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591