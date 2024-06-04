using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Persistance.Repositories.EntityFramework.EntityRepositories.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ProductService
{
    public class ProductManager: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> AddAsync(Product product)
        {
            Product addedProduct = await _productRepository.AddAsync(product);
            return addedProduct;
        }

        public async Task<Product> DeleteAsync(Product product, bool permanent = false)
        {
            Product deletedProduct = await _productRepository.DeleteAsync(product);
            return deletedProduct;
        }

        public async Task<Product?> GetAsync(Expression<Func<Product, bool>> predicate, Func<IQueryable<Product>, IIncludableQueryable<Product, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            Product? product = await _productRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
            return product;
        }

        public async Task<ICollection<Product>?> GetListAsync(Expression<Func<Product, bool>>? predicate = null, Func<IQueryable<Product>, IOrderedQueryable<Product>>? orderBy = null, Func<IQueryable<Product>, IIncludableQueryable<Product, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            ICollection<Product>? products = await _productRepository.GetListAsync(predicate, orderBy, include, withDeleted, enableTracking,cancellationToken);
            return products;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            Product updatedProduct = await _productRepository.UpdateAsync(product);
            return updatedProduct;
        }
    }
}
