#pragma checksum "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709ea3fbe1dae35d9ea0147864c2cbf710aa7094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_NewsDetial), @"mvc.1.0.view", @"/Views/Catalog/NewsDetial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/NewsDetial.cshtml", typeof(AspNetCore.Views_Catalog_NewsDetial))]
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
#line 3 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709ea3fbe1dae35d9ea0147864c2cbf710aa7094", @"/Views/Catalog/NewsDetial.cshtml")]
    public class Views_Catalog_NewsDetial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.NewsDetialModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
  
    Layout = "~/Views/Shared/_ColumnOne.cshtml";

#line default
#line hidden
            BeginContext(237, 147, true);
            WriteLiteral("\r\n\r\n<div class=\"container-fluid p-4\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            <img id=\"imgMainPic\" class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 384, "\"", 405, 1);
#line 15 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
WriteAttributeValue("", 390, Model.ImageUrl, 390, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 406, "\"", 424, 1);
#line 15 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
WriteAttributeValue("", 412, Model.Title, 412, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(425, 48, true);
            WriteLiteral(" style=\"height:400px;width:100%;cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 473, "\"", 520, 3);
            WriteAttributeValue("", 483, "location.href=\'/Catalog/", 483, 24, true);
#line 15 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
WriteAttributeValue("", 507, Model.Title, 507, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 519, "\'", 519, 1, true);
            EndWriteAttribute();
            BeginContext(521, 243, true);
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col-sm-8\">\r\n            <div class=\"row\">\r\n                <div class=\"card p-0\" style=\"width:100%;\">\r\n\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">عنوان: ");
            EndContext();
            BeginContext(765, 11, false);
#line 22 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
                                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(776, 59, true);
            WriteLiteral("</h5>\r\n\r\n                        <p class=\"card-text\">متن: ");
            EndContext();
            BeginContext(836, 14, false);
#line 24 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
                                             Write(Model.FullText);

#line default
#line hidden
            EndContext();
            BeginContext(850, 153, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">نام نویسنده: ");
            EndContext();
            BeginContext(1004, 18, false);
#line 34 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
                                                       Write(Model.UserLastName);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 65, true);
            WriteLiteral("</h5>\r\n\r\n                        <p class=\"card-text\">موضوع خبر: ");
            EndContext();
            BeginContext(1088, 18, false);
#line 36 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
                                                   Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 68, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                    <hr />\r\n\r\n");
            EndContext();
#line 42 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
                     if (!signInManager.IsSignedIn(User))
                    {


#line default
#line hidden
            BeginContext(1258, 109, true);
            WriteLiteral("                        <h4>در صورتی که تمایل به ثبت نظر برروی این خبر را دارید میبایست وارد سایت شوید</h4>\r\n");
            EndContext();
#line 46 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1441, 318, true);
            WriteLiteral(@"                        <h4>ثبت نظر</h4>
                        <div>



                            <form asp-controller=""comments"" asp-action=""Create"" method=""post"">
                                <input type=""hidden"" asp-for=""ID"" />
                                <input type=""hidden"" asp-for=""CustomerID""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1759, "\"", 1795, 1);
#line 57 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
WriteAttributeValue("", 1767, userManager.GetUserId(User), 1767, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1796, 72, true);
            WriteLiteral(">\r\n                                <input type=\"hidden\" asp-for=\"NewsID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1868, "\"", 1885, 1);
#line 58 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
WriteAttributeValue("", 1876, Model.ID, 1876, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1886, 449, true);
            WriteLiteral(@">
                                <div class=""form-group"">
                                    <label asp-for=""CommentName""></label>
                                    <textarea class=""form-control"" asp-for=""CommentName""></textarea>
                                </div>
                                <button type=""submit"" class=""btn btn-primary"">ثبت</button>
                            </form>





                        </div>
");
            EndContext();
#line 71 "C:\Users\ali\Desktop\tmp\1614068489\KhabarNahayee\Khabar\Views\Catalog\NewsDetial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2358, 196, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n\r\n                <div class=\"card p-0\" style=\"width:100%;\">\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Domains.Customer> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Domains.Customer> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.NewsDetialModel> Html { get; private set; }
    }
}
#pragma warning restore 1591