#pragma checksum "C:\Users\mnara\OneDrive\Plocha\chama-orientation-normal-exam2\chama-orientation-normal-exam\ErrorReport\ErrorReport\Views\Report\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c6c47fe03f5c0ab4485ec801c292a284ae3a0b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Index), @"mvc.1.0.view", @"/Views/Report/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/Index.cshtml", typeof(AspNetCore.Views_Report_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6c47fe03f5c0ab4485ec801c292a284ae3a0b7", @"/Views/Report/Index.cshtml")]
    public class Views_Report_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(10, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b4deb8c68840b4b7694ce15020b29e", async() => {
                BeginContext(16, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(22, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "987c52e7b0df4983abf64bba2adaea13", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(49, 35, true);
                WriteLiteral("\r\n    <title>Error Report</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(93, 1207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a0424ac2bd34ddaafa434ea86387613", async() => {
                BeginContext(99, 28, true);
                WriteLiteral("\r\n    <header>\r\n        <h1>");
                EndContext();
                BeginContext(128, 17, false);
#line 9 "C:\Users\mnara\OneDrive\Plocha\chama-orientation-normal-exam2\chama-orientation-normal-exam\ErrorReport\ErrorReport\Views\Report\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(145, 202, true);
                WriteLiteral("</h1>\r\n    </header>\r\n    <main>\r\n        <form action=\"/\" method=\"post\">\r\n            <div class=\"form-input\">\r\n                <label>Name:</label>\r\n                <select name=\"reporter\" required>\r\n");
                EndContext();
#line 16 "C:\Users\mnara\OneDrive\Plocha\chama-orientation-normal-exam2\chama-orientation-normal-exam\ErrorReport\ErrorReport\Views\Report\Index.cshtml"
                     foreach (var name in ViewBag.Names)
                    {

#line default
#line hidden
                BeginContext(428, 31, true);
                WriteLiteral("                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 459, "\"", 472, 1);
#line 18 "C:\Users\mnara\OneDrive\Plocha\chama-orientation-normal-exam2\chama-orientation-normal-exam\ErrorReport\ErrorReport\Views\Report\Index.cshtml"
WriteAttributeValue("", 467, name, 467, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(473, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(475, 4, false);
#line 18 "C:\Users\mnara\OneDrive\Plocha\chama-orientation-normal-exam2\chama-orientation-normal-exam\ErrorReport\ErrorReport\Views\Report\Index.cshtml"
                                         Write(name);

#line default
#line hidden
                EndContext();
                BeginContext(479, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 19 "C:\Users\mnara\OneDrive\Plocha\chama-orientation-normal-exam2\chama-orientation-normal-exam\ErrorReport\ErrorReport\Views\Report\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(513, 780, true);
                WriteLiteral(@"                </select>
            </div>
            <div class=""form-input"">
                <label for=""manufacturer"">Manufacturer:</label>
                <input type=""text"" name=""manufacturer"" id=""manufacturer"" />
            </div>
            <div class=""form-input"">
                <label for=""serialNumber"">Serial Number:</label>
                <input type=""text"" name=""serialNumber"" id=""serialNumber"" />
            </div>
            <div class=""form-input"">
                <label for=""text"">Description:</label>
                <input type=""text"" name=""description"" id=""description"" />
            </div>
            <div class=""form-input"">
                <button type=""submit"">Report</button>
            </div>
        </form>
    </main>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1300, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
