using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ProductService
{
    public interface IProductService
    {
        Task<Product?> GetAsync(
           Expression<Func<Product, bool>> predicate,
           Func<IQueryable<Product>, IIncludableQueryable<Product, object>>? include = null,
           bool withDeleted = false,
           bool enableTracking = true,
           CancellationToken cancellationToken = default
       );

        Task<ICollection<Product>?> GetListAsync(
            Expression<Func<Product, bool>>? predicate = null,
            Func<IQueryable<Product>, IOrderedQueryable<Product>>? orderBy = null,
            Func<IQueryable<Product>, IIncludableQueryable<Product, object>>? include = null,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default
        );

        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> DeleteAsync(Product product, bool permanent = false);
    }
}
