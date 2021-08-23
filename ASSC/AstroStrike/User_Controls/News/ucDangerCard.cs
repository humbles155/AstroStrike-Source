using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AstroStrike.User_Controls.News
{
	// Token: 0x02000056 RID: 86
	public class ucDangerCard : UserControl, IComponentConnector
	{
		// Token: 0x060001DF RID: 479 RVA: 0x00002871 File Offset: 0x00000A71
		public ucDangerCard(string title, string content)
		{
			this.InitializeComponent();
			this.lblTitle.Content = title;
			this.tbContent.Text = content;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000E82C File Offset: 0x0000CA2C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/news/ucdangercard.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000E85C File Offset: 0x0000CA5C
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

		// Token: 0x040002D1 RID: 721
		internal Label lblTitle;

		// Token: 0x040002D2 RID: 722
		internal TextBlock tbContent;

		// Token: 0x040002D3 RID: 723
		private bool _contentLoaded;
	}
}
