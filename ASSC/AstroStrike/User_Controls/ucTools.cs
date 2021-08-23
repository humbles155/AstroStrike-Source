using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AstroStrike.User_Controls.Notifications;

namespace AstroStrike.User_Controls
{
	// Token: 0x02000038 RID: 56
	public class ucTools : UserControl, IComponentConnector
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00002703 File Offset: 0x00000903
		public ucTools()
		{
			this.InitializeComponent();
			this.lol.Height = 518.0;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000B3AC File Offset: 0x000095AC
		[DebuggerStepThrough]
		private void GeoLocationBTN_Click(object sender, RoutedEventArgs e)
		{
			ucTools.<GeoLocationBTN_Click>d__1 <GeoLocationBTN_Click>d__ = new ucTools.<GeoLocationBTN_Click>d__1();
			<GeoLocationBTN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GeoLocationBTN_Click>d__.<>4__this = this;
			<GeoLocationBTN_Click>d__.sender = sender;
			<GeoLocationBTN_Click>d__.e = e;
			<GeoLocationBTN_Click>d__.<>1__state = -1;
			<GeoLocationBTN_Click>d__.<>t__builder.Start<ucTools.<GeoLocationBTN_Click>d__1>(ref <GeoLocationBTN_Click>d__);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000B3F4 File Offset: 0x000095F4
		private void ScanPortBTN_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.porthost.Text) && !string.IsNullOrWhiteSpace(this.porthost.Text))
			{
				try
				{
					TcpClient tcpClient = new TcpClient();
					if (tcpClient.ConnectAsync(this.porthost.Text, Convert.ToInt32(this.portport.Text)).Wait(300))
					{
						this.status.Content = "Successful";
						this.response.Content = "Port is open";
					}
					else
					{
						this.status.Content = "Failure";
						this.response.Content = "Port is closed";
					}
				}
				catch
				{
					MessageHost.dangerBox("Port Scan", "Invalid arguments", 5);
				}
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000B4C8 File Offset: 0x000096C8
		[DebuggerStepThrough]
		private void NmapScanBTN_Click(object sender, RoutedEventArgs e)
		{
			ucTools.<NmapScanBTN_Click>d__4 <NmapScanBTN_Click>d__ = new ucTools.<NmapScanBTN_Click>d__4();
			<NmapScanBTN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<NmapScanBTN_Click>d__.<>4__this = this;
			<NmapScanBTN_Click>d__.sender = sender;
			<NmapScanBTN_Click>d__.e = e;
			<NmapScanBTN_Click>d__.<>1__state = -1;
			<NmapScanBTN_Click>d__.<>t__builder.Start<ucTools.<NmapScanBTN_Click>d__4>(ref <NmapScanBTN_Click>d__);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000B510 File Offset: 0x00009710
		[DebuggerStepThrough]
		private void DeleteHookBTN_Click(object sender, RoutedEventArgs e)
		{
			ucTools.<DeleteHookBTN_Click>d__5 <DeleteHookBTN_Click>d__ = new ucTools.<DeleteHookBTN_Click>d__5();
			<DeleteHookBTN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<DeleteHookBTN_Click>d__.<>4__this = this;
			<DeleteHookBTN_Click>d__.sender = sender;
			<DeleteHookBTN_Click>d__.e = e;
			<DeleteHookBTN_Click>d__.<>1__state = -1;
			<DeleteHookBTN_Click>d__.<>t__builder.Start<ucTools.<DeleteHookBTN_Click>d__5>(ref <DeleteHookBTN_Click>d__);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000B558 File Offset: 0x00009758
		[DebuggerStepThrough]
		private void SendMSG_Click(object sender, RoutedEventArgs e)
		{
			ucTools.<SendMSG_Click>d__6 <SendMSG_Click>d__ = new ucTools.<SendMSG_Click>d__6();
			<SendMSG_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendMSG_Click>d__.<>4__this = this;
			<SendMSG_Click>d__.sender = sender;
			<SendMSG_Click>d__.e = e;
			<SendMSG_Click>d__.<>1__state = -1;
			<SendMSG_Click>d__.<>t__builder.Start<ucTools.<SendMSG_Click>d__6>(ref <SendMSG_Click>d__);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000B5A0 File Offset: 0x000097A0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/uctools.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000B5D0 File Offset: 0x000097D0
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.lol = (ScrollViewer)target;
				break;
			case 2:
				this.country = (Label)target;
				break;
			case 3:
				this.region = (Label)target;
				break;
			case 4:
				this.city = (Label)target;
				break;
			case 5:
				this.org = (Label)target;
				break;
			case 6:
				this._protected = (Label)target;
				break;
			case 7:
				this.timezone = (Label)target;
				break;
			case 8:
				this.host = (TextBox)target;
				break;
			case 9:
				this.GeoLocationBTN = (Button)target;
				this.GeoLocationBTN.Click += this.GeoLocationBTN_Click;
				break;
			case 10:
				this.NmapScanBTN = (Button)target;
				this.NmapScanBTN.Click += this.NmapScanBTN_Click;
				break;
			case 11:
				this.status = (Label)target;
				break;
			case 12:
				this.response = (Label)target;
				break;
			case 13:
				this.ScanPortBTN = (Button)target;
				this.ScanPortBTN.Click += this.ScanPortBTN_Click;
				break;
			case 14:
				this.porthost = (TextBox)target;
				break;
			case 15:
				this.portport = (TextBox)target;
				break;
			case 16:
				this.url = (TextBox)target;
				break;
			case 17:
				this.username = (TextBox)target;
				break;
			case 18:
				this.content = (TextBox)target;
				break;
			case 19:
				this.SendMSG = (Button)target;
				this.SendMSG.Click += this.SendMSG_Click;
				break;
			case 20:
				this.DeleteHookBTN = (Button)target;
				this.DeleteHookBTN.Click += this.DeleteHookBTN_Click;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x04000207 RID: 519
		private bool IsScanDone = true;

		// Token: 0x04000208 RID: 520
		internal ScrollViewer lol;

		// Token: 0x04000209 RID: 521
		internal Label country;

		// Token: 0x0400020A RID: 522
		internal Label region;

		// Token: 0x0400020B RID: 523
		internal Label city;

		// Token: 0x0400020C RID: 524
		internal Label org;

		// Token: 0x0400020D RID: 525
		internal Label _protected;

		// Token: 0x0400020E RID: 526
		internal Label timezone;

		// Token: 0x0400020F RID: 527
		internal TextBox host;

		// Token: 0x04000210 RID: 528
		internal Button GeoLocationBTN;

		// Token: 0x04000211 RID: 529
		internal Button NmapScanBTN;

		// Token: 0x04000212 RID: 530
		internal Label status;

		// Token: 0x04000213 RID: 531
		internal Label response;

		// Token: 0x04000214 RID: 532
		internal Button ScanPortBTN;

		// Token: 0x04000215 RID: 533
		internal TextBox porthost;

		// Token: 0x04000216 RID: 534
		internal TextBox portport;

		// Token: 0x04000217 RID: 535
		internal TextBox url;

		// Token: 0x04000218 RID: 536
		internal TextBox username;

		// Token: 0x04000219 RID: 537
		internal TextBox content;

		// Token: 0x0400021A RID: 538
		internal Button SendMSG;

		// Token: 0x0400021B RID: 539
		internal Button DeleteHookBTN;

		// Token: 0x0400021C RID: 540
		private bool _contentLoaded;
	}
}
