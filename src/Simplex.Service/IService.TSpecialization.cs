using System;

namespace Simplex.Service
{
	public interface IService<TSpecialization>
		where TSpecialization : ISpecialization
	{
		TSpecialization Specialization { get; }
    }
}