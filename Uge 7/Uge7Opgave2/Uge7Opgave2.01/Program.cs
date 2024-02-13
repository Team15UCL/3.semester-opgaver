using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Uge7Opgave2._01.Data;
namespace Uge7Opgave2._01;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddDbContext<StudentContext>(options =>
		    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentContext") ?? throw new InvalidOperationException("Connection string 'StudentContext' not found.")));

		// Add services to the container.
		builder.Services.AddControllersWithViews();

		var app = builder.Build();

		using (var scope = app.Services.CreateScope())
		{
			SeedData.Initialize(app.Services.CreateScope().ServiceProvider);
		}

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
	}
}
