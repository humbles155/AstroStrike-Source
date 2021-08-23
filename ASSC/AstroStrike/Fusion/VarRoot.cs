using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Fusion
{
	// Token: 0x02000019 RID: 25
	public struct VarRoot
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000022BE File Offset: 0x000004BE
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000022C6 File Offset: 0x000004C6
		[JsonProperty("error")]
		public bool Error { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000022CF File Offset: 0x000004CF
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000022D7 File Offset: 0x000004D7
		[JsonProperty("message")]
		public string Message { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000022E8 File Offset: 0x000004E8
		[JsonProperty("vars")]
		public Dictionary<string, string> Vars { get; set; }
	}
}
