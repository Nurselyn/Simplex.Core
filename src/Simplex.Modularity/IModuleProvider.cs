using System;
using Microsoft.Framework.DependencyInjection;
using Simplex.Eventing;

namespace Simplex.Modularity
{
    public interface IModuleProvider
    {
        IEventCollector EventCollector { get; }

        void RegisterService(ServiceDescriptor serviceDescriptor);
    }
}
