using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RazorPagesLibrary.Data;
using RazorPagesLibrary.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<RazorPagesLibraryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesLibraryContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesLibraryContext' not found.")));

// Configure logging
builder.Logging.ClearProviders(); // Clear the default providers

builder.Logging.AddConsole(); // Add console logging

// Add additional logging providers or configure options as needed
// For example, you might add logging to a file or other external services.

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedAccountData.Initialize(services);
}

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
