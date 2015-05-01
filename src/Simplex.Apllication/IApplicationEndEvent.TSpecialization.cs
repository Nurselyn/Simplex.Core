using Simplex.Service;
using System;

namespace Simplex.Apllication
{
    public interface IApplicationEndEvent<TSpecialization> : IApplicationEvent<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{

    }
}