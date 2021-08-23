using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000013 RID: 19
	public class ChatRoot
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002126 File Offset: 0x00000326
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000212E File Offset: 0x0000032E
		[JsonProperty("chat")]
		public List<ChatResponse> Chat { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002137 File Offset: 0x00000337
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000213F File Offset: 0x0000033F
		[JsonProperty("error")]
		public bool Error { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002150 File Offset: 0x00000350
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
