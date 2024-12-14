using Domain.TodoItemAggregate;

namespace Application.Models.TodoItem
{
    public class EditTodoItemModel
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }
        public int? Priority { get; set; }
        public List<Assignee>? Assignees { get; set; }
    }
}