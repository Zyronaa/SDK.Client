using System;
using JetBrains.Annotations;

namespace Zyronaa.SDK.Client.Interface
{
	[PublicAPI]
	public class OverlayEventArgs : EventArgs
	{
		public Overlay Overlay { get; protected set; }

		public OverlayEventArgs(Overlay overlay)
		{
			this.Overlay = overlay;
		}
	}
}
