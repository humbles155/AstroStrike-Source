using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Fusion
{
	// Token: 0x02000002 RID: 2
	public struct FusionApp
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public FusionApp(string app)
		{
			if (FusionApp.client == null)
			{
				HttpClientHandler handler = new HttpClientHandler
				{
					Proxy = null
				};
				FusionApp.client = new HttpClient(handler);
				FusionApp.baseUrl = FusionApp.url + "app/" + app + "/api";
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002D2C File Offset: 0x00000F2C
		[DebuggerStepThrough]
		public static Task RefreshApp()
		{
			FusionApp.<RefreshApp>d__5 <RefreshApp>d__ = new FusionApp.<RefreshApp>d__5();
			<RefreshApp>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RefreshApp>d__.<>1__state = -1;
			<RefreshApp>d__.<>t__builder.Start<FusionApp.<RefreshApp>d__5>(ref <RefreshApp>d__);
			return <RefreshApp>d__.<>t__builder.Task;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002D6C File Offset: 0x00000F6C
		[DebuggerStepThrough]
		public static Task<string> GetIp()
		{
			FusionApp.<GetIp>d__6 <GetIp>d__ = new FusionApp.<GetIp>d__6();
			<GetIp>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetIp>d__.<>1__state = -1;
			<GetIp>d__.<>t__builder.Start<FusionApp.<GetIp>d__6>(ref <GetIp>d__);
			return <GetIp>d__.<>t__builder.Task;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002DAC File Offset: 0x00000FAC
		public static string GetHwid()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002DCC File Offset: 0x00000FCC
		[DebuggerStepThrough]
		public Task<FusionResponse> Login(string username, string password)
		{
			FusionApp.<Login>d__8 <Login>d__ = new FusionApp.<Login>d__8();
			<Login>d__.<>t__builder = AsyncTaskMethodBuilder<FusionResponse>.Create();
			<Login>d__.<>4__this = this;
			<Login>d__.username = username;
			<Login>d__.password = password;
			<Login>d__.<>1__state = -1;
			<Login>d__.<>t__builder.Start<FusionApp.<Login>d__8>(ref <Login>d__);
			return <Login>d__.<>t__builder.Task;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002E24 File Offset: 0x00001024
		[DebuggerStepThrough]
		public Task<FusionResponse> Register(string username, string password, string token)
		{
			FusionApp.<Register>d__9 <Register>d__ = new FusionApp.<Register>d__9();
			<Register>d__.<>t__builder = AsyncTaskMethodBuilder<FusionResponse>.Create();
			<Register>d__.<>4__this = this;
			<Register>d__.username = username;
			<Register>d__.password = password;
			<Register>d__.token = token;
			<Register>d__.<>1__state = -1;
			<Register>d__.<>t__builder.Start<FusionApp.<Register>d__9>(ref <Register>d__);
			return <Register>d__.<>t__builder.Task;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002E84 File Offset: 0x00001084
		[DebuggerStepThrough]
		public static Task<FusionResponse> ResetPassword(string oldpassword, string newpassword)
		{
			FusionApp.<ResetPassword>d__10 <ResetPassword>d__ = new FusionApp.<ResetPassword>d__10();
			<ResetPassword>d__.<>t__builder = AsyncTaskMethodBuilder<FusionResponse>.Create();
			<ResetPassword>d__.oldpassword = oldpassword;
			<ResetPassword>d__.newpassword = newpassword;
			<ResetPassword>d__.<>1__state = -1;
			<ResetPassword>d__.<>t__builder.Start<FusionApp.<ResetPassword>d__10>(ref <ResetPassword>d__);
			return <ResetPassword>d__.<>t__builder.Task;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002ED0 File Offset: 0x000010D0
		[DebuggerStepThrough]
		public static Task<string> GetUserVar(string var)
		{
			FusionApp.<GetUserVar>d__11 <GetUserVar>d__ = new FusionApp.<GetUserVar>d__11();
			<GetUserVar>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetUserVar>d__.var = var;
			<GetUserVar>d__.<>1__state = -1;
			<GetUserVar>d__.<>t__builder.Start<FusionApp.<GetUserVar>d__11>(ref <GetUserVar>d__);
			return <GetUserVar>d__.<>t__builder.Task;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002F14 File Offset: 0x00001114
		[DebuggerStepThrough]
		public static Task SetUserVar(string key, string value)
		{
			FusionApp.<SetUserVar>d__12 <SetUserVar>d__ = new FusionApp.<SetUserVar>d__12();
			<SetUserVar>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SetUserVar>d__.key = key;
			<SetUserVar>d__.value = value;
			<SetUserVar>d__.<>1__state = -1;
			<SetUserVar>d__.<>t__builder.Start<FusionApp.<SetUserVar>d__12>(ref <SetUserVar>d__);
			return <SetUserVar>d__.<>t__builder.Task;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002F60 File Offset: 0x00001160
		[DebuggerStepThrough]
		public static Task<string> GetAppVar(string var)
		{
			FusionApp.<GetAppVar>d__13 <GetAppVar>d__ = new FusionApp.<GetAppVar>d__13();
			<GetAppVar>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetAppVar>d__.var = var;
			<GetAppVar>d__.<>1__state = -1;
			<GetAppVar>d__.<>t__builder.Start<FusionApp.<GetAppVar>d__13>(ref <GetAppVar>d__);
			return <GetAppVar>d__.<>t__builder.Task;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002FA4 File Offset: 0x000011A4
		[DebuggerStepThrough]
		public static Task<FusionResponse> ExecuteFullAPI(string id, string data, int time)
		{
			FusionApp.<ExecuteFullAPI>d__14 <ExecuteFullAPI>d__ = new FusionApp.<ExecuteFullAPI>d__14();
			<ExecuteFullAPI>d__.<>t__builder = AsyncTaskMethodBuilder<FusionResponse>.Create();
			<ExecuteFullAPI>d__.id = id;
			<ExecuteFullAPI>d__.data = data;
			<ExecuteFullAPI>d__.time = time;
			<ExecuteFullAPI>d__.<>1__state = -1;
			<ExecuteFullAPI>d__.<>t__builder.Start<FusionApp.<ExecuteFullAPI>d__14>(ref <ExecuteFullAPI>d__);
			return <ExecuteFullAPI>d__.<>t__builder.Task;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002FF8 File Offset: 0x000011F8
		[DebuggerStepThrough]
		public static Task<ChatRoot> GetChat()
		{
			FusionApp.<GetChat>d__15 <GetChat>d__ = new FusionApp.<GetChat>d__15();
			<GetChat>d__.<>t__builder = AsyncTaskMethodBuilder<ChatRoot>.Create();
			<GetChat>d__.<>1__state = -1;
			<GetChat>d__.<>t__builder.Start<FusionApp.<GetChat>d__15>(ref <GetChat>d__);
			return <GetChat>d__.<>t__builder.Task;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003038 File Offset: 0x00001238
		[DebuggerStepThrough]
		public static Task<ManageMessageResponse> DeleteMessage(string messageid)
		{
			FusionApp.<DeleteMessage>d__16 <DeleteMessage>d__ = new FusionApp.<DeleteMessage>d__16();
			<DeleteMessage>d__.<>t__builder = AsyncTaskMethodBuilder<ManageMessageResponse>.Create();
			<DeleteMessage>d__.messageid = messageid;
			<DeleteMessage>d__.<>1__state = -1;
			<DeleteMessage>d__.<>t__builder.Start<FusionApp.<DeleteMessage>d__16>(ref <DeleteMessage>d__);
			return <DeleteMessage>d__.<>t__builder.Task;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000307C File Offset: 0x0000127C
		[DebuggerStepThrough]
		public static Task<ManageMessageResponse> EditMessage(string messageid, string newmessage)
		{
			FusionApp.<EditMessage>d__17 <EditMessage>d__ = new FusionApp.<EditMessage>d__17();
			<EditMessage>d__.<>t__builder = AsyncTaskMethodBuilder<ManageMessageResponse>.Create();
			<EditMessage>d__.messageid = messageid;
			<EditMessage>d__.newmessage = newmessage;
			<EditMessage>d__.<>1__state = -1;
			<EditMessage>d__.<>t__builder.Start<FusionApp.<EditMessage>d__17>(ref <EditMessage>d__);
			return <EditMessage>d__.<>t__builder.Task;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000030C8 File Offset: 0x000012C8
		[DebuggerStepThrough]
		public static Task<MessageRoot> SendMessage(string content)
		{
			FusionApp.<SendMessage>d__18 <SendMessage>d__ = new FusionApp.<SendMessage>d__18();
			<SendMessage>d__.<>t__builder = AsyncTaskMethodBuilder<MessageRoot>.Create();
			<SendMessage>d__.content = content;
			<SendMessage>d__.<>1__state = -1;
			<SendMessage>d__.<>t__builder.Start<FusionApp.<SendMessage>d__18>(ref <SendMessage>d__);
			return <SendMessage>d__.<>t__builder.Task;
		}

		// Token: 0x04000001 RID: 1
		private static HttpClient client = null;

		// Token: 0x04000002 RID: 2
		private static string baseUrl = null;

		// Token: 0x04000003 RID: 3
		private static string session = string.Empty;

		// Token: 0x04000004 RID: 4
		private static readonly string url = "https://fusionapi.dev/";
	}
}
