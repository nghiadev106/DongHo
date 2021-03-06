#pragma checksum "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc87efc6f9f8e1014f987a5942d7fb998a79a5c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_ListBlogCategories), @"mvc.1.0.view", @"/Views/Blogs/ListBlogCategories.cshtml")]
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
#line 1 "D:\DA\DongHo\DongHo\Views\_ViewImports.cshtml"
using DongHo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DA\DongHo\DongHo\Views\_ViewImports.cshtml"
using DongHo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc87efc6f9f8e1014f987a5942d7fb998a79a5c4", @"/Views/Blogs/ListBlogCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087d71e1659e75de278296225f8fbaba87a26212", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_ListBlogCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DongHo.Models.PaginationSet<DongHo.Data.News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
  
    ViewData["Title"] = "Danh mục tin tức";
    var ListCate = (List<DongHo.Data.CategoriesNew>)ViewBag.ListCate;
    var ListNews = (List<DongHo.Data.News>)ViewBag.ListNews;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main id=\"main\"");
            BeginWriteAttribute("class", " class=\"", 258, "\"", 266, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div id=\"content\" class=\"blog-wrapper blog-archive page-wrapper\">\r\n        <div class=\"row row-large row-divided \">\r\n            <div class=\"large-9 col\">\r\n                <div class=\"row large-columns-1 medium-columns- small-columns-1\">\r\n");
#nullable restore
#line 14 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                     if (ListNews.Count() > 0)
                    {
                        foreach (var item in ListNews)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col post-item\">\r\n                                <div class=\"col-inner\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 819, "\"", 858, 4);
            WriteAttributeValue("", 826, "/chi-tiet-tin/", 826, 14, true);
#nullable restore
#line 20 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 840, item.Url, 840, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 849, "/", 849, 1, true);
#nullable restore
#line 20 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 850, item.Id, 850, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""plain"">
                                        <div class=""box box-vertical box-text-bottom box-blog-post has-hover"">
                                            <div class=""box-image"" style=""width:40%;"">
                                                <div class=""image-cover"" style=""padding-top:56%;"">
                                                    <img width=""600"" height=""400""");
            BeginWriteAttribute("src", " src=\"", 1257, "\"", 1273, 1);
#nullable restore
#line 24 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 1263, item.Logo, 1263, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"attachment-medium size-medium wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 1326, "\"", 1342, 1);
#nullable restore
#line 24 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 1332, item.Name, 1332, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" sizes=""(max-width: 600px) 100vw, 600px"" />
                                                </div>
                                            </div><!-- .box-image -->
                                            <div class=""box-text text-left"">
                                                <div class=""box-text-inner blog-post-inner"">
                                                    <h5 class=""post-title is-large "">");
#nullable restore
#line 29 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                    <div class=\"is-divider\"></div>\r\n");
#nullable restore
#line 31 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                                     if (item.Description.Length > 120)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"from_the_blog_excerpt \">\r\n                                                            ");
#nullable restore
#line 34 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                                       Write(item.Description.Substring(0, 120));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                                                        </p>\r\n");
#nullable restore
#line 36 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"from_the_blog_excerpt \"> ");
#nullable restore
#line 39 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                                                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div><!-- .box-text-inner -->
                                            </div><!-- .box-text -->
                                        </div><!-- .box -->
                                    </a><!-- .link -->
                                </div><!-- .col-inner -->
                            </div><!-- .col -->
");
#nullable restore
#line 47 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"

                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

            </div> <!-- .large-9 -->

            <div class=""post-sidebar large-3 col"">
                <div id=""secondary"" class=""widget-area "" role=""complementary"">
                   	<aside id=""recent-posts-2"" class=""widget widget_recent_entries"">
                        <span class=""widget-title ""><span>Bài viết mới</span></span><div class=""is-divider small""></div><ul>
");
#nullable restore
#line 59 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                             if (ListNews.Count() > 0)
                            {
                                foreach (var item in ListNews)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3717, "\"", 3756, 4);
            WriteAttributeValue("", 3724, "/chi-tiet-tin/", 3724, 14, true);
#nullable restore
#line 64 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 3738, item.Url, 3738, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3747, "/", 3747, 1, true);
#nullable restore
#line 64 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 3748, item.Id, 3748, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 66 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <aside id=\"categories-2\" class=\"widget widget_categories\">\r\n                            <span class=\"widget-title \"><span>Chuyên mục</span></span><div class=\"is-divider small\"></div>\t\t<ul>\r\n");
#nullable restore
#line 71 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                 if (ListCate.Count() > 0)
                                {
                                    foreach (var item in ListCate)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"cat-item cat-item-17 current-cat\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4463, "\"", 4497, 4);
            WriteAttributeValue("", 4470, "/tin-tuc/", 4470, 9, true);
#nullable restore
#line 76 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 4479, item.Url, 4479, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4488, "/", 4488, 1, true);
#nullable restore
#line 76 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
WriteAttributeValue("", 4489, item.Id, 4489, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </li>\r\n");
#nullable restore
#line 78 "D:\DA\DongHo\DongHo\Views\Blogs\ListBlogCategories.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                        </aside>
                </div><!-- #secondary -->
            </div><!-- .post-sidebar -->

        </div><!-- .row -->

    </div><!-- .page-wrapper .blog-wrapper -->


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DongHo.Models.PaginationSet<DongHo.Data.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
