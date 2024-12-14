using Infrastructure.Interfaces;
using Domain.ProjectAggregate;

namespace Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly BaseContext<Project> _ProjectContext;

        public ProjectRepository(BaseContext<Project> ProjectContext)
        {
            _ProjectContext = ProjectContext;
        }

        public async Task<Guid> AddProjectAsync(Project project)
        {
            await _ProjectContext.Collection.InsertOneAsync(project);
            return project.Id;
        }

        public Task GetProjectByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetProjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetProjectsByDueDateAsync(DateTime dueDate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetProjectsByUserIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}