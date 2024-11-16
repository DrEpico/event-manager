//using Xunit;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;
//using ThAmCo.Catering.Data;       
//using ThAmCo.Catering.Controllers;
//using Microsoft.AspNetCore.Mvc;    // For ActionResult

//namespace Test
//{
//    public class MenuFoodItemsControllerTests
//    {
//        [Fact]
//        public async Task PostMenuFoodItem_ShouldReturnCreated_WhenValidIds()
//        {
//            // Arrange
//            var options = new DbContextOptionsBuilder<CateringDbContext>()
//                .UseSqlite("Data Source=:memory:")
//                .Options;

//            using var context = new CateringDbContext(options);
//            await context.Database.OpenConnectionAsync();
//            await context.Database.EnsureCreatedAsync();

//            // Seed unique data for composite key
//            context.Menus.Add(new Menu { MenuId = 1, MenuName = "Sample Menu" });
//            context.FoodItems.Add(new FoodItem { FoodItemId = 1, Description = "Sample Food" });
//            await context.SaveChangesAsync();

//            var controller = new MenuFoodItemsController(context);

//            // Act: Add a valid menu-food item combination
//            var result = await controller.PostMenuFoodItem(1, 1);

//            // Assert: Check that it returns 201 Created
//            Assert.IsType<CreatedAtActionResult>(result.Result);
//        }

//        [Fact]
//        public async Task PostMenuFoodItem_ShouldReturnConflict_WhenItemAlreadyExists()
//        {
//            // Arrange
//            var options = new DbContextOptionsBuilder<CateringDbContext>()
//                .UseSqlite("Data Source=:memory:")
//                .Options;

//            using var context = new CateringDbContext(options);
//            await context.Database.OpenConnectionAsync();
//            await context.Database.EnsureCreatedAsync();

//            // Seed initial data
//            context.Menus.Add(new Menu { MenuId = 1, MenuName = "Sample Menu" });
//            context.FoodItems.Add(new FoodItem { FoodItemId = 1, Description = "Sample Food" });
//            context.MenuFoodItems.Add(new MenuFoodItem { MenuId = 1, FoodItemId = 1 });
//            await context.SaveChangesAsync();

//            var controller = new MenuFoodItemsController(context);

//            // Act: Attempt to add the same combination again
//            var result = await controller.PostMenuFoodItem(1, 1);

//            // Assert: Check that it returns a Conflict result
//            Assert.IsType<ConflictResult>(result.Result);
//        }
//    }
//}