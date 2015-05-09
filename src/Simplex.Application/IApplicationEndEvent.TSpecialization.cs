using Simplex.Service;
using System;

namespace Simplex.Application
{
    public interface IApplicationEndEvent<TSpecialization> : IApplicationEvent<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{

    }
}