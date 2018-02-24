using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;
using Senai.Ifood.Repository.Context;
using Senai.Ifood.Repository.Repositories;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController: Controller
    {
        private readonly IBaseRepository<ProdutoDomain> _repo;

        public ProdutoController(IBaseRepository<ProdutoDomain> repo)
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
        public IActionResult Cadastrar(ProdutoDomain produto){
            return Ok(_repo.Inserir(produto));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(ProdutoDomain produto){
            return Ok(_repo.Atualizar(produto));
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id){
            var produto = _repo.BuscarPorId(id);
            
            return Ok(_repo.Deletar(produto));
        }
    }
}