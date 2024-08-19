// Import the necessary namespaces
using Microsoft.AspNetCore.Mvc; // Provides classes and attributes for MVC (Model-View-Controller) functionality
using ToDoList.Models; // Import the models used in the ToDoList application

// Define the namespace for the application. This helps organize related classes.
namespace ToDoList.Controllers
{
    // This attribute specifies that the routing for this controller is based on the "api/[controller]" pattern
    [Route("api/[controller]")]
    // Indicates that this class is an API controller that can handle HTTP requests
    [ApiController]
    public class CreateItemController : Controller
    {
        // This static list will hold the items in memory. It's shared across all instances of the controller.
        private static List<CreateItem> _items = new List<CreateItem>();

        // The HttpPost attribute specifies that this action method responds to HTTP POST requests
        [HttpPost]
        // This method is asynchronous and will handle requests to create new items
        public async Task<ActionResult> CreateItem([FromBody] CreateItem newItem)
        {
            // Check if the incoming item data is null, which means the request was invalid
            if (newItem == null)
            {
                // Return a 400 Bad Request response with an error message
                return BadRequest("Invalid item data.");
            }

            // Use Task.Run to add the new item to the list asynchronously
            await Task.Run(() => _items.Add(newItem));

            // Return a 200 OK response with the created item as the response body
            return Ok(newItem);
        }
    }
}
