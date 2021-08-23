using System;

namespace AstroStrike.Modules
{
	// Token: 0x0200005B RID: 91
	public class Commands
	{
		// Token: 0x0200005C RID: 92
		public struct UpdateCheckModule
		{
			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000294A File Offset: 0x00000B4A
			// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002952 File Offset: 0x00000B52
			public bool Error { get; set; }

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060001FA RID: 506 RVA: 0x0000295B File Offset: 0x00000B5B
			// (set) Token: 0x060001FB RID: 507 RVA: 0x00002963 File Offset: 0x00000B63
			public bool NeedUpdate { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060001FC RID: 508 RVA: 0x0000296C File Offset: 0x00000B6C
			// (set) Token: 0x060001FD RID: 509 RVA: 0x00002974 File Offset: 0x00000B74
			public string Message { get; set; }
		}
	}
}
