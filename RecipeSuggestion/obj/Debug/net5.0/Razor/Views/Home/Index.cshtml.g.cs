#pragma checksum "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ce2288e9a7df1190ba1dcae877da4dbe393711c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ce2288e9a7df1190ba1dcae877da4dbe393711c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c01cfe949fe35887b9c045e9ef2e2f5e2e69041", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexPageViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Result", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"mb-5\" style=\"color: #0000ff;\">Enter the ingredients to search recipes!</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-8\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ce2288e9a7df1190ba1dcae877da4dbe393711c5664", async() => {
                WriteLiteral("\r\n            \r\n            <div class=\"text-danger\">");
#nullable restore
#line 11 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                Write(TempData["Error_NoIngredientsEntered"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"text-danger\">");
#nullable restore
#line 12 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                Write(TempData["Error_NoNumberNoSpecialCharacter"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>

            <div class=""form-group"">
                <label for=""ingredient1"">Ingredient 1:</label>
                <input type=""text"" name=""ingredient1"" class=""form-control col-lg-4 col-md-4 col-sm-6 col-xs-12"" />
            </div>

            <div class=""form-group"">
                <label for=""ingredient2"">Ingredient 2:</label>
                <input type=""text"" name=""ingredient2"" class=""form-control col-lg-4 col-md-4 col-sm-6 col-xs-12"" />
            </div>

            <div class=""form-group"">
                <label for=""ingredient3"">Ingredient 3:</label>
                <input type=""text"" name=""ingredient3"" class=""form-control col-lg-4 col-md-4 col-sm-6 col-xs-12"" />
            </div>

            <div class=""form-group"">
                <label for=""ingredient4"">Ingredient 4:</label>
                <input type=""text"" name=""ingredient4"" class=""form-control col-lg-4 col-md-4 col-sm-6 col-xs-12"" />
            </div>

            <div class=""form-group"">
                ");
                WriteLiteral(@"<label for=""ingredient5"">Ingredient 5:</label>
                <input type=""text"" name=""ingredient5"" class=""form-control col-lg-4 col-md-4 col-sm-6 col-xs-12"" />
            </div>
            <button type=""submit"" class=""btn btn-primary mt-5"">
                Show Recipe
            </button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <!-- Side bar -->

    <div class=""col-4"">
        <div class=""img-thumbnail card shadow"">
            <div class=""card-body by-light"">
                <h3 class=""card-title"">Random Suggestion</h3>

                <!-- Recipe Title -->
                <h6 class=""card-text"">");
#nullable restore
#line 52 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                 Write(Model.RandomRecipeSuggestion.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                <!-- Image -->\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2175, "\"", 2216, 1);
#nullable restore
#line 55 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
WriteAttributeValue("", 2181, Model.RandomRecipeSuggestion.Image, 2181, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2217, "\"", 2258, 1);
#nullable restore
#line 55 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
WriteAttributeValue("", 2223, Model.RandomRecipeSuggestion.Title, 2223, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n\r\n                <!-- Ingredients -->\r\n                <p>\r\n                    <strong>Ingredients:</strong>\r\n");
#nullable restore
#line 60 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                      
                        for (var i = 0; i < @Model.RandomRecipeSuggestion.ExtendedIngredients.Count; i++)
                        {
                            if (i != @Model.RandomRecipeSuggestion.ExtendedIngredients.Count - 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 65 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                 Write(Model.RandomRecipeSuggestion.ExtendedIngredients[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>\r\n");
#nullable restore
#line 66 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 69 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                 Write(Model.RandomRecipeSuggestion.ExtendedIngredients[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 70 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                            }

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n\r\n                <!-- Cuisines -->\r\n                <p>\r\n                    <strong>Cuisines:</strong>\r\n");
#nullable restore
#line 79 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                      
                        if (@Model.RandomRecipeSuggestion.Cuisines.Count == 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                       Write(Html.Raw("N/A"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                            ;

                        }
                        else
                        {
                            for (var i = 0; i < @Model.RandomRecipeSuggestion.Cuisines.Count; i++)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                           Write(Model.RandomRecipeSuggestion.Cuisines[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                                                         
                            }
                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n\r\n                <!-- Servings -->\r\n                <p><strong>Servings: </strong>");
#nullable restore
#line 97 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                         Write(Model.RandomRecipeSuggestion.Servings);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <!-- See more button! -->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ce2288e9a7df1190ba1dcae877da4dbe393711c15438", async() => {
                WriteLiteral("See more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-recipeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Index.cshtml"
                                                                       WriteLiteral(Model.RandomRecipeSuggestion.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["recipeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-recipeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["recipeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexPageViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
