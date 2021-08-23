using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using AstroStrike.Discord;
using AstroStrike.Modules;
using AstroStrike.User_Controls;

namespace AstroStrike
{
	// Token: 0x02000026 RID: 38
	public partial class MainWindow : Window
	{
		// Token: 0x060000CC RID: 204 RVA: 0x000061EC File Offset: 0x000043EC
		public MainWindow()
		{
			this.InitializeComponent();
			this.UpdateChat();
			this.LoadData();
			this.LoadPfp();
			this.tabDisplay.Children.Add(MainWindow.ucDashboard);
			MainWindow.lastui = MainWindow.ucDashboard;
			Status.Start();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000623C File Offset: 0x0000443C
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

		// Token: 0x060000CE RID: 206 RVA: 0x00005C94 File Offset: 0x00003E94
		public void UpdateChat()
		{
			SettingsModel settingsModel = SettingsManager.Load();
			base.Resources["AccentColor"] = new SolidColorBrush(settingsModel.BaseColor);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000062A0 File Offset: 0x000044A0
		[DebuggerStepThrough]
		public void LoadData()
		{
			MainWindow.<LoadData>d__4 <LoadData>d__ = new MainWindow.<LoadData>d__4();
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.<>4__this = this;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<MainWindow.<LoadData>d__4>(ref <LoadData>d__);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000062DC File Offset: 0x000044DC
		private void TabChange(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			this.tabDisplay.Children.Clear();
			string name = button.Name;
			string a = name;
			if (!(a == "btnDashboard"))
			{
				if (!(a == "btnHub"))
				{
					if (!(a == "btnTools"))
					{
						if (!(a == "btnEnemyLogger"))
						{
							if (!(a == "btnChat"))
							{
								if (a == "btnSupport")
								{
									this.gsDashboard.Visibility = Visibility.Hidden;
									this.gsHub.Visibility = Visibility.Hidden;
									this.gsTools.Visibility = Visibility.Hidden;
									this.gsEnemyLogger.Visibility = Visibility.Hidden;
									this.gsChat.Visibility = Visibility.Hidden;
									this.gsSupport.Visibility = Visibility.Visible;
									this.bDashboard.Background = Brushes.Transparent;
									this.bHub.Background = Brushes.Transparent;
									this.bTools.Background = Brushes.Transparent;
									this.bEnemyLogger.Background = Brushes.Transparent;
									this.bChat.Background = Brushes.Transparent;
									this.bSupport.Background = new SolidColorBrush(Color.FromRgb(37, 40, 54));
									if (MainWindow.lastui != null)
									{
										this.tabDisplay.Children.Remove(MainWindow.lastui);
									}
									this.tabDisplay.Children.Add(new Support());
								}
							}
							else
							{
								this.gsDashboard.Visibility = Visibility.Hidden;
								this.gsHub.Visibility = Visibility.Hidden;
								this.gsTools.Visibility = Visibility.Hidden;
								this.gsEnemyLogger.Visibility = Visibility.Hidden;
								this.gsChat.Visibility = Visibility.Visible;
								this.gsSupport.Visibility = Visibility.Hidden;
								this.bDashboard.Background = Brushes.Transparent;
								this.bHub.Background = Brushes.Transparent;
								this.bTools.Background = Brushes.Transparent;
								this.bEnemyLogger.Background = Brushes.Transparent;
								this.bSupport.Background = Brushes.Transparent;
								this.bChat.Background = new SolidColorBrush(Color.FromRgb(37, 40, 54));
								if (MainWindow.lastui != null)
								{
									this.tabDisplay.Children.Remove(MainWindow.lastui);
								}
								this.tabDisplay.Children.Add(MainWindow.ucChat);
								MainWindow.lastui = MainWindow.ucChat;
							}
						}
						else
						{
							this.gsDashboard.Visibility = Visibility.Hidden;
							this.gsHub.Visibility = Visibility.Hidden;
							this.gsTools.Visibility = Visibility.Hidden;
							this.gsEnemyLogger.Visibility = Visibility.Visible;
							this.gsChat.Visibility = Visibility.Hidden;
							this.gsSupport.Visibility = Visibility.Hidden;
							this.bDashboard.Background = Brushes.Transparent;
							this.bHub.Background = Brushes.Transparent;
							this.bTools.Background = Brushes.Transparent;
							this.bEnemyLogger.Background = new SolidColorBrush(Color.FromRgb(37, 40, 54));
							this.bChat.Background = Brushes.Transparent;
							this.bSupport.Background = Brushes.Transparent;
							if (MainWindow.lastui != null)
							{
								this.tabDisplay.Children.Remove(MainWindow.lastui);
							}
							this.tabDisplay.Children.Add(MainWindow.ucEnemyLogger);
							MainWindow.lastui = MainWindow.ucEnemyLogger;
						}
					}
					else
					{
						this.gsDashboard.Visibility = Visibility.Hidden;
						this.gsHub.Visibility = Visibility.Hidden;
						this.gsTools.Visibility = Visibility.Visible;
						this.gsEnemyLogger.Visibility = Visibility.Hidden;
						this.gsChat.Visibility = Visibility.Hidden;
						this.gsSupport.Visibility = Visibility.Hidden;
						this.bDashboard.Background = Brushes.Transparent;
						this.bHub.Background = Brushes.Transparent;
						this.bTools.Background = new SolidColorBrush(Color.FromRgb(37, 40, 54));
						this.bEnemyLogger.Background = Brushes.Transparent;
						this.bChat.Background = Brushes.Transparent;
						this.bSupport.Background = Brushes.Transparent;
						if (MainWindow.lastui != null)
						{
							this.tabDisplay.Children.Remove(MainWindow.lastui);
						}
						this.tabDisplay.Children.Add(MainWindow.ucTools);
						MainWindow.lastui = MainWindow.ucTools;
					}
				}
				else
				{
					this.gsDashboard.Visibility = Visibility.Hidden;
					this.gsHub.Visibility = Visibility.Visible;
					this.gsTools.Visibility = Visibility.Hidden;
					this.gsEnemyLogger.Visibility = Visibility.Hidden;
					this.gsChat.Visibility = Visibility.Hidden;
					this.gsSupport.Visibility = Visibility.Hidden;
					this.bDashboard.Background = Brushes.Transparent;
					this.bHub.Background = new SolidColorBrush(Color.FromRgb(37, 40, 54));
					this.bTools.Background = Brushes.Transparent;
					this.bEnemyLogger.Background = Brushes.Transparent;
					this.bChat.Background = Brushes.Transparent;
					this.bSupport.Background = Brushes.Transparent;
					if (MainWindow.lastui != null)
					{
						this.tabDisplay.Children.Remove(MainWindow.lastui);
					}
					this.tabDisplay.Children.Add(MainWindow.ucHub);
					MainWindow.lastui = MainWindow.ucHub;
				}
			}
			else
			{
				this.gsDashboard.Visibility = Visibility.Visible;
				this.gsHub.Visibility = Visibility.Hidden;
				this.gsTools.Visibility = Visibility.Hidden;
				this.gsEnemyLogger.Visibility = Visibility.Hidden;
				this.gsChat.Visibility = Visibility.Hidden;
				this.gsSupport.Visibility = Visibility.Hidden;
				this.bDashboard.Background = new SolidColorBrush(Color.FromRgb(37, 40, 54));
				this.bHub.Background = Brushes.Transparent;
				this.bTools.Background = Brushes.Transparent;
				this.bEnemyLogger.Background = Brushes.Transparent;
				this.bChat.Background = Brushes.Transparent;
				this.bSupport.Background = Brushes.Transparent;
				if (MainWindow.lastui != null)
				{
					this.tabDisplay.Children.Remove(MainWindow.lastui);
				}
				this.tabDisplay.Children.Add(MainWindow.ucDashboard);
				MainWindow.lastui = MainWindow.ucDashboard;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005690 File Offset: 0x00003890
		private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			try
			{
				base.DragMove();
			}
			catch
			{
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006924 File Offset: 0x00004B24
		private void btnSettings_Click(object sender, RoutedEventArgs e)
		{
			this.tabDisplay.Children.Clear();
			if (MainWindow.lastui != null)
			{
				this.tabDisplay.Children.Remove(MainWindow.lastui);
			}
			this.tabDisplay.Children.Add(MainWindow.ucSettings);
			MainWindow.lastui = MainWindow.ucSettings;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000024D1 File Offset: 0x000006D1
		private void MiniBTN_Click(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000024DA File Offset: 0x000006DA
		private void ExitBTN_Click(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x04000127 RID: 295
		public static Dictionary<int, UserInfo> UserInfoList;

		// Token: 0x04000128 RID: 296
		private static UserControl lastui = null;

		// Token: 0x04000129 RID: 297
		private static readonly ucDashboard ucDashboard = new ucDashboard();

		// Token: 0x0400012A RID: 298
		private static readonly ucHub ucHub = new ucHub();

		// Token: 0x0400012B RID: 299
		private static readonly ucTools ucTools = new ucTools();

		// Token: 0x0400012C RID: 300
		private static readonly ucEnemyLogger ucEnemyLogger = new ucEnemyLogger();

		// Token: 0x0400012D RID: 301
		private static readonly ucChat ucChat = new ucChat();

		// Token: 0x0400012E RID: 302
		private static readonly ucSettings ucSettings = new ucSettings();
	}
}
