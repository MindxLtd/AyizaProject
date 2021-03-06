[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Ayiza_Backend.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Ayiza_Backend.App_Start.NinjectWebCommon), "Stop")]

namespace Ayiza_Backend.App_Start
{
    using System;
    using System.Web;
    using DataLayer.Repositories.Unit_Of_Work;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using ServiceLayer.Services;
    //This class is automatically created by installing ninject which handles dependency injection through out the project.
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        /// 
        // This function is used to register the dependency to use through out the project.
        private static void RegisterServices(IKernel kernel)
        {
            // This will creat a service object wherever the dependency of Iservice is injected in constructor of any class.
            kernel.Bind<IService>().To<Service>().InRequestScope();
            // This will creat a UnitOfWork object wherever the dependency of IUnitOfWork is injected in constructor of any class.
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();


        }        
    }
}
