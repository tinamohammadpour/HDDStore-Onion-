using App.DataAccess.Services.Abouts;
using App.DataAccess.Services.Blogs;
using App.DataAccess.Services.contactUs;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


IConfiguration _config = builder.Configuration;
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(_config["ConnectionStrings:Connection"]);
});

#region IOC 
builder.Services.AddTransient<IAboutService, AboutService>();
builder.Services.AddTransient<IBlogCategoryService, BlogCategoryService>();
builder.Services.AddTransient<IBlogService, BlogService>();
#endregion

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
