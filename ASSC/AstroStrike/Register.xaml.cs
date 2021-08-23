using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using AstroStrike.Helpers;
using Fusion;

namespace AstroStrike
{
	// Token: 0x02000021 RID: 33
	public partial class Register : Window
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x000023A4 File Offset: 0x000005A4
		public Register()
		{
			this.InitializeComponent();
			this.UpdateForm();
			this.version.Content = "v" + Config.AppVersion;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005C94 File Offset: 0x00003E94
		public void UpdateForm()
		{
			SettingsModel settingsModel = SettingsManager.Load();
			base.Resources["AccentColor"] = new SolidColorBrush(settingsModel.BaseColor);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005690 File Offset: 0x00003890
		private void DragMove(object sender, MouseButtonEventArgs e)
		{
			try
			{
				base.DragMove();
			}
			catch
			{
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002375 File Offset: 0x00000575
		private void ExitBTN_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000023D2 File Offset: 0x000005D2
		private void GoBackToLoginBTn_Click(object sender, RoutedEventArgs e)
		{
			base.Hide();
			new Login().Show();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005CC4 File Offset: 0x00003EC4
		[DebuggerStepThrough]
		private void RegisterBTn_Click(object sender, RoutedEventArgs e)
		{
			Register.<RegisterBTn_Click>d__6 <RegisterBTn_Click>d__ = new Register.<RegisterBTn_Click>d__6();
			<RegisterBTn_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<RegisterBTn_Click>d__.<>4__this = this;
			<RegisterBTn_Click>d__.sender = sender;
			<RegisterBTn_Click>d__.e = e;
			<RegisterBTn_Click>d__.<>1__state = -1;
			<RegisterBTn_Click>d__.<>t__builder.Start<Register.<RegisterBTn_Click>d__6>(ref <RegisterBTn_Click>d__);
		}

		// Token: 0x04000108 RID: 264
		private static FusionApp APP = new FusionApp(Config.AppID);
	}
}
