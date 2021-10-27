#pragma checksum "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02946c766eec28fc6b41d41dbaac70e00fa076ec"
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
#line 2 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
using BlazorSep3LoginExample.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
using BlazorSep3LoginExample.model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
#nullable restore
#line 11 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
     foreach (NewTask task in tasks)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, 
#nullable restore
#line 13 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
            task.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 14 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
            task.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, 
#nullable restore
#line 15 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
            task.numberOFTeam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "F:\VIA\Third Semester\SEP3\LoginExample\BlazorSep3LoginExample\BlazorSep3LoginExample\Pages\Counter.razor"
       
    private List<NewTask> tasks = new List<NewTask>();

    protected override async Task OnInitializedAsync()
    {
        
         var token = await ((CustomAuthenticationStateProvider) TokenProvider).GetTokenAsync();
        
        var httpClient = httpClientFactory.CreateClient("UserService");
        
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "api/task"));
        if (response.StatusCode.ToString().ToLower().Equals("ok"))
        {
            var stringresponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine(stringresponse);
             tasks = JsonSerializer.Deserialize<List<NewTask>>(stringresponse);
              
        }
        else
        {
            Console.WriteLine("Fail to get content");
            Console.WriteLine();
        }
      

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory httpClientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider TokenProvider { get; set; }
    }
}
#pragma warning restore 1591
