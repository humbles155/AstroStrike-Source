using System;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000010 RID: 16
	public class MessageRoot
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000207C File Offset: 0x0000027C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002084 File Offset: 0x00000284
		[JsonProperty("error")]
		public bool Error { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000208D File Offset: 0x0000028D
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002095 File Offset: 0x00000295
		[JsonProperty("id")]
		public string Id { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000209E File Offset: 0x0000029E
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000020A6 File Offset: 0x000002A6
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
