#pragma checksum "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81cb57b46eb936ffbcbe0e0053a6aaf0891c67d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Song_Index), @"mvc.1.0.view", @"/Views/Song/Index.cshtml")]
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
#line 1 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cb57b46eb936ffbcbe0e0053a6aaf0891c67d9", @"/Views/Song/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Song_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Songs.SongsIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Request a song</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81cb57b46eb936ffbcbe0e0053a6aaf0891c67d94135", async() => {
                WriteLiteral("Add New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<link href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"" crossorigin=""anonymous"">

<table class=""table"" align=""right"">

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81cb57b46eb936ffbcbe0e0053a6aaf0891c67d95565", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"Video\" href=\"Style.css\">\r\n                <h2>");
#nullable restore
#line 21 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <iframe width=\"400\" height=\"315\"");
                BeginWriteAttribute("src", "\r\n                        src=\"", 654, "\"", 724, 1);
#nullable restore
#line 23 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
WriteAttributeValue("", 685, Html.DisplayFor(modelItem => item.Url), 685, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </iframe>\r\n                <div class=\"Rating\">\r\n                    <h5>\r\n\r\n                        <button type=\"button\" class=\"btn btn-default upvote\"");
                BeginWriteAttribute("id", " id=\"", 897, "\"", 950, 2);
#nullable restore
#line 28 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
WriteAttributeValue("", 902, Html.DisplayFor(modelItem => item.Title), 902, 41, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 943, "-upvote", 943, 7, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span class=\"glyphicon glyphicon-arrow-up\" aria-hidden=\"false\"></span>\r\n                        </button>\r\n\r\n                        ");
#nullable restore
#line 32 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        <button type=\"button\" class=\"btn btn-default\" class=\"downvote\"");
                BeginWriteAttribute("id", " id=\"", 1247, "\"", 1300, 2);
#nullable restore
#line 34 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
WriteAttributeValue("", 1252, Html.DisplayFor(modelItem => item.Title), 1252, 41, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1293, "-upvote", 1293, 7, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span class=\"glyphicon glyphicon-arrow-down\"></span>\r\n                        </button>\r\n\r\n                    </h5>\r\n                </div>\r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81cb57b46eb936ffbcbe0e0053a6aaf0891c67d98842", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
       Write(Html.ActionLink("Download", "DownloadVideo", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\kiril\Desktop\Website\SchoolE-BellWebsite\MyLibrary\Web\Views\Song\Index.cshtml"
                                                                               

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</table>\r\n\r\n<script>\r\n    /*document.getElementsByClassName(\'upvote\').forEach(function (el) {\r\n        el.onclick = function()\r\n    })*/\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Songs.SongsIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
