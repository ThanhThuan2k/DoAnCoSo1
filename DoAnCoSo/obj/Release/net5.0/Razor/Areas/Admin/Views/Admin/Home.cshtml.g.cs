#pragma checksum "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f123b019435fc249c3569fc33aa038da1ab21d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Home), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f123b019435fc249c3569fc33aa038da1ab21d0", @"/Areas/Admin/Views/Admin/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ecaa3d83ad4b046df131383aab6b5faef7275d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Admin_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoAnCoSo.Data.ModelHelper.SanPhamReviewClientModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/vendors/images/banner-img.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
  
	ViewData["Title"] = "Home";
	Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"pd-ltr-20\">\r\n\t<div class=\"card-box pd-20 height-100-p mb-30\">\r\n\t\t<div class=\"row align-items-center\">\r\n\t\t\t<div class=\"col-md-4\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f123b019435fc249c3569fc33aa038da1ab21d04631", async() => {
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
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-8\">\r\n\t\t\t\t<h4 class=\"font-20 weight-500 mb-10 text-capitalize\">\r\n");
#nullable restore
#line 15 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
                      
						string hoTen = "";
						if (User.Identity.IsAuthenticated)
						{
							hoTen = User.Claims
														 .Where(x => x.Type.ToLower().Contains("actor"))
														 .Select(x => x.Value).First();
						}
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\tWelcome back <bold class=\"weight-600 font-30 text-blue\">");
#nullable restore
#line 24 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
                                                                       Write(hoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</bold>
				</h4>
				<p class=""font-18 max-width-600"">Chất lượng của sản phẩm là uy tín của chúng tôi.</p>
			</div>
		</div>
	</div>
	<div class=""row"">
		<div class=""col-xl-3 mb-30"">
			<div class=""card-box height-100-p widget-style1"">
				<div class=""d-flex flex-wrap align-items-center"">
					<div class=""progress-data"">
						<div id=""chart""></div>
					</div>
					<div class=""widget-data"">
						<div class=""h4 mb-0"">2020</div>
						<div class=""weight-600 font-14"">Contact</div>
					</div>
				</div>
			</div>
		</div>
		<div class=""col-xl-3 mb-30"">
			<div class=""card-box height-100-p widget-style1"">
				<div class=""d-flex flex-wrap align-items-center"">
					<div class=""progress-data"">
						<div id=""chart2""></div>
					</div>
					<div class=""widget-data"">
						<div class=""h4 mb-0"">400</div>
						<div class=""weight-600 font-14"">Deals</div>
					</div>
				</div>
			</div>
		</div>
		<div class=""col-xl-3 mb-30"">
			<div class=""card-box height-100-p widget-style1"">
		");
            WriteLiteral(@"		<div class=""d-flex flex-wrap align-items-center"">
					<div class=""progress-data"">
						<div id=""chart3""></div>
					</div>
					<div class=""widget-data"">
						<div class=""h4 mb-0"">350</div>
						<div class=""weight-600 font-14"">Campaign</div>
					</div>
				</div>
			</div>
		</div>
		<div class=""col-xl-3 mb-30"">
			<div class=""card-box height-100-p widget-style1"">
				<div class=""d-flex flex-wrap align-items-center"">
					<div class=""progress-data"">
						<div id=""chart4""></div>
					</div>
					<div class=""widget-data"">
						<div class=""h4 mb-0"">$6060</div>
						<div class=""weight-600 font-14"">Worth</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""row"">
		<div class=""col-xl-8 mb-30"">
			<div class=""card-box height-100-p pd-20"">
				<h2 class=""h4 mb-20"">Activity</h2>
				<div id=""chart5""></div>
			</div>
		</div>
		<div class=""col-xl-4 mb-30"">
			<div class=""card-box height-100-p pd-20"">
				<h2 class=""h4 mb-20"">Lead Target</h2>
				<div id=""char");
            WriteLiteral(@"t6""></div>
			</div>
		</div>
	</div>
	<div class=""card-box mb-30"">
		<h2 class=""h4 pd-20"">Sản phẩm bán chạy nhất</h2>
		<table class=""data-table table nowrap"">
			<thead>
				<tr>
					<th class=""datatable-nosort"" style=""width: 30px;"">STT</th>
					<th class=""datatable-nosort"" style=""width: 100px;"">Ảnh</th>
					<th class=""datatable-nosort"">Tên sản phẩm</th>
					<th class=""datatable-nosort"" style=""width: 120px;"">Giá gốc</th>
					<th class=""datatable-nosort"" style=""width: 100px;"">Actions</th>
				</tr>
			</thead>
			<tbody>
");
#nullable restore
#line 111 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
                 for (int i = 0; i < Model.Count; i++)
				{
					var item = Model.ElementAt(i);
					var stt = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 116 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
                       Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td class=\"table-plus\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f123b019435fc249c3569fc33aa038da1ab21d010028", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3559, "~/Images/SanPham/", 3559, 17, true);
#nullable restore
#line 118 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
AddHtmlAttributeValue("", 3576, item.AnhDaiDien, 3576, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t<h6>");
#nullable restore
#line 121 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
                           Write(item.TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 123 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
                       Write(item.GiaGoc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
						<td>
							<div class=""dropdown"">
								<a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
									<i class=""dw dw-more""></i>
								</a>
								<div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">
									<a class=""dropdown-item"" href=""#""><i class=""dw dw-eye""></i> View</a>
									<a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Edit</a>
									<a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Delete</a>
								</div>
							</div>
						</td>
					</tr>
");
#nullable restore
#line 137 "D:\C#\DoAnCoSo\DoAnCoSo\DoAnCoSo\Areas\Admin\Views\Admin\Home.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n\t</div>\r\n\t<div class=\"footer-wrap pd-20 mb-20 card-box\">\r\n\t\t<h3>Đồ án cơ sở 1</h3>\r\n\t\t<h6>Huỳnh Thanh Thuận - Lê Nguyễn Bích Phượng</h6>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoAnCoSo.Data.ModelHelper.SanPhamReviewClientModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
