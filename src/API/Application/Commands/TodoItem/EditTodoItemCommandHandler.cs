using API.Application.Factories;
using Infrastructure.Interfaces;
using MediatR;

namespace API.Application.Commands.Task
{
    public class EditTodoItemCommandHandler : IRequestHandler<EditTodoItemCommand, Guid>
    {
        private readonly ITodoItemRepository _taskRepository;
        private readonly TodoItemFactory _todoItemFactory;

        public EditTodoItemCommandHandler(ITodoItemRepository taskRepository, TodoItemFactory todoItemFactory)
        {
            _taskRepository = taskRepository;
            _todoItemFactory = todoItemFactory;
        }

        public async Task<Guid> Handle(EditTodoItemCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskRepository.FindById(request.Input.Id);
            task = _todoItemFactory.Edit(task, request);

            if (task == null)
            {
                throw new Exception("Task not found");
            }

            await _taskRepository.UpdateTodoItemsAsync(task);

            return task.Id;
        }
    }
}