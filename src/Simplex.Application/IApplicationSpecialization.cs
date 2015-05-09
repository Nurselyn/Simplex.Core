using Simplex.Eventing;
using Simplex.Service;
using System;

namespace Simplex.Application
{
    public interface IApplicationSpecialization : ISpecialization
	{
		IEventCollector EventCollector { get; }

		void Log(string message);
	}
}