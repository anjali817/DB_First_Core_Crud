#pragma checksum "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2661ca922862b0e306d53726be4a7aa30ed1db13"
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
#line 1 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\_ViewImports.cshtml"
using CORE_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\_ViewImports.cshtml"
using CORE_CRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2661ca922862b0e306d53726be4a7aa30ed1db13", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd02921491ff911297a6728a0e01db44837cb4d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CORE_CRUD.Models.EMPModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 3 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
Write(HttpContextAccessor.HttpContext.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<style>\r\n    body {\r\n        background-color: #afe1e1;\r\n    }\r\n    table tr{\r\n        background-color : #ef8b8b;\r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2661ca922862b0e306d53726be4a7aa30ed1db134981", async() => {
                WriteLiteral("logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>ID</td>\r\n        <td>Name</td>\r\n        <td>Email</td>\r\n        <td>Mobile</td>\r\n        <td>Password</td>\r\n        <td>EDIT</td>\r\n        <td>DELETE</td>\r\n    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
           Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
           Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 960, "\"", 1007, 1);
#nullable restore
#line 37 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
WriteAttributeValue("", 967, Url.Action("Edit","Home",new {item.Id}), 967, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">EDIT</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1115, 1);
#nullable restore
#line 38 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
WriteAttributeValue("", 1073, Url.Action("Delete","Home",new {item.Id}), 1073, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">DELETE</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\admin\Desktop\Anjali Rai\New folder (2)\CORE_CRUD\CORE_CRUD\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CORE_CRUD.Models.EMPModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
