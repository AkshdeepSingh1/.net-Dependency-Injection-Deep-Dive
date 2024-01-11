using DIExplained.Interfaces;
using DIExplained.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IScopedGuidService, ScopedGuidService>();
builder.Services.AddTransient<ITransientGuidService, TransientGuidService>();
builder.Services.AddSingleton<ISingletonGuidService, SingletonGuidService>();
builder.Services.AddSingleton<IKeyedServiceFactory, KeyedServiceFactory>();
var useFakeWeatherService = builder.Configuration["UseFakeWeatherService"]?.ToLower() == "true";
if (useFakeWeatherService)
{
    builder.Services.AddScoped<IWeatherService, FakeWeatherService>();
}
else
{
    builder.Services.AddScoped<IWeatherService, RealWeatherService>();
}
var env = builder.Environment;

if (env.IsDevelopment())
{
    builder.Services.AddScoped<IEnvService, DevelopmentService>();
}
else
{
    builder.Services.AddScoped<IEnvService, ProductionService>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

