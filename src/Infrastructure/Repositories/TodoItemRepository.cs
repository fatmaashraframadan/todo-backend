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
            var filter = Builders<TodoItem>.Filter.Eq(x => x.Id, id);
            return _TodoItemContext.Collection.Find(filter).FirstOrDefaultAsync();
        }

        public Task GetTodoItemsByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoItem>> GetTodoItemsAsync()
        {
            return _TodoItemContext.Collection.Find(_ => true).ToListAsync();
        }

        public Task<IEnumerable<TodoItem>> GetTodoItemsByDueDateAsync(DateTime dueDate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TodoItem>> GetTodoItemsByCreatorIdAsync(Guid userId)
        {
            var filter = Builders<TodoItem>.Filter.Eq(x => x.CreatorId, userId);
            var todoItems = await _TodoItemContext.Collection.Find(filter).ToListAsync();
            return todoItems;
        }


        public Task UpdateTodoItemsAsync(TodoItem task)
        {
            var filter = Builders<TodoItem>.Filter.Eq(x => x.Id, task.Id);
            _TodoItemContext.Collection.ReplaceOneAsync(filter, task);
            return Task.CompletedTask;
        }
    }
}