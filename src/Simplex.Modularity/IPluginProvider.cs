using System;

namespace Simplex.Modularity
{
    public interface IPluginProvider
    {
        IModuleRegistration AddModule<TModule>(TModule module)
            where TModule : IModule;

        IModuleInstallerRegistration AddModuleInstaller<TModuleInstaller>(TModuleInstaller installer)
            where TModuleInstaller : IModuleInstaller;
    }
}
