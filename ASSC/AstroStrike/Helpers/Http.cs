using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AstroStrike.Modules;

namespace AstroStrike.Helpers
{
	// Token: 0x02000066 RID: 102
	public class Http
	{
		// Token: 0x06000265 RID: 613 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		[DebuggerStepThrough]
		public static Task<HttpResponse> GetStringAsync(string uri)
		{
			Http.<GetStringAsync>d__1 <GetStringAsync>d__ = new Http.<GetStringAsync>d__1();
			<GetStringAsync>d__.<>t__builder = AsyncTaskMethodBuilder<HttpResponse>.Create();
			<GetStringAsync>d__.uri = uri;
			<GetStringAsync>d__.<>1__state = -1;
			<GetStringAsync>d__.<>t__builder.Start<Http.<GetStringAsync>d__1>(ref <GetStringAsync>d__);
			return <GetStringAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0400031D RID: 797
		private static HttpClient client;
	}
}
