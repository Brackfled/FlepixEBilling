using Domain.Entities;
using Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.EntityFramework.EntityRepositories.CurrentRepository
{
    public class CurrentRepository:EfRepositoryBase<Current, Guid, BaseDbContext>, ICurrentRepository
    {
        public CurrentRepository(BaseDbContext context) : base(context)
        {
            
        }
    }
}
