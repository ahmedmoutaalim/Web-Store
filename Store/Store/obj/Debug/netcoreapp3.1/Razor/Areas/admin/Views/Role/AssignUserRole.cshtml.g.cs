#pragma checksum "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51a1c98cd0745cdd4644e8c62e818d9d66a0c90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Role_AssignUserRole), @"mvc.1.0.view", @"/Areas/admin/Views/Role/AssignUserRole.cshtml")]
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
#line 1 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\_ViewImports.cshtml"
using Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51a1c98cd0745cdd4644e8c62e818d9d66a0c90", @"/Areas/admin/Views/Role/AssignUserRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf4e815b3c664a1a42b413716bf96a575e49a98", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Role_AssignUserRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-info\">Assign User Role</h2>\n    </div>\n");
            WriteLiteral("</div>\n<br />\n<div>\n    <table class=\"table table-striped border\">\n        <tr class=\"table-info\">\n            <th>\n                User Name\n            </th>\n\n            <th>Role Name</th>\n        </tr>\n");
#nullable restore
#line 23 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml"
         foreach (var item in ViewBag.UserRoles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 26 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml"
   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 27 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml"
   Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("</tr>");
#nullable restore
#line 39 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js\"></script>\n    <script type=\"text/javascript\">\n        $(function(){\n            var save = \'");
#nullable restore
#line 47 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if(save!=\'\') {\n                alertify.success(save);\n            }\n            var edit = \'");
#nullable restore
#line 51 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if(edit!=\'\') {\n                alertify.success(edit);\n            }\n            var del = \'");
#nullable restore
#line 55 "C:\Users\Youcode\Desktop\Web-Store\Store\Store\Areas\admin\Views\Role\AssignUserRole.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\n            if (del!=\'\') {\n                alertify.error(del);\n            }\n        })\n    </script>\n");
            }
            );
            WriteLiteral("\n");
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
