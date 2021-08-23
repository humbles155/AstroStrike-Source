using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AstroStrike.User_Controls.News
{
	// Token: 0x02000054 RID: 84
	public class ucInfoCard : UserControl, IComponentConnector
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00002825 File Offset: 0x00000A25
		public ucInfoCard(string title, string content)
		{
			this.InitializeComponent();
			this.lblTitle.Content = title;
			this.tbContent.Text = content;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000E754 File Offset: 0x0000C954
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/news/ucinfocard.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000E784 File Offset: 0x0000C984
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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
					this.tbContent = (TextBlock)target;
				}
			}
			else
			{
				this.lblTitle = (Label)target;
			}
		}

		// Token: 0x040002CB RID: 715
		internal Label lblTitle;

		// Token: 0x040002CC RID: 716
		internal TextBlock tbContent;

		// Token: 0x040002CD RID: 717
		private bool _contentLoaded;
	}
}
