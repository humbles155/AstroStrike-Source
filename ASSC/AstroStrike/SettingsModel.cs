using System;
using System.Collections.Generic;
using System.Windows.Media;
using AstroStrike.Modules;

namespace AstroStrike
{
	// Token: 0x02000024 RID: 36
	public class SettingsModel
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0000614C File Offset: 0x0000434C
		public SettingsModel()
		{
			this.AttackLogList = new List<Attack>();
			this.EnemyList = new List<EnemyLog>();
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000242E File Offset: 0x0000062E
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002436 File Offset: 0x00000636
		public string Username { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000243F File Offset: 0x0000063F
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002447 File Offset: 0x00000647
		public string Password { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002450 File Offset: 0x00000650
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002458 File Offset: 0x00000658
		public bool SaveMyLogin { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002461 File Offset: 0x00000661
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002469 File Offset: 0x00000669
		public int TotalAttacksSent { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002472 File Offset: 0x00000672
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000247A File Offset: 0x0000067A
		public bool AutoLogin { get; set; } = false;

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002483 File Offset: 0x00000683
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000248B File Offset: 0x0000068B
		public bool DiscordRPC { get; set; } = true;

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002494 File Offset: 0x00000694
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000249C File Offset: 0x0000069C
		public string PicPath { get; set; } = null;

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000024A5 File Offset: 0x000006A5
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000024AD File Offset: 0x000006AD
		public Color BaseColor { get; set; } = (Color)ColorConverter.ConvertFromString("#FF9370F6");

		// Token: 0x04000120 RID: 288
		public List<Attack> AttackLogList;

		// Token: 0x04000121 RID: 289
		public List<EnemyLog> EnemyList;
	}
}
