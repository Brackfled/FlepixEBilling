﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.EntityFramework.EntityRepositories.TaxDepartmentRepository
{
    public interface ITaxDepartmentRepository: IAsyncRepository<TaxDepartment, int>
    {
    }
}
