#pragma checksum "C:\Users\23871167800\Desktop\Projeto-RoleTOPmvc\RoleTOPMVC\Views\Shared\Erro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56026022b654537b67ed26484ffb266e7116d119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Erro), @"mvc.1.0.view", @"/Views/Shared/Erro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Erro.cshtml", typeof(AspNetCore.Views_Shared_Erro))]
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
#line 1 "C:\Users\23871167800\Desktop\Projeto-RoleTOPmvc\RoleTOPMVC\Views\_ViewImports.cshtml"
using RoleTOPMVC;

#line default
#line hidden
#line 2 "C:\Users\23871167800\Desktop\Projeto-RoleTOPmvc\RoleTOPMVC\Views\_ViewImports.cshtml"
using RoleTOPMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56026022b654537b67ed26484ffb266e7116d119", @"/Views/Shared/Erro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dac2758acc7bd733d17639a392dba085b51c09", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Erro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTOPMVC.ViewModels.RespostaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 26, true);
            WriteLiteral("<main>\r\n    <h2>\r\n        ");
            EndContext();
            BeginContext(75, 14, false);
#line 4 "C:\Users\23871167800\Desktop\Projeto-RoleTOPmvc\RoleTOPMVC\Views\Shared\Erro.cshtml"
   Write(Model.NomeView);

#line default
#line hidden
            EndContext();
            BeginContext(89, 49, true);
            WriteLiteral(" Falha no login :c \r\n    </h2>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(139, 14, false);
#line 7 "C:\Users\23871167800\Desktop\Projeto-RoleTOPmvc\RoleTOPMVC\Views\Shared\Erro.cshtml"
   Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(153, 19, true);
            WriteLiteral("\r\n    </p>\r\n</main>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTOPMVC.ViewModels.RespostaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591