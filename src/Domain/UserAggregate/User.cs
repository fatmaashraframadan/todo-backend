namespace Domain.UserAggregate
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public UserRole Role { get; private set; }

        public User(string firstName, string lastName, string email, string password, UserRole role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IsActive = true;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Role = role;
        }
    }
}