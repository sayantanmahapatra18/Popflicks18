#pragma checksum "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ccbfe8880d7ecb427aa5ba5b6d3c0a9b01e130"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DashBoard_Movie), @"mvc.1.0.view", @"/Areas/Admin/Views/DashBoard/Movie.cshtml")]
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
#line 1 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\_ViewImports.cshtml"
using popflix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\_ViewImports.cshtml"
using popflix.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ccbfe8880d7ecb427aa5ba5b6d3c0a9b01e130", @"/Areas/Admin/Views/DashBoard/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a00308b3aa3702409b6127891941754a8643b66", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DashBoard_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
  
    ViewData["Title"] = "Movie";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: black;\r\n    }\r\n\r\n    h6 {\r\n        color: white\r\n    }\r\n</style>\r\n\r\n<h1 style=\"color:white\">Admin Dashboard</h1>\r\n<hr />\r\n\r\n\r\n<div class=\"container\">\r\n    <h3 class=\"text-white\">");
#nullable restore
#line 22 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <hr />\r\n\r\n    <div>\r\n");
#nullable restore
#line 26 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
          
            var link = "https://www.youtube.com/embed/";
            var model = Model.MovieLink;
            var movielink = link + model;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <iframe width=\"100%\" height=\"500\"");
            BeginWriteAttribute("src", " src=\"", 579, "\"", 595, 1);
#nullable restore
#line 31 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
WriteAttributeValue("", 585, movielink, 585, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n    </div>\r\n\r\n    <div class=\"detailbox row\">\r\n\r\n        <div class=\"col-md-3 col-sm-10\">\r\n");
#nullable restore
#line 37 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
              
                var base64 = Convert.ToBase64String(Model.Banner);
                var imgsrc = string.Format("data:image/jpg; base64,{0}", base64);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 1009, "\"", 1022, 1);
#nullable restore
#line 41 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
WriteAttributeValue("", 1015, imgsrc, 1015, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"260\"");
            BeginWriteAttribute("title", " title=", 1048, "", 1066, 1);
#nullable restore
#line 41 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
WriteAttributeValue("", 1055, Model.Name, 1055, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div class=\"col-md-9 col-sm-10\">\r\n            <div class=\"row pr-3\">\r\n                <div class=\"col-md-7\">\r\n                    <h4 class=\"text-white\">");
#nullable restore
#line 47 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"lead text-white\">");
#nullable restore
#line 48 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                                          Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h6 class=\"text-white\">\r\n");
#nullable restore
#line 50 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Category == "0")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Action</h6>\r\n");
#nullable restore
#line 53 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Category == "1")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> : Adventure</h6>\r\n");
#nullable restore
#line 57 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Category == "2")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Horror</h6>\r\n");
#nullable restore
#line 61 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Category == "3")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Drama</h6>\r\n");
#nullable restore
#line 65 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Category == "4")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Romance</h6>\r\n");
#nullable restore
#line 69 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Category == "5")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Comedy</h6>\r\n");
#nullable restore
#line 73 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h6>\r\n\r\n                </div>\r\n                <div class=\"col-md-5\">\r\n                    <h6></h6><br />\r\n\r\n                    <h6 class=\"text-white\"><span class=\"text-danger\">Director</span> : ");
#nullable restore
#line 81 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                                                                                  Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6 class=\"text-white\"><span class=\"text-danger\">Actors</span> : ");
#nullable restore
#line 82 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                                                                                Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6 class=\"text-white\"><span class=\"text-danger\">Producer</span> : ");
#nullable restore
#line 83 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                                                                                  Write(Model.Producer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6 class=\"text-white\"><span class=\"text-danger\">Runtime</span> : ");
#nullable restore
#line 84 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                                                                                 Write(Model.WatchTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6 class=\"text-white\"><span class=\"text-danger\">Release</span> : ");
#nullable restore
#line 85 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                                                                                 Write(Model.Release);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6 class=\"text-white\">\r\n                        <span class=\"text-danger\">Ratings</span> :\r\n");
#nullable restore
#line 88 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Ratings == "0")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label title=\"No star rating\">No Ratings</label>\r\n");
#nullable restore
#line 91 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Ratings == "1")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img srcset=\"/Images/Star.png\" width=\"30\" height=\"30\" title=\"one star rating\" />\r\n");
#nullable restore
#line 95 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Ratings == "2")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img srcset=\"/Images/Star.png\" width=\"30\" height=\"30\" title=\"two star rating\" />\r\n                            <img srcset=\"/Images/Star.png\" width=\"30\" height=\"30\" title=\"two star rating\" />\r\n");
#nullable restore
#line 100 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Ratings == "3")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""three star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""three star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""three star rating"" />
");
#nullable restore
#line 106 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Ratings == "4")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""four star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""four star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""four star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""four star rating"" />
");
#nullable restore
#line 113 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                         if (Model.Ratings == "5")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""five star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""five star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""five star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""five star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30"" height=""30"" title=""five star rating"" />
");
#nullable restore
#line 121 "C:\Users\91993\source\repos\popflix\Areas\Admin\Views\DashBoard\Movie.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
