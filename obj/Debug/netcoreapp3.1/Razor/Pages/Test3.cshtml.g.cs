#pragma checksum "D:\study\workin\AspNetCore.Docs-master\AspNetCore.Docs-master\aspnetcore\fundamentals\configuration\index\samples\3.x\ConfigSample\Pages\Test3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e6476f2bd07f8ffda88f2bbb5e3d96d995738e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConfigSample.Pages.Pages_Test3), @"mvc.1.0.razor-page", @"/Pages/Test3.cshtml")]
namespace ConfigSample.Pages
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
#line 1 "D:\study\workin\AspNetCore.Docs-master\AspNetCore.Docs-master\aspnetcore\fundamentals\configuration\index\samples\3.x\ConfigSample\Pages\_ViewImports.cshtml"
using ConfigSample;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e6476f2bd07f8ffda88f2bbb5e3d96d995738e", @"/Pages/Test3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85846d0853d09d31b262bf9e1c507160dc9641dd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Test3 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<p>This content is never used. The preceding directives are required in Razor Pages.</p>

Test with the following:

dotnet run -k1=value1 -k2 value2 --alt3=value2 /alt4=value3 --alt5 value5 /alt6 value6
dotnet run -k1 value1 -k2 value2 --alt3=value2 /alt4=value3 --alt5 value5 /alt6 value6");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test3Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test3Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test3Model>)PageContext?.ViewData;
        public Test3Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
