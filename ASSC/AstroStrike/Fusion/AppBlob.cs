using System;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000014 RID: 20
	public class AppBlob
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002159 File Offset: 0x00000359
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002161 File Offset: 0x00000361
		[JsonProperty("activeapis")]
		public string ActiveApi { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000216A File Offset: 0x0000036A
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002172 File Offset: 0x00000372
		[JsonProperty("apicount")]
		public string ApiCount { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000217B File Offset: 0x0000037B
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002183 File Offset: 0x00000383
		[JsonProperty("usercount")]
		public string UserCount { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000218C File Offset: 0x0000038C
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002194 File Offset: 0x00000394
		[JsonProperty("label")]
		public string Label { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000219D File Offset: 0x0000039D
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000021A5 File Offset: 0x000003A5
		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
