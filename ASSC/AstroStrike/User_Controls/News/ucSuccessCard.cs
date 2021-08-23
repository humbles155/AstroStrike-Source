using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AstroStrike.User_Controls.News
{
	// Token: 0x02000055 RID: 85
	public class ucSuccessCard : UserControl, IComponentConnector
	{
		// Token: 0x060001DC RID: 476 RVA: 0x0000284B File Offset: 0x00000A4B
		public ucSuccessCard(string title, string content)
		{
			this.InitializeComponent();
			this.lblTitle.Content = title;
			this.tbContent.Text = content;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/news/ucsuccesscard.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
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
					this.tbContent = (TextBlock)target;
				}
			}
			else
			{
				this.lblTitle = (Label)target;
			}
		}

		// Token: 0x040002CE RID: 718
		internal Label lblTitle;

		// Token: 0x040002CF RID: 719
		internal TextBlock tbContent;

		// Token: 0x040002D0 RID: 720
		private bool _contentLoaded;
	}
}
