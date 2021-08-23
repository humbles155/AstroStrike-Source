using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000012 RID: 18
	public class ChatResponse
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000020D1 File Offset: 0x000002D1
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000020D9 File Offset: 0x000002D9
		[JsonProperty("author")]
		public List<string> Author { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000020EA File Offset: 0x000002EA
		[JsonProperty("content")]
		public string Content { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000020F3 File Offset: 0x000002F3
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000020FB File Offset: 0x000002FB
		[JsonProperty("edited")]
		public bool Edited { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002104 File Offset: 0x00000304
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000210C File Offset: 0x0000030C
		[JsonProperty("message-id")]
		public string MessageId { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002115 File Offset: 0x00000315
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000211D File Offset: 0x0000031D
		[JsonProperty("timestamp")]
		public int Timestamp { get; set; }
	}
}
