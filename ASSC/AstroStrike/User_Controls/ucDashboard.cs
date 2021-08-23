using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Threading;

namespace AstroStrike.User_Controls
{
	// Token: 0x02000041 RID: 65
	public class ucDashboard : UserControl, IComponentConnector
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00002746 File Offset: 0x00000946
		public ucDashboard()
		{
			this.InitializeComponent();
			this.OnLoad();
			this.TimerSet();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000D280 File Offset: 0x0000B480
		[DebuggerStepThrough]
		private void OnLoad()
		{
			ucDashboard.<OnLoad>d__1 <OnLoad>d__ = new ucDashboard.<OnLoad>d__1();
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<ucDashboard.<OnLoad>d__1>(ref <OnLoad>d__);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000D2BC File Offset: 0x0000B4BC
		[DebuggerStepThrough]
		private Task LoadNewsAsync()
		{
			ucDashboard.<LoadNewsAsync>d__2 <LoadNewsAsync>d__ = new ucDashboard.<LoadNewsAsync>d__2();
			<LoadNewsAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadNewsAsync>d__.<>4__this = this;
			<LoadNewsAsync>d__.<>1__state = -1;
			<LoadNewsAsync>d__.<>t__builder.Start<ucDashboard.<LoadNewsAsync>d__2>(ref <LoadNewsAsync>d__);
			return <LoadNewsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000D300 File Offset: 0x0000B500
		private void TimerSet()
		{
			DispatcherTimer dispatcherTimer = new DispatcherTimer();
			dispatcherTimer.Tick += this.dispatcherTimer_Tick;
			dispatcherTimer.Interval = new TimeSpan(1, 0, 0);
			if (dispatcherTimer.IsEnabled)
			{
				dispatcherTimer.Stop();
			}
			else
			{
				dispatcherTimer.Start();
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000D34C File Offset: 0x0000B54C
		[DebuggerStepThrough]
		private void dispatcherTimer_Tick(object sender, EventArgs e)
		{
			ucDashboard.<dispatcherTimer_Tick>d__4 <dispatcherTimer_Tick>d__ = new ucDashboard.<dispatcherTimer_Tick>d__4();
			<dispatcherTimer_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<dispatcherTimer_Tick>d__.<>4__this = this;
			<dispatcherTimer_Tick>d__.sender = sender;
			<dispatcherTimer_Tick>d__.e = e;
			<dispatcherTimer_Tick>d__.<>1__state = -1;
			<dispatcherTimer_Tick>d__.<>t__builder.Start<ucDashboard.<dispatcherTimer_Tick>d__4>(ref <dispatcherTimer_Tick>d__);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000D394 File Offset: 0x0000B594
		[DebuggerStepThrough]
		private void SendAttackBTN_Click(object sender, RoutedEventArgs e)
		{
			ucDashboard.<SendAttackBTN_Click>d__5 <SendAttackBTN_Click>d__ = new ucDashboard.<SendAttackBTN_Click>d__5();
			<SendAttackBTN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendAttackBTN_Click>d__.<>4__this = this;
			<SendAttackBTN_Click>d__.sender = sender;
			<SendAttackBTN_Click>d__.e = e;
			<SendAttackBTN_Click>d__.<>1__state = -1;
			<SendAttackBTN_Click>d__.<>t__builder.Start<ucDashboard.<SendAttackBTN_Click>d__5>(ref <SendAttackBTN_Click>d__);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/ucdashboard.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000D40C File Offset: 0x0000B60C
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.TotalUsers = (Label)target;
				break;
			case 2:
				this.ServersOnline = (Label)target;
				break;
			case 3:
				this.TopMethod = (Label)target;
				break;
			case 4:
				this.newsHost = (StackPanel)target;
				break;
			case 5:
				this.totalattacks = (Label)target;
				break;
			case 6:
				this.membership = (Label)target;
				break;
			case 7:
				this.maxtime = (Label)target;
				break;
			case 8:
				this.cooldown = (Label)target;
				break;
			case 9:
				this.conc = (Label)target;
				break;
			case 10:
				this.OpenDiscordBTN = (Button)target;
				this.OpenDiscordBTN.Click += this.SendAttackBTN_Click;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x04000271 RID: 625
		internal Label TotalUsers;

		// Token: 0x04000272 RID: 626
		internal Label ServersOnline;

		// Token: 0x04000273 RID: 627
		internal Label TopMethod;

		// Token: 0x04000274 RID: 628
		internal StackPanel newsHost;

		// Token: 0x04000275 RID: 629
		internal Label totalattacks;

		// Token: 0x04000276 RID: 630
		internal Label membership;

		// Token: 0x04000277 RID: 631
		internal Label maxtime;

		// Token: 0x04000278 RID: 632
		internal Label cooldown;

		// Token: 0x04000279 RID: 633
		internal Label conc;

		// Token: 0x0400027A RID: 634
		internal Button OpenDiscordBTN;

		// Token: 0x0400027B RID: 635
		private bool _contentLoaded;
	}
}
