using Application.Services.CurrentService;
using Application.Services.ProductService;
using Application.Services.TaxDepartmentService;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;
using Persistance.Repositories.EntityFramework.EntityRepositories.CurrentRepository;
using Persistance.Repositories.EntityFramework.EntityRepositories.ProductRepository;
using Persistance.Repositories.EntityFramework.EntityRepositories.TaxDepartmentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class AutofacApplicationModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CurrentManager>().As<ICurrentService>().InstancePerLifetimeScope();
            builder.RegisterType<CurrentRepository>().As<ICurrentRepository>().InstancePerLifetimeScope();

            builder.RegisterType<TaxDepartmentManager>().As<ITaxDepartmentService>().InstancePerLifetimeScope();
            builder.RegisterType<TaxDepartmentRepository>().As<ITaxDepartmentRepository>().InstancePerLifetimeScope();

            builder.RegisterType<ProductManager>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();

            builder.Register(c =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<BaseDbContext>();
                optionsBuilder.UseSqlServer("Data Source=HUSEYIN\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Database=FlepixEBilling");
                return new BaseDbContext(optionsBuilder.Options);
            }).AsSelf().InstancePerLifetimeScope();
        }
    }
}
