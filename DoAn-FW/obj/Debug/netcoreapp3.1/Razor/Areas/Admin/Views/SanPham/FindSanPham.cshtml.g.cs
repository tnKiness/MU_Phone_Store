#pragma checksum "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31e0a77b3646ee68073780777bba9d9cd6de28bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SanPham_FindSanPham), @"mvc.1.0.view", @"/Areas/Admin/Views/SanPham/FindSanPham.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e0a77b3646ee68073780777bba9d9cd6de28bd", @"/Areas/Admin/Views/SanPham/FindSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SanPham_FindSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.SanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""content-wrapper"" style=""min-height: 639px;"">
        <section class=""content-header"">
            <h1>
                <i class=""glyphicon glyphicon-phone""></i>Danh sách sản phẩm
            </h1>
        </section>
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-header with-border"">
                            <div class=""box-body"">
                                <div class=""row"" style=""padding:0px; margin:0px; height: 1000px;"">
                                    <div class=""table-responsive"">
");
#nullable restore
#line 17 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                         if (Model.Any())
                                         { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                         <table class=""table table-hover table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-center"" style=""width:70px"">Mã TTSP</th>
                                                    <th>Tên sản phẩm</th>
                                                    <th>Hình ảnh</th>
                                                    <th>Loại sản phẩm</th>
                                                    <th>Thương hiệu</th>
                                                    <th>Số lượng</th>
                                                    <th class=""text-center"" colspan=""2"">Thao tác</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 32 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"text-center\">");
#nullable restore
#line 35 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                                                           Write(item.MATTSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td style=\"font-size: 16px;\">");
#nullable restore
#line 36 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                                                                Write(item.TENSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td style=\"width:120px\">\r\n                                                            <img");
            BeginWriteAttribute("src", " src=\"", 2321, "\"", 2340, 1);
#nullable restore
#line 38 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
WriteAttributeValue("", 2327, item.HINHANH, 2327, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Điện thoại Iphone 13 ProMax\" class=\"img-responsive\">\r\n                                                        </td>\r\n                                                        <td>");
#nullable restore
#line 40 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                                       Write(item.MALOAISP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 41 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                                       Write(item.MATH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 42 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                                       Write(item.SOLUONG);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"text-center\">\r\n                                                            <a class=\"btn btn-success btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 2877, "\"", 2926, 2);
            WriteAttributeValue("", 2884, "/Admin/SanPham/ViewSanPham?Id=", 2884, 30, true);
#nullable restore
#line 44 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
WriteAttributeValue("", 2914, item.MATTSP, 2914, 12, false);

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
            BeginWriteAttribute("href", " href=\"", 3362, "\"", 3413, 2);
            WriteAttributeValue("", 3369, "/Admin/SanPham/DeleteSanPham?Id=", 3369, 32, true);
#nullable restore
#line 49 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
WriteAttributeValue("", 3401, item.MATTSP, 3401, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" Sonclick=""return confirm('Xác nhận xóa sản phẩm này ?')"" role=""button"">
                                                                <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 54 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\r\n                                         </table>\r\n");
#nullable restore
#line 57 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>Không tìm thấy sản phẩm</p>\r\n");
#nullable restore
#line 61 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\SanPham\FindSanPham.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591