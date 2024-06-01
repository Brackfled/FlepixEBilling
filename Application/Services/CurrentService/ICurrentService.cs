using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrentService
{
    public interface ICurrentService
    {
        Task<Current?> GetAsync(
           Expression<Func<Current, bool>> predicate,
           Func<IQueryable<Current>, IIncludableQueryable<Current, object>>? include = null,
           bool withDeleted = false,
           bool enableTracking = true,
           CancellationToken cancellationToken = default
       );

        Task<ICollection<Current>?> GetListAsync(
            Expression<Func<Current, bool>>? predicate = null,
            Func<IQueryable<Current>, IOrderedQueryable<Current>>? orderBy = null,
            Func<IQueryable<Current>, IIncludableQueryable<Current, object>>? include = null,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default
        );

        Task<Current> AddAsync(Current current);
        Task<Current> UpdateAsync(Current current);
        Task<Current> DeleteAsync(Current current, bool permanent = false);
    }
}
