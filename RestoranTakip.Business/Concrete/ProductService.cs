using RestoranTakip.Business.Abstract;
using RestoranTakip.Models;
using RestoranTakip.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranTakip.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Add(Product product)
        {
            return _productRepository.Add(product);
        }

        public bool Delete(int id)
        {
            _productRepository.Delete(id);
            return true;
        }

        public IQueryable<Product> GetAll()
        {
            return _productRepository.GetAll(p => !p.IsDeleted);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product Update(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
