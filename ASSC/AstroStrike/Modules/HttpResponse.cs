using System;

namespace AstroStrike.Modules
{
	// Token: 0x02000060 RID: 96
	public class HttpResponse
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00002B9D File Offset: 0x00000D9D
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public bool Error { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002BAE File Offset: 0x00000DAE
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002BB6 File Offset: 0x00000DB6
		public string Response { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002BBF File Offset: 0x00000DBF
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002BC7 File Offset: 0x00000DC7
		public Exception Exception { get; set; }
	}
}
