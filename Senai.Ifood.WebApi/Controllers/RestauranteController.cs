using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Senai.Ifood.Domain.Contracts;
using Senai.Ifood.Domain.Entities;
using Senai.Ifood.Repository.Context;
using Senai.Ifood.Repository.Repositories;

namespace Senai.Ifood.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RestauranteController: Controller
    {
        private readonly IBaseRepository<RestauranteDomain> _repo;

        public RestauranteController(IBaseRepository<RestauranteDomain> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAction(){
            return Ok(_repo.Listar(new string[]{"Produtos"}));
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id){
            return Ok(_repo.BuscarPorId(id));
        }
        
        [HttpPost]
        public IActionResult Cadastrar(RestauranteDomain restaurante){
            return Ok(_repo.Inserir(restaurante));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(RestauranteDomain restaurante){
            return Ok(_repo.Atualizar(restaurante));
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id){
            var restaurante = _repo.BuscarPorId(id);
            
            return Ok(_repo.Deletar(restaurante));
        }
    }
}