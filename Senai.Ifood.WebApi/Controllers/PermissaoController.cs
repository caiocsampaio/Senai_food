using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;
using Senai.Ifood.Repository.Context;
using Senai.Ifood.Repository.Repositories;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PermissaoController: Controller
    {
        private readonly IBaseRepository<PermissaoDomain> _repo;

        public PermissaoController(IBaseRepository<PermissaoDomain> repo)
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
        public IActionResult Cadastrar(PermissaoDomain permissao){
            return Ok(_repo.Inserir(permissao));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(PermissaoDomain permissao){
            return Ok(_repo.Atualizar(permissao));
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id){
            var permissao = _repo.BuscarPorId(id);
            
            return Ok(_repo.Deletar(permissao));
        }
    }
}