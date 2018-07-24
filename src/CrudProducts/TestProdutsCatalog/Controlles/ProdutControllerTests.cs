using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductCatalog.Dto;
using ProductCatalog.Enum;
using ProductCatalog.Models;
using ProductCatalog.Repositories;
using System;

namespace TestProdutsCatalog.Controlles
{
    [TestClass]
    public class ProdutControllerTests
    {
        [TestMethod]
        public void GetById(string id)
        {
            var rp = new ProductRepository(new ProductsDataContext());

            var resp =  rp.Get(id);

            var produtc = new Product() {
                Id = Guid.NewGuid().ToString(),
                Name = "Escumadeira Teste",
                Description = "Escumaderia de alumino utilizado pelo foguete da nasa",
                BrandName = "Nasa",
                SellersName= "Nasa",
                CategoryName= "Cozinha",
                State= StateProdutc.Active,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };
        Assert.AreNotEqual(produtc, resp);
        }

    }
}
