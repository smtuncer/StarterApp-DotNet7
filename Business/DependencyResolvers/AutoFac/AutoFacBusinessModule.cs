using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfRepository<Product>>().As<IRepository<Product>>().SingleInstance();

            builder.RegisterType<ProductCategoryManager>().As<IProductCategoryService>().SingleInstance();
            builder.RegisterType<EfRepository<ProductCategory>>().As<IRepository<ProductCategory>>().SingleInstance();
        }
    }
}
