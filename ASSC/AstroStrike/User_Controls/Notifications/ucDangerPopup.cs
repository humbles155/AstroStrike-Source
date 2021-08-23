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
	// Token: 0x02000050 RID: 80
	public class ucDangerPopup : UserControl, IComponentConnector
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
		public ucDangerPopup(string title, string content, int timeout)
		{
			ucDangerPopup.<>c__DisplayClass0_0 CS$<>8__locals1 = new ucDangerPopup.<>c__DisplayClass0_0();
			CS$<>8__locals1.timeout = timeout;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.InitializeComponent();
			this.lbTitle.Content = title;
			this.tbMessage.Text = content;
			Task.Run(delegate()
			{
				ucDangerPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d <<-ctor>b__0>d = new ucDangerPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d();
				<<-ctor>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
				<<-ctor>b__0>d.<>1__state = -1;
				<<-ctor>b__0>d.<>t__builder.Start<ucDangerPopup.<>c__DisplayClass0_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
				return <<-ctor>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000E510 File Offset: 0x0000C710
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/notifications/ucdangerpopup.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000E540 File Offset: 0x0000C740
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

		// Token: 0x040002BF RID: 703
		internal Label lbTitle;

		// Token: 0x040002C0 RID: 704
		internal Emoji.Wpf.TextBlock tbMessage;

		// Token: 0x040002C1 RID: 705
		private bool _contentLoaded;
	}
}
