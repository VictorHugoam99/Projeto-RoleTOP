#pragma checksum "C:\Users\23871167800\Desktop\Projeto RoleTop\RoleTOPMVC\Views\Cliente\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73da4aa2003611aca62e3492d893e64752a11d8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_login), @"mvc.1.0.view", @"/Views/Cliente/login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/login.cshtml", typeof(AspNetCore.Views_Cliente_login))]
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
#line 1 "C:\Users\23871167800\Desktop\Projeto RoleTop\RoleTOPMVC\Views\_ViewImports.cshtml"
using RoleTOPMVC;

#line default
#line hidden
#line 2 "C:\Users\23871167800\Desktop\Projeto RoleTop\RoleTOPMVC\Views\_ViewImports.cshtml"
using RoleTOPMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73da4aa2003611aca62e3492d893e64752a11d8f", @"/Views/Cliente/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dac2758acc7bd733d17639a392dba085b51c09", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 107, true);
            WriteLiteral("<main>\r\n\t\r\n\t<div class=\"limiter\">\r\n\t\t<div class=\"container-login100\">\r\n\t\t\t<div class=\"wrap-login100\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(107, 1208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73da4aa2003611aca62e3492d893e64752a11d8f3844", async() => {
                BeginContext(149, 1159, true);
                WriteLiteral(@"
					<span class=""login100-form-logo"">
						<i class=""zmdi zmdi-landscape""></i>
					</span>

					<span class=""login100-form-title p-b-34 p-t-27"">
						Entrar
					</span>

					<div class=""wrap-input100 validate-input"" data-validate = ""Enter username"">
						<input class=""input100"" type=""text"" name=""username"" placeholder=""Usuário"">
						
						
					</div>

					<div class=""wrap-input100 validate-input"" data-validate=""Enter password"">
						<input class=""input100"" type=""password"" name=""pass"" placeholder=""Senha"">
						
					</div>

					<div class=""contact100-form-checkbox"">
						<input class=""input-checkbox100"" id=""ckb1"" type=""checkbox"" name=""remember-me"">
						<label class=""label-checkbox100"" for=""ckb1"">
							Lembrar de mim
						</label>
					</div>

					<div class=""container-login100-form-btn"">
						
					<a href=""Telauser.html"">Entrar</a>
					</div>
					
					<div class=""text-center p-t-90"">
						<a class=""txt1"" href=""#"">
							Esqueceu a senha ?
						<");
                WriteLiteral("/a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"voltarpgprinc\">\r\n\t\t\t\t\t\t<a href=\"Roletop.html\"> Voltar para a página principal</a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1315, 560, true);
            WriteLiteral(@"
			</div>
		</div>
	</div>
	

	<div id=""dropDownSelect1""></div>
	
	<script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
	<script src=""vendor/animsition/js/animsition.min.js""></script>
	<script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
	<script src=""vendor/select2/select2.min.js""></script>
	<script src=""vendor/daterangepicker/moment.min.js""></script>
	<script src=""vendor/daterangepicker/daterangepicker.js""></script>
	<script src=""vendor/countdowntime/countdowntime.js""></script>
	<script src=""js/main.js""></script>

</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
