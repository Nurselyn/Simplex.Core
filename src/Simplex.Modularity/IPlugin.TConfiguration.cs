using System;

namespace Simplex.Modularity
{
    public interface IPlugin<TConfiguration>
    {
        void Init(IPluginProvider provider, TConfiguration configuration);
    }
}
