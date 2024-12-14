using Domain.UserAggregate;

namespace Domain.TodoItemAggregate
{
    public class TodoItem : Entity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsCompleted { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public Guid CreatorId { get; private set; }
        public List<Assignee> Assignee { get; private set; }
        public int Priority { get; private set; }
        public DateTime DueDate { get; private set; }

        public TodoItem(string title, string description, Guid creatorId)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
            UpdatedAt = DateTime.UtcNow;
            CreatorId = creatorId;
        }


        public TodoItem UpdateTitle(string title)
        {
            Title = title;
            UpdatedAt = DateTime.UtcNow;
            return this;
        }

        public TodoItem UpdateDescription(string description)
        {
            Description = description;
            UpdatedAt = DateTime.UtcNow;
            return this;
        }

        public TodoItem MarkAsCompleted()
        {
            IsCompleted = true;
            UpdatedAt = DateTime.UtcNow;
            return this;
        }

        public TodoItem MarkAsIncompleted()
        {
            IsCompleted = false;
            UpdatedAt = DateTime.UtcNow;
            return this;
        }

        public TodoItem AssignToUser(Assignee user)
        {
            Assignee.Add(user);
            UpdatedAt = DateTime.UtcNow;
            return this;
        }

        public TodoItem RemoveAssignee(Assignee user)
        {
            Assignee.Remove(user);
            UpdatedAt = DateTime.UtcNow;
            return this;
        }

        public TodoItem UpdateAssignees(List<Assignee> assignees)
        {
            Assignee = assignees;
            UpdatedAt = DateTime.UtcNow;
            return this;
        }

        public TodoItem UpdateIsCompleted(bool isCompleted)
        {
            IsCompleted = isCompleted;
            UpdatedAt = DateTime.UtcNow;
            return this;
        }

        public TodoItem UpdateDueDate(DateTime dueDate)
        {
            DueDate = dueDate;
            UpdatedAt = DateTime.UtcNow;
            return this;

        }

        public TodoItem UpdatePriority(int priority)
        {
            Priority = priority;
            UpdatedAt = DateTime.UtcNow;
            return this;

        }
    }
}