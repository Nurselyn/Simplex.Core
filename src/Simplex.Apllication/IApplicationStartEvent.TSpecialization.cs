using System;

namespace Simplex.Apllication
{
    public interface IApplicationStartEvent<TSpecialization> : IApplicationEvent<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{

    }
}