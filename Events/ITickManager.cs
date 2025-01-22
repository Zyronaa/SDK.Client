using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Zyronaa.SDK.Client.Events
{
	[PublicAPI]
	public interface ITickManager
	{
		void On(Action callback);

		void On(Func<Task> callback);

		void Off(Action callback);

		void Off(Func<Task> callback);
	}
}
