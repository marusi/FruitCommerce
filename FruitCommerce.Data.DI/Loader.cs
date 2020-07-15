using FruitCommerce.Data.Repositories;
using FruitCommerce.Data.Services;
using FruitCommerce.Service.Dxos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Reflection;

namespace FruitCommerce.Data.DI
{
    public class Loader
    {

        // , Action<Assembly> setMediator
        public static void Register(IServiceCollection services)
        {
            /*  foreach (var item in GetAll())
              {
                  setMediator(item);
              }
              */
            //Add DIs
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerDxos, CustomerDxos>();

        }

   /*     public static ServiceProvider providerDI; 
        public static ServiceProvider BasicRegister(string filePath)
        {
            Environment.SetEnvironmentVariable("routes:path", filePath);
            var services = new ServiceCollection();
            Register(services, p => { });
            providerDI =  services.BuildServiceProvider();
            return providerDI;
        }


        public static Assembly[] GetAll()
        {
            return new[] {
                typeof(Application.Configuration.ICommand).GetTypeInfo().Assembly,
                typeof(Application.Configuration.IQuery<Response>).GetTypeInfo().Assembly
            };
        }

        public  T GetService<T>()
        {
            return providerDI.GetService<T>();
        } */
    }
}
