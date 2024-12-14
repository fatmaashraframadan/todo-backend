using Application.Models.TodoItem;
using MediatR;

namespace API.Application.Commands.Task
{
    public class EditTodoItemCommand : IRequest<Guid>
    {
        public EditTodoItemModel Input { get; set; }

        public EditTodoItemCommand(EditTodoItemModel input)
        {
            Input = input;
        }
    }

}