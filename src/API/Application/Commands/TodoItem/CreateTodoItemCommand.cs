using MediatR;

namespace API.Application.Commands.TodoItem
{
    public class CreateTodoItemCommand : IRequest<Guid>
    {
        public TodoItemCreateModel Input { get; set; }

        public CreateTodoItemCommand(TodoItemCreateModel input)
        {
            Input = input;
        }
    }
}