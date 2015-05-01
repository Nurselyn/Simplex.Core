using Simplex.Service;
using System;

namespace Simplex.Apllication
{
    public interface IApplicationExtension<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{
		void Extend(TSpecialization specialization);
    }
}