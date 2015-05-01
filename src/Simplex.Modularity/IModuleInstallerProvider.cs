using System;
using Simplex.Resource;

namespace Simplex.Modularity
{
    public interface IModuleInstallerProvider
    {
        TResourceManager GetResourceManager<TResourceManager, TResource>()
            where TResourceManager : IResourceManager<TResource>
            where TResource : IResource;
    }
}
