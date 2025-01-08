using ThAmCo.Catering.Data;
using ThAmCo.Events.Data;
using ThAmCo.Events.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("EventDbContextConnection") ?? throw new InvalidOperationException("Connection string 'EventDbContextConnection' not found.");

// Add services to the container.

// Register the HTTP client and VenueService for Dependency Injection (DI)
builder.Services.AddHttpClient<VenueAvailabilityService>();
builder.Services.AddHttpClient<VenueEventTypeService>();
builder.Services.AddHttpClient<VenueReservationService>();

builder.Services.AddRazorPages();

builder.Services.AddDbContext<EventDbContext>();

// Configure Identity with roles
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // Add role support
    .AddEntityFrameworkStores<EventDbContext>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminAccess", policy =>
          policy.RequireRole("Admin"));
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ElevatedAccess", policy =>
          policy.RequireRole("Admin", "Manager"));
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("EmployeeAccess", policy =>
          policy.RequireRole("Admin", "Manager", "Assistant"));
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("FreeAccess", policy =>
          policy.RequireRole("Admin", "Manager", "Assistant", "User"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Seed roles
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    // Define roles
    string[] roleNames = { "Admin", "Manager", "Assistant", "User" };

    foreach (var roleName in roleNames)
    {
        if (!await roleManager.RoleExistsAsync(roleName))
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }
    }

    // Optionally seed a default admin user
    var adminEmail = "admin@example.com";
    var adminUsername = "admin@example.com";
    var adminPassword = "AdminPassword123!";

    var managerEmail = "manager@example.com";
    var managerUsername = "manager@example.com";
    var managerPassword = "ManagerPassword123!";

    var assistantEmail = "assistant@example.com";
    var assistantUsername = "assistant@example.com";
    var assistantPassword = "AssistantPassword123!";

    var userEmail = "user@example.com";
    var userUsername = "user@example.com";
    var userPassword = "UserPassword123!";

    var myEmail = "adadashipour@gmail.com";
    var myUsername = "adadashipour@gmail.com";
    var myPassword = "Password123!";

    var adminUser = await userManager.FindByEmailAsync(adminEmail);
    if (adminUser == null)
    {
        adminUser = new IdentityUser { UserName = adminUsername, Email = adminEmail, EmailConfirmed = true };
        var result = await userManager.CreateAsync(adminUser, adminPassword);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(adminUser, "Admin");
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

    var managerUser = await userManager.FindByEmailAsync(managerEmail);
    if (managerUser == null)
    {
        managerUser = new IdentityUser { UserName = managerUsername, Email = managerEmail, EmailConfirmed = true };
        var result = await userManager.CreateAsync(managerUser, managerPassword);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(managerUser, "Manager");
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

    var assistantUser = await userManager.FindByEmailAsync(assistantEmail);
    if (assistantUser == null)
    {
        assistantUser = new IdentityUser { UserName = assistantUsername, Email = assistantEmail, EmailConfirmed = true };
        var result = await userManager.CreateAsync(assistantUser, assistantPassword);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(assistantUser, "Assistant");
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

    var userUser = await userManager.FindByEmailAsync(userEmail);
    if (userUser == null)
    {
        userUser = new IdentityUser { UserName = userUsername, Email = userEmail, EmailConfirmed = true };
        var result = await userManager.CreateAsync(userUser, userPassword);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(userUser, "User");
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

    var me = await userManager.FindByEmailAsync(myEmail);
    if (me == null)
    {
        me = new IdentityUser { UserName = myUsername, Email = myEmail, EmailConfirmed = true };
        var result = await userManager.CreateAsync(me, myPassword);

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(me, "User");
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
//    var user = await userManager.FindByEmailAsync("adadashipour@gmail.com");

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

app.MapRazorPages();

app.Run();
