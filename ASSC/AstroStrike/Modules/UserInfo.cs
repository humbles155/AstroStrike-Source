using System;

namespace AstroStrike.Modules
{
	// Token: 0x02000064 RID: 100
	public class UserInfo
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00002C58 File Offset: 0x00000E58
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002C60 File Offset: 0x00000E60
		public string Membership { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00002C69 File Offset: 0x00000E69
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002C71 File Offset: 0x00000E71
		public int Concurrents { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002C7A File Offset: 0x00000E7A
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002C82 File Offset: 0x00000E82
		public int MaxTime { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00002C8B File Offset: 0x00000E8B
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002C93 File Offset: 0x00000E93
		public int Cooldown { get; set; }
	}
}
