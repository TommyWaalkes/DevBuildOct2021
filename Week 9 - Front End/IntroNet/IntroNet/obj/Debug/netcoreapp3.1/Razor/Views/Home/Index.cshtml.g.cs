#pragma checksum "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\IntroNet\IntroNet\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "810bd1e134ebce44014913360aa6e3846081576a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\IntroNet\IntroNet\Views\_ViewImports.cshtml"
using IntroNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\IntroNet\IntroNet\Views\_ViewImports.cshtml"
using IntroNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"810bd1e134ebce44014913360aa6e3846081576a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f2b13d9ba2b8effc3c6bcb62cd07b253a67cb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--Any time in CSHTML you see an at symbol, that is server-side markup
    Server side markup get processed before the HTML is sent to the user 
    and comes in many different forms

    Server Side Markup comes in many forms so its hard to define, 
    but it helps you style your page, pull data in/out of a view, display data, 
    talk to databases, and much much more

    In particular, there's a subset of markup called Razor, 
    which allows you to use C# syntax in your view. 
    Most commonly razor is used to iterate through lists/arrays and to print data into the view
    with Razor all C# features are there BUT scope only exists in that view, 
    nothing will persist once you move away from the view

    With pure .Net Razor is useful, with Angular/.Net Razor isn't need since most functions are handled by angular 
    -->

");
#nullable restore
#line 18 "C:\Users\Tommy\Desktop\Dev Build Class Repo\Week 9 - Front End\IntroNet\IntroNet\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<h2>Hello World!!!</h2>
<p>I'm making a web page it is neat!!!</p>
");
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
