using System;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000011 RID: 17
	public class ManageMessageResponse
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000020AF File Offset: 0x000002AF
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000020B7 File Offset: 0x000002B7
		[JsonProperty("error")]
		public bool Error { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000020C0 File Offset: 0x000002C0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000020C8 File Offset: 0x000002C8
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
