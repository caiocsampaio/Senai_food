using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;
using Senai.Ifood.Repository.Context;
using Senai.Ifood.Repository.Repositories;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EspecialidadeController: Controller
    {
        private readonly IBaseRepository<EspecialidadeDomain> _repo;

        public EspecialidadeController(IBaseRepository<EspecialidadeDomain> repo)
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
        public IActionResult Cadastrar(EspecialidadeDomain especialidade){
            return Ok(_repo.Inserir(especialidade));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(EspecialidadeDomain especialidade){
            return Ok(_repo.Atualizar(especialidade));
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id){
            var especialidade = _repo.BuscarPorId(id);
            
            return Ok(_repo.Deletar(especialidade));
        }
    }
}