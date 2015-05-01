using System;

namespace Simplex.Modularity
{
    public interface IModuleInstallerRegistration
    {
        void Before<TModuleInstaller>()
            where TModuleInstaller : IModuleInstaller;

        void After<TModuleInstaller>()
            where TModuleInstaller : IModuleInstaller;
    }
}
