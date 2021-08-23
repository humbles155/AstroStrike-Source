using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Emoji.Wpf;

namespace AstroStrike.User_Controls.Notifications
{
	// Token: 0x02000047 RID: 71
	public class ucWarningPopup : UserControl, IComponentConnector
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x0000DE28 File Offset: 0x0000C028
		public ucWarningPopup(string title, string content, int timeout)
		{
			ucWarningPopup.<>c__DisplayClass0_0 CS$<>8__locals1 = new ucWarningPopup.<>c__DisplayClass0_0();
			CS$<>8__locals1.timeout = timeout;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.InitializeComponent();
			this.lbTitle.Content = title;
			this.tbMessage.Text = content;
			Task.Run(delegate()
			{
				ucWarningPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d <<-ctor>b__0>d = new ucWarningPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d();
				<<-ctor>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
				<<-ctor>b__0>d.<>1__state = -1;
				<<-ctor>b__0>d.<>t__builder.Start<ucWarningPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
				return <<-ctor>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000DE80 File Offset: 0x0000C080
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/notifications/ucwarningpopup.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
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
					this.tbMessage = (Emoji.Wpf.TextBlock)target;
				}
			}
			else
			{
				this.lbTitle = (Label)target;
			}
		}

		// Token: 0x040002A4 RID: 676
		internal Label lbTitle;

		// Token: 0x040002A5 RID: 677
		internal Emoji.Wpf.TextBlock tbMessage;

		// Token: 0x040002A6 RID: 678
		private bool _contentLoaded;
	}
}
