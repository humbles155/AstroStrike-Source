using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DiscordRPC;

namespace AstroStrike.Discord
{
	// Token: 0x0200006A RID: 106
	public class Status
	{
		// Token: 0x0600026F RID: 623 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		[DebuggerStepThrough]
		public static void Start()
		{
			Status.<Start>d__1 <Start>d__ = new Status.<Start>d__1();
			<Start>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Start>d__.<>1__state = -1;
			<Start>d__.<>t__builder.Start<Status.<Start>d__1>(ref <Start>d__);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000EE14 File Offset: 0x0000D014
		public static void Stop()
		{
			try
			{
				if (Status.client.IsInitialized)
				{
					Status.client.Dispose();
					Status.client.Deinitialize();
					Status.client.ClearPresence();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0400032B RID: 811
		private static DiscordRpcClient client = new DiscordRpcClient("872520853181591582");
	}
}
