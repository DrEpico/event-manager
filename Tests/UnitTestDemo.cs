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
    /// <summary>
    /// This class contains demo unit tests for the MenuItemsController class.
    /// I have demonstrated how to write unit tests for the GetFoodItems method.
    /// Note: I figured out how I can write unit tests too late in the project but otherwise I would have written tests while
    /// development, which would've been a great way to proceed with the testing criteria of the assignment.
    /// Note 2: These unit tests mostly only look for a success status code, which is meant to simulates black-box testing.
    /// </summary>
    public class MenuItemsControllerTests
    {
        /// <summary>
        /// This unit test checks if the GetFoodItems method returns an OK result.
        /// </summary>
        [Fact]
        public async Task AddFoodItem_ShouldReturnCreatedResult()
        {
            // Arrange
            var context = new CateringDbContext();
            var controller = new FoodItemsController(context);

            // Act
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
            result.EnsureSuccessStatusCode(); // Verify the result has a success status code using the custom extension method.
        }
    }
}