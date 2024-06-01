using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Persistance.Repositories.EntityFramework.EntityRepositories.TaxDepartmentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.TaxDepartmentService
{
    public class TaxDepartmentManager : ITaxDepartmentService
    {

        private readonly ITaxDepartmentRepository _taxDepartmenRepository;

        public TaxDepartmentManager(ITaxDepartmentRepository taxDepartmenRepository)
        {
            _taxDepartmenRepository = taxDepartmenRepository;
        }

        public async Task<TaxDepartment> AddAsync(TaxDepartment taxDepartment)
        {
            TaxDepartment addedTaxDepartment = await _taxDepartmenRepository.AddAsync(taxDepartment);
            return addedTaxDepartment;
        }

        public async Task<TaxDepartment> DeleteAsync(TaxDepartment taxDepartment, bool permanent = false)
        {
            TaxDepartment deletedTaxDepartment = await _taxDepartmenRepository.DeleteAsync(taxDepartment);
            return deletedTaxDepartment;
        }

        public async Task<TaxDepartment?> GetAsync(Expression<Func<TaxDepartment, bool>> predicate, Func<IQueryable<TaxDepartment>, IIncludableQueryable<TaxDepartment, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            TaxDepartment? taxDepartment = await _taxDepartmenRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
            return taxDepartment;
        }

        public async Task<ICollection<TaxDepartment>?> GetListAsync(Expression<Func<TaxDepartment, bool>>? predicate = null, Func<IQueryable<TaxDepartment>, IOrderedQueryable<TaxDepartment>>? orderBy = null, Func<IQueryable<TaxDepartment>, IIncludableQueryable<TaxDepartment, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            ICollection<TaxDepartment>? taxDepartments = await _taxDepartmenRepository.GetListAsync(predicate,orderBy,include,withDeleted,enableTracking,cancellationToken);
            return taxDepartments;
        }

        public async Task<TaxDepartment> UpdateAsync(TaxDepartment taxDepartment)
        {
            TaxDepartment updatedTaxDepartment = await _taxDepartmenRepository.UpdateAsync(taxDepartment);
            return updatedTaxDepartment;
        }
    }
}
