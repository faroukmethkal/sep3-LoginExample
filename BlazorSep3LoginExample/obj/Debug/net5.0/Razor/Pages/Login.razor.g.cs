#pragma checksum "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37c2bdb63c1f834d767d4fca457a5e65fca538fc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSep3LoginExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using BlazorSep3LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\_Imports.razor"
using BlazorSep3LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor"
using BlazorSep3LoginExample.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor"
using BlazorSep3LoginExample.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor"
using BlazorSep3LoginExample.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor"
                                    User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor"
                                                          SubmitCredentials

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "main");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label>usernam</label>\r\n            ");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "placeholder", "Username");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor"
                                                  User.username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.username = __value, User.username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "<label>password</label>\r\n            ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "placeholder", "Password");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor"
                                                  User.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.password = __value, User.password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.AddMarkupContent(23, "<div class=\"form-group\"><button class=\"btn-success\" type=\"submit\">\r\n                Login\r\n            </button></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Login.razor"
       
    public LoginUser User { get; set; } = new LoginUser();

    private string token;
    private string username;
    private string role;


    async Task SubmitCredentials()
    {
        /*string serializedUser = JsonSerializer.Serialize(User);


        HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "login");
        httpRequestMessage.Content = new StringContent(serializedUser);
        httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        var client = httpClientFactory.CreateClient("UserService");


        var response = await client.SendAsync(httpRequestMessage);
        var responseStatusCode = response.StatusCode.ToString().ToLower();

        if (responseStatusCode.Equals("ok"))
        {
            var stringresponse = await response.Content.ReadAsStringAsync();
            Dictionary<string, string> values = JsonSerializer.Deserialize<Dictionary<string, string>>(stringresponse);*/

        Dictionary<string, string> values = await ((ServiceUser) _serviceUser).ValidateUser(User);
        if (values != null)
        {
            if (values.TryGetValue("access_token", out token))
                if (values.TryGetValue("role", out role))
                    if (values.TryGetValue("username", out username))
                        ((CustomAuthenticationStateProvider) authenticationStateProvider).SetTokenAsync(token);
            NavigationManaget.NavigateTo("/counter");
        }
          
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceUser _serviceUser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManaget { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
