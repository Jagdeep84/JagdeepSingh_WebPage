#pragma checksum "H:\web\JagdeepSingh_webPage\JagdeepSingh_webPage\Pages\Arraypage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc2be12c97efb38af962ecf83fbd87110b36918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(JagdeepSingh_webPage.Pages.Pages_Arraypage), @"mvc.1.0.razor-page", @"/Pages/Arraypage.cshtml")]
namespace JagdeepSingh_webPage.Pages
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
#line 1 "H:\web\JagdeepSingh_webPage\JagdeepSingh_webPage\Pages\_ViewImports.cshtml"
using JagdeepSingh_webPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc2be12c97efb38af962ecf83fbd87110b36918", @"/Pages/Arraypage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"884932ccb8cd18f4fcd99f29fb0ef253a0ca27e1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Arraypage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "H:\web\JagdeepSingh_webPage\JagdeepSingh_webPage\Pages\Arraypage.cshtml"
  
    ViewData["Title"] = "Top Authors";
    string[] names = new string[4];
    names[0] = "Jagdeep Singh";
    names[1] = "Gurdeep Singh";
    names[2] = "Amrit Mathur";
    names[3] = "Gagandeep Kaur";


#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"text-center\">\r\n    <h1 class=\"font-weight-bold\">");
#nullable restore
#line 13 "H:\web\JagdeepSingh_webPage\JagdeepSingh_webPage\Pages\Arraypage.cshtml"
                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</section>\r\n<ol>\r\n");
#nullable restore
#line 16 "H:\web\JagdeepSingh_webPage\JagdeepSingh_webPage\Pages\Arraypage.cshtml"
     for (int i = 0; i < names.Length; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li> ");
#nullable restore
#line 18 "H:\web\JagdeepSingh_webPage\JagdeepSingh_webPage\Pages\Arraypage.cshtml"
        Write(names[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 19 "H:\web\JagdeepSingh_webPage\JagdeepSingh_webPage\Pages\Arraypage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n</ol>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JagdeepSingh_webPage.Pages.ArraypageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JagdeepSingh_webPage.Pages.ArraypageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JagdeepSingh_webPage.Pages.ArraypageModel>)PageContext?.ViewData;
        public JagdeepSingh_webPage.Pages.ArraypageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
