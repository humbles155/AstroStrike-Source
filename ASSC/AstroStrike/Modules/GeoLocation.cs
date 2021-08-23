using System;
using Newtonsoft.Json;

namespace AstroStrike.Modules
{
	// Token: 0x0200005F RID: 95
	public class GeoLocation
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000029F4 File Offset: 0x00000BF4
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000029FC File Offset: 0x00000BFC
		[JsonProperty("status")]
		public string Status { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00002A05 File Offset: 0x00000C05
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002A0D File Offset: 0x00000C0D
		[JsonProperty("continent")]
		public string Continent { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00002A16 File Offset: 0x00000C16
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002A1E File Offset: 0x00000C1E
		[JsonProperty("continentCode")]
		public string ContinentCode { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00002A27 File Offset: 0x00000C27
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002A2F File Offset: 0x00000C2F
		[JsonProperty("country")]
		public string Country { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00002A38 File Offset: 0x00000C38
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002A40 File Offset: 0x00000C40
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00002A49 File Offset: 0x00000C49
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002A51 File Offset: 0x00000C51
		[JsonProperty("region")]
		public string Region { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00002A5A File Offset: 0x00000C5A
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00002A62 File Offset: 0x00000C62
		[JsonProperty("regionName")]
		public string RegionName { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002A6B File Offset: 0x00000C6B
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002A73 File Offset: 0x00000C73
		[JsonProperty("city")]
		public string City { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00002A7C File Offset: 0x00000C7C
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002A84 File Offset: 0x00000C84
		[JsonProperty("district")]
		public string District { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002A8D File Offset: 0x00000C8D
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002A95 File Offset: 0x00000C95
		[JsonProperty("message")]
		public string Message { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002A9E File Offset: 0x00000C9E
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002AA6 File Offset: 0x00000CA6
		[JsonProperty("zip")]
		public string Zip { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002AAF File Offset: 0x00000CAF
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002AB7 File Offset: 0x00000CB7
		[JsonProperty("lat")]
		public double Lat { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002AC8 File Offset: 0x00000CC8
		[JsonProperty("lon")]
		public double Lon { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002AD1 File Offset: 0x00000CD1
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002AD9 File Offset: 0x00000CD9
		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002AE2 File Offset: 0x00000CE2
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002AEA File Offset: 0x00000CEA
		[JsonProperty("offset")]
		public int Offset { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002AF3 File Offset: 0x00000CF3
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00002AFB File Offset: 0x00000CFB
		[JsonProperty("currency")]
		public string Currency { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00002B04 File Offset: 0x00000D04
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002B0C File Offset: 0x00000D0C
		[JsonProperty("isp")]
		public string Isp { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00002B15 File Offset: 0x00000D15
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002B1D File Offset: 0x00000D1D
		[JsonProperty("org")]
		public string Org { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002B26 File Offset: 0x00000D26
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002B2E File Offset: 0x00000D2E
		[JsonProperty("as")]
		public string As { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002B37 File Offset: 0x00000D37
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002B3F File Offset: 0x00000D3F
		[JsonProperty("asname")]
		public string Asname { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002B48 File Offset: 0x00000D48
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00002B50 File Offset: 0x00000D50
		[JsonProperty("reverse")]
		public string Reverse { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002B59 File Offset: 0x00000D59
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002B61 File Offset: 0x00000D61
		[JsonProperty("mobile")]
		public bool Mobile { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002B6A File Offset: 0x00000D6A
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002B72 File Offset: 0x00000D72
		[JsonProperty("proxy")]
		public bool Proxy { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00002B7B File Offset: 0x00000D7B
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002B83 File Offset: 0x00000D83
		[JsonProperty("hosting")]
		public bool Hosting { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00002B8C File Offset: 0x00000D8C
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002B94 File Offset: 0x00000D94
		[JsonProperty("query")]
		public string Query { get; set; }
	}
}
