using DatabaseMastery.TransportMongoDb.Services.SliderServices;
using DatabaseMastery.TransportMongoDb.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;
using AutoMapper;
using DatabaseMastery.TransportMongoDb.Services.BrandServices;
using DatabaseMastery.TransportMongoDb.Services.OfferServices;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IOfferService, OfferService>();


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));

builder.Services.AddScoped<IDatabaseSettings>(
    sp => sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
