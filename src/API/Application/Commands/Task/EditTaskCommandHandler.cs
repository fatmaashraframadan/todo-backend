using Infrastructure.Interfaces;
using MediatR;

namespace API.Application.Commands.Task
{
    public class EditTaskCommandHandler : IRequestHandler<EditTaskCommand, Guid>
    {
        private readonly ITodoItemRepository _taskRepository;

        public EditTaskCommandHandler(ITodoItemRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<Guid> Handle(EditTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskRepository.FindById(request.Id);

            if (task == null)
            {
                throw new Exception("Task not found");
            }

            

            await _taskRepository.UpdateTaskAsync(task);

            return task.Id;
        }
    }
}