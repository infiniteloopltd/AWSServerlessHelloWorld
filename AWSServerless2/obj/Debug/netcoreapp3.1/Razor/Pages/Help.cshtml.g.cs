#pragma checksum "C:\Users\Fiach.000\source\repos\AWSServerless2\AWSServerless2\Pages\Help.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7090db67caa0b9929b2a8c7c3d8ec21d7f83e4e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AWSServerless2.Pages.Pages_Help), @"mvc.1.0.razor-page", @"/Pages/Help.cshtml")]
namespace AWSServerless2.Pages
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
#line 1 "C:\Users\Fiach.000\source\repos\AWSServerless2\AWSServerless2\Pages\_ViewImports.cshtml"
using AWSServerless2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7090db67caa0b9929b2a8c7c3d8ec21d7f83e4e1", @"/Pages/Help.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b636676735dedad4af21db1e71fcc5d1a360e8bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Help : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Fiach.000\source\repos\AWSServerless2\AWSServerless2\Pages\Help.cshtml"
  
    ViewData["Title"] = "Help";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Places to Find Additional Help.</h2>

<p></p>
<ul>
    <li><a href=""https://github.com/aws/aws-lambda-dotnet"">AWS Lambda .NET Core GitHub Repository</a></li>
    <li><a href=""https://github.com/aws/aws-sdk-net"">AWS SDK for .NET GitHub Repository</a></li>
    <li><a href=""https://aws.amazon.com/blogs/developer/category/net/"">AWS .NET Developer Blog</a></li>
    <li><a href=""https://twitter.com/awsfornet"">AWS .NET Twitter Handle</a></li>
    <li><a href=""https://aws.amazon.com/documentation/sdk-for-net/"">AWS .NET Developer Guide</a></li>
</ul>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelpModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelpModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelpModel>)PageContext?.ViewData;
        public HelpModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
