using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain.Entities;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace Application.Services.TaxDepartmentService
{
    public interface ITaxDepartmentService
    {
        Task<TaxDepartment?> GetAsync(
           Expression<Func<TaxDepartment, bool>> predicate,
           Func<IQueryable<TaxDepartment>, IIncludableQueryable<TaxDepartment, object>>? include = null,
           bool withDeleted = false,
           bool enableTracking = true,
           CancellationToken cancellationToken = default
       );

        Task<ICollection<TaxDepartment>?> GetListAsync(
            Expression<Func<TaxDepartment, bool>>? predicate = null,
            Func<IQueryable<TaxDepartment>, IOrderedQueryable<TaxDepartment>>? orderBy = null,
            Func<IQueryable<TaxDepartment>, IIncludableQueryable<TaxDepartment, object>>? include = null,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default
        );

        Task<TaxDepartment> AddAsync(TaxDepartment taxDepartment);
        Task<TaxDepartment> UpdateAsync(TaxDepartment taxDepartment);
        Task<TaxDepartment> DeleteAsync(TaxDepartment taxDepartment, bool permanent = false);
    }
}
