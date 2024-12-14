

using API.Application.Commands.TodoItem;
using Domain.TodoItemAggregate;

namespace API.Application.Factories
{
    public class TodoItemFactory
    {
        public TodoItem Create(CreateTodoItemCommand command)
        {
            var todoItem = new TodoItemBuilder(command.Input.Title, command.Input.Description, command.Input.CreatorId)
                .WithAssignees(command.Input.Assignees)
                .WithDueDate(command.Input.DueDate)
                .WithPriority(command.Input.Priority)
                .WithIsCompleted(command.Input.IsCompleted).Build();

            return todoItem;
        }
    }
}