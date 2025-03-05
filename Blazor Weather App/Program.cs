using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor_Weather_App;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://keithchidamba.github.io/Blazor-Weather-App/") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://nominatim.openstreetmap.org/") });

await builder.Build().RunAsync();