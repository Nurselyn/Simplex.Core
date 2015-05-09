using System;

namespace Simplex.Application
{
    public interface IApplicationEvent<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{
		TSpecialization Specialization { get; }
	}
}