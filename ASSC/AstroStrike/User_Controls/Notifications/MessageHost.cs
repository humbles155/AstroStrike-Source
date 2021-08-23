using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AstroStrike.User_Controls.Notifications
{
	// Token: 0x02000046 RID: 70
	public class MessageHost : Window, IComponentConnector
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002767 File Offset: 0x00000967
		public static MessageHost Instance { get; private set; }

		// Token: 0x060001AA RID: 426 RVA: 0x0000276F File Offset: 0x0000096F
		public MessageHost()
		{
			this.InitializeComponent();
			MessageHost.Instance = this;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002783 File Offset: 0x00000983
		public static void infoBox(string Title, string Message, int Timeout = 5)
		{
			MessageHost.Instance.spNotifications.Children.Add(new ucInfoPopup(Title, Message, Timeout));
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000027A2 File Offset: 0x000009A2
		public static void successBox(string Title, string Message, int Timeout = 5)
		{
			MessageHost.Instance.spNotifications.Children.Add(new ucSuccessPopup(Title, Message, Timeout));
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000027C1 File Offset: 0x000009C1
		public static void warningBox(string Title, string Message, int Timeout = 5)
		{
			MessageHost.Instance.spNotifications.Children.Add(new ucWarningPopup(Title, Message, Timeout));
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000027E0 File Offset: 0x000009E0
		public static void dangerBox(string Title, string Message, int Timeout = 5)
		{
			MessageHost.Instance.spNotifications.Children.Add(new ucDangerPopup(Title, Message, Timeout));
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000DD74 File Offset: 0x0000BF74
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Rect workArea = SystemParameters.WorkArea;
			base.Left = workArea.Right - base.Width;
			base.Top = workArea.Bottom - base.Height;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/notifications/messagehost.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId != 1)
			{
				if (connectionId != 2)
				{
					this._contentLoaded = true;
				}
				else
				{
					this.spNotifications = (StackPanel)target;
				}
			}
			else
			{
				((MessageHost)target).Loaded += this.Window_Loaded;
			}
		}

		// Token: 0x040002A2 RID: 674
		internal StackPanel spNotifications;

		// Token: 0x040002A3 RID: 675
		private bool _contentLoaded;
	}
}
