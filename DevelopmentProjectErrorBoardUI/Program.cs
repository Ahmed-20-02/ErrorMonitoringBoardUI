using DevelopmentProjectErrorBoardUI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DevelopmentProjectErrorBoardUI.Services;
using DevelopmentProjectErrorBoardUI.Services.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5114/") });

builder.Services.AddScoped<IErrorService, ErrorService>();

await builder.Build().RunAsync();