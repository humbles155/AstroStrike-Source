using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AstroStrike.Helpers;
using AstroStrike.Modules;
using Fusion;

namespace AstroStrike
{
	// Token: 0x0200001D RID: 29
	public class Commands
	{
		// Token: 0x06000097 RID: 151 RVA: 0x0000547C File Offset: 0x0000367C
		public static Commands.UpdateCheckModule CheckForUpdate()
		{
			string appDescription = App.AppDescription;
			string appVersion = Config.AppVersion;
			Commands.UpdateCheckModule result;
			if (appDescription == "Response Was Not Valid" || string.IsNullOrWhiteSpace(appDescription))
			{
				result = new Commands.UpdateCheckModule
				{
					Error = true,
					NeedUpdate = false,
					Message = "Update check failure, invalid response"
				};
			}
			else if (appDescription == appVersion)
			{
				result = new Commands.UpdateCheckModule
				{
					Error = false,
					NeedUpdate = false,
					Message = "Your running latest version"
				};
			}
			else
			{
				result = new Commands.UpdateCheckModule
				{
					Error = false,
					NeedUpdate = true,
					Message = "New " + appDescription + " update available"
				};
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000553C File Offset: 0x0000373C
		[DebuggerStepThrough]
		public static Task<bool> IsHwidBanned()
		{
			Commands.<IsHwidBanned>d__1 <IsHwidBanned>d__ = new Commands.<IsHwidBanned>d__1();
			<IsHwidBanned>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<IsHwidBanned>d__.<>1__state = -1;
			<IsHwidBanned>d__.<>t__builder.Start<Commands.<IsHwidBanned>d__1>(ref <IsHwidBanned>d__);
			return <IsHwidBanned>d__.<>t__builder.Task;
		}
	}
}
