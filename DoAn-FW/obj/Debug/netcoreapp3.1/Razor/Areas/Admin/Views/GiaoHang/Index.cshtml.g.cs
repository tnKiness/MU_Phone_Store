#pragma checksum "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff3f17fd24bb3e836d9c8f133152e98ceab8ecc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GiaoHang_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/GiaoHang/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff3f17fd24bb3e836d9c8f133152e98ceab8ecc6", @"/Areas/Admin/Views/GiaoHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_GiaoHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.GiaoHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/GiaoHang/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/GiaoHang/HoanThanhGH"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
   int pages = Convert.ToInt32(ViewData["pages"]); int p = Convert.ToInt32(ViewData["page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\" style=\"min-height: 639px;\">\r\n    <section class=\"content-header\">\r\n        <h1><i class=\"glyphicon glyphicon-shopping-cart\"></i> Giao hàng</h1>\r\n        <div class=\"breadcrumb\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff3f17fd24bb3e836d9c8f133152e98ceab8ecc65319", async() => {
                WriteLiteral(@"
                <input type=""text"" placeholder=""Search here"" name=""Search"">
                <button type=""submit"" style=""width: 50px; height: 25px; background-color: darkcyan; border-radius: 10px; color: white; border-color: white; ""><i class=""fas fa-search-location""></i></button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n    <!-- Main content -->\r\n    <section class=\"content\">\r\n");
#nullable restore
#line 15 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
          
            if (Convert.ToString(ViewData["trangthai"]) == "Xóa không thành công")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"alert alert-error\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                   Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
            }
            if (Convert.ToString(ViewData["trangthai"]) == "Xóa thành công")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"alert alert-success\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                   Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""box"" id=""view"">
                    <div class=""box-body"">
                        <div class=""row"" style=""padding:0px; margin:0px;"">
                            <div class=""table-responsive"">
                                <table class=""table table-hover table-bordered"">
                                    <thead>
                                        <tr>
                                            <th class=""text-center"">Mã hóa đơn</th>
                                            <th>Địa chỉ nhận hàng</th>
                                            <th>NV giao hàng</th>
                                            <th class=""text-center"">SĐT nhân viên</th>
                                            <th class=""text-center"">Giao hàng</th>
                                            <th class=""text-center"">Thao tác</th>
                                        </tr>
                                    ");
            WriteLiteral("</thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                          
                                            int a = Convert.ToInt32(ViewData["ThongBao"]);
                                            if (a == 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr><td class=\"text-center\" colspan=\"9\">Không tìm thấy phiếu giao hàng nào!</td></tr>\r\n");
#nullable restore
#line 58 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"text-center\">");
#nullable restore
#line 64 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                                           Write(item.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 65 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                       Write(item.DiaChiGH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 66 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                       Write(item.TenNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"text-center\">");
#nullable restore
#line 67 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                                           Write(item.SDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td class=\"text-center\">\r\n");
#nullable restore
#line 69 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                             if (item.TinhTrangGH == 0)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff3f17fd24bb3e836d9c8f133152e98ceab8ecc613904", async() => {
                WriteLiteral("\r\n                                                                    <input type=\"hidden\" name=\"MaHD\"");
                BeginWriteAttribute("value", " value=\"", 4285, "\"", 4303, 1);
#nullable restore
#line 72 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
WriteAttributeValue("", 4293, item.MaHD, 4293, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                                    <input type=\"hidden\" name=\"MaNV\"");
                BeginWriteAttribute("value", " value=\"", 4409, "\"", 4427, 1);
#nullable restore
#line 73 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
WriteAttributeValue("", 4417, item.MaNV, 4417, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                                    <input type=\"hidden\" name=\"page\"");
                BeginWriteAttribute("value", " value=\"", 4533, "\"", 4543, 1);
#nullable restore
#line 74 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
WriteAttributeValue("", 4541, p, 4541, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                                    <input type=""hidden"" name=""STN"" id=""stn"" />
                                                                    <button class=""btn btn-success btn-xs"" onclick=""FunctionPrompt()"">
                                                                        <span class=""glyphicon glyphicon-ok""></span>Hoàn thành
                                                                    </button>
                                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"

                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span>Đã giao</span>\r\n");
#nullable restore
#line 85 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </td>\r\n                                                        <td class=\"text-center\">\r\n");
#nullable restore
#line 88 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                              var t = (Model.Count() == 1) ? (p - 1) : p;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 5766, "\"", 5835, 6);
            WriteAttributeValue("", 5773, "/Admin/GiaoHang/Delete?MAHD=", 5773, 28, true);
#nullable restore
#line 89 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
WriteAttributeValue("", 5801, item.MaHD, 5801, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5811, "&MANV=", 5811, 6, true);
#nullable restore
#line 89 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
WriteAttributeValue("", 5817, item.MaNV, 5817, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5827, "&page=", 5827, 6, true);
#nullable restore
#line 89 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
WriteAttributeValue("", 5833, t, 5833, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận xóa phiếu giao hàng này ?')"" role=""button"">
                                                                <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 94 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                 

                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                </table>
                            </div>
                            <script type=""text/javascript"">
                                function FunctionPrompt() {
                                    var result = prompt(""Nhập số tiền nhận:"");
                                    if (result != null) {
                                        document.getElementById(""stn"").value = result;
                                    }
                                }
                            </script>

                        </div>
                    </div>
                </div>
            </div><!-- /.box -->
        </div>
        <!-- /.col -->
        <div class=""row"">
            <div class=""col-md-12 text-center"">
                <div class=""pull-right pagination"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff3f17fd24bb3e836d9c8f133152e98ceab8ecc621796", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Go to\" /> page <input type=\"number\"");
                BeginWriteAttribute("max", " max=\"", 7399, "\"", 7411, 1);
#nullable restore
#line 121 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
WriteAttributeValue("", 7405, pages, 7405, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" name=\"page\"");
                BeginWriteAttribute("value", " value=\"", 7432, "\"", 7442, 1);
#nullable restore
#line 121 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
WriteAttributeValue("", 7440, p, 7440, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> of ");
#nullable restore
#line 121 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\GiaoHang\Index.cshtml"
                                                                                                                                     Write(pages);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.GiaoHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
