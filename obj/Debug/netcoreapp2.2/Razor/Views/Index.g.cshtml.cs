#pragma checksum "/Users/jdmead/Library/Mobile Documents/com~apple~CloudDocs/Coding Dojo/C#/ASP_MVC_I/razorFun/RazorFun/Views/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d99e974599d72e32ff13becc13d63d23b7fd0de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index), @"mvc.1.0.view", @"/Views/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Index.cshtml", typeof(AspNetCore.Views_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d99e974599d72e32ff13becc13d63d23b7fd0de", @"/Views/Index.cshtml")]
    public class Views_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d99e974599d72e32ff13becc13d63d23b7fd0de2863", async() => {
                BeginContext(39, 189, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Document</title>\n");
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
            BeginContext(235, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(236, 362, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d99e974599d72e32ff13becc13d63d23b7fd0de4223", async() => {
                BeginContext(242, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 10 "/Users/jdmead/Library/Mobile Documents/com~apple~CloudDocs/Coding Dojo/C#/ASP_MVC_I/razorFun/RazorFun/Views/Index.cshtml"
  
    var StringList = new List<string>
    {
        "Apple Pie",
        "Burritos",
        "Clams",
        "Donuts"
    };
        
    foreach(var word in StringList)
    {

#line default
#line hidden
                BeginContext(423, 29, true);
                WriteLiteral("        <div>\n            <p>");
                EndContext();
                BeginContext(453, 4, false);
#line 22 "/Users/jdmead/Library/Mobile Documents/com~apple~CloudDocs/Coding Dojo/C#/ASP_MVC_I/razorFun/RazorFun/Views/Index.cshtml"
          Write(word);

#line default
#line hidden
                EndContext();
                BeginContext(457, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
#line 23 "/Users/jdmead/Library/Mobile Documents/com~apple~CloudDocs/Coding Dojo/C#/ASP_MVC_I/razorFun/RazorFun/Views/Index.cshtml"
             if(word.Length < 4)
            {

#line default
#line hidden
                BeginContext(509, 20, true);
                WriteLiteral("                 <p>");
                EndContext();
                BeginContext(530, 4, false);
#line 25 "/Users/jdmead/Library/Mobile Documents/com~apple~CloudDocs/Coding Dojo/C#/ASP_MVC_I/razorFun/RazorFun/Views/Index.cshtml"
               Write(word);

#line default
#line hidden
                EndContext();
                BeginContext(534, 21, true);
                WriteLiteral(" is a short word</p>\n");
                EndContext();
#line 26 "/Users/jdmead/Library/Mobile Documents/com~apple~CloudDocs/Coding Dojo/C#/ASP_MVC_I/razorFun/RazorFun/Views/Index.cshtml"
            }

#line default
#line hidden
                BeginContext(569, 14, true);
                WriteLiteral("       </div>\n");
                EndContext();
#line 28 "/Users/jdmead/Library/Mobile Documents/com~apple~CloudDocs/Coding Dojo/C#/ASP_MVC_I/razorFun/RazorFun/Views/Index.cshtml"
    }

#line default
#line hidden
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
            BeginContext(598, 8, true);
            WriteLiteral("\n</html>");
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
