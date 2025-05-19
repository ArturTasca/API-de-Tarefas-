using Microsoft.AspNetCore.Mvc;
using Minha_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Minha_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefasController : ControllerBase
    {
        private static List<Tarefas> tarefas = new List<Tarefas>();
        private static int proximoId = 1;

        [HttpGet]
        public IActionResult Get() => Ok(tarefas);

        [HttpPost]
        public IActionResult Post(Tarefas novaTarefa)
        {
            novaTarefa.Id = proximoId++;
            tarefas.Add(novaTarefa);
            return CreatedAtAction(nameof(GetById), new { id = novaTarefa.Id }, novaTarefa);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa == null) return NotFound();
            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Tarefas atualizada)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa == null) return NotFound();

            tarefa.Titulo = atualizada.Titulo;
            tarefa.Concluida = atualizada.Concluida;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa == null) return NotFound();

            tarefas.Remove(tarefa);
            return NoContent();
        }
    }
}
