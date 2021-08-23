using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace AstroStrike.User_Controls
{
	// Token: 0x0200002A RID: 42
	public class Support : UserControl, IComponentConnector
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00002508 File Offset: 0x00000708
		public Support()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006F18 File Offset: 0x00005118
		[DebuggerStepThrough]
		private Task<bool> CheckIfHasTicket()
		{
			Support.<CheckIfHasTicket>d__1 <CheckIfHasTicket>d__ = new Support.<CheckIfHasTicket>d__1();
			<CheckIfHasTicket>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CheckIfHasTicket>d__.<>4__this = this;
			<CheckIfHasTicket>d__.<>1__state = -1;
			<CheckIfHasTicket>d__.<>t__builder.Start<Support.<CheckIfHasTicket>d__1>(ref <CheckIfHasTicket>d__);
			return <CheckIfHasTicket>d__.<>t__builder.Task;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00006F5C File Offset: 0x0000515C
		[DebuggerStepThrough]
		private Task<bool> CheckForBlackList()
		{
			Support.<CheckForBlackList>d__2 <CheckForBlackList>d__ = new Support.<CheckForBlackList>d__2();
			<CheckForBlackList>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CheckForBlackList>d__.<>4__this = this;
			<CheckForBlackList>d__.<>1__state = -1;
			<CheckForBlackList>d__.<>t__builder.Start<Support.<CheckForBlackList>d__2>(ref <CheckForBlackList>d__);
			return <CheckForBlackList>d__.<>t__builder.Task;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00006FA0 File Offset: 0x000051A0
		[DebuggerStepThrough]
		private Task GetTicketText()
		{
			Support.<GetTicketText>d__3 <GetTicketText>d__ = new Support.<GetTicketText>d__3();
			<GetTicketText>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<GetTicketText>d__.<>4__this = this;
			<GetTicketText>d__.<>1__state = -1;
			<GetTicketText>d__.<>t__builder.Start<Support.<GetTicketText>d__3>(ref <GetTicketText>d__);
			return <GetTicketText>d__.<>t__builder.Task;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00006FE4 File Offset: 0x000051E4
		[DebuggerStepThrough]
		private void SendNewTicketBTN_Click(object sender, RoutedEventArgs e)
		{
			Support.<SendNewTicketBTN_Click>d__4 <SendNewTicketBTN_Click>d__ = new Support.<SendNewTicketBTN_Click>d__4();
			<SendNewTicketBTN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendNewTicketBTN_Click>d__.<>4__this = this;
			<SendNewTicketBTN_Click>d__.sender = sender;
			<SendNewTicketBTN_Click>d__.e = e;
			<SendNewTicketBTN_Click>d__.<>1__state = -1;
			<SendNewTicketBTN_Click>d__.<>t__builder.Start<Support.<SendNewTicketBTN_Click>d__4>(ref <SendNewTicketBTN_Click>d__);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000702C File Offset: 0x0000522C
		[DebuggerStepThrough]
		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			Support.<UserControl_Loaded>d__5 <UserControl_Loaded>d__ = new Support.<UserControl_Loaded>d__5();
			<UserControl_Loaded>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UserControl_Loaded>d__.<>4__this = this;
			<UserControl_Loaded>d__.sender = sender;
			<UserControl_Loaded>d__.e = e;
			<UserControl_Loaded>d__.<>1__state = -1;
			<UserControl_Loaded>d__.<>t__builder.Start<Support.<UserControl_Loaded>d__5>(ref <UserControl_Loaded>d__);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007074 File Offset: 0x00005274
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/support.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000070A4 File Offset: 0x000052A4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Support)target).Loaded += this.UserControl_Loaded;
				break;
			case 2:
				this.SendNewTicketBTN = (Button)target;
				this.SendNewTicketBTN.Click += this.SendNewTicketBTN_Click;
				break;
			case 3:
				this.title = (TextBox)target;
				break;
			case 4:
				this.message = (TextBox)target;
				break;
			case 5:
				this.Output = (Label)target;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x04000153 RID: 339
		internal Button SendNewTicketBTN;

		// Token: 0x04000154 RID: 340
		internal TextBox title;

		// Token: 0x04000155 RID: 341
		internal TextBox message;

		// Token: 0x04000156 RID: 342
		internal Label Output;

		// Token: 0x04000157 RID: 343
		private bool _contentLoaded;
	}
}
