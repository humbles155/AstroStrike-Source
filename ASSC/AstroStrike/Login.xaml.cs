using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using AstroStrike.Helpers;
using AstroStrike.User_Controls.Notifications;
using Fusion;

namespace AstroStrike
{
	// Token: 0x0200001F RID: 31
	public partial class Login : Window
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00002357 File Offset: 0x00000557
		public Login()
		{
			this.InitializeComponent();
			new MessageHost().Show();
			this.OnLoad();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005690 File Offset: 0x00003890
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

		// Token: 0x0600009F RID: 159 RVA: 0x000056B8 File Offset: 0x000038B8
		private void OnLoad()
		{
			SettingsModel settingsModel = SettingsManager.Load();
			base.Resources["AccentColor"] = new SolidColorBrush(settingsModel.BaseColor);
			this.Version.Content = "v" + Config.AppVersion;
			if (settingsModel.SaveMyLogin)
			{
				this.RemeberMeSwitch.IsChecked = new bool?(true);
				this.username.Text = settingsModel.Username;
				this.password.Password = settingsModel.Password;
				if (settingsModel.AutoLogin)
				{
					this.LoginBTN_Click(null, null);
				}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002375 File Offset: 0x00000575
		private void ExitBTN_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000574C File Offset: 0x0000394C
		[DebuggerStepThrough]
		private void LoginBTN_Click(object sender, RoutedEventArgs e)
		{
			Login.<LoginBTN_Click>d__5 <LoginBTN_Click>d__ = new Login.<LoginBTN_Click>d__5();
			<LoginBTN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoginBTN_Click>d__.<>4__this = this;
			<LoginBTN_Click>d__.sender = sender;
			<LoginBTN_Click>d__.e = e;
			<LoginBTN_Click>d__.<>1__state = -1;
			<LoginBTN_Click>d__.<>t__builder.Start<Login.<LoginBTN_Click>d__5>(ref <LoginBTN_Click>d__);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002381 File Offset: 0x00000581
		private void RegisterBTN_Click(object sender, RoutedEventArgs e)
		{
			base.Hide();
			new Register().Show();
		}

		// Token: 0x040000F3 RID: 243
		private static FusionApp APP = new FusionApp(Config.AppID);
	}
}
