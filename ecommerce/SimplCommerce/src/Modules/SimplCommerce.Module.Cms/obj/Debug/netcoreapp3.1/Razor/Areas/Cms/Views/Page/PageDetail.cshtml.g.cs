#pragma checksum "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45d374b0be37aa0567aa79c4b3e6ae5428483438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cms_Views_Page_PageDetail), @"mvc.1.0.view", @"/Areas/Cms/Views/Page/PageDetail.cshtml")]
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
#line 1 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45d374b0be37aa0567aa79c4b3e6ae5428483438", @"/Areas/Cms/Views/Page/PageDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b78f39d77f59319d109ccd8a079aed7a26e54b", @"/Areas/Cms/Views/_ViewImports.cshtml")]
    public class Areas_Cms_Views_Page_PageDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.PageVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
  
    ViewBag.Title = Model.MetaTitle ?? Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("additionalMeta", async() => {
                WriteLiteral("\r\n    <meta name=\"title\"");
                BeginWriteAttribute("content", " content=\"", 173, "\"", 197, 1);
#nullable restore
#line 8 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
WriteAttributeValue("", 183, ViewBag.Title, 183, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 228, "\"", 257, 1);
#nullable restore
#line 9 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
WriteAttributeValue("", 238, Model.MetaKeywords, 238, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 291, "\"", 323, 1);
#nullable restore
#line 10 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
WriteAttributeValue("", 301, Model.MetaDescription, 301, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            WriteLiteral("\r\n<div>");
#nullable restore
#line 13 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Cms\Areas\Cms\Views\Page\PageDetail.cshtml"
Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.PageVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
