using API.Application.Commands.Task;
using API.Application.Commands.TodoItem;
using API.Application.Models.TodoItem;
using Application.Commands.TodoItem;
using Application.Models.TodoItem;
using Domain.TodoItemAggregate;
using Infrastructure.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace todo_backend.Controllers
{
    [Route("api/")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ITodoItemRepository _todoItemRepository;

        public TodoItemController(IMediator mediator, ITodoItemRepository todoItemService)
        {
            _mediator = mediator;
            _todoItemRepository = todoItemService;
        }

        [HttpGet]
        [Route("todo-items/")]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            var todoItems = await _todoItemRepository.GetTodoItemsAsync();

            return Ok(todoItems);
        }

        [HttpGet]
        [Route("todo-item/{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(string id)
        {
            if (!Guid.TryParse(id, out Guid guidId))
            {
                return BadRequest("Invalid GUID format.");
            }
            var todoItem = await _todoItemRepository.FindById(new Guid(id));

            if (todoItem == null)
            {
                return NotFound();
            }

            return Ok(todoItem);
        }

        [HttpPost]
        [Route("add-todo-item/")]
        public async Task<ActionResult<TodoItem>> CreateTodoItem([FromBody] TodoItemCreateModel todoItem)
        {
            var command = new CreateTodoItemCommand(todoItem);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("edit-todo-item/")]
        public async Task<IActionResult> UpdateTodoItem([FromBody] EditTodoItemModel todoItem)
        {
            var command = new EditTodoItemCommand(todoItem);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("delete-todo-item/")]
        public async Task<IActionResult> DeleteTodoItem([FromBody] DeleteTodoItemModel todoItem)
        {
            var command = new DeleteTodoItemCommand(todoItem);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}