using System;

namespace Simplex.Application
{
    public interface IApplicationStartEvent<TSpecialization> : IApplicationEvent<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{

    }
}