#pragma checksum "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da6c56571888e373d1b9a2c6b1556f30f5be3f91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Event_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Event/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Event/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Event_Detail))]
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
#line 1 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.Models;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\_ViewImports.cshtml"
using EducationBackendFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da6c56571888e373d1b9a2c6b1556f30f5be3f91", @"/Areas/Admin/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3109889607af79c9a88ab44a896fdd41fc962b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UpComingEvent>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(64, 25, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(89, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1853773db8bd427697b7f4d84ce49d0f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 99, "~/img/event/", 99, 12, true);
#line 7 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 111, Model.Image, 111, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(152, 134, true);
            WriteLiteral("\r\n\r\n</div>\r\n<div class=\"row mt-5\">\r\n    <div class=\"col-2\">\r\n        <h6>Title</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(287, 11, false);
#line 15 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(298, 156, true);
            WriteLiteral("</p>\r\n    </div>\r\n    \r\n\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Month</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(455, 28, false);
#line 25 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Month.ToString("MMMM"));

#line default
#line hidden
            EndContext();
            BeginContext(483, 146, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Day</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(630, 24, false);
#line 33 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Day.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(654, 152, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>StartTime</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(807, 36, false);
#line 41 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.StartTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(843, 145, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-2\">\r\n        <h6>EndTime</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(989, 34, false);
#line 49 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.EndTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 154, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Description</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
            EndContext();
            BeginContext(1178, 17, false);
#line 57 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1195, 152, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Speaker</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <ul>\r\n");
            EndContext();
#line 66 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
             foreach (var item in Model.SpeakerEvents)
            {


#line default
#line hidden
            BeginContext(1420, 44, true);
            WriteLiteral("                <li style=\"list-style:none\">");
            EndContext();
            BeginContext(1465, 17, false);
#line 69 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"
                                       Write(item.Speaker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1482, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 70 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Areas\Admin\Views\Event\Detail.cshtml"

            }

#line default
#line hidden
            BeginContext(1506, 69, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n  \r\n</div>\r\n\r\n<div class=\"row mt-3\">\r\n    ");
            EndContext();
            BeginContext(1575, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f74adc6a8d4e477db2fb2e0d44f310b0", async() => {
                BeginContext(1618, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1629, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpComingEvent> Html { get; private set; }
    }
}
#pragma warning restore 1591
