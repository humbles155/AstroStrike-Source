using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AstroStrike.User_Controls.News
{
	// Token: 0x02000053 RID: 83
	public class ucWarningCard : UserControl, IComponentConnector
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x000027FF File Offset: 0x000009FF
		public ucWarningCard(string title, string content)
		{
			this.InitializeComponent();
			this.lblTitle.Content = title;
			this.tbContent.Text = content;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/news/ucwarningcard.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000E718 File Offset: 0x0000C918
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
					this.tbContent = (TextBlock)target;
				}
			}
			else
			{
				this.lblTitle = (Label)target;
			}
		}

		// Token: 0x040002C8 RID: 712
		internal Label lblTitle;

		// Token: 0x040002C9 RID: 713
		internal TextBlock tbContent;

		// Token: 0x040002CA RID: 714
		private bool _contentLoaded;
	}
}
