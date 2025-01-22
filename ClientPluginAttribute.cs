using JetBrains.Annotations;
using Zyronaa.SDK.Core;

namespace Zyronaa.SDK.Client
{
	/// <inheritdoc />
	/// <summary>
	/// Specifies the client SDK version number the assembly was built against.
	/// </summary>
	[PublicAPI]
	public class ClientPluginAttribute : PluginAttribute
	{
		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ClientPluginAttribute" /> class.
		/// </summary>
		/// <param name="target">The target client SDK version number.</param>
		public ClientPluginAttribute(uint target) : base(target) { }
	}
}
