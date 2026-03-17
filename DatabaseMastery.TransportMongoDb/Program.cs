using DatabaseMastery.TransportMongoDb.Mapping;
using DatabaseMastery.TransportMongoDb.Services.AboutServices;
using DatabaseMastery.TransportMongoDb.Services.BrandServices;
using DatabaseMastery.TransportMongoDb.Services.GetInTouchServices;
using DatabaseMastery.TransportMongoDb.Services.HowItWorkServices;
using DatabaseMastery.TransportMongoDb.Services.OfferServices;
using DatabaseMastery.TransportMongoDb.Services.ProjectSectionServices;
using DatabaseMastery.TransportMongoDb.Services.QuestionServices;
using DatabaseMastery.TransportMongoDb.Services.ShipmentServices;
using DatabaseMastery.TransportMongoDb.Services.ShipmentTrackingServices;
using DatabaseMastery.TransportMongoDb.Services.SliderServices;
using DatabaseMastery.TransportMongoDb.Services.TestimonialServices;
using DatabaseMastery.TransportMongoDb.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IOfferService, OfferService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IGetInTouchService, GetInTouchService>();
builder.Services.AddScoped<IHowItWorkService, HowItWorkService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IProjectSectionService, ProjectSectionService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IShipmentService, ShipmentService>();
builder.Services.AddScoped<IShipmentTrackingService, ShipmentTrackingService>();

#endregion

#region AutoMapper

builder.Services.AddAutoMapper(cfg => { },
    typeof(GeneralMapping).Assembly);

// Or
builder.Services.AddAutoMapper(cfg => { },
    Assembly.GetExecutingAssembly());


#endregion

#region Database Settings

builder.Services.Configure<DatabaseSettings>(
    builder.Configuration.GetSection("DatabaseSettingsKey"));

builder.Services.AddScoped<IDatabaseSettings>(
    sp => sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);

#endregion

builder.Services.AddControllersWithViews();

var app = builder.Build();

#region Middleware

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

#endregion

#region Routing

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

#endregion

app.Run();