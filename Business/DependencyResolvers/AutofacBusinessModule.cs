using Autofac;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //ICategoryProductService gibi bir instance istendiğinde CategoryProductManager instance'ı üretilir
            builder.RegisterType<CategoryProductManager>().As<ICategoryProductService>().SingleInstance();
            builder.RegisterType<CategoryProductDal>().As<ICategoryProductDal>().SingleInstance();
        }
    }
}
