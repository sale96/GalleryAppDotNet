#pragma checksum "D:\Projects\Projects\C#\ASP\SimpleImageGallery\SimpleImageGallery\Views\Gallery\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "799fe22d341baff356080205584d7e81402d9d13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_index), @"mvc.1.0.view", @"/Views/Gallery/index.cshtml")]
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
#line 1 "D:\Projects\Projects\C#\ASP\SimpleImageGallery\SimpleImageGallery\Views\_ViewImports.cshtml"
using SimpleImageGallery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Projects\C#\ASP\SimpleImageGallery\SimpleImageGallery\Views\_ViewImports.cshtml"
using SimpleImageGallery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"799fe22d341baff356080205584d7e81402d9d13", @"/Views/Gallery/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f701001ece5f1e4801c5e1e3af21d00f1f376502", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleImageGallery.Models.GalleryIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"gallery-content\">\r\n");
#nullable restore
#line 5 "D:\Projects\Projects\C#\ASP\SimpleImageGallery\SimpleImageGallery\Views\Gallery\index.cshtml"
         foreach(var image in Model.Images)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"gallery-image-container\">\r\n                <div class=\"gallery-image\"");
            BeginWriteAttribute("style", " style=\"", 276, "\"", 318, 4);
            WriteAttributeValue("", 284, "background-image:", 284, 17, true);
            WriteAttributeValue(" ", 301, "url(", 302, 5, true);
#nullable restore
#line 8 "D:\Projects\Projects\C#\ASP\SimpleImageGallery\SimpleImageGallery\Views\Gallery\index.cshtml"
WriteAttributeValue("", 306, image.Url, 306, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 316, ");", 316, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            </div>\r\n");
#nullable restore
#line 10 "D:\Projects\Projects\C#\ASP\SimpleImageGallery\SimpleImageGallery\Views\Gallery\index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>    \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleImageGallery.Models.GalleryIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
