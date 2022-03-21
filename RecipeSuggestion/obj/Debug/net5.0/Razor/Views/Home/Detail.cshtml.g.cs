#pragma checksum "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5bb2d36b8460052cc2a58894b9aec048f948c57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5bb2d36b8460052cc2a58894b9aec048f948c57", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c01cfe949fe35887b9c045e9ef2e2f5e2e69041", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = @Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"thumbnail card shadow\">\r\n    <div class=\"clearfix\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 138, "\"", 156, 1);
#nullable restore
#line 7 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
WriteAttributeValue("", 144, Model.Image, 144, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 157, "\"", 175, 1);
#nullable restore
#line 7 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
WriteAttributeValue("", 163, Model.Title, 163, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:50%\" class=\"float-right\">\r\n        <h4 class=\"m-2\">");
#nullable restore
#line 8 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n        <h5 class=\"m-2\">Ingredients:</h5>\r\n        <ul>\r\n");
#nullable restore
#line 12 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
              
                    for (var i = 0; i < @Model.ExtendedIngredients.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <li class=\"m-2\">");
#nullable restore
#line 15 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                                  Write(Model.ExtendedIngredients[i].Original);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <h5 class=\"m-2\">How to cook?</h5>\r\n        <ol class=\"m-2\">\r\n");
#nullable restore
#line 21 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
             for (var i = 0; i < @Model.AnalyzedInstructions[0].Steps.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <!-- Step description -->\r\n                    ");
#nullable restore
#line 25 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
               Write(Model.AnalyzedInstructions[0].Steps[i].Step);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 27 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n\r\n        <h5 class=\"m-2\">Servings: ");
#nullable restore
#line 30 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                             Write(Model.Servings);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n        <h5 class=\"m-2\">Pricing per serving: ");
#nullable restore
#line 32 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                                        Write(Model.PricePerServing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n        <h5 class=\"m-2\">Health Score: ");
#nullable restore
#line 34 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                                 Write(Model.HealthScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n        <h5 class=\"m-2\">\r\n            <strong>Cuisines:</strong>\r\n");
#nullable restore
#line 38 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
              
                if (@Model.Cuisines.Count == 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
               Write(Html.Raw("N/A"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                                    ;

                }
                else
                {
                    for (var i = 0; i < @Model.Cuisines.Count; i++)
                    {
                        if (i != @Model.Cuisines.Count - 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 50 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                             Write(Model.Cuisines[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>\r\n");
#nullable restore
#line 51 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 54 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                             Write(Model.Cuisines[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 55 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                            }
                        }

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h5>\r\n        <h5 class=\"m-2\">Source: <a");
            BeginWriteAttribute("href", " href=\"", 1929, "\"", 1952, 1);
#nullable restore
#line 61 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1936, Model.SourceUrl, 1936, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
                                                      Write(Model.SourceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>, <a");
            BeginWriteAttribute("href", " href=\"", 1979, "\"", 2013, 1);
#nullable restore
#line 61 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1986, Model.SpoonacularSourceUrl, 1986, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Spoonacular API</a></h5>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
