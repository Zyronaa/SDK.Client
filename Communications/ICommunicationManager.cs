using JetBrains.Annotations;

namespace Zyronaa.SDK.Client.Communications
{
	[PublicAPI]
	public interface ICommunicationManager
	{
		ICommunicationTarget Event(string @event);
	}
}
