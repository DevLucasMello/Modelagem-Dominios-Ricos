#pragma checksum "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2e3ab806900a75928bc6c952eb0010cb0cd8689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vitrine_Index), @"mvc.1.0.view", @"/Views/Vitrine/Index.cshtml")]
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
#line 1 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\_ViewImports.cshtml"
using LojaIO.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\_ViewImports.cshtml"
using LojaIO.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2e3ab806900a75928bc6c952eb0010cb0cd8689", @"/Views/Vitrine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24f34d51bf1f082bafbfa4b739726c599514be4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Vitrine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LojaIO.Catalogo.Application.ViewModels.ProdutoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vitrine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdutoDetalhe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
  
    ViewData["Title"] = "Vitrine";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    h4 {
        font-weight: 600;
    }

    p {
        font-size: 12px;
        margin-top: 5px;
    }

    .price {
        font-size: 30px;
        margin: 0 auto;
        color: #333;
    }

    .right {
        float: right;
        border-bottom: 2px solid #4B8E4B;
    }

    .thumbnail {
        opacity: 0.70;
        -webkit-transition: all 0.5s;
        transition: all 0.5s;
    }

        .thumbnail:hover {
            opacity: 1.00;
            box-shadow: 0px 0px 10px #4bc6ff;
        }

    .line {
        margin-bottom: 5px;
    }

    ");
            WriteLiteral(@"@media screen and (max-width: 770px) {
        .right {
            float: left;
            width: 100%;
        }
    }

    .product_view .modal-dialog {
        max-width: 800px;
        width: 100%;
    }

    .pre-cost {
        text-decoration: line-through;
        color: #a5a5a5;
    }

    .space-ten {
        padding: 10px 0;
    }
</style>
<div class=""container"">

    <h1>Vitrine de Produtos</h1>
    <br />
    <div class=""row"">
        <!-- BEGIN PRODUCTS -->
");
#nullable restore
#line 69 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
          
            foreach (var produto in Model.OrderBy(p=>p.CategoriaId))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 col-sm-6\">\r\n                <span class=\"thumbnail\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2e3ab806900a75928bc6c952eb0010cb0cd86896301", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2e3ab806900a75928bc6c952eb0010cb0cd86896517", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1551, "~/Images/", 1551, 9, true);
#nullable restore
#line 74 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
AddHtmlAttributeValue("", 1560, produto.Imagem, 1560, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
                                                                              WriteLiteral(produto.Id);

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
            WriteLiteral("\r\n                    <h4>");
#nullable restore
#line 75 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
                   Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>Apenas ");
#nullable restore
#line 76 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
                         Write(produto.QuantidadeEstoque);

#line default
#line hidden
#nullable disable
            WriteLiteral(" em estoque!</p>\r\n                    <p>");
#nullable restore
#line 77 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
                  Write(produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <hr class=\"line\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6 col-sm-6\">\r\n                            <p class=\"price\">");
#nullable restore
#line 81 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
                                        Write(produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </span>\r\n            </div>\r\n");
#nullable restore
#line 86 "C:\dev\LojaIO\src\LojaIO.WebApp.MVC\Views\Vitrine\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- END PRODUCTS -->\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LojaIO.Catalogo.Application.ViewModels.ProdutoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
