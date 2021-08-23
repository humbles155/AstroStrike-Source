using System;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000018 RID: 24
	public class UserRoot
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000228B File Offset: 0x0000048B
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002293 File Offset: 0x00000493
		[JsonProperty("blob")]
		public UserBlob Blob { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000229C File Offset: 0x0000049C
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000022A4 File Offset: 0x000004A4
		[JsonProperty("error")]
		public bool Error { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000022AD File Offset: 0x000004AD
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000022B5 File Offset: 0x000004B5
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
