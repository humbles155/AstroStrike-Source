using System;

namespace AstroStrike.Modules
{
	// Token: 0x02000062 RID: 98
	public struct NewsModules
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00002BE1 File Offset: 0x00000DE1
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002BE9 File Offset: 0x00000DE9
		public int Type { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002BF2 File Offset: 0x00000DF2
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002BFA File Offset: 0x00000DFA
		public string Title { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00002C03 File Offset: 0x00000E03
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002C0B File Offset: 0x00000E0B
		public string Content { get; set; }
	}
}
