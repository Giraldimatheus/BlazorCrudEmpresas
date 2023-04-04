using BlazorCRUDEmpresas;
using BlazorCRUDEmpresas.Data;
using BlazorCRUDEmpresas.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("CompanyDb"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ICompanyServices, CompanyServices>();

await builder.Build().RunAsync();


