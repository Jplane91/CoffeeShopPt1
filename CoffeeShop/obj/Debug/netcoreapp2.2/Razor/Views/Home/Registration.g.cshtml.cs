#pragma checksum "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f58eba548df880c33384790157032ba468f5ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registration.cshtml", typeof(AspNetCore.Views_Home_Registration))]
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
#line 1 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#line 2 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f58eba548df880c33384790157032ba468f5ff", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Registration.cshtml"
  
    ViewData["Title"] = "Registration Form";

#line default
#line hidden
            BeginContext(53, 32, true);
            WriteLiteral("\r\n<h1>Registration Form</h1>\r\n\r\n");
            EndContext();
#line 7 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Registration.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(120, 23, false);
#line 9 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Registration.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(152, 21, false);
#line 11 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Registration.cshtml"
Write(Html.EditorForModel());

#line default
#line hidden
            EndContext();
            BeginContext(177, 44, true);
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
            EndContext();
#line 14 "/Users/mac/Projects/CoffeeShop/CoffeeShop/Views/Home/Registration.cshtml"

}

#line default
#line hidden
            BeginContext(991, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
