using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Emoji.Wpf;

namespace AstroStrike.User_Controls.Chat_Bubbles
{
	// Token: 0x02000059 RID: 89
	public class ucReceivedBubble : UserControl, IComponentConnector
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x000028CF File Offset: 0x00000ACF
		public ucReceivedBubble(string title, string content)
		{
			this.InitializeComponent();
			this.lblTitle.Content = title;
			this.tbMessage.Text = content;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/chat%20bubbles/ucreceivedbubble.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
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
				this.lblTitle = (Label)target;
			}
		}

		// Token: 0x040002E1 RID: 737
		internal Label lblTitle;

		// Token: 0x040002E2 RID: 738
		internal Emoji.Wpf.TextBlock tbMessage;

		// Token: 0x040002E3 RID: 739
		private bool _contentLoaded;
	}
}
