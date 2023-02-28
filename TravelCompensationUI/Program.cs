using ExampleAPIClient.Client;
using NodaTime;
using System.IO.Abstractions;
using TravelAllowance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IRestClient>(x => new RestClient("https://api.staging.yeshugo.com/applicant/travel_types"));
builder.Services.AddScoped<IDBHandler, DBHandler>();
builder.Services.AddScoped<ITravelCompensationCalculator, TravelCompensationCalculator>();
builder.Services.AddScoped<IFileSystem, FileSystem>();
builder.Services.AddScoped<ICSVFileGenerator, CSVFileGenerator>();
builder.Services.AddSingleton<IClock>(SystemClock.Instance);
builder.Services.AddScoped<ITravelCompensationService, TravelCompensationService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   app.UseExceptionHandler("/Error");
   // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
   app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
