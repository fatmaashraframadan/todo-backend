
using API.Application.Commands.TodoItem;
using API.Application.Factories;
using Infrastructure.Interfaces;
using MediatR;

namespace todo_backend.Application.Commands.TodoItem
{

    public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, Guid>
    {
        private readonly ITodoItemRepository _todoItemRepository;

        public CreateTodoItemCommandHandler(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public async Task<Guid> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
        {
            var todoItem = new TodoItemFactory().Create(request);

            await _todoItemRepository.AddTodoItemAsync(todoItem);
            return todoItem.Id;
        }
    }
}