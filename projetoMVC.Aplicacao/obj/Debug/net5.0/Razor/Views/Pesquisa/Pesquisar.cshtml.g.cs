#pragma checksum "C:\projetoMVC\projetoMVC.Aplicacao\Views\Pesquisa\Pesquisar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ad2d065f620e92e404ba1f980b50ceb5d686ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pesquisa_Pesquisar), @"mvc.1.0.view", @"/Views/Pesquisa/Pesquisar.cshtml")]
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
#line 1 "C:\projetoMVC\projetoMVC.Aplicacao\Views\_ViewImports.cshtml"
using projetoMVC.Aplicacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projetoMVC\projetoMVC.Aplicacao\Views\_ViewImports.cshtml"
using projetoMVC.Aplicacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ad2d065f620e92e404ba1f980b50ceb5d686ca", @"/Views/Pesquisa/Pesquisar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbef1b2e941ca0710156545adf6eeaaa12b2ba1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pesquisa_Pesquisar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\projetoMVC\projetoMVC.Aplicacao\Views\Pesquisa\Pesquisar.cshtml"
  
    ViewData["Title"] = "Pesquisar";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n  <ul class=\"nav\">\r\n  <li class=\"nav-item\">\r\n    <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 129, "\"", 164, 1);
#nullable restore
#line 8 "C:\projetoMVC\projetoMVC.Aplicacao\Views\Pesquisa\Pesquisar.cshtml"
WriteAttributeValue("", 136, Url.Action("Index", "Home"), 136, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a>\r\n  </li>\r\n  <li class=\"nav-item\">\r\n    <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 233, "\"", 276, 1);
#nullable restore
#line 11 "C:\projetoMVC\projetoMVC.Aplicacao\Views\Pesquisa\Pesquisar.cshtml"
WriteAttributeValue("", 240, Url.Action("Cadastrar", "Cadastro"), 240, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cadastro</a>\r\n  </li>\r\n  <li class=\"nav-item\">\r\n    <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 349, "\"", 392, 1);
#nullable restore
#line 14 "C:\projetoMVC\projetoMVC.Aplicacao\Views\Pesquisa\Pesquisar.cshtml"
WriteAttributeValue("", 356, Url.Action("Consultar", "Consulta"), 356, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Consultar</a>\r\n  </li>\r\n  <li class=\"nav-item\">\r\n    <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 466, "\"", 509, 1);
#nullable restore
#line 17 "C:\projetoMVC\projetoMVC.Aplicacao\Views\Pesquisa\Pesquisar.cshtml"
WriteAttributeValue("", 473, Url.Action("Pesquisar", "Pesquisa"), 473, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Pesquisar</a>\r\n  </li>\r\n</ul>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591