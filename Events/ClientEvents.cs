using JetBrains.Annotations;

namespace Zyronaa.SDK.Client.Events
{
	[PublicAPI]
	public class ClientEvents
	{
		public const string ResourceStart = "zyronaa:client:resourceStart";

		public const string ResourceStop = "zyronaa:client:resourceStop";

		public const string PopulationPedCreating = "zyronaa:client:populationPedCreating";
	}
}
