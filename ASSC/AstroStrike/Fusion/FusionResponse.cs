using System;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x0200001A RID: 26
	public struct FusionResponse
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000022F1 File Offset: 0x000004F1
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000022F9 File Offset: 0x000004F9
		[JsonProperty("error")]
		public bool Error { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002302 File Offset: 0x00000502
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000230A File Offset: 0x0000050A
		[JsonProperty("session")]
		public string Session { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002313 File Offset: 0x00000513
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000231B File Offset: 0x0000051B
		[JsonProperty("message")]
		public string Message { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000232C File Offset: 0x0000052C
		[JsonProperty("response")]
		public string Response { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002335 File Offset: 0x00000535
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000233D File Offset: 0x0000053D
		[JsonProperty("status")]
		public string Status { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002346 File Offset: 0x00000546
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000234E File Offset: 0x0000054E
		[JsonProperty("blob")]
		public string Blob { get; set; }
	}
}
