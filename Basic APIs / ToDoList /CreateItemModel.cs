// Define the namespace for the application's models. This helps organize related classes.
namespace ToDoList.Models
{
    // Define a class named CreateItem that represents a single item in the to-do list
    public class CreateItem
    {
        // The unique identifier for the item. Typically, this would be used to identify the item in a database.
        public int Id { get; set; }

        // The title or name of the to-do item. For example, "Buy groceries".
        public string Title { get; set; }

        // The description or details of the to-do item. For example, "Milk, eggs, and bread".
        public string Item { get; set; }
    }
}
