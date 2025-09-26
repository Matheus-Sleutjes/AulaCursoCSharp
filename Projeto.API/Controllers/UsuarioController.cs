using Microsoft.AspNetCore.Mvc;
using Projeto.Data.Model;
using Projeto.Data.Repository;

namespace Projeto.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository _repository;
        public UsuarioController(UsuarioRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var lista = _repository.GetAll();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entidade = _repository.Get(id);
            return Ok(entidade);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            _repository.Add(usuario);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Usuario usuario)
        {
            _repository.Update(id, usuario);
            return Ok("Foi atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok("Foi deletado");
        }

        [HttpDelete()]
        public IActionResult Delete([FromBody] Usuario usuario)
        {
            _repository.Delete(usuario);
            return Ok("Foi deletado");
        }
    }
}
