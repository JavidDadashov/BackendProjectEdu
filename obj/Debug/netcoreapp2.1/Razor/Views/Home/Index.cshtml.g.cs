#pragma checksum "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c2518113c256cf5e520f921dbe0f515a034a7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c2518113c256cf5e520f921dbe0f515a034a7f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3109889607af79c9a88ab44a896fdd41fc962b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("section-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSubscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_HomeLayout.cshtml";
   


#line default
#line hidden
            BeginContext(114, 178, true);
            WriteLiteral("\r\n<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n        <!-- Start Slingle Slide -->\r\n");
            EndContext();
#line 13 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
         foreach (Slider slider in Model.Sliders)
        {

#line default
#line hidden
            BeginContext(354, 42, true);
            WriteLiteral("            <div class=\"single-slide item\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 396, "\"", 452, 4);
            WriteAttributeValue("", 404, "background-image:", 404, 17, true);
            WriteAttributeValue(" ", 421, "url(/img/slider/", 422, 17, true);
#line 15 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
WriteAttributeValue("", 438, slider.Image, 438, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 451, ")", 451, 1, true);
            EndWriteAttribute();
            BeginContext(453, 436, true);
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-7 col-md-offset-left-5"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content"">
                                        ");
            EndContext();
            BeginContext(890, 22, false);
#line 23 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                   Write(Html.Raw(slider.Title));

#line default
#line hidden
            EndContext();
            BeginContext(912, 45, true);
            WriteLiteral("\r\n                                        <p>");
            EndContext();
            BeginContext(958, 18, false);
#line 24 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                      Write(slider.Description);

#line default
#line hidden
            EndContext();
            BeginContext(976, 374, true);
            WriteLiteral(@"</p>
                                        <a class=""default-btn"" href=""about.html"">Learn more</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Slider Content -->
            </div>
");
            EndContext();
#line 34 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1361, 359, true);
            WriteLiteral(@"
        <!-- End Slingle Slide -->

    </div>
</section>
<!-- Background Area End -->
<!-- Notice Start -->
<section class=""notice-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left"">
                    <h3>notice board</h3>
");
            EndContext();
#line 48 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                     foreach (var notice in Model.NoticeBoards)
                    {

#line default
#line hidden
            BeginContext(1808, 102, true);
            WriteLiteral("                        <div class=\"single-notice-left mb-25 pb-25\">\r\n                            <h4>");
            EndContext();
            BeginContext(1911, 42, false);
#line 51 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                           Write(notice.Date.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 38, true);
            WriteLiteral("</h4>\r\n                            <p>");
            EndContext();
            BeginContext(1992, 18, false);
#line 52 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                          Write(notice.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2010, 38, true);
            WriteLiteral("</p>\r\n                        </div>\r\n");
            EndContext();
#line 54 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2071, 143, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                <div class=\"notice-right\">\r\n");
            EndContext();
#line 59 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                     foreach (var noticeRight in Model.NoticeRightInfos)
                    {

#line default
#line hidden
            BeginContext(2311, 103, true);
            WriteLiteral("                        <div class=\"single-notice-right mb-25 pb-25\">\r\n                            <h3>");
            EndContext();
            BeginContext(2415, 17, false);
#line 62 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                           Write(noticeRight.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2432, 38, true);
            WriteLiteral("</h3>\r\n                            <p>");
            EndContext();
            BeginContext(2471, 23, false);
#line 63 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                          Write(noticeRight.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2494, 38, true);
            WriteLiteral("</p>\r\n                        </div>\r\n");
            EndContext();
#line 65 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2555, 394, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->
<!-- Choose Start -->
<section class=""choose-area pb-85 pt-77"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4"">
                <div class=""choose-content text-left"">
                    <h2>");
            EndContext();
            BeginContext(2950, 20, false);
#line 78 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                   Write(Model.WhyUs.Question);

#line default
#line hidden
            EndContext();
            BeginContext(2970, 25, true);
            WriteLiteral("</h2>\r\n                  ");
            EndContext();
            BeginContext(2996, 28, false);
#line 79 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
             Write(Html.Raw(Model.WhyUs.Answer));

#line default
#line hidden
            EndContext();
            BeginContext(3024, 434, true);
            WriteLiteral(@"
                    <a class=""default-btn"" href=""course-details.html"">view courses</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Choose Area End -->
<!-- Courses Area Start -->
<div class=""courses-area pt-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            EndContext();
            BeginContext(3458, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "009f4a3e5fec46e5919a04b1c90dcda6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(3512, 148, true);
            WriteLiteral("\r\n                    <h2>COURSES WE OFFER</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(3661, 39, false);
#line 99 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Course",3));

#line default
#line hidden
            EndContext();
            BeginContext(3700, 310, true);
            WriteLiteral(@"


        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Event Area Start -->
<div class=""event-area one text-center pt-140 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            EndContext();
            BeginContext(4010, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92bf392859de4778b922ee30ef89f2fc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(4064, 242, true);
            WriteLiteral("\r\n                    <h2>UPCOMMING EVENTS</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 col-sm-12 col-xs-12\">\r\n                <div class=\"single-event mb-35\">\r\n");
            EndContext();
#line 120 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                     foreach (var item in Model.UpComingEvents.Take(4))
                    {

#line default
#line hidden
            BeginContext(4402, 112, true);
            WriteLiteral("                        <div class=\"event-date\">\r\n                            <h3><a href=\"event-details.html\"> ");
            EndContext();
            BeginContext(4515, 23, false);
#line 123 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                         Write(item.Day.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(4538, 7, true);
            WriteLiteral(" <span>");
            EndContext();
            BeginContext(4546, 27, false);
#line 123 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                                        Write(item.Month.ToString("MMMM"));

#line default
#line hidden
            EndContext();
            BeginContext(4573, 240, true);
            WriteLiteral("</span></a></h3>\r\n                        </div>\r\n                        <div class=\"event-content text-left\">\r\n                            <div class=\"event-content-left\">\r\n                                <h4><a href=\"event-details.html\">");
            EndContext();
            BeginContext(4814, 10, false);
#line 127 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                            Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4824, 118, true);
            WriteLiteral("</a></h4>\r\n                                <ul>\r\n                                    <li><i class=\"fa fa-clock-o\"></i>");
            EndContext();
            BeginContext(4943, 35, false);
#line 129 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                Write(item.StartTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(4978, 2, true);
            WriteLiteral(" -");
            EndContext();
            BeginContext(4981, 33, false);
#line 129 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                                                      Write(item.EndTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(5014, 79, true);
            WriteLiteral("</li>\r\n                                    <li><i class=\"fa fa-map-marker\"></i>");
            EndContext();
            BeginContext(5094, 13, false);
#line 130 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                   Write(item.Location);

#line default
#line hidden
            EndContext();
            BeginContext(5107, 177, true);
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                            <div class=\"event-content-right\">\r\n                                ");
            EndContext();
            BeginContext(5284, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9877d94d90864ac1acd7a34e1e691a6d", async() => {
                BeginContext(5374, 8, true);
                WriteLiteral("join now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 134 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5386, 70, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 137 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(5481, 168, true);
            WriteLiteral("                </div>\r\n               \r\n            </div>\r\n            <div class=\"col-md-6 hidden-sm hidden-xs\">\r\n                <div class=\"single-event mb-35 \">\r\n");
            EndContext();
#line 144 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                     foreach (var item in Model.UpComingEvents.Skip(4).Take(4))
                    {

#line default
#line hidden
            BeginContext(5753, 113, true);
            WriteLiteral("                        <div class=\"event-date \">\r\n                            <h3><a href=\"event-details.html\"> ");
            EndContext();
            BeginContext(5867, 23, false);
#line 147 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                         Write(item.Day.ToString("dd"));

#line default
#line hidden
            EndContext();
            BeginContext(5890, 6, true);
            WriteLiteral("<span>");
            EndContext();
            BeginContext(5897, 27, false);
#line 147 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                                       Write(item.Month.ToString("MMMM"));

#line default
#line hidden
            EndContext();
            BeginContext(5924, 240, true);
            WriteLiteral("</span></a></h3>\r\n                        </div>\r\n                        <div class=\"event-content text-left\">\r\n                            <div class=\"event-content-left\">\r\n                                <h4><a href=\"event-details.html\">");
            EndContext();
            BeginContext(6165, 10, false);
#line 151 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                            Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(6175, 118, true);
            WriteLiteral("</a></h4>\r\n                                <ul>\r\n                                    <li><i class=\"fa fa-clock-o\"></i>");
            EndContext();
            BeginContext(6294, 35, false);
#line 153 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                Write(item.StartTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(6329, 2, true);
            WriteLiteral(" -");
            EndContext();
            BeginContext(6332, 33, false);
#line 153 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                                                      Write(item.EndTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(6365, 79, true);
            WriteLiteral("</li>\r\n                                    <li><i class=\"fa fa-map-marker\"></i>");
            EndContext();
            BeginContext(6445, 13, false);
#line 154 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                                                                   Write(item.Location);

#line default
#line hidden
            EndContext();
            BeginContext(6458, 308, true);
            WriteLiteral(@"</li>
                                </ul>
                            </div>
                            <div class=""event-content-right"">
                                <a class=""default-btn"" href=""event-details.html"">join now</a>
                            </div>
                        </div>
");
            EndContext();
#line 161 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(6791, 585, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<!-- Event Area End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
                <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                    <div class=""single-testimonial"">
                        <div class=""testimonial-info"">
                            <div class=""testimonial-img"">
                                ");
            EndContext();
            BeginContext(7376, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d8b6de2f1fc945dab0d5208f907c7a75", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7386, "~/img/testimonial/", 7386, 18, true);
#line 178 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7404, Model.Testimonial.Image, 7404, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7448, 137, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"testimonial-content\">\r\n                                <p> ");
            EndContext();
            BeginContext(7586, 23, false);
#line 181 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                               Write(Model.Testimonial.Title);

#line default
#line hidden
            EndContext();
            BeginContext(7609, 42, true);
            WriteLiteral("</p>\r\n                                <h4>");
            EndContext();
            BeginContext(7652, 22, false);
#line 182 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                               Write(Model.Testimonial.Name);

#line default
#line hidden
            EndContext();
            BeginContext(7674, 43, true);
            WriteLiteral("</h4>\r\n                                <h5>");
            EndContext();
            BeginContext(7718, 26, false);
#line 183 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
                               Write(Model.Testimonial.Position);

#line default
#line hidden
            EndContext();
            BeginContext(7744, 449, true);
            WriteLiteral(@"</h5>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            EndContext();
            BeginContext(8193, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5aea29b11d34e07a59210e120cc79d5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(8247, 148, true);
            WriteLiteral("\r\n                    <h2>LATEST FROM BLOG</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(8396, 37, false);
#line 205 "C:\Users\Cavid\Desktop\backendProect\EducationBackendFinal\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Blog",3));

#line default
#line hidden
            EndContext();
            BeginContext(8433, 90, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Area End -->\r\n<!-- Subscribe Start -->\r\n");
            EndContext();
            BeginContext(8523, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b19aead2487f4aafb78fa762ade873f7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8559, 26, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
