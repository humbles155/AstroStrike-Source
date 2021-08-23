using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000017 RID: 23
	public class UserBlob
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002214 File Offset: 0x00000414
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000221C File Offset: 0x0000041C
		[JsonProperty("2fa-code")]
		public string TwoFactorCode { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002225 File Offset: 0x00000425
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000222D File Offset: 0x0000042D
		[JsonProperty("expiry")]
		public string Expiry { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002236 File Offset: 0x00000436
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000223E File Offset: 0x0000043E
		[JsonProperty("ip")]
		public string Ip { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002247 File Offset: 0x00000447
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000224F File Offset: 0x0000044F
		[JsonProperty("level")]
		public int Level { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002258 File Offset: 0x00000458
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002260 File Offset: 0x00000460
		[JsonProperty("logs")]
		public List<UserLog> Logs { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002269 File Offset: 0x00000469
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002271 File Offset: 0x00000471
		[JsonProperty("uid")]
		public string UserId { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000227A File Offset: 0x0000047A
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002282 File Offset: 0x00000482
		[JsonProperty("using2fa")]
		public bool Using2fa { get; set; }
	}
}
