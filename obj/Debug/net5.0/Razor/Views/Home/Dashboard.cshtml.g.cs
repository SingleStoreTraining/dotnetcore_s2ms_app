#pragma checksum "/Users/dan/Desktop/mys2msapp/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f981e64230bf9c9719eb636ebd126c70d46554e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/dan/Desktop/mys2msapp/Views/_ViewImports.cshtml"
using mys2msapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dan/Desktop/mys2msapp/Views/_ViewImports.cshtml"
using mys2msapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f981e64230bf9c9719eb636ebd126c70d46554e", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d41053c1a95770c9bac692f3c9e9f918396df99", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddTodo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"dash\">\n<h1>SingleSpace Dashboard</h1> <a href=\"Logout\">Log Out</a>\n<h3>Welcome, ");
#nullable restore
#line 3 "/Users/dan/Desktop/mys2msapp/Views/Home/Dashboard.cshtml"
        Write(ViewBag.CurrUser["username"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<br><br>\n\n<div class=\"post\">\n    <h3>Let\'s Create some ToDos!</h3>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f981e64230bf9c9719eb636ebd126c70d46554e4471", async() => {
                WriteLiteral("\n        Title: <input type=\"text\" name=\"Title\"><br>\n        Description: <br> <textarea name=\"Description\"");
                BeginWriteAttribute("id", " id=\"", 361, "\"", 366, 0);
                EndWriteAttribute();
                WriteLiteral(" cols=\"30\" rows=\"8\"></textarea><br>\n        <input type=\"submit\" value=\"Add ToDo\" class=\"btn btn-success\">\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br><br><br><br>\n</div>\n\n<div class=\"all\">\n    <h3>All ToDos:</h3>\n");
#nullable restore
#line 17 "/Users/dan/Desktop/mys2msapp/Views/Home/Dashboard.cshtml"
      
        foreach(var todo in ViewBag.AllToDos){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><b>Title:</b> ");
#nullable restore
#line 19 "/Users/dan/Desktop/mys2msapp/Views/Home/Dashboard.cshtml"
                        Write(todo["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p><b>Description:</b> ");
#nullable restore
#line 20 "/Users/dan/Desktop/mys2msapp/Views/Home/Dashboard.cshtml"
                              Write(todo["description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <a");
            BeginWriteAttribute("href", " href=\'", 728, "\'", 764, 1);
#nullable restore
#line 21 "/Users/dan/Desktop/mys2msapp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 735, "Edit/" + @todo["toDosId"], 735, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> <span> - </span> <a");
            BeginWriteAttribute("href", " href=\'", 794, "\'", 832, 1);
#nullable restore
#line 21 "/Users/dan/Desktop/mys2msapp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 801, "Delete/" + @todo["toDosId"], 801, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n            <hr>\n");
#nullable restore
#line 23 "/Users/dan/Desktop/mys2msapp/Views/Home/Dashboard.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

</div>

<style>
.dash{
  width: 960px;
  padding: 10px;
}

.dash h1{
  display: inline-block;
  margin-right: 400px;
}

.box {
  display: inline-block;
  vertical-align: top;
  margin: 50px 50px;
}

.box label{
  width: 140px;
  text-align: right;
}

.post{
  display: inline-block;
  margin: 0px 60px;
}

.all{
  display: inline-block;
  vertical-align: top;
  margin: 0px 60px;
  width: 300px;
}

</style>");
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