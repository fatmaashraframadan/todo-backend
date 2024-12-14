using API.Application.Commands.Task;
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

        public TodoItem Edit(TodoItem todoItem, EditTodoItemCommand command)
        {
            todoItem.UpdateTitle(command.Input.Title ?? todoItem.Title)
                .UpdateDescription(command.Input.Description ?? todoItem.Description)
                .UpdateIsCompleted(command.Input.IsCompleted ?? todoItem.IsCompleted)
                .UpdatePriority(command.Input.Priority ?? todoItem.Priority)
                .UpdateDueDate(command.Input.DueDate ?? todoItem.DueDate)
                .UpdateAssignees(command.Input.Assignees ?? todoItem.Assignee);

            return todoItem;
        }

    }
}