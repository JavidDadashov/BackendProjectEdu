#pragma checksum "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf758767f5ce025f55f090cb4e1821c5c64e5340"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Detail), @"mvc.1.0.view", @"/Views/Courses/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Detail.cshtml", typeof(AspNetCore.Views_Courses_Detail))]
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
#line 1 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\_ViewImports.cshtml"
using EducationBackendFinal.Models;

#line default
#line hidden
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\_ViewImports.cshtml"
using EducationBackendFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf758767f5ce025f55f090cb4e1821c5c64e5340", @"/Views/Courses/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3109889607af79c9a88ab44a896fdd41fc962b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:600px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://demo.devitems.com/eduhome/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/blog/blog-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSubscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(57, 816, true);
            WriteLiteral(@"
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>courses details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""courses-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""courses-details"">
                    <div class=""courses-details-img"">
                        ");
            EndContext();
            BeginContext(873, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22873d6d5807461c8ead146a1afb0b57", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 883, "~/img/course/", 883, 13, true);
#line 29 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
AddHtmlAttributeValue("", 896, Model.Image, 896, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(930, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"course-details-content\">\r\n                        <h2>");
            EndContext();
            BeginContext(1047, 11, false);
#line 32 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1058, 34, true);
            WriteLiteral("</h2>\r\n                        <p>");
            EndContext();
            BeginContext(1093, 17, false);
#line 33 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1110, 217, true);
            WriteLiteral("</p>\r\n                        <div class=\"course-details-left\">\r\n                            <div class=\"single-course-left\">\r\n                                <h3>about course</h3>\r\n                                <p>");
            EndContext();
            BeginContext(1328, 17, false);
#line 37 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                              Write(Model.AboutCourse);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 193, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"single-course-left\">\r\n                                <h3>how to apply</h3>\r\n                               <p>");
            EndContext();
            BeginContext(1539, 16, false);
#line 41 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                             Write(Model.HowToApply);

#line default
#line hidden
            EndContext();
            BeginContext(1555, 194, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"single-course-left\">\r\n                                <h3>certification</h3>\r\n                               <p>");
            EndContext();
            BeginContext(1750, 19, false);
#line 45 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                             Write(Model.Certification);

#line default
#line hidden
            EndContext();
            BeginContext(1769, 271, true);
            WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""course-details-right"">
                            <h3>COURSE FEATURES</h3>
                            <ul>
                                <li>starts <span>");
            EndContext();
            BeginContext(2041, 15, false);
#line 51 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                                            Write(Model.StartTime);

#line default
#line hidden
            EndContext();
            BeginContext(2056, 65, true);
            WriteLiteral("</span></li>\r\n                                <li>duration <span>");
            EndContext();
            BeginContext(2122, 14, false);
#line 52 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                                              Write(Model.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(2136, 77, true);
            WriteLiteral(" Month</span></li>\r\n                                <li>class duration <span>");
            EndContext();
            BeginContext(2214, 19, false);
#line 53 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                                                    Write(Model.ClassDuration);

#line default
#line hidden
            EndContext();
            BeginContext(2233, 74, true);
            WriteLiteral(" hours</span></li>\r\n                                <li>skill level <span>");
            EndContext();
            BeginContext(2308, 15, false);
#line 54 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                                                 Write(Model.SkilLevel);

#line default
#line hidden
            EndContext();
            BeginContext(2323, 71, true);
            WriteLiteral(" level</span></li>\r\n                                <li>language <span>");
            EndContext();
            BeginContext(2395, 14, false);
#line 55 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                                              Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(2409, 65, true);
            WriteLiteral("</span></li>\r\n                                <li>students <span>");
            EndContext();
            BeginContext(2475, 19, false);
#line 56 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                                              Write(Model.StudentsCount);

#line default
#line hidden
            EndContext();
            BeginContext(2494, 67, true);
            WriteLiteral("</span></li>\r\n                                <li>assesments <span>");
            EndContext();
            BeginContext(2562, 16, false);
#line 57 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                                                Write(Model.Assesments);

#line default
#line hidden
            EndContext();
            BeginContext(2578, 105, true);
            WriteLiteral("</span></li>\r\n                            </ul>\r\n                            <h3 class=\"red\">course fee $");
            EndContext();
            BeginContext(2684, 15, false);
#line 59 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                                                   Write(Model.CourseFee);

#line default
#line hidden
            EndContext();
            BeginContext(2699, 384, true);
            WriteLiteral(@"</h3>
                        </div>
                    </div>
                    <div class=""reply-area"">
                        <h3>LEAVE A REPLY</h3>
                        <p>I must explain to you how all this a mistaken idea of ncing great explorer of the rut<br> the is lder of human happinescias unde omnis iste natus error sit volptatem </p>
                        ");
            EndContext();
            BeginContext(3083, 1215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "793b14b07f3d4262b2f832318ef48606", async() => {
                BeginContext(3172, 1119, true);
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p>Name</p>
                                    <input type=""text"" name=""name"" id=""name"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Email</p>
                                    <input type=""text"" name=""email"" id=""email"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Subject</p>
                                    <input type=""text"" name=""subject"" id=""subject"">
                                    <p>Massage</p>
                                    <textarea name=""message"" id=""message"" cols=""15"" rows=""10""></textarea>
                                </div>
                            </div>
                            <a class=""reply-btn"" href=""#"" data-text=""send""><span>send message");
                WriteLiteral("</span></a>\r\n                            <p class=\"form-messege\"></p>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4298, 340, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            ");
            EndContext();
            BeginContext(4638, 339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57e9d2d38b5346b5991f151cbb1d20fc", async() => {
                BeginContext(4667, 303, true);
                WriteLiteral(@"
                                <input type=""search"" placeholder=""Search..."" name=""search"" />
                                <button type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4977, 254, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <h3>categories</h3>\r\n                        <ul>\r\n                            \r\n                           ");
            EndContext();
            BeginContext(5232, 39, false);
#line 105 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                      Write(await Component.InvokeAsync("Category"));

#line default
#line hidden
            EndContext();
            BeginContext(5271, 247, true);
            WriteLiteral("  \r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <div class=\"single-blog-banner\">\r\n                            <a href=\"blog-details.html\" id=\"blog\">");
            EndContext();
            BeginContext(5518, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "05b75ae5e14a469381c398832b6ccf07", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5564, 263, true);
            WriteLiteral(@"</a>
                            <h2>best<br> eductaion<br> theme</h2>
                        </div>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <h3>latest post</h3>
                        ");
            EndContext();
            BeginContext(5828, 43, false);
#line 116 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Courses\Detail.cshtml"
                   Write(await Component.InvokeAsync("LatestPost",3));

#line default
#line hidden
            EndContext();
            BeginContext(5871, 859, true);
            WriteLiteral(@"
                    </div>
                    <div class=""single-blog-widget"">
                        <h3>tags</h3>
                        <div class=""single-tag"">
                            <a href=""blog-details.html"" class=""mr-10 mb-10"">course</a>
                            <a href=""blog-details.html"" class=""mr-10 mb-10"">education</a>
                            <a href=""blog-details.html"" class=""mb-10"">teachers</a>
                            <a href=""blog-details.html"" class=""mr-10"">learning</a>
                            <a href=""blog-details.html"" class=""mr-10"">university</a>
                            <a href=""blog-details.html"">events</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Blog End -->
<!-- Subscribe Start -->
");
            EndContext();
            BeginContext(6730, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c2ad51e3c8e243dbbec58421840683de", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6765, 26, true);
            WriteLiteral("\r\n<!-- Subscribe End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
