#pragma checksum "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a1f470bb2a876c69108f6a84348c6dbedcf3623"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_DetailBlog), @"mvc.1.0.view", @"/Views/Blogs/DetailBlog.cshtml")]
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\_ViewImports.cshtml"
using NuocHoa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\_ViewImports.cshtml"
using NuocHoa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a1f470bb2a876c69108f6a84348c6dbedcf3623", @"/Views/Blogs/DetailBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11aabca74cac8494c7993553744da4e1b3f12e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_DetailBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NuocHoa.Data.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://dongho.giaodienwebmau.com/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
  
    ViewData["Title"] = "Chi tiết tin";
    var categories = (List<NuocHoa.Data.CategoriesNew>)ViewBag.categories;
    var relatedNews = (List<NuocHoa.Data.News>)ViewBag.relatedNews;
    var ListNews = (List<NuocHoa.Data.News>)ViewBag.ListNews;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"main\"");
            BeginWriteAttribute("class", " class=\"", 299, "\"", 307, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div id=""content"" class=""blog-wrapper blog-single page-wrapper"">
        <div class=""row row-large row-divided "">
            <div class=""large-9 col"">
                <article id=""post-323"" class=""post-323 post type-post status-publish format-standard has-post-thumbnail hentry category-tin-tuc"">
                    <div class=""article-inner "">
                        <header class=""entry-header"">
                            <div class=""entry-header-text entry-header-text-top  text-left"">
                                <h1 class=""entry-title"">");
#nullable restore
#line 17 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                <div class=\"entry-meta is-small single-date\">\r\n                                    <span class=\"posted-on\">Posted on <time class=\"entry-date published\" datetime=\"2019-12-12T03:41:29+00:00\">");
#nullable restore
#line 19 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                                                                                                                         Write(Model.CreateDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</time></span><span class=""byline""> by <span class=""meta-author vcard"">admin</span></span>
                                </div><!-- .entry-meta -->
                            </div><!-- .entry-header -->
                            <div class=""entry-image relative"">
                            </div><!-- .entry-image -->
                        </header><!-- post-header -->
                        <div class=""entry-content single-page"">
                            <p><strong><em>");
#nullable restore
#line 26 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></strong></p>\r\n                            <p>");
#nullable restore
#line 27 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                          Write(Html.Raw(Model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""blog-share text-center""><div class=""social-icons share-icons share-row relative""><a href=""whatsapp://send?text=M%E1%BA%A1nh%20M%E1%BA%BD%20%26%23038%3B%20Cu%E1%BB%91n%20H%C3%BAt%20v%E1%BB%9Bi%20%C4%91%E1%BB%93ng%20h%E1%BB%93%20m%E1%BA%B7t%20r%E1%BA%AFn%20L%26%238217%3BDuchen%20Silver%20Snake - http://dongho.giaodienwebmau.com/manh-me-cuon-hut-voi-dong-ho-mat-ran-lduchen-silver-snake/"" data-action=""share/whatsapp/share"" class=""icon button circle is-outline tooltip whatsapp show-for-medium"" title=""Share on WhatsApp""><i class=""icon-whatsapp""></i></a><a href=""http://www.facebook.com/sharer.php?u=http://dongho.giaodienwebmau.com/manh-me-cuon-hut-voi-dong-ho-mat-ran-lduchen-silver-snake/"" data-label=""Facebook"" onclick=""window.open(this.href,this.title,'width=500,height=500,top=300px,left=300px');  return false;"" rel=""noopener noreferrer nofollow"" target=""_blank"" class=""icon button circle is-outline tooltip facebook"" title=""Share on Facebook""><i class=""icon-facebook""></i");
            WriteLiteral(@"></a><a href=""http://twitter.com/share?url=http://dongho.giaodienwebmau.com/manh-me-cuon-hut-voi-dong-ho-mat-ran-lduchen-silver-snake/"" onclick=""window.open(this.href,this.title,'width=500,height=500,top=300px,left=300px');  return false;"" rel=""noopener noreferrer nofollow"" target=""_blank"" class=""icon button circle is-outline tooltip twitter"" title=""Share on Twitter""><i class=""icon-twitter""></i></a><a href=""mailto:enteryour@addresshere.com?subject=M%E1%BA%A1nh%20M%E1%BA%BD%20%26%23038%3B%20Cu%E1%BB%91n%20H%C3%BAt%20v%E1%BB%9Bi%20%C4%91%E1%BB%93ng%20h%E1%BB%93%20m%E1%BA%B7t%20r%E1%BA%AFn%20L%26%238217%3BDuchen%20Silver%20Snake&amp;body=Check%20this%20out:%20http://dongho.giaodienwebmau.com/manh-me-cuon-hut-voi-dong-ho-mat-ran-lduchen-silver-snake/"" rel=""nofollow"" class=""icon button circle is-outline tooltip email"" title=""Email to a Friend""><i class=""icon-envelop""></i></a><a href=""http://pinterest.com/pin/create/button/?url=http://dongho.giaodienwebmau.com/manh-me-cuon-hut-voi-dong-ho-mat-ran-lduchen-silver-sna");
            WriteLiteral(@"ke/&amp;media=http://dongho.giaodienwebmau.com/wp-content/uploads/2019/12/luu-ban-nhap-tu-dong-323.jpg&amp;description=M%E1%BA%A1nh%20M%E1%BA%BD%20%26%23038%3B%20Cu%E1%BB%91n%20H%C3%BAt%20v%E1%BB%9Bi%20%C4%91%E1%BB%93ng%20h%E1%BB%93%20m%E1%BA%B7t%20r%E1%BA%AFn%20L%26%238217%3BDuchen%20Silver%20Snake"" onclick=""window.open(this.href,this.title,'width=500,height=500,top=300px,left=300px');  return false;"" rel=""noopener noreferrer nofollow"" target=""_blank"" class=""icon button circle is-outline tooltip pinterest"" title=""Pin on Pinterest""><i class=""icon-pinterest""></i></a><a href=""http://www.linkedin.com/shareArticle?mini=true&amp;url=http://dongho.giaodienwebmau.com/manh-me-cuon-hut-voi-dong-ho-mat-ran-lduchen-silver-snake/&amp;title=M%E1%BA%A1nh%20M%E1%BA%BD%20%26%23038%3B%20Cu%E1%BB%91n%20H%C3%BAt%20v%E1%BB%9Bi%20%C4%91%E1%BB%93ng%20h%E1%BB%93%20m%E1%BA%B7t%20r%E1%BA%AFn%20L%26%238217%3BDuchen%20Silver%20Snake"" onclick=""window.open(this.href,this.title,'width=500,height=500,top=300px,left=300px');  return false;""");
            WriteLiteral(@" rel=""noopener noreferrer nofollow"" target=""_blank"" class=""icon button circle is-outline tooltip linkedin"" title=""Share on LinkedIn""><i class=""icon-linkedin""></i></a></div></div>
                        </div><!-- .entry-content2 -->

                        <div class=""related-post"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 5137, "\"", 5145, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""margin-top: 30px;margin-bottom: 20px""> <h7>Bài viết liên quan</h7><div class=""duong-line""></div></div>
                            <div class=""clearfix""></div>
                            <div class=""row large-columns-3 medium-columns-2 small-columns-1 has-shadow row-box-shadow-1 row-box-shadow-1-hover"">
");
#nullable restore
#line 35 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                 if (relatedNews.Count() > 0)
                                {
                                    foreach (var item in relatedNews)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col post-item\">\r\n                                            <div class=\"col-inner\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5859, "\"", 5898, 4);
            WriteAttributeValue("", 5866, "/chi-tiet-tin/", 5866, 14, true);
#nullable restore
#line 41 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
WriteAttributeValue("", 5880, item.Url, 5880, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5889, "/", 5889, 1, true);
#nullable restore
#line 41 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
WriteAttributeValue("", 5890, item.Id, 5890, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""plain"">
                                                    <div class=""box box-bounce box-text-bottom box-blog-post has-hover"">
                                                        <div class=""box-image"">
                                                            <div class=""image-cover"" style=""padding-top:56%;"">
                                                                <img width=""1024"" height=""575""");
            BeginWriteAttribute("src", " src=\"", 6325, "\"", 6341, 1);
#nullable restore
#line 45 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
WriteAttributeValue("", 6331, item.Logo, 6331, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"attachment-post-thumbnail size-post-thumbnail wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 6410, "\"", 6426, 1);
#nullable restore
#line 45 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
WriteAttributeValue("", 6416, item.Name, 6416, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" sizes=""(max-width: 1024px) 100vw, 1024px"" />
                                                            </div>
                                                        </div><!-- .box-image -->
                                                        <div class=""box-text text-center"">
                                                            <div class=""box-text-inner blog-post-inner"">
                                                                <h5 class=""post-title is-large "">");
#nullable restore
#line 50 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                                <div class=\"post-meta is-small op-8\">");
#nullable restore
#line 51 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                                                                                Write(item.CreateDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div><div class=""is-divider""></div>
                                                            </div><!-- .box-text-inner -->
                                                        </div><!-- .box-text -->
                                                    </div><!-- .box -->
                                                </a><!-- .link -->
                                            </div><!-- .col-inner -->
                                        </div><!-- .col -->
");
#nullable restore
#line 58 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div><!-- .article-inner -->
                </article><!-- #-323 -->
                <div class=""fb-comments"" xid=""323 data-numposts=""20"" data-width=""100%"" data-colorscheme=""light"" data-version=""v2.3""></div>
            </div> <!-- .large-9 -->

            <div class=""post-sidebar large-3 col"">
                <div id=""secondary"" class=""widget-area "" role=""complementary"">
                    <aside id=""search-2"" class=""widget widget_search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a1f470bb2a876c69108f6a84348c6dbedcf362316882", async() => {
                WriteLiteral("\r\n                            <div class=\"flex-row relative\">\r\n                                <div class=\"flex-col flex-grow\">\r\n                                    <input type=\"search\" class=\"search-field mb-0\" name=\"s\"");
                BeginWriteAttribute("value", " value=\"", 8530, "\"", 8538, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""s"" placeholder=""Tìm kiếm&hellip;"" />
                                </div><!-- .flex-col -->
                                <div class=""flex-col"">
                                    <button type=""submit"" class=""ux-search-submit submit-button secondary button icon mb-0"" aria-label=""Submit"">
                                        <i class=""icon-search""></i>
                                    </button>
                                </div><!-- .flex-col -->
                            </div><!-- .flex-row -->
                            <div class=""live-search-results text-left z-top""></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </aside>\t\t<aside id=\"recent-posts-2\" class=\"widget widget_recent_entries\">\r\n                        <span class=\"widget-title \"><span>Bài viết mới</span></span><div class=\"is-divider small\"></div>\t\t<ul>\r\n");
#nullable restore
#line 87 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
     if (ListNews.Count() > 0)
    {
        foreach (var item in ListNews
            )
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 9552, "\"", 9591, 4);
            WriteAttributeValue("", 9559, "/chi-tiet-tin/", 9559, 14, true);
#nullable restore
#line 93 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
WriteAttributeValue("", 9573, item.Url, 9573, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9582, "/", 9582, 1, true);
#nullable restore
#line 93 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
WriteAttributeValue("", 9583, item.Id, 9583, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 93 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 95 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

</ul>
                   <aside id=""categories-2"" class=""widget widget_categories"">

                        <span class=""widget-title ""><span>Chuyên mục</span></span><div class=""is-divider small""></div>	
                                                                                  <ul>
");
#nullable restore
#line 104 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                                                                       if (categories.Count() > 0)
                                                                                      {
                                                                                          foreach (var item in categories)
                                                                                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                              <li class=\"cat-item cat-item-17\">\r\n                                                                                                  <a");
            BeginWriteAttribute("href", " href=\"", 10598, "\"", 10632, 4);
            WriteAttributeValue("", 10605, "/tin-tuc/", 10605, 9, true);
#nullable restore
#line 109 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
WriteAttributeValue("", 10614, item.Url, 10614, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10623, "/", 10623, 1, true);
#nullable restore
#line 109 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
WriteAttributeValue("", 10624, item.Id, 10624, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 109 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                                                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                                                              </li>\r\n");
#nullable restore
#line 111 "D:\nghia\DoAnTotNghiep2022\Thiêm\NuocHoa\NuocHoa\Views\Blogs\DetailBlog.cshtml"
                                                                                          }
                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                  </ul>
                </div><!-- #secondary -->
            </div><!-- .post-sidebar -->

        </div><!-- .row -->

    </div><!-- #content .page-wrapper -->


</main><!-- #main -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NuocHoa.Data.News> Html { get; private set; }
    }
}
#pragma warning restore 1591