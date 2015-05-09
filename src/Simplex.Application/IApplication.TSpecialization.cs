using Simplex.Service;
using System;

namespace Simplex.Application
{
	public interface IApplication<TSpecialization> : IService<TSpecialization>
		where TSpecialization : IApplicationSpecialization
	{
		void Start();

		void Stop();
	}
}