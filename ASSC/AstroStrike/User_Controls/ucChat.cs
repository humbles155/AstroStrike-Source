using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using Emoji.Wpf;

namespace AstroStrike.User_Controls
{
	// Token: 0x02000033 RID: 51
	public class ucChat : UserControl, IComponentConnector
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00002568 File Offset: 0x00000768
		public ucChat()
		{
			this.InitializeComponent();
			this.UpdateChat();
			this.TimerSet();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00008164 File Offset: 0x00006364
		private void emojiSmile_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude00 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000081CC File Offset: 0x000063CC
		private void emojiXD_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude06 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008234 File Offset: 0x00006434
		private void emojiSweat_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude05 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000829C File Offset: 0x0000649C
		private void emojiTrive_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude02 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008304 File Offset: 0x00006504
		private void emojiTongue_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude0b ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000836C File Offset: 0x0000656C
		private void emojiFuji_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude0e ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000083D4 File Offset: 0x000065D4
		private void emojiParty_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udd73 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000843C File Offset: 0x0000663C
		private void emojiWorried_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude30 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000084A4 File Offset: 0x000066A4
		private void emojiOhDaDdY_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude29 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000850C File Offset: 0x0000670C
		private void emojiMemes_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udd23 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00008574 File Offset: 0x00006774
		private void emojiDevil_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude08 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000085DC File Offset: 0x000067DC
		private void emojiFxck_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udd2c ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00008644 File Offset: 0x00006844
		private void emojiMiddleFinger_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udd95 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000086AC File Offset: 0x000068AC
		private void emojiOK_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc4c ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008714 File Offset: 0x00006914
		private void emojiGreenHeart_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc9a ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000877C File Offset: 0x0000697C
		private void emojiSparkleHeart_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc96 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000087E4 File Offset: 0x000069E4
		private void emoji2Hearts_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc95 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000884C File Offset: 0x00006A4C
		private void emojiBeatingHeart_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc93 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000088B4 File Offset: 0x00006AB4
		private void emojiKiss_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude18 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000891C File Offset: 0x00006B1C
		private void emojiBrokenHeart_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc94 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00008984 File Offset: 0x00006B84
		private void emojiLove_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udd70 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000089EC File Offset: 0x00006BEC
		private void emojiLips_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc8b ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00008A54 File Offset: 0x00006C54
		private void EmojiRose_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83c\udf39 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008ABC File Offset: 0x00006CBC
		private void emojiDeadRose_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udd40 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008B24 File Offset: 0x00006D24
		private void emojiRibbon_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83c\udf80 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008B8C File Offset: 0x00006D8C
		private void emojiBlueHeart_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc99 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00008BF4 File Offset: 0x00006DF4
		private void emojiPurpleHeart_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc9c ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00008C5C File Offset: 0x00006E5C
		private void emojiBlackHeart_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udda4 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008CC4 File Offset: 0x00006EC4
		private void emojiClown_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udd21 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00008D2C File Offset: 0x00006F2C
		private void emojiMonkey1_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\ude48 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008D94 File Offset: 0x00006F94
		private void emojiMonkey2_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc12 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00008DFC File Offset: 0x00006FFC
		private void emojiCat_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc31 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00008E64 File Offset: 0x00007064
		private void emojiFire_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udd25 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008ECC File Offset: 0x000070CC
		private void emojiSleep_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udca4 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00008F34 File Offset: 0x00007134
		private void emojiEyes_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc40 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00008F9C File Offset: 0x0000719C
		private void emojiDead_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc80 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00009004 File Offset: 0x00007204
		private void emojiPlug_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udd0c ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000906C File Offset: 0x0000726C
		private void emojiGem_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc8e ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000090D4 File Offset: 0x000072D4
		private void emojiControl_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83c\udfae ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000913C File Offset: 0x0000733C
		private void emojiClap_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc4f ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000091A4 File Offset: 0x000073A4
		private void emojiGreenBoi_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc7d ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000920C File Offset: 0x0000740C
		private void emojiCoonGang_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udd9d ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00009274 File Offset: 0x00007474
		private void emojiPartyPopper_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83c\udf89 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000092DC File Offset: 0x000074DC
		private void emojiGift_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83c\udf81 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00009344 File Offset: 0x00007544
		private void emojiMoney_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udcb8 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000093AC File Offset: 0x000075AC
		private void emojiSmoke_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udca8 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00009414 File Offset: 0x00007614
		private void emojiPill_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udc8a ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000947C File Offset: 0x0000767C
		private void emojiHerb_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83c\udf3f ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000094E4 File Offset: 0x000076E4
		private void emojiBomb_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udca3 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000954C File Offset: 0x0000774C
		private void emojiShield_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udee1 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000095B4 File Offset: 0x000077B4
		private void emojiPin_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udccc ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000961C File Offset: 0x0000781C
		private void emojiBrain_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udde0 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00009684 File Offset: 0x00007884
		private void emojiWet_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83d\udca6 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000096EC File Offset: 0x000078EC
		private void emojiOrangeBoi_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udda7 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00009754 File Offset: 0x00007954
		private void emojiCorona_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udda0 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000097BC File Offset: 0x000079BC
		private void emojiEagle_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.tbMessage.Text = this.tbMessage.Text + "\ud83e\udd85 ";
			this.tbText.Text = (this.tbText.Text ?? "");
			this.tbMessage.Select(this.tbMessage.Text.Length, 0);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002582 File Offset: 0x00000782
		private void btnSmile_Click(object sender, RoutedEventArgs e)
		{
			this.gridSmile.Visibility = Visibility.Visible;
			this.gridHeart.Visibility = Visibility.Hidden;
			this.gridBeef.Visibility = Visibility.Hidden;
			this.gridMisc.Visibility = Visibility.Hidden;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000025B4 File Offset: 0x000007B4
		private void btnHeart_Click(object sender, RoutedEventArgs e)
		{
			this.gridSmile.Visibility = Visibility.Hidden;
			this.gridHeart.Visibility = Visibility.Visible;
			this.gridBeef.Visibility = Visibility.Hidden;
			this.gridMisc.Visibility = Visibility.Hidden;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000025E6 File Offset: 0x000007E6
		private void btnBeef_Click(object sender, RoutedEventArgs e)
		{
			this.gridSmile.Visibility = Visibility.Hidden;
			this.gridHeart.Visibility = Visibility.Hidden;
			this.gridBeef.Visibility = Visibility.Visible;
			this.gridMisc.Visibility = Visibility.Hidden;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002618 File Offset: 0x00000818
		private void btnMisc_Click(object sender, RoutedEventArgs e)
		{
			this.gridSmile.Visibility = Visibility.Hidden;
			this.gridHeart.Visibility = Visibility.Hidden;
			this.gridBeef.Visibility = Visibility.Hidden;
			this.gridMisc.Visibility = Visibility.Visible;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00009824 File Offset: 0x00007A24
		private void btnEmoji_Click(object sender, RoutedEventArgs e)
		{
			if (this.PeepsEmojiPicker.Visibility == Visibility.Hidden)
			{
				this.PeepsEmojiPicker.Visibility = Visibility.Visible;
			}
			else
			{
				this.PeepsEmojiPicker.Visibility = Visibility.Hidden;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000264A File Offset: 0x0000084A
		private void tbMessage_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.tbText.Text = this.tbMessage.Text;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000985C File Offset: 0x00007A5C
		private void tbMessage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Return && this.SendMSG.IsEnabled)
			{
				this.SendMSG_Click(null, null);
				this.tbMessage.Text = string.Empty;
				this.tbText.Text = string.Empty;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000098AC File Offset: 0x00007AAC
		private void TimerSet()
		{
			DispatcherTimer dispatcherTimer = new DispatcherTimer();
			dispatcherTimer.Tick += this.timechat_Tick;
			dispatcherTimer.Interval = new TimeSpan(0, 0, 15);
			if (dispatcherTimer.IsEnabled)
			{
				dispatcherTimer.Stop();
			}
			else
			{
				dispatcherTimer.Start();
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002662 File Offset: 0x00000862
		private void timechat_Tick(object sender, EventArgs e)
		{
			this.UpdateChat();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000098F8 File Offset: 0x00007AF8
		[DebuggerStepThrough]
		public void UpdateChat()
		{
			ucChat.<UpdateChat>d__66 <UpdateChat>d__ = new ucChat.<UpdateChat>d__66();
			<UpdateChat>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdateChat>d__.<>4__this = this;
			<UpdateChat>d__.<>1__state = -1;
			<UpdateChat>d__.<>t__builder.Start<ucChat.<UpdateChat>d__66>(ref <UpdateChat>d__);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00009934 File Offset: 0x00007B34
		[DebuggerStepThrough]
		private void SendMSG_Click(object sender, RoutedEventArgs e)
		{
			ucChat.<SendMSG_Click>d__67 <SendMSG_Click>d__ = new ucChat.<SendMSG_Click>d__67();
			<SendMSG_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendMSG_Click>d__.<>4__this = this;
			<SendMSG_Click>d__.sender = sender;
			<SendMSG_Click>d__.e = e;
			<SendMSG_Click>d__.<>1__state = -1;
			<SendMSG_Click>d__.<>t__builder.Start<ucChat.<SendMSG_Click>d__67>(ref <SendMSG_Click>d__);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000997C File Offset: 0x00007B7C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/ucchat.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000099AC File Offset: 0x00007BAC
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.SendMSG = (Button)target;
				this.SendMSG.Click += this.SendMSG_Click;
				break;
			case 2:
				this.btnEmoji = (Button)target;
				this.btnEmoji.Click += this.btnEmoji_Click;
				break;
			case 3:
				this.tbText = (Emoji.Wpf.TextBlock)target;
				break;
			case 4:
				this.tbMessage = (System.Windows.Controls.TextBox)target;
				this.tbMessage.TextChanged += this.tbMessage_TextChanged;
				this.tbMessage.KeyDown += this.tbMessage_KeyDown;
				break;
			case 5:
				this.scrollviwer = (ScrollViewer)target;
				break;
			case 6:
				this.spMessages = (StackPanel)target;
				break;
			case 7:
				this.PeepsEmojiPicker = (Grid)target;
				break;
			case 8:
				this.girdEmojiHeader = (Grid)target;
				break;
			case 9:
				this.btnSmile = (Button)target;
				this.btnSmile.Click += this.btnSmile_Click;
				break;
			case 10:
				this.btnHeart = (Button)target;
				this.btnHeart.Click += this.btnHeart_Click;
				break;
			case 11:
				this.btnBeef = (Button)target;
				this.btnBeef.Click += this.btnBeef_Click;
				break;
			case 12:
				this.btnMisc = (Button)target;
				this.btnMisc.Click += this.btnMisc_Click;
				break;
			case 13:
				this.gridSmile = (Grid)target;
				break;
			case 14:
				this.emojiSmile = (Emoji.Wpf.TextBlock)target;
				this.emojiSmile.MouseDown += this.emojiSmile_MouseDown;
				break;
			case 15:
				this.emojiXD = (Emoji.Wpf.TextBlock)target;
				this.emojiXD.MouseDown += this.emojiXD_MouseDown;
				break;
			case 16:
				this.emojiSweat = (Emoji.Wpf.TextBlock)target;
				this.emojiSweat.MouseDown += this.emojiSweat_MouseDown;
				break;
			case 17:
				this.emojiTrive = (Emoji.Wpf.TextBlock)target;
				this.emojiTrive.MouseDown += this.emojiTrive_MouseDown;
				break;
			case 18:
				this.emojiTongue = (Emoji.Wpf.TextBlock)target;
				this.emojiTongue.MouseDown += this.emojiTongue_MouseDown;
				break;
			case 19:
				this.emojiFuji = (Emoji.Wpf.TextBlock)target;
				this.emojiFuji.MouseDown += this.emojiFuji_MouseDown;
				break;
			case 20:
				this.emojiParty = (Emoji.Wpf.TextBlock)target;
				this.emojiParty.MouseDown += this.emojiParty_MouseDown;
				break;
			case 21:
				this.emojiWorried = (Emoji.Wpf.TextBlock)target;
				this.emojiWorried.MouseDown += this.emojiWorried_MouseDown;
				break;
			case 22:
				this.emojiOhDaDdY = (Emoji.Wpf.TextBlock)target;
				this.emojiOhDaDdY.MouseDown += this.emojiOhDaDdY_MouseDown;
				break;
			case 23:
				this.emojiMemes = (Emoji.Wpf.TextBlock)target;
				this.emojiMemes.MouseDown += this.emojiMemes_MouseDown;
				break;
			case 24:
				this.emojiPeep = (Emoji.Wpf.TextBlock)target;
				this.emojiPeep.MouseDown += this.emojiDevil_MouseDown;
				break;
			case 25:
				this.emojiFxck = (Emoji.Wpf.TextBlock)target;
				this.emojiFxck.MouseDown += this.emojiFxck_MouseDown;
				break;
			case 26:
				this.emojiMiddleFinger = (Emoji.Wpf.TextBlock)target;
				this.emojiMiddleFinger.MouseDown += this.emojiMiddleFinger_MouseDown;
				break;
			case 27:
				this.emojiOK = (Emoji.Wpf.TextBlock)target;
				this.emojiOK.MouseDown += this.emojiOK_MouseDown;
				break;
			case 28:
				this.gridHeart = (Grid)target;
				break;
			case 29:
				this.emojiGreenHeart = (Emoji.Wpf.TextBlock)target;
				this.emojiGreenHeart.MouseDown += this.emojiGreenHeart_MouseDown;
				break;
			case 30:
				this.emojiSparkleHeart = (Emoji.Wpf.TextBlock)target;
				this.emojiSparkleHeart.MouseDown += this.emojiSparkleHeart_MouseDown;
				break;
			case 31:
				this.emoji2Hearts = (Emoji.Wpf.TextBlock)target;
				this.emoji2Hearts.MouseDown += this.emoji2Hearts_MouseDown;
				break;
			case 32:
				this.emojiBeatingHeart = (Emoji.Wpf.TextBlock)target;
				this.emojiBeatingHeart.MouseDown += this.emojiBeatingHeart_MouseDown;
				break;
			case 33:
				this.emojiKiss = (Emoji.Wpf.TextBlock)target;
				this.emojiKiss.MouseDown += this.emojiKiss_MouseDown;
				break;
			case 34:
				this.emojiBrokenHeart = (Emoji.Wpf.TextBlock)target;
				this.emojiBrokenHeart.MouseDown += this.emojiBrokenHeart_MouseDown;
				break;
			case 35:
				this.emojiLove = (Emoji.Wpf.TextBlock)target;
				this.emojiLove.MouseDown += this.emojiLove_MouseDown;
				break;
			case 36:
				this.emojiLips = (Emoji.Wpf.TextBlock)target;
				this.emojiLips.MouseDown += this.emojiLips_MouseDown;
				break;
			case 37:
				this.EmojiRose = (Emoji.Wpf.TextBlock)target;
				this.EmojiRose.MouseDown += this.EmojiRose_MouseDown;
				break;
			case 38:
				this.emojiDeadRose = (Emoji.Wpf.TextBlock)target;
				this.emojiDeadRose.MouseDown += this.emojiDeadRose_MouseDown;
				break;
			case 39:
				this.emojiRibbon = (Emoji.Wpf.TextBlock)target;
				this.emojiRibbon.MouseDown += this.emojiRibbon_MouseDown;
				break;
			case 40:
				this.emojiBlueHeart = (Emoji.Wpf.TextBlock)target;
				this.emojiBlueHeart.MouseDown += this.emojiBlueHeart_MouseDown;
				break;
			case 41:
				this.emojiPurpleHeart = (Emoji.Wpf.TextBlock)target;
				this.emojiPurpleHeart.MouseDown += this.emojiPurpleHeart_MouseDown;
				break;
			case 42:
				this.emojiBlackHeart = (Emoji.Wpf.TextBlock)target;
				this.emojiBlackHeart.MouseDown += this.emojiBlackHeart_MouseDown;
				break;
			case 43:
				this.gridBeef = (Grid)target;
				break;
			case 44:
				this.emojiClown = (Emoji.Wpf.TextBlock)target;
				this.emojiClown.MouseDown += this.emojiClown_MouseDown;
				break;
			case 45:
				this.emojiMonkey1 = (Emoji.Wpf.TextBlock)target;
				this.emojiMonkey1.MouseDown += this.emojiMonkey1_MouseDown;
				break;
			case 46:
				this.emojiMonkey2 = (Emoji.Wpf.TextBlock)target;
				this.emojiMonkey2.MouseDown += this.emojiMonkey2_MouseDown;
				break;
			case 47:
				this.emojiCat = (Emoji.Wpf.TextBlock)target;
				this.emojiCat.MouseDown += this.emojiCat_MouseDown;
				break;
			case 48:
				this.emojiFire = (Emoji.Wpf.TextBlock)target;
				this.emojiFire.MouseDown += this.emojiFire_MouseDown;
				break;
			case 49:
				this.emojiSleep = (Emoji.Wpf.TextBlock)target;
				this.emojiSleep.MouseDown += this.emojiSleep_MouseDown;
				break;
			case 50:
				this.emojiEyes = (Emoji.Wpf.TextBlock)target;
				this.emojiEyes.MouseDown += this.emojiEyes_MouseDown;
				break;
			case 51:
				this.emojiDead = (Emoji.Wpf.TextBlock)target;
				this.emojiDead.MouseDown += this.emojiDead_MouseDown;
				break;
			case 52:
				this.emojiPlug = (Emoji.Wpf.TextBlock)target;
				this.emojiPlug.MouseDown += this.emojiPlug_MouseDown;
				break;
			case 53:
				this.emojiGem = (Emoji.Wpf.TextBlock)target;
				this.emojiGem.MouseDown += this.emojiGem_MouseDown;
				break;
			case 54:
				this.emojiControl = (Emoji.Wpf.TextBlock)target;
				this.emojiControl.MouseDown += this.emojiControl_MouseDown;
				break;
			case 55:
				this.emojiClap = (Emoji.Wpf.TextBlock)target;
				this.emojiClap.MouseDown += this.emojiClap_MouseDown;
				break;
			case 56:
				this.emojiGreenBoi = (Emoji.Wpf.TextBlock)target;
				this.emojiGreenBoi.MouseDown += this.emojiGreenBoi_MouseDown;
				break;
			case 57:
				this.emojiCoonGang = (Emoji.Wpf.TextBlock)target;
				this.emojiCoonGang.MouseDown += this.emojiCoonGang_MouseDown;
				break;
			case 58:
				this.gridMisc = (Grid)target;
				break;
			case 59:
				this.emojiPartyPopper = (Emoji.Wpf.TextBlock)target;
				this.emojiPartyPopper.MouseDown += this.emojiPartyPopper_MouseDown;
				break;
			case 60:
				this.emojiGift = (Emoji.Wpf.TextBlock)target;
				this.emojiGift.MouseDown += this.emojiGift_MouseDown;
				break;
			case 61:
				this.emojiMoney = (Emoji.Wpf.TextBlock)target;
				this.emojiMoney.MouseDown += this.emojiMoney_MouseDown;
				break;
			case 62:
				this.emojiSmoke = (Emoji.Wpf.TextBlock)target;
				this.emojiSmoke.MouseDown += this.emojiSmoke_MouseDown;
				break;
			case 63:
				this.emojiPill = (Emoji.Wpf.TextBlock)target;
				this.emojiPill.MouseDown += this.emojiPill_MouseDown;
				break;
			case 64:
				this.emojiHerb = (Emoji.Wpf.TextBlock)target;
				this.emojiHerb.MouseDown += this.emojiHerb_MouseDown;
				break;
			case 65:
				this.emojiBomb = (Emoji.Wpf.TextBlock)target;
				this.emojiBomb.MouseDown += this.emojiBomb_MouseDown;
				break;
			case 66:
				this.emojiShield = (Emoji.Wpf.TextBlock)target;
				this.emojiShield.MouseDown += this.emojiShield_MouseDown;
				break;
			case 67:
				this.emojiPin = (Emoji.Wpf.TextBlock)target;
				this.emojiPin.MouseDown += this.emojiPin_MouseDown;
				break;
			case 68:
				this.emojiBrain = (Emoji.Wpf.TextBlock)target;
				this.emojiBrain.MouseDown += this.emojiBrain_MouseDown;
				break;
			case 69:
				this.emojiWet = (Emoji.Wpf.TextBlock)target;
				this.emojiWet.MouseDown += this.emojiWet_MouseDown;
				break;
			case 70:
				this.emojiOrangeBoi = (Emoji.Wpf.TextBlock)target;
				this.emojiOrangeBoi.MouseDown += this.emojiOrangeBoi_MouseDown;
				break;
			case 71:
				this.emojiCorona = (Emoji.Wpf.TextBlock)target;
				this.emojiCorona.MouseDown += this.emojiCorona_MouseDown;
				break;
			case 72:
				this.emojiEagle = (Emoji.Wpf.TextBlock)target;
				this.emojiEagle.MouseDown += this.emojiEagle_MouseDown;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x0400018C RID: 396
		internal Button SendMSG;

		// Token: 0x0400018D RID: 397
		internal Button btnEmoji;

		// Token: 0x0400018E RID: 398
		internal Emoji.Wpf.TextBlock tbText;

		// Token: 0x0400018F RID: 399
		internal System.Windows.Controls.TextBox tbMessage;

		// Token: 0x04000190 RID: 400
		internal ScrollViewer scrollviwer;

		// Token: 0x04000191 RID: 401
		internal StackPanel spMessages;

		// Token: 0x04000192 RID: 402
		internal Grid PeepsEmojiPicker;

		// Token: 0x04000193 RID: 403
		internal Grid girdEmojiHeader;

		// Token: 0x04000194 RID: 404
		internal Button btnSmile;

		// Token: 0x04000195 RID: 405
		internal Button btnHeart;

		// Token: 0x04000196 RID: 406
		internal Button btnBeef;

		// Token: 0x04000197 RID: 407
		internal Button btnMisc;

		// Token: 0x04000198 RID: 408
		internal Grid gridSmile;

		// Token: 0x04000199 RID: 409
		internal Emoji.Wpf.TextBlock emojiSmile;

		// Token: 0x0400019A RID: 410
		internal Emoji.Wpf.TextBlock emojiXD;

		// Token: 0x0400019B RID: 411
		internal Emoji.Wpf.TextBlock emojiSweat;

		// Token: 0x0400019C RID: 412
		internal Emoji.Wpf.TextBlock emojiTrive;

		// Token: 0x0400019D RID: 413
		internal Emoji.Wpf.TextBlock emojiTongue;

		// Token: 0x0400019E RID: 414
		internal Emoji.Wpf.TextBlock emojiFuji;

		// Token: 0x0400019F RID: 415
		internal Emoji.Wpf.TextBlock emojiParty;

		// Token: 0x040001A0 RID: 416
		internal Emoji.Wpf.TextBlock emojiWorried;

		// Token: 0x040001A1 RID: 417
		internal Emoji.Wpf.TextBlock emojiOhDaDdY;

		// Token: 0x040001A2 RID: 418
		internal Emoji.Wpf.TextBlock emojiMemes;

		// Token: 0x040001A3 RID: 419
		internal Emoji.Wpf.TextBlock emojiPeep;

		// Token: 0x040001A4 RID: 420
		internal Emoji.Wpf.TextBlock emojiFxck;

		// Token: 0x040001A5 RID: 421
		internal Emoji.Wpf.TextBlock emojiMiddleFinger;

		// Token: 0x040001A6 RID: 422
		internal Emoji.Wpf.TextBlock emojiOK;

		// Token: 0x040001A7 RID: 423
		internal Grid gridHeart;

		// Token: 0x040001A8 RID: 424
		internal Emoji.Wpf.TextBlock emojiGreenHeart;

		// Token: 0x040001A9 RID: 425
		internal Emoji.Wpf.TextBlock emojiSparkleHeart;

		// Token: 0x040001AA RID: 426
		internal Emoji.Wpf.TextBlock emoji2Hearts;

		// Token: 0x040001AB RID: 427
		internal Emoji.Wpf.TextBlock emojiBeatingHeart;

		// Token: 0x040001AC RID: 428
		internal Emoji.Wpf.TextBlock emojiKiss;

		// Token: 0x040001AD RID: 429
		internal Emoji.Wpf.TextBlock emojiBrokenHeart;

		// Token: 0x040001AE RID: 430
		internal Emoji.Wpf.TextBlock emojiLove;

		// Token: 0x040001AF RID: 431
		internal Emoji.Wpf.TextBlock emojiLips;

		// Token: 0x040001B0 RID: 432
		internal Emoji.Wpf.TextBlock EmojiRose;

		// Token: 0x040001B1 RID: 433
		internal Emoji.Wpf.TextBlock emojiDeadRose;

		// Token: 0x040001B2 RID: 434
		internal Emoji.Wpf.TextBlock emojiRibbon;

		// Token: 0x040001B3 RID: 435
		internal Emoji.Wpf.TextBlock emojiBlueHeart;

		// Token: 0x040001B4 RID: 436
		internal Emoji.Wpf.TextBlock emojiPurpleHeart;

		// Token: 0x040001B5 RID: 437
		internal Emoji.Wpf.TextBlock emojiBlackHeart;

		// Token: 0x040001B6 RID: 438
		internal Grid gridBeef;

		// Token: 0x040001B7 RID: 439
		internal Emoji.Wpf.TextBlock emojiClown;

		// Token: 0x040001B8 RID: 440
		internal Emoji.Wpf.TextBlock emojiMonkey1;

		// Token: 0x040001B9 RID: 441
		internal Emoji.Wpf.TextBlock emojiMonkey2;

		// Token: 0x040001BA RID: 442
		internal Emoji.Wpf.TextBlock emojiCat;

		// Token: 0x040001BB RID: 443
		internal Emoji.Wpf.TextBlock emojiFire;

		// Token: 0x040001BC RID: 444
		internal Emoji.Wpf.TextBlock emojiSleep;

		// Token: 0x040001BD RID: 445
		internal Emoji.Wpf.TextBlock emojiEyes;

		// Token: 0x040001BE RID: 446
		internal Emoji.Wpf.TextBlock emojiDead;

		// Token: 0x040001BF RID: 447
		internal Emoji.Wpf.TextBlock emojiPlug;

		// Token: 0x040001C0 RID: 448
		internal Emoji.Wpf.TextBlock emojiGem;

		// Token: 0x040001C1 RID: 449
		internal Emoji.Wpf.TextBlock emojiControl;

		// Token: 0x040001C2 RID: 450
		internal Emoji.Wpf.TextBlock emojiClap;

		// Token: 0x040001C3 RID: 451
		internal Emoji.Wpf.TextBlock emojiGreenBoi;

		// Token: 0x040001C4 RID: 452
		internal Emoji.Wpf.TextBlock emojiCoonGang;

		// Token: 0x040001C5 RID: 453
		internal Grid gridMisc;

		// Token: 0x040001C6 RID: 454
		internal Emoji.Wpf.TextBlock emojiPartyPopper;

		// Token: 0x040001C7 RID: 455
		internal Emoji.Wpf.TextBlock emojiGift;

		// Token: 0x040001C8 RID: 456
		internal Emoji.Wpf.TextBlock emojiMoney;

		// Token: 0x040001C9 RID: 457
		internal Emoji.Wpf.TextBlock emojiSmoke;

		// Token: 0x040001CA RID: 458
		internal Emoji.Wpf.TextBlock emojiPill;

		// Token: 0x040001CB RID: 459
		internal Emoji.Wpf.TextBlock emojiHerb;

		// Token: 0x040001CC RID: 460
		internal Emoji.Wpf.TextBlock emojiBomb;

		// Token: 0x040001CD RID: 461
		internal Emoji.Wpf.TextBlock emojiShield;

		// Token: 0x040001CE RID: 462
		internal Emoji.Wpf.TextBlock emojiPin;

		// Token: 0x040001CF RID: 463
		internal Emoji.Wpf.TextBlock emojiBrain;

		// Token: 0x040001D0 RID: 464
		internal Emoji.Wpf.TextBlock emojiWet;

		// Token: 0x040001D1 RID: 465
		internal Emoji.Wpf.TextBlock emojiOrangeBoi;

		// Token: 0x040001D2 RID: 466
		internal Emoji.Wpf.TextBlock emojiCorona;

		// Token: 0x040001D3 RID: 467
		internal Emoji.Wpf.TextBlock emojiEagle;

		// Token: 0x040001D4 RID: 468
		private bool _contentLoaded;
	}
}
