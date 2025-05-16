using EventEaseApp;
using EventEaseApp.Services; // Ensure this matches the namespace of UserSession
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSingleton<EventService>();
builder.Services.AddSingleton<AttendanceService>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registering UserSession as a Singleton
builder.Services.AddSingleton<UserSession>();

// Registering HttpClient (Scoped to the application)
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

await builder.Build().RunAsync();
