using Domain.Entities;
using Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.EntityFramework.EntityRepositories.TaxDepartmentRepository
{
    public class TaxDepartmentRepository: EfRepositoryBase<TaxDepartment, int, BaseDbContext>, ITaxDepartmentRepository
    {
        public TaxDepartmentRepository(BaseDbContext context):base(context) 
        {
            
        }
    }
}
