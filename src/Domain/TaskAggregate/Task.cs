using Domain.UserAggregate;

namespace Domain.TaskAggregate
{
    public class Task
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public User Creator { get; private set; }
        public List<User> Assignee { get; private set; }

        public Task(string title, string description, User creator, List<User> assignee)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Creator = creator;
            Assignee = assignee;
        }
    }
}