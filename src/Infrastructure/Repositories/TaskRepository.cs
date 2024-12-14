using Domain.TodoItemAggregate;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories
{
    public class TaskRepository : ITodoItemRepository
    {
        private readonly BaseContext<TodoItem> _TaskContext;

        public TaskRepository(BaseContext<TodoItem> TaskContext)
        {
            _TaskContext = TaskContext;
        }

        public async Task<Guid> AddTodoItemAsync(TodoItem task)
        {
            await _TaskContext.Collection.InsertOneAsync(task);
            return task.Id;
        }

        public Task<TodoItem> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task GetTaskByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TodoItem>> GetTasksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TodoItem>> GetTasksByDueDateAsync(DateTime dueDate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TodoItem>> GetTasksByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTaskAsync(TodoItem task)
        {
            throw new NotImplementedException();
        }
    }
}