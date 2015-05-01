using System;

namespace Simplex.Modularity
{
    public interface IModule
    {
        void Load(IModuleProvider provider);
    }
}
