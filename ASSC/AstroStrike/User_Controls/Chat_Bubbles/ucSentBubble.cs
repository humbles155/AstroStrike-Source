using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Emoji.Wpf;

namespace AstroStrike.User_Controls.Chat_Bubbles
{
	// Token: 0x02000057 RID: 87
	public class ucSentBubble : UserControl, IComponentConnector
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00002897 File Offset: 0x00000A97
		public ucSentBubble(string title, string content, string id)
		{
			this.InitializeComponent();
			this.MessageID = id;
			this.lblTitle.Content = title;
			this.tbMessage.Text = content;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000E898 File Offset: 0x0000CA98
		[DebuggerStepThrough]
		private void SendMSG_Click(object sender, RoutedEventArgs e)
		{
			ucSentBubble.<SendMSG_Click>d__2 <SendMSG_Click>d__ = new ucSentBubble.<SendMSG_Click>d__2();
			<SendMSG_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendMSG_Click>d__.<>4__this = this;
			<SendMSG_Click>d__.sender = sender;
			<SendMSG_Click>d__.e = e;
			<SendMSG_Click>d__.<>1__state = -1;
			<SendMSG_Click>d__.<>t__builder.Start<ucSentBubble.<SendMSG_Click>d__2>(ref <SendMSG_Click>d__);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/chat%20bubbles/ucsentbubble.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000E910 File Offset: 0x0000CB10
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.lblTitle = (Label)target;
				break;
			case 2:
				this.tbMessage = (Emoji.Wpf.TextBlock)target;
				break;
			case 3:
				this.DeleteMSG = (Button)target;
				this.DeleteMSG.Click += this.SendMSG_Click;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x040002D4 RID: 724
		private string MessageID = string.Empty;

		// Token: 0x040002D5 RID: 725
		internal Label lblTitle;

		// Token: 0x040002D6 RID: 726
		internal Emoji.Wpf.TextBlock tbMessage;

		// Token: 0x040002D7 RID: 727
		internal Button DeleteMSG;

		// Token: 0x040002D8 RID: 728
		private bool _contentLoaded;
	}
}
