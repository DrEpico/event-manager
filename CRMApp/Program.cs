using CRMApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("CrmDbContextConnection") ?? throw new InvalidOperationException("Connection string 'CrmDbContextConnection' not found.");

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CrmDbContext>();

// Configure Identity with roles
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // Add role support
    .AddEntityFrameworkStores<CrmDbContext>();

//builder.Services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Seed roles
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    // Define roles
    string[] roleNames = { "Admin", "Manager", "User" };

    foreach (var roleName in roleNames)
    {
        if (!await roleManager.RoleExistsAsync(roleName))
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }
    }

    // Optionally seed a default admin user
    var adminEmail = "user@example.com";
    var adminPassword = "UserPassword123!";

    var adminUser = await userManager.FindByEmailAsync(adminEmail);
    if (adminUser == null)
    {
        adminUser = new IdentityUser { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
        var result = await userManager.CreateAsync(adminUser, adminPassword);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(adminUser, "User");
        }
        else
        {
            Console.WriteLine("Error creating admin user:");
            foreach (var error in result.Errors)
            {
                Console.WriteLine(error.Description);
            }
        }
    }
}

//using (var scope = app.Services.CreateScope())
//{
//    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

//    // Find the user by email
//    var user = await userManager.FindByEmailAsync("aadmin@example.com");

//    if (user != null)
//    {
//        // Delete the user
//        var result = await userManager.DeleteAsync(user); //says database is locked at here?

//        if (result.Succeeded)
//        {
//            Console.WriteLine("User deleted successfully.");
//        }
//        else
//        {
//            Console.WriteLine("Error deleting user:");
//            foreach (var error in result.Errors)
//            {
//                Console.WriteLine(error.Description);
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("User not found.");
//    }
//}




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages(); // Map razor pages
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
