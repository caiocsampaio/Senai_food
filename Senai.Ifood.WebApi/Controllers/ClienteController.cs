using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;
using Senai.Ifood.Repository.Context;
using Senai.Ifood.Repository.Repositories;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController: Controller
    {
        private readonly IBaseRepository<ClienteDomain> _repo;

        public ClienteController(IBaseRepository<ClienteDomain> repo)
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
        public IActionResult Cadastrar(ClienteDomain cliente){
            return Ok(_repo.Inserir(cliente));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(ClienteDomain cliente){
            return Ok(_repo.Atualizar(cliente));
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id){
            var cliente = _repo.BuscarPorId(id);
            
            return Ok(_repo.Deletar(cliente));
        }
    }
}