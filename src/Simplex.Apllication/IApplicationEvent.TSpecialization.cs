using System;

namespace Simplex.Apllication
{
    public interface IApplicationEvent<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{
		TSpecialization Specialization { get; }
	}
}