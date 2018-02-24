using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;
using Senai.Ifood.Repository.Context;
using Senai.Ifood.Repository.Repositories;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioPermissaoController: Controller
    {
        private readonly IBaseRepository<UsuarioPermissaoDomain> _repo;

        public UsuarioPermissaoController(IBaseRepository<UsuarioPermissaoDomain> repo)
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
        public IActionResult Cadastrar(UsuarioPermissaoDomain usuarioPermissao){
            return Ok(_repo.Inserir(usuarioPermissao));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(UsuarioPermissaoDomain usuarioPermissao){
            return Ok(_repo.Atualizar(usuarioPermissao));
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id){
            var usuarioPermissao = _repo.BuscarPorId(id);
            
            return Ok(_repo.Deletar(usuarioPermissao));
        }
    }
}