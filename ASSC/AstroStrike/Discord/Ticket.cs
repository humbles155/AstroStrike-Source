using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AstroStrike.Modules;

namespace AstroStrike.Discord
{
	// Token: 0x0200006C RID: 108
	public class Ticket
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0000F0AC File Offset: 0x0000D2AC
		[DebuggerStepThrough]
		private static Task<string> PictureURL()
		{
			Ticket.<PictureURL>d__1 <PictureURL>d__ = new Ticket.<PictureURL>d__1();
			<PictureURL>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<PictureURL>d__.<>1__state = -1;
			<PictureURL>d__.<>t__builder.Start<Ticket.<PictureURL>d__1>(ref <PictureURL>d__);
			return <PictureURL>d__.<>t__builder.Task;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		[DebuggerStepThrough]
		private static Task<string> WebhookURL()
		{
			Ticket.<WebhookURL>d__2 <WebhookURL>d__ = new Ticket.<WebhookURL>d__2();
			<WebhookURL>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<WebhookURL>d__.<>1__state = -1;
			<WebhookURL>d__.<>t__builder.Start<Ticket.<WebhookURL>d__2>(ref <WebhookURL>d__);
			return <WebhookURL>d__.<>t__builder.Task;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000F12C File Offset: 0x0000D32C
		[DebuggerStepThrough]
		public static Task<DiscordModules> SendTicket(string message, string title)
		{
			Ticket.<SendTicket>d__3 <SendTicket>d__ = new Ticket.<SendTicket>d__3();
			<SendTicket>d__.<>t__builder = AsyncTaskMethodBuilder<DiscordModules>.Create();
			<SendTicket>d__.message = message;
			<SendTicket>d__.title = title;
			<SendTicket>d__.<>1__state = -1;
			<SendTicket>d__.<>t__builder.Start<Ticket.<SendTicket>d__3>(ref <SendTicket>d__);
			return <SendTicket>d__.<>t__builder.Task;
		}

		// Token: 0x04000336 RID: 822
		private static Random rnd = new Random();
	}
}
