using Domain.TodoItemAggregate;
using Domain.UserAggregate;

namespace API.Application.Factories
{
    public class TodoItemBuilder
    {
       private readonly TodoItem _todoItem;

        public TodoItemBuilder(string title, string description, Guid creatorId)
        {
            _todoItem = new TodoItem(title, description, creatorId);
        }

        public TodoItemBuilder WithAssignees(List<Assignee> assignees)
        {
            _todoItem.UpdateAssignees(assignees);
            return this;
        }

        public TodoItemBuilder WithDueDate(DateTime dueDate)
        {
            _todoItem.UpdateDueDate(dueDate);
            return this;
        }

        public TodoItemBuilder WithPriority(int priority)
        {
            _todoItem.UpdatePriority(priority);
            return this;
        }

        public TodoItemBuilder WithIsCompleted(bool IsCompleted)
        {
            _todoItem.UpdateIsCompleted(IsCompleted);
            return this;
        }

        public TodoItem Build()
        {
            return _todoItem;
        }
    }
}