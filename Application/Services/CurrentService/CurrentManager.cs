using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Persistance.Repositories.EntityFramework.EntityRepositories.CurrentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CurrentService
{
    public class CurrentManager : ICurrentService
    {
        private readonly ICurrentRepository _currentRepository;

        public CurrentManager(ICurrentRepository currentRepository)
        {
            _currentRepository = currentRepository;
        }

        public async Task<Current> AddAsync(Current current)
        {
            Current addedCurrent = await _currentRepository.AddAsync(current);
            return addedCurrent;
        }

        public async Task<Current> DeleteAsync(Current current, bool permanent = false)
        {
            Current deletedCurrent = await _currentRepository.DeleteAsync(current);
            return deletedCurrent;
        }

        public async Task<Current?> GetAsync(Expression<Func<Current, bool>> predicate, Func<IQueryable<Current>, IIncludableQueryable<Current, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            Current? current = await _currentRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
            return current;
        }

        public async Task<ICollection<Current>?> GetListAsync(Expression<Func<Current, bool>>? predicate = null, Func<IQueryable<Current>, IOrderedQueryable<Current>>? orderBy = null, Func<IQueryable<Current>, IIncludableQueryable<Current, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            ICollection<Current>? currents = await _currentRepository.GetListAsync(predicate, orderBy, include, withDeleted, enableTracking, cancellationToken);
            return currents;
        }

        public async Task<Current> UpdateAsync(Current current)
        {
            Current updatedCurrent = await _currentRepository.UpdateAsync(current);    
            return updatedCurrent;
        }
    }
}
