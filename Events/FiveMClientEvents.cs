using JetBrains.Annotations;

namespace Zyronaa.SDK.Client.Events
{
	[PublicAPI]
	public static class FiveMClientEvents
	{
		public const string ResourceStart = "onClientResourceStart";

		public const string ResourceStop = "onClientResourceStop";

		public const string PopulationPedCreating = "populationPedCreating";
	}
}
