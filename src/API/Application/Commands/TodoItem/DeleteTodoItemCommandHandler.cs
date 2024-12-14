using Application.Commands.TodoItem;
using Infrastructure.Interfaces;
using MediatR;

namespace todo_backend.Application.Commands.TodoItem
{
    public class DeleteTodoItemCommandHandler : IRequestHandler<DeleteTodoItemCommand, bool>
    {
        private readonly ITodoItemRepository _todoItemRepository;

        public DeleteTodoItemCommandHandler(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public async Task<bool> Handle(DeleteTodoItemCommand request, CancellationToken cancellationToken)
        {
            var todoItem = await _todoItemRepository.FindById(request.Input.Id);

            if (todoItem == null)
            {
                return false;
            }

            var result = await _todoItemRepository.DeleteTodoItemAsync(todoItem.Id);

            return result;
        }
    }
}