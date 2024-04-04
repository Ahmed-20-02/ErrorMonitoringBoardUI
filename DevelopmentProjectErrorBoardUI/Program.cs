using DevelopmentProjectErrorBoardUI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DevelopmentProjectErrorBoardUI.AutofacDependencies;
using DevelopmentProjectErrorBoardUI.Services;
using Microsoft.Extensions.DependencyInjection;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5114/") });



builder.Services.AddScoped<IErrorService, ErrorService>();

// Configure CORS policy
/*builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:5015")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});*/

await builder.Build().RunAsync();

////Reference
//https://stackoverflow.com/questions/69754985/adding-autofac-to-net-core-6-0-using-the-new-single-file-template/71448702#71448702
//02/01/2024
/*builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    });*/