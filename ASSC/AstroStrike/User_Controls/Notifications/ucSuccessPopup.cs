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
	// Token: 0x0200004D RID: 77
	public class ucSuccessPopup : UserControl, IComponentConnector
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0000E288 File Offset: 0x0000C488
		public ucSuccessPopup(string title, string content, int timeout)
		{
			ucSuccessPopup.<>c__DisplayClass0_0 CS$<>8__locals1 = new ucSuccessPopup.<>c__DisplayClass0_0();
			CS$<>8__locals1.timeout = timeout;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.InitializeComponent();
			this.lbTitle.Content = title;
			this.tbMessage.Text = content;
			Task.Run(delegate()
			{
				ucSuccessPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d <<-ctor>b__0>d = new ucSuccessPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d();
				<<-ctor>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
				<<-ctor>b__0>d.<>1__state = -1;
				<<-ctor>b__0>d.<>t__builder.Start<ucSuccessPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
				return <<-ctor>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/notifications/ucsuccesspopup.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000E310 File Offset: 0x0000C510
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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

		// Token: 0x040002B6 RID: 694
		internal Label lbTitle;

		// Token: 0x040002B7 RID: 695
		internal Emoji.Wpf.TextBlock tbMessage;

		// Token: 0x040002B8 RID: 696
		private bool _contentLoaded;
	}
}
