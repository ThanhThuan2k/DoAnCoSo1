#pragma checksum "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\DonDatHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f539880bcab6ec7b3eedfcea9cf3cdcc9ffed26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DonDatHang_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DonDatHang/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f539880bcab6ec7b3eedfcea9cf3cdcc9ffed26", @"/Areas/Admin/Views/DonDatHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ecaa3d83ad4b046df131383aab6b5faef7275d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DonDatHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoAnCoSo.DTOs.DonDatHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/NotificationModal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/js/DonDatHang/donDatHang.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\DonDatHang\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f539880bcab6ec7b3eedfcea9cf3cdcc9ffed264257", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-sm-12"">
		<table class=""data-table table stripe hover nowrap dataTable no-footer dtr-inline"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
			<thead>
				<tr role=""row"">
				<th class=""table-plus datatable-nosort"" rowspan=""1"" colspan=""1"" aria-label=""STT"">STT</th>
				<th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"">Khách hàng</th>
				<th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"">Tổng tiền</th>
				<th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"">Ngày đặt</th>
				<th class=""datatable-nosort sorting_disabled"" rowspan=""1"" colspan=""1"" aria-label=""Action""");
            BeginWriteAttribute("style", " style=\"", 992, "\"", 1000, 0);
            EndWriteAttribute();
            WriteLiteral(">Action</th></tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
#nullable restore
#line 23 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\DonDatHang\Index.cshtml"
                 for (var i = 0; i < Model.Count; i++)
				{
					var item = Model.ElementAt(i);
					var stt = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr role=\"row\" class=\"odd\">\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 28 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\DonDatHang\Index.cshtml"
                       Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td class=\"table-plus sorting_1\" tabindex=\"0\">");
#nullable restore
#line 29 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\DonDatHang\Index.cshtml"
                                                                 Write(item.HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 30 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\DonDatHang\Index.cshtml"
                       Write(item.TongTienHoaDon.ToString("#,###đ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 31 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\DonDatHang\Index.cshtml"
                       Write(item.NgayDat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td");
            BeginWriteAttribute("style", " style=\"", 1376, "\"", 1384, 0);
            EndWriteAttribute();
            WriteLiteral(@">
							<div class=""dropdown"">
								<a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
									<i class=""dw dw-more""></i>
								</a>
								<div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
									<a class=""dropdown-item"" href=""#""><i class=""dw dw-eye""></i> Xem</a>
									<a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Sửa</a>
									<a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Xóa</a>
								</div>
							</div>
						</td>
					</tr>
");
#nullable restore
#line 45 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\DonDatHang\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n\t</div>\r\n</div>\r\n\r\n<div class=\"notification-modal d-none\">\r\n\tKhông có dữ liệu\r\n</div>\r\n\r\n");
            DefineSection("js", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f539880bcab6ec7b3eedfcea9cf3cdcc9ffed269213", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoAnCoSo.DTOs.DonDatHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
