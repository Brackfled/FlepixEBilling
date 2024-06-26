﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.EntityFramework.EntityRepositories.ProductRepository
{
    public interface IProductRepository: IAsyncRepository<Product, Guid>
    {
    }
}
