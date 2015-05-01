using System;

namespace Simplex.Modularity
{
    public interface IModuleRegistration
    {
        void RequireModuleInstaller<TModuleInstaller>()
            where TModuleInstaller : IModuleInstaller;

        void RequireModule<TModule>()
            where TModule : IModule;

        void ReplaceModule<TModule>()
            where TModule : IModule;
    }
}
