using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Domain.Entities;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly TodoService _service;

    public TodoController(TodoService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetTodos());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var todo = _service.GetTodoById(id);
        if (todo == null) return NotFound();
        return Ok(todo);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Todo todo)
    {
        if (_service.Add(todo))
            return CreatedAtAction(nameof(GetById), new { id = todo.Id }, todo);
        return BadRequest();
    }

    [HttpPut("{id}")]
    public IActionResult Update(string id, [FromBody] Todo updated)
    {
        updated.Id = id;
        if (_service.Update(updated)) return NoContent();
        return NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (_service.Delete(id)) return NoContent();
        return NotFound();
    }
}