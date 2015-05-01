using Simplex.Service;
using System;

namespace Simplex.Resource
{
    public interface IResourceManager<TResource> : IService<TResource>
		where TResource : IResource
	{

    }
}