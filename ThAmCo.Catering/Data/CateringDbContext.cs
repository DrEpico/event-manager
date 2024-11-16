using Microsoft.EntityFrameworkCore;

namespace ThAmCo.Catering.Data
{
    public class CateringDbContext : DbContext
    {
        // Notes
        // - DbSet defines the database table.
        // - the class name is defined as part of the data model
        // - the instance/object name is normally plural
        // - by default, the instance name will become the table name
        public DbSet<FoodBooking> FoodBookings { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<MenuFoodItem> MenuFoodItems { get; set; }
        public string DbPath { get; } = string.Empty;

        public CateringDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "ThAmCo.catering.db");
        }

        public CateringDbContext(DbContextOptions<CateringDbContext> options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Composite Key
            modelBuilder.Entity<MenuFoodItem>()
                .HasKey(mf => new { mf.MenuId, mf.FoodItemId });

            //Define many to many
            modelBuilder.Entity<Menu>()
                .HasMany(m => m.MenuFoodItems)
                .WithOne(mfi => mfi.Menu)
                .HasForeignKey(mf => mf.MenuId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FoodItem>()
                .HasMany(fi => fi.MenuFoodItems)
                .WithOne(mfi => mfi.FoodItem)
                .HasForeignKey(mfi => mfi.FoodItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed data for FoodBooking table
            modelBuilder.Entity<FoodBooking>().HasData(
                new FoodBooking { FoodBookingId = 1, ClientReferenceId = 1001, NumberOfGuests = 50, MenuId = 1 },
                new FoodBooking { FoodBookingId = 2, ClientReferenceId = 1002, NumberOfGuests = 30, MenuId = 2 },
                new FoodBooking { FoodBookingId = 3, ClientReferenceId = 1003, NumberOfGuests = 75, MenuId = 3 },
                new FoodBooking { FoodBookingId = 4, ClientReferenceId = 1004, NumberOfGuests = 20, MenuId = 4 },
                new FoodBooking { FoodBookingId = 5, ClientReferenceId = 1005, NumberOfGuests = 100, MenuId = 5 },
                new FoodBooking { FoodBookingId = 6, ClientReferenceId = 1006, NumberOfGuests = 40, MenuId = 6 },
                new FoodBooking { FoodBookingId = 7, ClientReferenceId = 1007, NumberOfGuests = 60, MenuId = 7 },
                new FoodBooking { FoodBookingId = 8, ClientReferenceId = 1008, NumberOfGuests = 35, MenuId = 8 },
                new FoodBooking { FoodBookingId = 9, ClientReferenceId = 1009, NumberOfGuests = 45, MenuId = 9 },
                new FoodBooking { FoodBookingId = 10, ClientReferenceId = 1010, NumberOfGuests = 25, MenuId = 10 }
            );

            // Seed data for Menu table
            modelBuilder.Entity<Menu>().HasData(
                new Menu { MenuId = 1, MenuName = "Classic Menu" },
                new Menu { MenuId = 2, MenuName = "Vegetarian Menu" },
                new Menu { MenuId = 3, MenuName = "Vegan Menu" },
                new Menu { MenuId = 4, MenuName = "Kids Menu" },
                new Menu { MenuId = 5, MenuName = "Seafood Menu" },
                new Menu { MenuId = 6, MenuName = "Italian Menu" },
                new Menu { MenuId = 7, MenuName = "BBQ Menu" },
                new Menu { MenuId = 8, MenuName = "Dessert Menu" },
                new Menu { MenuId = 9, MenuName = "Breakfast Menu" },
                new Menu { MenuId = 10, MenuName = "Lunch Menu" }
            );

            // Seed data for FoodItem table
            modelBuilder.Entity<FoodItem>().HasData(
                new FoodItem { FoodItemId = 1, Description = "Grilled Chicken", UnitPrice = 12.50f },
                new FoodItem { FoodItemId = 2, Description = "Vegan Salad", UnitPrice = 8.00f },
                new FoodItem { FoodItemId = 3, Description = "Chocolate Cake", UnitPrice = 5.00f },
                new FoodItem { FoodItemId = 4, Description = "Fruit Salad", UnitPrice = 4.50f },
                new FoodItem { FoodItemId = 5, Description = "Fish and Chips", UnitPrice = 10.00f },
                new FoodItem { FoodItemId = 6, Description = "Macaroni and Cheese", UnitPrice = 6.50f },
                new FoodItem { FoodItemId = 7, Description = "Caesar Salad", UnitPrice = 7.00f },
                new FoodItem { FoodItemId = 8, Description = "Pasta Primavera", UnitPrice = 9.00f },
                new FoodItem { FoodItemId = 9, Description = "Ice Cream Sundae", UnitPrice = 3.50f },
                new FoodItem { FoodItemId = 10, Description = "Pancakes", UnitPrice = 4.00f }
            );

            // Seed data for MenuFoodItem table
            modelBuilder.Entity<MenuFoodItem>().HasData(
                new MenuFoodItem { MenuId = 1, FoodItemId = 1 },
                new MenuFoodItem { MenuId = 1, FoodItemId = 3 },
                new MenuFoodItem { MenuId = 1, FoodItemId = 5 },
                new MenuFoodItem { MenuId = 2, FoodItemId = 2 },
                new MenuFoodItem { MenuId = 2, FoodItemId = 4 },
                new MenuFoodItem { MenuId = 3, FoodItemId = 2 },
                new MenuFoodItem { MenuId = 3, FoodItemId = 7 },
                new MenuFoodItem { MenuId = 4, FoodItemId = 6 },
                new MenuFoodItem { MenuId = 4, FoodItemId = 9 },
                new MenuFoodItem { MenuId = 5, FoodItemId = 5 },
                new MenuFoodItem { MenuId = 5, FoodItemId = 8 },
                new MenuFoodItem { MenuId = 6, FoodItemId = 8 },
                new MenuFoodItem { MenuId = 6, FoodItemId = 7 },
                new MenuFoodItem { MenuId = 7, FoodItemId = 1 },
                new MenuFoodItem { MenuId = 7, FoodItemId = 5 },
                new MenuFoodItem { MenuId = 8, FoodItemId = 3 },
                new MenuFoodItem { MenuId = 8, FoodItemId = 9 },
                new MenuFoodItem { MenuId = 9, FoodItemId = 10 },
                new MenuFoodItem { MenuId = 9, FoodItemId = 4 },
                new MenuFoodItem { MenuId = 10, FoodItemId = 6 }
            );
        }
    }
}
