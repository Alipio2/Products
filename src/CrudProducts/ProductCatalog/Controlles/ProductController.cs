using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;
using ProductCatalog.Repositories;
using ProductCatalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Controlles
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _repository;

        protected ProductController(ProductRepository repository)
        {
            _repository = repository;
        }

        [Route("v1/Products/{id}")]
        [HttpGet]
        public Product GetById(string id)
        {
            return _repository.Get(id);
        }

        [Route("v1/Products")]
        [HttpPost]
        public ResultViewModel Post(Product product)
        {
            _repository.Create(product);
            return new ResultViewModel
            {
                Success = true,
                Message = "Produto cadastrado com sucesso!"                
            };
        }

        [Route("v1/Products")]
        [HttpPut]
        public ResultViewModel Put(Product product)
        {           
            _repository.Save(product);
            return new ResultViewModel
            {
                Success = true,
                Message = "Produto Alterado com sucesso!"
            };
        }

        [Route("v1/Products")]
        [HttpDelete]
        public ResultViewModel Delete(Product product)
        {
            _repository.Delete(product);

            return new ResultViewModel
            {
                Success = true,
                Message = "Produto Apagador com sucesso!"
            };
        }


    }
}
