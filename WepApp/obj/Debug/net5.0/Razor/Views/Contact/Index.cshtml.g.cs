#pragma checksum "C:\Users\aehol\Desktop\FinalProJectDA\WepApp\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f386aa0d89c97f48e4871f367e5e1c866a7a4233"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\aehol\Desktop\FinalProJectDA\WepApp\Views\_ViewImports.cshtml"
using WepApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aehol\Desktop\FinalProJectDA\WepApp\Views\_ViewImports.cshtml"
using WepApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f386aa0d89c97f48e4871f367e5e1c866a7a4233", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35881990136e32ae488f6d16f5989a6100247a67", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\aehol\Desktop\FinalProJectDA\WepApp\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Header Section Start Here -->
        <section class=""page-header"">
            <div class=""container"">
                <div class=""page-title"">
                    <h2>Contact info</h2>
                    <ul class=""breadcrumb lab-ul"">
                        <li><a href=""index.html"">Home</a></li>
                        <li>Contact</li>
                    </ul>
                </div>
            </div>
        </section>
		<!-- Page Header Section Ending Here -->
        
        <!-- Contact Section Start Here -->
        <section class=""contact-us padding-tb pb-0"">
            <div class=""container"">
                <div class=""contact-wrap"" style=""text-align:center"">
                    <div class=""row"">
                        <div class=""col-lg-12 col-md-12 col-12"">
                        	<div class=""contact-title"">
                        		<h5>Contact Informations</h5>
                        	</div>
                            <ul class=""contact-area lab-ul"">
");
            WriteLiteral(@"                                <li class=""contact-item"">
                                    <div class=""contact-icon"">
                                        <img src=""assets/images/contact/icon/01.png"" alt=""contact"">
                                    </div>
                                    <div class=""content"">
                                        <h6>Our Location</h6>
                                        <p>218 Sahera Tropical Center Room#7 <br> New Elephant Road 1205</p>
                                    </div>
                                </li>
                                <li class=""contact-item"">
                                    <div class=""contact-icon"">
                                        <img src=""assets/images/contact/icon/02.png"" alt=""contact"">
                                    </div>
                                    <div class=""content"">
                                        <h6>Phone Number</h6>
                                        <p>01923-97");
            WriteLiteral(@"0212, 01776-502993 <br> +2154897369</p>
                                    </div>
                                </li>
                                <li class=""contact-item"">
                                    <div class=""contact-icon"">
                                        <img src=""assets/images/contact/icon/03.png"" alt=""contact"">
                                    </div>
                                    <div class=""content"">
                                        <h6>Email Address</h6>
                                        <p>suport@admincovid.com</p>
                                    </div>
                                </li>
                                <li class=""contact-item"">
                                    <div class=""contact-icon"">
                                        <img src=""assets/images/contact/icon/04.png"" alt=""contact"">
                                    </div>
                                    <div class=""content"">
                             ");
            WriteLiteral(@"           <h6>Website Address:</h6>
                                        <p>http://admincovid.com</p>
                                    </div>
                                </li>
                            </ul>
                        </div>
");
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </section>
        <!-- Contact Section Ending Here -->

        <!-- G-Map Section Start Here -->
        <div class=""gmaps-section"">
            <div class=""map-area"">
				<iframe class=""maps"" src=""https://coronavirus.app/map?embed=true"" allow=""accelerometer;"" allowfullscreen style=""border:0""></iframe>
            </div>
        </div>
        <!-- G-Map Section Ending Here -->

");
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
