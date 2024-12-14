using Domain.UserAggregate;

namespace Domain.ProjectAggregate
{
    public class Project : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public User Creator { get; private set; }
        public List<User> Members { get; private set; }

        public Project(string name, string description, User creator, List<User> members)
        {
            Name = name;
            Description = description;
            UpdatedAt = DateTime.UtcNow;
            Creator = creator;
            Members = members;
        }
    }
}