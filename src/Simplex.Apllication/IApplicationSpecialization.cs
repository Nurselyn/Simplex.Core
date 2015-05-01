using Simplex.Eventing;
using Simplex.Service;
using System;

namespace Simplex.Apllication
{
    public interface IApplicationSpecialization : ISpecialization
	{
		IEventCollector EventCollector { get; }

		void Log(string message);
	}
}