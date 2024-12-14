namespace API.Application.Commands.TodoItem
{
    public class TodoItemCreateModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid CreatorId { get; set; }
        public List<Domain.UserAggregate.User> Assignees { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public bool IsCompleted { get; set; }

    }
}