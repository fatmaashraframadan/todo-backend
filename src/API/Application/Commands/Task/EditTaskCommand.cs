using MediatR;

namespace API.Application.Commands.Task
{
    public class EditTaskCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }

        public EditTaskCommand(Guid id, string title, string description, DateTime dueDate, int priority, int status)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            Priority = priority;
            Status = status;
        }
    }

}