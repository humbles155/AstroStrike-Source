using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AstroStrike.Modules
{
	// Token: 0x02000061 RID: 97
	public class News
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002BD0 File Offset: 0x00000DD0
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002BD8 File Offset: 0x00000DD8
		[JsonProperty("News")]
		public List<NewsModules> NewsList { get; set; }
	}
}
