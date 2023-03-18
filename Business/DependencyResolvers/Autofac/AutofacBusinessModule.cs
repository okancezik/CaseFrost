using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilites.Interceptors;
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
            builder.RegisterType<CategoryDiscountDal>().As<ICategoryDiscountDal>().SingleInstance();
            builder.RegisterType<CategoryDiscountManager>().As<ICategoryDiscountService>().SingleInstance();
            builder.RegisterType<DiscountDal>().As<IDiscountDal>().SingleInstance();
            builder.RegisterType<DiscountManager>().As<IDiscountService>().SingleInstance();
            builder.RegisterType<ProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
