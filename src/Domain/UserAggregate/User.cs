namespace Domain.UserAggregate
{
    public class User : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public UserRole Role { get; private set; }

        public User(string firstName, string lastName, string email, string password, UserRole role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IsActive = true;
            UpdatedAt = DateTime.UtcNow;
            Role = role;
        }
    }
}