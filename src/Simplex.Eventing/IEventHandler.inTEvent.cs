using System;

namespace Simplex.Eventing
{
	public interface IEventHandler<in TEvent>
	{
		void Handle(IEventProvider provider, TEvent information);
	}
}