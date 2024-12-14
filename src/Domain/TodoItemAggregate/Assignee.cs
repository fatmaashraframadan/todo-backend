namespace Domain.TodoItemAggregate
{
    public class Assignee : Entity
    {
        public Guid UserId { get; private set; }
        public string Email { get; private set; }
        public string Name { get; private set; }

        public Assignee(Guid userId, string email, string name)
        {
            UserId = userId;
            Email = email;
            Name = name;
        }
    }
}