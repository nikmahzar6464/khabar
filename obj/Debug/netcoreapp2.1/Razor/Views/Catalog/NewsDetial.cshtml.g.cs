#pragma checksum "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38c028a9b55615af631bcb452b679e31debf5bdf"
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
#line 3 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38c028a9b55615af631bcb452b679e31debf5bdf", @"/Views/Catalog/NewsDetial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7753acc99ce0d5d4a34e6aebf16bf4c2cb725d60", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_NewsDetial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.NewsDetialModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
  
    Layout = "~/Views/Shared/_ColumnOne.cshtml";

#line default
#line hidden
            BeginContext(237, 147, true);
            WriteLiteral("\r\n\r\n<div class=\"container-fluid p-4\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            <img id=\"imgMainPic\" class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 384, "\"", 405, 1);
#line 15 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
WriteAttributeValue("", 390, Model.ImageUrl, 390, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 406, "\"", 424, 1);
#line 15 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
WriteAttributeValue("", 412, Model.Title, 412, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(425, 48, true);
            WriteLiteral(" style=\"height:400px;width:100%;cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 473, "\"", 520, 3);
            WriteAttributeValue("", 483, "location.href=\'/Catalog/", 483, 24, true);
#line 15 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
WriteAttributeValue("", 507, Model.Title, 507, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 519, "\'", 519, 1, true);
            EndWriteAttribute();
            BeginContext(521, 243, true);
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col-sm-8\">\r\n            <div class=\"row\">\r\n                <div class=\"card p-0\" style=\"width:100%;\">\r\n\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">عنوان: ");
            EndContext();
            BeginContext(765, 11, false);
#line 22 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
                                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(776, 59, true);
            WriteLiteral("</h5>\r\n\r\n                        <p class=\"card-text\">متن: ");
            EndContext();
            BeginContext(836, 14, false);
#line 24 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
                                             Write(Model.FullText);

#line default
#line hidden
            EndContext();
            BeginContext(850, 153, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">نام نویسنده: ");
            EndContext();
            BeginContext(1004, 18, false);
#line 34 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
                                                       Write(Model.UserLastName);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 65, true);
            WriteLiteral("</h5>\r\n\r\n                        <p class=\"card-text\">موضوع خبر: ");
            EndContext();
            BeginContext(1088, 18, false);
#line 36 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
                                                   Write(Model.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 68, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                    <hr />\r\n\r\n");
            EndContext();
#line 42 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
                     if (!signInManager.IsSignedIn(User))
                    {


#line default
#line hidden
            BeginContext(1258, 109, true);
            WriteLiteral("                        <h4>در صورتی که تمایل به ثبت نظر برروی این خبر را دارید میبایست وارد سایت شوید</h4>\r\n");
            EndContext();
#line 46 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1441, 107, true);
            WriteLiteral("                        <h4>ثبت نظر</h4>\r\n                        <div>\r\n\r\n\r\n\r\n                            ");
            EndContext();
            BeginContext(1548, 739, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793ea34153384280b0d1b526ae6b814a", async() => {
                BeginContext(1614, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1648, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a1c3a40ac144e429b08921ded745112", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 56 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(1684, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1718, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4dbe2583ae824fde90382fed354c84ac", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 57 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 57 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
                                                                     WriteLiteral(userManager.GetUserId(User));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1797, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1831, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3eacd3b1b82c4ad4ae5057907f1b7bfe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 58 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
                                                             WriteLiteral(Model.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1883, 96, true);
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    ");
                EndContext();
                BeginContext(1979, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42f6cd60aa7d41a4bef4a921b6873dc2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 60 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CommentName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2016, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2054, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b756f343b24c5d80b647ed2249fc99", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 61 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CommentName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2118, 162, true);
                WriteLiteral("\r\n                                </div>\r\n                                <button type=\"submit\" class=\"btn btn-primary\">ثبت</button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            BeginContext(2287, 44, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                        </div>\r\n");
            EndContext();
#line 71 "C:\Users\Nima\Desktop\FinalProjects\Khabar\Views\Catalog\NewsDetial.cshtml"
                    }

#line default
#line hidden
            BeginContext(2354, 196, true);
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
