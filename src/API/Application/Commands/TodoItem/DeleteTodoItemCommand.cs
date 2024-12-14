using API.Application.Models.TodoItem;
using MediatR;

namespace Application.Commands.TodoItem
{
    public class DeleteTodoItemCommand : IRequest<bool>
    {
        public DeleteTodoItemModel Input { get; set; }

        public DeleteTodoItemCommand(DeleteTodoItemModel input)
        {
            Input = input;
        }
    }
}