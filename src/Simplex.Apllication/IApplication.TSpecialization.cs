using Simplex.Service;
using System;

namespace Simplex.Apllication
{
	public interface IApplication<TSpecialization> : IService<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{
		void Start();

		void Stop();
	}
}