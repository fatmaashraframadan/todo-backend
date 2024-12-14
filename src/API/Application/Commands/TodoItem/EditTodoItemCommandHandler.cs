using Infrastructure.Interfaces;
using MediatR;

namespace API.Application.Commands.Task
{
    public class EditTodoItemCommandHandler : IRequestHandler<EditTodoItemCommand, Guid>
    {
        private readonly ITodoItemRepository _taskRepository;

        public EditTodoItemCommandHandler(ITodoItemRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<Guid> Handle(EditTodoItemCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskRepository.FindById(request.Input.Id);

            if (task == null)
            {
                throw new Exception("Task not found");
            }

            await _taskRepository.UpdateTaskAsync(task);

            return task.Id;
        }
    }
}