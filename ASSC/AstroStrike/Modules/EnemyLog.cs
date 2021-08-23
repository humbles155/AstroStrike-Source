using System;

namespace AstroStrike.Modules
{
	// Token: 0x0200005E RID: 94
	public class EnemyLog
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000298E File Offset: 0x00000B8E
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002996 File Offset: 0x00000B96
		public string Username { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000299F File Offset: 0x00000B9F
		// (set) Token: 0x06000204 RID: 516 RVA: 0x000029A7 File Offset: 0x00000BA7
		public string Host { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000029B0 File Offset: 0x00000BB0
		// (set) Token: 0x06000206 RID: 518 RVA: 0x000029B8 File Offset: 0x00000BB8
		public string Port { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000029C1 File Offset: 0x00000BC1
		// (set) Token: 0x06000208 RID: 520 RVA: 0x000029C9 File Offset: 0x00000BC9
		public string Reason { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000029D2 File Offset: 0x00000BD2
		// (set) Token: 0x0600020A RID: 522 RVA: 0x000029DA File Offset: 0x00000BDA
		public string Type { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600020B RID: 523 RVA: 0x000029E3 File Offset: 0x00000BE3
		// (set) Token: 0x0600020C RID: 524 RVA: 0x000029EB File Offset: 0x00000BEB
		public DateTime TimeEntered { get; set; }
	}
}
