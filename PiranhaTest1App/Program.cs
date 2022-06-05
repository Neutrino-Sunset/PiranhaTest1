using Microsoft.EntityFrameworkCore;

using Piranha;
using Piranha.AspNetCore.Identity.SQLite;
using Piranha.AttributeBuilder;
using Piranha.Data.EF.SQLite;
using Piranha.Local;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddPiranha(options =>
{
   options.AddRazorRuntimeCompilation = true;

   options.UseCms();
   options.UseManager();
   options.UseFileStorage(naming: FileStorageNaming.UniqueFolderNames);
   options.UseImageSharp();
   options.UseMemoryCache();
   options.UseTinyMCE();
   options.UseEF<SQLiteDb>(db =>
       db.UseSqlite("Filename=./PiranhaWeb.db"));
   options.UseIdentityWithSeed<IdentitySQLiteDb>(db =>
       db.UseSqlite("Filename=./PiranhaWeb.db"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   app.UseExceptionHandler("/Error");
   // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
   app.UseHsts();
}

app.UsePiranha(options =>
{
   App.Init(options.Api);

   // Build content types
   new ContentTypeBuilder(options.Api)
       .AddAssembly(typeof(Program).Assembly)
       .Build()
       .DeleteOrphans();

   options.UseManager();
   options.UseTinyMCE();
   options.UseIdentity();
});

app.Run();
