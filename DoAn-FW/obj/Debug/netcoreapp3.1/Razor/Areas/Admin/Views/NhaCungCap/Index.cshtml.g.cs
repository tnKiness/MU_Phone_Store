#pragma checksum "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c8587ba339eb918938b9def0bef60bb70bca265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhaCungCap_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/NhaCungCap/Index.cshtml")]
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
#line 1 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c8587ba339eb918938b9def0bef60bb70bca265", @"/Areas/Admin/Views/NhaCungCap/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NhaCungCap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.NhaCungCap>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""content-wrapper"" style=""min-height: 639px;"">
        <section class=""content-header"">
            <h1>
                <i class=""glyphicon glyphicon-tower""></i>Danh sách nhà cung cấp
            </h1>
            <div class=""breadcrumb"">
                <div class=""searchbox"">
                    <input type=""text"" placeholder=""Search here"">
                    <a><i class=""fas fa-search-location""></i></a>
                </div>
                <a class=""btn btn-primary btn-sm"" href=""/Admin/NhaCungCap/ThemNCC"" role=""button"">
                    <span class=""glyphicon glyphicon-plus""></span>Thêm mới
                </a>
            </div>
        </section>
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-header with-border"">
                            <div class=""box-body"">
                                <div class=""row"" style=""pa");
            WriteLiteral(@"dding:0px; margin:0px;"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-hover table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-center"">Mã NCC</th>
                                                    <th>Tên nhà cung cấp</th>
                                                    <th>Email</th>
                                                    <th>Số điện thoại</th>
                                                    <th>Địa chỉ</th>
                                                    <th>Website</th>
                                                    <th class=""text-center"" colspan=""2"">Thao tác</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 39 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"text-center\">");
#nullable restore
#line 42 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
                                                                           Write(item.mancc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 43 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
                                                       Write(item.tenncc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 44 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
                                                       Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 45 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
                                                       Write(item.sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 46 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
                                                       Write(item.diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 47 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
                                                       Write(item.website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"text-center\">\r\n                                                            <a class=\"btn btn-success btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 2954, "\"", 3000, 2);
            WriteAttributeValue("", 2961, "/Admin/NhaCungCap/SuaNCC?id=", 2961, 28, true);
#nullable restore
#line 49 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
WriteAttributeValue("", 2989, item.mancc, 2989, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                                                                <span class=""glyphicon glyphicon-edit""></span>Sửa
                                                            </a>
                                                        </td>
                                                        <td class=""text-center"">
                                                            <a class=""btn btn-danger btn-xs""");
            BeginWriteAttribute("href", " href=\"", 3436, "\"", 3481, 2);
            WriteAttributeValue("", 3443, "/Admin/NhaCungCap/Index?id=", 3443, 27, true);
#nullable restore
#line 54 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
WriteAttributeValue("", 3470, item.mancc, 3470, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận xóa nhà cung cấp này ?')"" role=""button"">
                                                                <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 59 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\NhaCungCap\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </tbody>
                                        </table>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-md-12 text-center"">
                                            <ul class=""pagination"">
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.NhaCungCap>> Html { get; private set; }
    }
}
#pragma warning restore 1591