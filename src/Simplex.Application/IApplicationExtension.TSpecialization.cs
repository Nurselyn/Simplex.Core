using Simplex.Service;
using System;

namespace Simplex.Application
{
    public interface IApplicationExtension<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{
		void Extend(TSpecialization specialization);
    }
}