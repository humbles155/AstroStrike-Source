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
using System.Windows.Media.Imaging;
using AstroStrike.Discord;
using Fusion;
using MaterialDesignThemes.Wpf;
using Microsoft.Win32;

namespace AstroStrike.User_Controls
{
	// Token: 0x02000036 RID: 54
	public class ucSettings : UserControl, IComponentConnector
	{
		// Token: 0x06000155 RID: 341 RVA: 0x0000266A File Offset: 0x0000086A
		public ucSettings()
		{
			this.InitializeComponent();
			this.OnLoad();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000AA00 File Offset: 0x00008C00
		private void OnLoad()
		{
			SettingsModel settingsModel = SettingsManager.Load();
			this.LoadPfp();
			this.AutoLoginSwitch.IsChecked = new bool?(settingsModel.AutoLogin);
			this.RPCswitch.IsChecked = new bool?(settingsModel.DiscordRPC);
			this.colorZone.Background = new SolidColorBrush(settingsModel.BaseColor);
			this.username.Content = User.Username;
			this.exdate.Content = User.Expiry;
			this.userid.Content = User.UserId;
			this.level.Content = User.Level;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000267E File Offset: 0x0000087E
		private void btnPwReset_Click(object sender, RoutedEventArgs e)
		{
			this.bProfileSettings.Visibility = Visibility.Hidden;
			this.bPwReset.Visibility = Visibility.Visible;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002698 File Offset: 0x00000898
		private void btnBack_Click(object sender, RoutedEventArgs e)
		{
			this.bProfileSettings.Visibility = Visibility.Visible;
			this.bPwReset.Visibility = Visibility.Hidden;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000026B2 File Offset: 0x000008B2
		private void btnBack2Color_Click(object sender, RoutedEventArgs e)
		{
			this.bColors.Visibility = Visibility.Visible;
			this.bImg.Visibility = Visibility.Hidden;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000026CC File Offset: 0x000008CC
		private void btnImgSettings_Click(object sender, RoutedEventArgs e)
		{
			this.bColors.Visibility = Visibility.Hidden;
			this.bImg.Visibility = Visibility.Visible;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		private void AutoLoginSwitch_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			settingsModel.AutoLogin = this.AutoLoginSwitch.IsChecked.Value;
			settingsModel.Save();
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000026E6 File Offset: 0x000008E6
		private void colorPicker_MouseMove(object sender, MouseEventArgs e)
		{
			this.colorZone.Background = new SolidColorBrush(this.colorPicker.Color);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		private void RestartALl_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			settingsModel.BaseColor = (Color)ColorConverter.ConvertFromString("#FF9370F6");
			settingsModel.Save();
			this.colorZone.Background = new SolidColorBrush(settingsModel.BaseColor);
			base.Resources["AccentColor"] = new SolidColorBrush(settingsModel.BaseColor);
			foreach (object obj in Application.Current.Windows)
			{
				Window window = (Window)obj;
				if (window.GetType() == typeof(MainWindow))
				{
					(window as MainWindow).UpdateChat();
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		private void ApplyColor_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			settingsModel.BaseColor = this.colorPicker.Color;
			settingsModel.Save();
			base.Resources["AccentColor"] = new SolidColorBrush(settingsModel.BaseColor);
			this.colorZone.Background = new SolidColorBrush(this.colorPicker.Color);
			foreach (object obj in Application.Current.Windows)
			{
				Window window = (Window)obj;
				if (window.GetType() == typeof(MainWindow))
				{
					(window as MainWindow).UpdateChat();
				}
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000AC74 File Offset: 0x00008E74
		[DebuggerStepThrough]
		private void UpdatePassBTN_Click(object sender, RoutedEventArgs e)
		{
			ucSettings.<UpdatePassBTN_Click>d__10 <UpdatePassBTN_Click>d__ = new ucSettings.<UpdatePassBTN_Click>d__10();
			<UpdatePassBTN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdatePassBTN_Click>d__.<>4__this = this;
			<UpdatePassBTN_Click>d__.sender = sender;
			<UpdatePassBTN_Click>d__.e = e;
			<UpdatePassBTN_Click>d__.<>1__state = -1;
			<UpdatePassBTN_Click>d__.<>t__builder.Start<ucSettings.<UpdatePassBTN_Click>d__10>(ref <UpdatePassBTN_Click>d__);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000ACBC File Offset: 0x00008EBC
		private void RPCswitch_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			settingsModel.DiscordRPC = this.RPCswitch.IsChecked.Value;
			settingsModel.Save();
			Status.Start();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		public void LoadPfp()
		{
			try
			{
				SettingsModel settingsModel = SettingsManager.Load();
				if (settingsModel.PicPath != null)
				{
					BitmapImage bitmapImage = new BitmapImage();
					bitmapImage.BeginInit();
					bitmapImage.UriSource = new Uri(settingsModel.PicPath);
					bitmapImage.EndInit();
					this.pic.ImageSource = bitmapImage;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000AD58 File Offset: 0x00008F58
		private void ChnagePFP_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
				openFileDialog.RestoreDirectory = true;
				openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
				openFileDialog.ShowDialog();
				string fileName = openFileDialog.FileName;
				if (!string.IsNullOrWhiteSpace(fileName))
				{
					settingsModel.PicPath = fileName;
					settingsModel.Save();
					BitmapImage bitmapImage = new BitmapImage();
					bitmapImage.BeginInit();
					bitmapImage.UriSource = new Uri(fileName);
					bitmapImage.EndInit();
					this.pic.ImageSource = bitmapImage;
					foreach (object obj in Application.Current.Windows)
					{
						Window window = (Window)obj;
						if (window.GetType() == typeof(MainWindow))
						{
							(window as MainWindow).LoadPfp();
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000AE6C File Offset: 0x0000906C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/ucsettings.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000AE9C File Offset: 0x0000909C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.exdate = (Label)target;
				break;
			case 2:
				this.userid = (Label)target;
				break;
			case 3:
				this.level = (Label)target;
				break;
			case 4:
				this.bProfileSettings = (Border)target;
				break;
			case 5:
				this.pic = (ImageBrush)target;
				break;
			case 6:
				this.username = (Label)target;
				break;
			case 7:
				this.ChnagePFP = (Button)target;
				this.ChnagePFP.Click += this.ChnagePFP_Click;
				break;
			case 8:
				this.AutoLoginSwitch = (ToggleButton)target;
				this.AutoLoginSwitch.Click += this.AutoLoginSwitch_Click;
				break;
			case 9:
				this.RPCswitch = (ToggleButton)target;
				this.RPCswitch.Click += this.RPCswitch_Click;
				break;
			case 10:
				this.btnPwReset = (Button)target;
				this.btnPwReset.Click += this.btnPwReset_Click;
				break;
			case 11:
				this.bPwReset = (Border)target;
				break;
			case 12:
				this.UpdatePassBTN = (Button)target;
				this.UpdatePassBTN.Click += this.UpdatePassBTN_Click;
				break;
			case 13:
				this.current = (TextBox)target;
				break;
			case 14:
				this._new = (TextBox)target;
				break;
			case 15:
				this.newagain = (TextBox)target;
				break;
			case 16:
				this.btnBack = (Button)target;
				this.btnBack.Click += this.btnBack_Click;
				break;
			case 17:
				this.bColors = (Border)target;
				break;
			case 18:
				this.ApplyColor = (Button)target;
				this.ApplyColor.Click += this.ApplyColor_Click;
				break;
			case 19:
				this.colorPicker = (ColorPicker)target;
				this.colorPicker.MouseMove += this.colorPicker_MouseMove;
				break;
			case 20:
				this.colorZone = (ColorZone)target;
				break;
			case 21:
				this.RestartALl = (Button)target;
				this.RestartALl.Click += this.RestartALl_Click;
				break;
			case 22:
				this.bImg = (Border)target;
				break;
			case 23:
				this.btnBack2Color = (Button)target;
				this.btnBack2Color.Click += this.btnBack2Color_Click;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x040001E6 RID: 486
		internal Label exdate;

		// Token: 0x040001E7 RID: 487
		internal Label userid;

		// Token: 0x040001E8 RID: 488
		internal Label level;

		// Token: 0x040001E9 RID: 489
		internal Border bProfileSettings;

		// Token: 0x040001EA RID: 490
		internal ImageBrush pic;

		// Token: 0x040001EB RID: 491
		internal Label username;

		// Token: 0x040001EC RID: 492
		internal Button ChnagePFP;

		// Token: 0x040001ED RID: 493
		internal ToggleButton AutoLoginSwitch;

		// Token: 0x040001EE RID: 494
		internal ToggleButton RPCswitch;

		// Token: 0x040001EF RID: 495
		internal Button btnPwReset;

		// Token: 0x040001F0 RID: 496
		internal Border bPwReset;

		// Token: 0x040001F1 RID: 497
		internal Button UpdatePassBTN;

		// Token: 0x040001F2 RID: 498
		internal TextBox current;

		// Token: 0x040001F3 RID: 499
		internal TextBox _new;

		// Token: 0x040001F4 RID: 500
		internal TextBox newagain;

		// Token: 0x040001F5 RID: 501
		internal Button btnBack;

		// Token: 0x040001F6 RID: 502
		internal Border bColors;

		// Token: 0x040001F7 RID: 503
		internal Button ApplyColor;

		// Token: 0x040001F8 RID: 504
		internal ColorPicker colorPicker;

		// Token: 0x040001F9 RID: 505
		internal ColorZone colorZone;

		// Token: 0x040001FA RID: 506
		internal Button RestartALl;

		// Token: 0x040001FB RID: 507
		internal Border bImg;

		// Token: 0x040001FC RID: 508
		internal Button btnBack2Color;

		// Token: 0x040001FD RID: 509
		private bool _contentLoaded;
	}
}
