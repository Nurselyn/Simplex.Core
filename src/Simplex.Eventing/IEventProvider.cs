using System;

namespace Simplex.Eventing
{
	public interface IEventProvider
	{
		void FireEvent<TEvent>(TEvent information);
	}
}