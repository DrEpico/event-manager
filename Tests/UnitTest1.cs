using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ThAmCo.Catering.Data;
using ThAmCo.Catering.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ThAmCo.Catering.Dtos;
using Microsoft.AspNetCore.Builder;

namespace Tests
{
    public class MenuItemsControllerTests
    {
        [Fact]
        public async Task GetFoodItems_ShouldReturnOkResult()
        {
            // Arrange: Setup an in-memory SQLite database
            var options = new DbContextOptionsBuilder<CateringDbContext>()
                .UseSqlite("Data Source=:memory:")
                .Options;

            using var context = new CateringDbContext();
            await context.Database.OpenConnectionAsync();
            await context.Database.EnsureCreatedAsync();

            // Seed test data
            context.FoodItems.Add(new FoodItem { FoodItemId = 1, Description = "Sample Food" });
            await context.SaveChangesAsync();

            var controller = new FoodItemsController(context);

            // Act
            var result = await controller.GetFoodItems();

            // Assert
            var objectResult = Assert.IsType<ObjectResult>(result.Result); // Check generic ObjectResult
            Assert.Equal(200, objectResult.StatusCode); // Verify it's HTTP 200 OK
        }
    }
}