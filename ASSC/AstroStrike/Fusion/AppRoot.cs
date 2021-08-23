using System;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000015 RID: 21
	public class AppRoot
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000021AE File Offset: 0x000003AE
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000021B6 File Offset: 0x000003B6
		[JsonProperty("blob")]
		public AppBlob Blob { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000021BF File Offset: 0x000003BF
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000021C7 File Offset: 0x000003C7
		[JsonProperty("error")]
		public bool Error { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000021D0 File Offset: 0x000003D0
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000021D8 File Offset: 0x000003D8
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
