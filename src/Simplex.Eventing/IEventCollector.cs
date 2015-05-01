using System;
using System.Collections.Generic;

namespace Simplex.Eventing
{
	public interface IEventCollector
	{
		bool AllowEventRegistration { get; }

		IEnumerable<Type> RegisteredEventInfoTypes { get; }

		void RegisterEvent<TEvent>();

		void RegisterEventHandler<TEvent>(IEventHandler<TEvent> handler);
	}
}