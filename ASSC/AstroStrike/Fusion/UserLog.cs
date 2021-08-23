using System;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000016 RID: 22
	public class UserLog
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000021E1 File Offset: 0x000003E1
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000021E9 File Offset: 0x000003E9
		[JsonProperty("ip")]
		public string Ip { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000021F2 File Offset: 0x000003F2
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000021FA File Offset: 0x000003FA
		[JsonProperty("message")]
		public string Message { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002203 File Offset: 0x00000403
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000220B File Offset: 0x0000040B
		[JsonProperty("time")]
		public string Time { get; set; }
	}
}
