#pragma checksum "C:\Users\Asus\MyMVC_ControllerDemo\MyMVC_ControllerDemo\Views\Student\StudentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa79eda8f3deef32f1a7ba85ad777ad61ee3c80b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentDetails), @"mvc.1.0.view", @"/Views/Student/StudentDetails.cshtml")]
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
#line 1 "C:\Users\Asus\MyMVC_ControllerDemo\MyMVC_ControllerDemo\Views\_ViewImports.cshtml"
using MyMVC_ControllerDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\MyMVC_ControllerDemo\MyMVC_ControllerDemo\Views\_ViewImports.cshtml"
using MyMVC_ControllerDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa79eda8f3deef32f1a7ba85ad777ad61ee3c80b", @"/Views/Student/StudentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc3a9224a63bb11cae0505b48a6f1693292ee82", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_StudentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyMVC_ControllerDemo.Models.Student>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>Id:");
#nullable restore
#line 2 "C:\Users\Asus\MyMVC_ControllerDemo\MyMVC_ControllerDemo\Views\Student\StudentDetails.cshtml"
  Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>First Name:");
#nullable restore
#line 3 "C:\Users\Asus\MyMVC_ControllerDemo\MyMVC_ControllerDemo\Views\Student\StudentDetails.cshtml"
          Write(Model.fName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Last Name:");
#nullable restore
#line 4 "C:\Users\Asus\MyMVC_ControllerDemo\MyMVC_ControllerDemo\Views\Student\StudentDetails.cshtml"
         Write(Model.lName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyMVC_ControllerDemo.Models.Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
