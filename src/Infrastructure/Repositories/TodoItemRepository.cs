using Domain.TodoItemAggregate;
using Infrastructure.Interfaces;
using MongoDB.Driver;

namespace Infrastructure.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly BaseContext<TodoItem> _TodoItemContext;

        public TodoItemRepository(BaseContext<TodoItem> TaskContext)
        {
            _TodoItemContext = TaskContext;
        }

        public async Task<Guid> AddTodoItemAsync(TodoItem task)
        {
            await _TodoItemContext.Collection.InsertOneAsync(task);
            return task.Id;
        }

        public Task<bool> DeleteTodoItemAsync(Guid todoItemId)
        {
            var filter = Builders<TodoItem>.Filter.Eq(x => x.Id, todoItemId);
            _TodoItemContext.Collection.DeleteOneAsync(filter);
            return Task.FromResult(true);
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