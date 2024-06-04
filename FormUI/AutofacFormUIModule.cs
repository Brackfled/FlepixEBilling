using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class AutofacFormUIModule:  Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainForm>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<CurrentCreateForm>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<TaxDepartmentPopup>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<CurrentPopup>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<StocTrackingForm>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<ProductCreatePopup>().AsSelf().InstancePerLifetimeScope();
        }
    }
}
