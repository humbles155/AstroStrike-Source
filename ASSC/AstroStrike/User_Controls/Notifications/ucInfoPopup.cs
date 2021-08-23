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
	// Token: 0x0200004A RID: 74
	public class ucInfoPopup : UserControl, IComponentConnector
	{
		// Token: 0x060001BB RID: 443 RVA: 0x0000E058 File Offset: 0x0000C258
		public ucInfoPopup(string title, string content, int timeout)
		{
			ucInfoPopup.<>c__DisplayClass0_0 CS$<>8__locals1 = new ucInfoPopup.<>c__DisplayClass0_0();
			CS$<>8__locals1.timeout = timeout;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.InitializeComponent();
			this.lbTitle.Content = title;
			this.tbMessage.Text = content;
			Task.Run(delegate()
			{
				ucInfoPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d <<-ctor>b__0>d = new ucInfoPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d();
				<<-ctor>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
				<<-ctor>b__0>d.<>1__state = -1;
				<<-ctor>b__0>d.<>t__builder.Start<ucInfoPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
				return <<-ctor>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000E0B0 File Offset: 0x0000C2B0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/notifications/ucinfopopup.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000E0E0 File Offset: 0x0000C2E0
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

		// Token: 0x040002AD RID: 685
		internal Label lbTitle;

		// Token: 0x040002AE RID: 686
		internal Emoji.Wpf.TextBlock tbMessage;

		// Token: 0x040002AF RID: 687
		private bool _contentLoaded;
	}
}
