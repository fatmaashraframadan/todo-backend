using Domain.TodoItemAggregate;

namespace Infrastructure.Interfaces
{
    public interface ITodoItemRepository
    {
        Task<Guid> AddTodoItemAsync(TodoItem task);
        Task UpdateTaskAsync(TodoItem task);
        Task GetTaskByIdAsync(Guid id);
        Task<IEnumerable<TodoItem>> GetTasksAsync();
        Task<IEnumerable<TodoItem>> GetTasksByUserIdAsync(Guid userId);
        Task<IEnumerable<TodoItem>> GetTasksByDueDateAsync(DateTime dueDate);

        Task<TodoItem> FindById(Guid id);
        Task<bool> DeleteTodoItemAsync(Guid todoItemId);
    }
}