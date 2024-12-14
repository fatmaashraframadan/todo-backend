using Domain.TodoItemAggregate;

namespace Infrastructure.Interfaces
{
    public interface ITodoItemRepository
    {
        Task<Guid> AddTodoItemAsync(TodoItem task);
        Task UpdateTodoItemsAsync(TodoItem task);
        Task GetTodoItemsByIdAsync(Guid id);
        Task<List<TodoItem>> GetTodoItemsAsync();
        Task<IEnumerable<TodoItem>> GetTodoItemsByCreatorIdAsync(Guid userId);
        Task<IEnumerable<TodoItem>> GetTodoItemsByDueDateAsync(DateTime dueDate);

        Task<TodoItem> FindById(Guid id);
        Task<bool> DeleteTodoItemAsync(Guid todoItemId);
    }
}