#pragma checksum "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Home\HomeNewss.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3342855082faaf4bd4e921f06bee695943e994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomeNewss), @"mvc.1.0.view", @"/Views/Home/HomeNewss.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HomeNewss.cshtml", typeof(AspNetCore.Views_Home_HomeNewss))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3342855082faaf4bd4e921f06bee695943e994", @"/Views/Home/HomeNewss.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7753acc99ce0d5d4a34e6aebf16bf4c2cb725d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomeNewss : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.HomeNewsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 71, true);
            WriteLiteral("\r\n\r\n<div class=\"container-fluid col-sm-3 p-4\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 6 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Home\HomeNewss.cshtml"
         foreach (var product in Model.newslist)
        {

#line default
#line hidden
            BeginContext(161, 60, true);
            WriteLiteral("            <div class=\"col-sm-3 p-1\">\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(222, 47, false);
#line 11 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Home\HomeNewss.cshtml"
           Write(await Html.PartialAsync("_PictureBox", product));

#line default
#line hidden
            EndContext();
            BeginContext(269, 24, true);
            WriteLiteral("\r\n\r\n            </div>\r\n");
            EndContext();
#line 14 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Home\HomeNewss.cshtml"
        }

#line default
#line hidden
            BeginContext(304, 20, true);
            WriteLiteral("    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.HomeNewsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
