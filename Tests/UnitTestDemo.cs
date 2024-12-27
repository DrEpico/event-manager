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
        public async Task AddFoodItem_ShouldReturnCreatedResult()
        {
            var context = new CateringDbContext();
            var controller = new FoodItemsController(context);

            var result = await controller.AddFoodItem(new FoodItemDto { Description = "Test Food Item", UnitPrice = 10 });

            // Assert
            var actionResult = Assert.IsType<ActionResult<FoodItemDto>>(result); // Verify the outer ActionResult
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result); // Extract and verify CreatedAtActionResult
            Assert.Equal(201, createdAtActionResult.StatusCode); // Verify it's HTTP 201 Created
            Assert.NotNull(createdAtActionResult.Value); // Ensure the created object is not null
            Assert.IsType<FoodItemDto>(createdAtActionResult.Value); // Verify the returned object type
        }

        [Fact]
        public async Task EditFoodItem_ShouldReturnSuccessCode()
        {
            // Arrange
            var context = new CateringDbContext();
            var controller = new FoodItemsController(context);

            // Act
            var result = await controller.EditFoodItem(13, new FoodItemDto { Description = "Editing Food Item", UnitPrice = 10 });

            // Assert
            result.EnsureSuccessStatusCode(); // Verify the result has a success status code
        }

    }
}