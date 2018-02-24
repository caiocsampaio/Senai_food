using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;
using Senai.Ifood.Repository.Context;
using Senai.Ifood.Repository.Repositories;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController: Controller
    {
        private readonly IBaseRepository<UsuarioDomain> _repo;

        public UsuarioController(IBaseRepository<UsuarioDomain> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Listar(){
            return Ok(_repo.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id){
            return Ok(_repo.BuscarPorId(id));
        }
        
        [HttpPost]
        public IActionResult Cadastrar(UsuarioDomain usuario){
            return Ok(_repo.Inserir(usuario));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(UsuarioDomain usuario){
            return Ok(_repo.Atualizar(usuario));
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id){
            var usuario = _repo.BuscarPorId(id);
            
            return Ok(_repo.Deletar(usuario));
        }
    }
}