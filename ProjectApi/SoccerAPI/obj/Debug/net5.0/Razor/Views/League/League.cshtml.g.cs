#pragma checksum "P:\GitRepositories\Webapps\MVCCoreWebAPI\ProjectApi\SoccerAPI\Views\League\League.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23227633c6692b1c9b65b6e895d3fd5c6d60edcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_League_League), @"mvc.1.0.view", @"/Views/League/League.cshtml")]
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
#line 1 "P:\GitRepositories\Webapps\MVCCoreWebAPI\ProjectApi\SoccerAPI\Views\_ViewImports.cshtml"
using SoccerAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\GitRepositories\Webapps\MVCCoreWebAPI\ProjectApi\SoccerAPI\Views\_ViewImports.cshtml"
using SoccerAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23227633c6692b1c9b65b6e895d3fd5c6d60edcf", @"/Views/League/League.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56db58d8205c2490cce484f5493ece107451ce58", @"/Views/_ViewImports.cshtml")]
    public class Views_League_League : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SoccerAPI.Models.JsonLeague>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "P:\GitRepositories\Webapps\MVCCoreWebAPI\ProjectApi\SoccerAPI\Views\League\League.cshtml"
  var data = ViewBag.Message;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nId: ");
#nullable restore
#line 5 "P:\GitRepositories\Webapps\MVCCoreWebAPI\ProjectApi\SoccerAPI\Views\League\League.cshtml"
Write(data.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Navn: ");
#nullable restore
#line 5 "P:\GitRepositories\Webapps\MVCCoreWebAPI\ProjectApi\SoccerAPI\Views\League\League.cshtml"
               Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", IsCup? ");
#nullable restore
#line 5 "P:\GitRepositories\Webapps\MVCCoreWebAPI\ProjectApi\SoccerAPI\Views\League\League.cshtml"
                                  Write(data.IsCup);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SoccerAPI.Models.JsonLeague> Html { get; private set; }
    }
}
#pragma warning restore 1591