#pragma checksum "C:\Users\jiali\Desktop\lesson materials\CSC\CA1\CSC_AY2020\CSC_AY2020_Task6_new\Views\Home\PlanSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55f249666cec7025c1f50a3797091d937386defe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PlanSelect), @"mvc.1.0.view", @"/Views/Home/PlanSelect.cshtml")]
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
#line 1 "C:\Users\jiali\Desktop\lesson materials\CSC\CA1\CSC_AY2020\CSC_AY2020_Task6_new\Views\_ViewImports.cshtml"
using CSC_AY2020_Task6_new;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jiali\Desktop\lesson materials\CSC\CA1\CSC_AY2020\CSC_AY2020_Task6_new\Views\_ViewImports.cshtml"
using CSC_AY2020_Task6_new.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f249666cec7025c1f50a3797091d937386defe", @"/Views/Home/PlanSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe6a20031f30fc6cab6521c44f4659af1666eac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PlanSelect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50%; margin-bottom: 40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\jiali\Desktop\lesson materials\CSC\CA1\CSC_AY2020\CSC_AY2020_Task6_new\Views\Home\PlanSelect.cshtml"
  
    ViewBag.Title = "PlanSelect";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>PlanSelect</h2>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55f249666cec7025c1f50a3797091d937386defe4357", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <label for=""card-element"">
            Credit or debit card
        </label>
        <div id=""card-element"" style=""width: 100%"">
            <!--Used to display form errors-->
        </div>
        <div id=""card-errors"" role=""alert""></div>

    </div>
    <div id=""select_plan"" style=""margin-top: 30px;"">
");
                WriteLiteral("    </div>\r\n    <input type=\"submit\" value=\"Subscribe\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://js.stripe.com/v2/""></script>
    <script type=""text/javascript"" src=""https://js.stripe.com/v3/""></script>

    <script type=""text/javascript"">

        $('document').ready(function () {

            var custId = '");
#nullable restore
#line 42 "C:\Users\jiali\Desktop\lesson materials\CSC\CA1\CSC_AY2020\CSC_AY2020_Task6_new\Views\Home\PlanSelect.cshtml"
                     Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';  

            if (!custId.startsWith(""cus_"")) {
                console.log('customer ID not found');
            }
            else {

                Stripe.setPublishableKey('pk_test_51I2bbHBYTNT0yLeeYssT9JQ3142VZbZhwXEUT8WpkItAX2dNYwQxX6Hao76QQuWGiQ57eL95Su8XgqtVRfd6TFLE00StsUPkvK');
                var stripe = Stripe('pk_test_51I2bbHBYTNT0yLeeYssT9JQ3142VZbZhwXEUT8WpkItAX2dNYwQxX6Hao76QQuWGiQ57eL95Su8XgqtVRfd6TFLE00StsUPkvK');
                var elements = stripe.elements();
                var style = {
                    base: {
                        color: '#32325d',
                        fontFamily: '""Helvetica Neue"", Helvetica, sans-serif',
                        fontSmoothing: 'antialiased',
                        fontSize: '16px',
                        '::placeholder': {
                            color: '#aab7c4'
                        }
                    },
                    invalid: {
                        color: '#fa755a',
                        ic");
                WriteLiteral(@"onColor: '#fa755a'
                    }
                };
                var card = elements.create('card', {
                    hidePostalCode: true,
                    style: style
                });
                // Add an instance of the card UI component into the `card-element` <div>
                card.mount('#card-element');

                

                $.ajax({
                    type: ""GET"",
                    url: ""/api/Stripe/ListPrice"",
                    dataType: ""json"",
                    success: function (data) {
                        console.log(data);
                        for (var x = 0; x < data.length; x++) {
                            var i = x + 1;
                            var label = '(SGD$' + data[x].amt + '/' + data[x].paymentInterval + ') ' + data[x].product_name;
                            var radio_row = `
                                <input type=""radio"" id=""price` + i + `"" name=""priceId"" value=""` + data[x].price_id + `"">
    ");
                WriteLiteral(@"                            <label for=""price` + i + `"">` + label + `</label><br>
                            `;
                            document.getElementById(""select_plan"").innerHTML += radio_row;
                                    
                        }
                    },
                    failure: function (response) {
                        console.log(response);
                        document.getElementById(""select_plan"").innerHTML += '<p>Products could not be retrieved at this time</p>';
                    }
                });

                // Create a token when the form is submitted.
                var form = document.getElementById('payment-form');
                form.addEventListener('submit', function (e) {
                    e.preventDefault();
                    createToken();
                });


                function createToken() {
                    stripe.createToken(card).then(function (result) {
                        if (result.erro");
                WriteLiteral(@"r) {
                            // Inform the user if there was an error
                            var errorElement = document.getElementById('card-errors');
                            errorElement.textContent = result.error.message;
                        } else {
                            // Send the token to your server
                            stripeTokenHandler(result.token);
                        }
                    });
                };

                function stripeTokenHandler(token) {
                    // Insert the token ID into the form so it gets submitted to the server
                    var form = document.getElementById('payment-form');
                    var hiddenInput = document.createElement('input');
                    hiddenInput.setAttribute('type', 'hidden');
                    hiddenInput.setAttribute('name', 'stripeToken');
                    hiddenInput.setAttribute('value', token.id);
                    form.appendChild(hiddenInput);

  ");
                WriteLiteral(@"                  // Submit the form
                    //form.submit();
                    console.log($('#payment-form').serialize());

                    var purchaseData = {
                        CardToken: token.id,
                        CustomerId: custId,
                        PriceId: $('input[name=""priceId""]:checked').val()
                    }
                    $.ajax({
                        type: ""post"",
                        url: ""/api/Stripe/PurchasePlan"",
                        contentType: 'application/json; charset=utf-8',
                        data: JSON.stringify(purchaseData),
                        success: function (data) {
                            console.log(data);
                            $.ajax({
                                type: ""post"",
                                url: ""/api/Stripe/AccessPortal?custId="" + custId,
                                success: function (data) {
                                    console.log(data);
    ");
                WriteLiteral(@"                                window.location.replace(data);
                                },
                                failure: function (response) {
                                    console.log(response);

                                }
                            });
                        },
                        failure: function (response) {
                            console.log(response);
                           
                        }
                    });
                }


            }

        });
    </script>
");
            }
            );
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