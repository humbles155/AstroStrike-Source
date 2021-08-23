using System;
using Newtonsoft.Json;

namespace AstroStrike.Modules
{
	// Token: 0x02000063 RID: 99
	public class ServerInfo
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00002C14 File Offset: 0x00000E14
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002C1C File Offset: 0x00000E1C
		[JsonProperty("id")]
		public string Id { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00002C25 File Offset: 0x00000E25
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00002C2D File Offset: 0x00000E2D
		[JsonProperty("ipSlot")]
		public string IPSlot { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00002C36 File Offset: 0x00000E36
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002C3E File Offset: 0x00000E3E
		[JsonProperty("safeResponse")]
		public bool SafeResponse { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002C47 File Offset: 0x00000E47
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002C4F File Offset: 0x00000E4F
		[JsonProperty("methods")]
		public string[] Methods { get; set; }
	}
}
