using Domain.ProjectAggregate;

namespace Infrastructure.Interfaces
{
    public interface IProjectRepository
    {
        Task<Guid> AddProjectAsync(Project project);
        Task UpdateProjectAsync(Project project);
        Task GetProjectByIdAsync(int id);
        Task<IEnumerable<Project>> GetProjectsAsync();
        Task<IEnumerable<Project>> GetProjectsByUserIdAsync(Guid userId);
        Task<IEnumerable<Project>> GetProjectsByDueDateAsync(DateTime dueDate);
    }
}