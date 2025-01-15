using GerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace GerenciadorTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GerenciadorTarefasController : ControllerBase
{

    // Lista simulando as tarefas
    private static List<TasksJson> tasks = new List<TasksJson>
        {
            new TasksJson
            {
              Id = 1,
              Name = "Estudar React",
              Description = "Estudar React nos próximos meses",
              Priority = "Alta",
              FinishTaskUntil = DateTime.Now.AddDays(7),
              Status = "Em andamento"
            },
            new TasksJson {
              Id = 2,
              Name = "Estudar C#",
              Description = "Estudar C# nos próximos dias",
              Priority = "Alta",
              FinishTaskUntil = DateTime.Now.AddDays(5),
              Status = "Em andamento"
            },
             new TasksJson {
              Id = 3,
              Name = "Estudar Inglês",
              Description = "Estudar Inglês nos próximos dias",
              Priority = "Alta",
              FinishTaskUntil = DateTime.Now.AddDays(3),
              Status = "Em andamento"
            },

        };

    // GET: api/GerenciarTarefas
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(tasks);
    }

    // GET: api/GerenciadorTarefas/{id}
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound(); // Se não encontrar a tarefa, retorna 404
        }
        return Ok(task); // Retorna a tarefa com o ID específico
    }

    // POST: api/GerenciadorTarefas Criar nova tarefa
    [HttpPost]
    public IActionResult CreateNewTask([FromBody] TasksJson newTasks)
    {
        newTasks.Id = tasks.Max(t => t.Id) + 1; // gera um novo id
        tasks.Add(newTasks);
        return CreatedAtAction(nameof(GetById), new { id = newTasks.Id }, newTasks);

    }

    // PUT: api/GerenciadorTarefas/{id}
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] TasksJson updatedTask)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound(); // Retorna 404 se não encontrar a tarefa
        }

        // Atualiza os campos da tarefa
        task.Name = updatedTask.Name;
        task.Description = updatedTask.Description;
        task.Priority = updatedTask.Priority;
        task.FinishTaskUntil = updatedTask.FinishTaskUntil;
        task.Status = updatedTask.Status;

        return Ok(task); // Retorna a tarefa atualizada
    }

    // DELETE: api/GerenciadorTarefas/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound(); // Retorna 404 se não encontrar a tarefa
        }

        tasks.Remove(task); // Remove a tarefa
        return NoContent(); // Retorna 204 (sem conteúdo)

    }

    // - Deve ser possível criar uma tarefa; ROTA POST
    // - Deve ser possível visualizar todas as tarefas criadas; // GET 
    // - Deve ser possível visualizar uma tarefa buscando pelo seu id; // GET ID
    // - Deve ser possível editar informações de uma tarefa; // ROTA PUT
    // - Deve ser possível excluir uma tarefa. // ROTA DELETE

}
