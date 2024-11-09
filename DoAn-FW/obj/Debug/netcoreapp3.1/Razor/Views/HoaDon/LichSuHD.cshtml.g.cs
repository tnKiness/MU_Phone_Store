#pragma checksum "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d91060dc29280162d1be7a651f3bfb8c2185fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_LichSuHD), @"mvc.1.0.view", @"/Views/HoaDon/LichSuHD.cshtml")]
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
#line 1 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\_ViewImports.cshtml"
using DoAn_FW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\_ViewImports.cshtml"
using DoAn_FW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d91060dc29280162d1be7a651f3bfb8c2185fd", @"/Views/HoaDon/LichSuHD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3faed0a872865f7b5063ed88e6ca22051c9f0aa3", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_LichSuHD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
  
    List<HoaDon> ListHD = ViewBag.ListHD;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""mainmenu-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <div class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav"">
                    <li>
                        <a href=""/Home/Index"">Trang chủ</a>
                    </li>
                    <li>
                        <a href=""/TaiKhoan/ThongTinTK"">Thông tin cá nhân</a>
                    </li>
                    <li class=""active"">
                        <a href=""/HoaDon/LichSuHD"">
                            Quản lý đơn hàng cá nhân
                     ");
            WriteLiteral(@"   </a>
                    </li>
                    <li><a href=""/DSSPMua/DSSPMua"">Sản phẩm đã mua</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- End mainmenu area -->
<!-- End mainmenu area -->

<div class=""product-big-title-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""product-bit-title text-center"">
                    <h2>
                        Quản lý đơn hàng cá nhân
                    </h2>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Page title area -->

<div class=""single-product-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <div class=""row"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Mã hóa đơn</th>
                        <th scope=""col"">Tổng tiền</th>
                        <th scope=""col");
            WriteLiteral(@""">Ngày lập hóa đơn</th>
                        <th scope=""col"">Tình trạng</th>
                        <th scope=""col"">Giao hàng</th>
                        <th scope=""col"">Thanh toán</th>
                        <th scope=""col"" colspan=""2"" class=""text-center""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 69 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                     foreach (var item in ListHD)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 73 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                           Write(item.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 76 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                           Write(string.Format("{0:0,0 đ}",item.TongTienTT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 78 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                           Write(item.NgayLapHD.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 80 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                 if (@item.TinhTrangHD == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Chưa duyệt </p> ");
#nullable restore
#line 81 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                                     }
                                else if(@item.TinhTrangHD == -1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Đã hủy </p> ");
#nullable restore
#line 82 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                                                                 }
                                else {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Đã duyệt </p> ");
#nullable restore
#line 83 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 86 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                 if (@item.TinhTrangGH == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Chưa giao hàng </p> ");
#nullable restore
#line 87 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                                        }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Đã giao hàng </p>");
#nullable restore
#line 89 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 92 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                 if (@item.TinhTrangTT == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Chưa thanh toán </p> ");
#nullable restore
#line 93 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                                         }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Đã thanh toán </p>");
#nullable restore
#line 95 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <a class=\"btn btn-info btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 3885, "\"", 3920, 2);
            WriteAttributeValue("", 3892, "/HoaDon/CTHD?mahd=", 3892, 18, true);
#nullable restore
#line 98 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
WriteAttributeValue("", 3910, item.MaHD, 3910, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">\r\n                                    <span class=\"glyphicon glyphicon-eye-open\">Xem</span>\r\n                                </a>\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 103 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                 if (@item.TinhTrangHD == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 4301, "\"", 4349, 3);
            WriteAttributeValue("", 4308, "/HoaDon/CapNhatHD?mahd=", 4308, 23, true);
#nullable restore
#line 105 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
WriteAttributeValue("", 4331, item.MaHD, 4331, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4341, "&tthd=-1", 4341, 8, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">\r\n                                    <span class=\"glyphicon glyphicon-remove-circle\">Hủy</span>\r\n                                    </a>\r\n");
#nullable restore
#line 108 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                }
                                else if (@item.TinhTrangHD == -1) 
                                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn btn-success btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 4713, "\"", 4760, 3);
            WriteAttributeValue("", 4720, "/HoaDon/CapNhatHD?mahd=", 4720, 23, true);
#nullable restore
#line 111 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
WriteAttributeValue("", 4743, item.MaHD, 4743, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4753, "&tthd=0", 4753, 7, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">\r\n                                    <span class=\"glyphicon glyphicon-refresh\">Đặt lại</span>\r\n                                    </a>\r\n");
#nullable restore
#line 114 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 117 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\HoaDon\LichSuHD.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <hr>\r\n            <h4 class=\"text-center\">Hết</h4>\r\n        </div>\r\n    </div>\r\n</div>");
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