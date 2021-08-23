using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AstroStrike.Modules;
using AstroStrike.User_Controls.Notifications;

namespace AstroStrike.User_Controls
{
	// Token: 0x0200003D RID: 61
	public class ucHub : UserControl, IComponentConnector, IStyleConnector
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		public ucHub()
		{
			this.InitializeComponent();
			this.OnLoad();
			SettingsModel settingsModel = SettingsManager.Load();
			this.countLBL.Content = settingsModel.AttackLogList.Count;
			foreach (Attack attack in settingsModel.AttackLogList)
			{
				Attack newItem = new Attack
				{
					Target = attack.Target,
					Port = attack.Port,
					Time = attack.Time,
					Method = attack.Method,
					Server = attack.Server
				};
				this.dgAttackHub.Items.Add(newItem);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		[DebuggerStepThrough]
		private void OnLoad()
		{
			ucHub.<OnLoad>d__2 <OnLoad>d__ = new ucHub.<OnLoad>d__2();
			<OnLoad>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<OnLoad>d__.<>4__this = this;
			<OnLoad>d__.<>1__state = -1;
			<OnLoad>d__.<>t__builder.Start<ucHub.<OnLoad>d__2>(ref <OnLoad>d__);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000272C File Offset: 0x0000092C
		private void btnBack2Hub_Click(object sender, RoutedEventArgs e)
		{
			this.bGeoLocation.Visibility = Visibility.Hidden;
			this.bTargetInfo.Visibility = Visibility.Visible;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		[DebuggerStepThrough]
		private void btnGEO_Click(object sender, RoutedEventArgs e)
		{
			ucHub.<btnGEO_Click>d__4 <btnGEO_Click>d__ = new ucHub.<btnGEO_Click>d__4();
			<btnGEO_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<btnGEO_Click>d__.<>4__this = this;
			<btnGEO_Click>d__.sender = sender;
			<btnGEO_Click>d__.e = e;
			<btnGEO_Click>d__.<>1__state = -1;
			<btnGEO_Click>d__.<>t__builder.Start<ucHub.<btnGEO_Click>d__4>(ref <btnGEO_Click>d__);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000C130 File Offset: 0x0000A330
		private void AddNewLog()
		{
			SettingsModel settingsModel = SettingsManager.Load();
			SettingsModel settingsModel2 = settingsModel;
			int totalAttacksSent = settingsModel2.TotalAttacksSent;
			settingsModel2.TotalAttacksSent = totalAttacksSent + 1;
			settingsModel.AttackLogList.Add(new Attack
			{
				Target = this.host.Text,
				Port = this.port.Text,
				Time = this.time.Text,
				Method = this.method.Text,
				Server = this.server.SelectedItem.ToString()
			});
			settingsModel.Save();
			this.dgAttackHub.Items.Clear();
			foreach (Attack attack in settingsModel.AttackLogList)
			{
				Attack newItem = new Attack
				{
					Target = attack.Target,
					Port = attack.Port,
					Time = attack.Time,
					Method = attack.Method,
					Server = attack.Server
				};
				this.dgAttackHub.Items.Add(newItem);
			}
			this.countLBL.Content = settingsModel.AttackLogList.Count;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000C284 File Offset: 0x0000A484
		[DebuggerStepThrough]
		private void SendAttackBTN_Click(object sender, RoutedEventArgs e)
		{
			ucHub.<SendAttackBTN_Click>d__7 <SendAttackBTN_Click>d__ = new ucHub.<SendAttackBTN_Click>d__7();
			<SendAttackBTN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SendAttackBTN_Click>d__.<>4__this = this;
			<SendAttackBTN_Click>d__.sender = sender;
			<SendAttackBTN_Click>d__.e = e;
			<SendAttackBTN_Click>d__.<>1__state = -1;
			<SendAttackBTN_Click>d__.<>t__builder.Start<ucHub.<SendAttackBTN_Click>d__7>(ref <SendAttackBTN_Click>d__);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		private void DeleteAllLogs_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			if (settingsModel.AttackLogList.Count == 0)
			{
				MessageHost.warningBox("WARNING", "Attack list already cleared", 5);
			}
			else
			{
				settingsModel.AttackLogList.Clear();
				settingsModel.Save();
				this.dgAttackHub.Items.Clear();
				this.countLBL.Content = "0";
				MessageHost.successBox("SUCCESS", "Attack list cleared successfully", 5);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000C344 File Offset: 0x0000A544
		private void btnPing_Click(object sender, RoutedEventArgs e)
		{
			string text = (this.dgAttackHub.SelectedCells[0].Column.GetCellContent(this.dgAttackHub.SelectedCells[0].Item) as TextBlock).Text;
			Process.Start("CMD.exe", "/K mode con lines=25 cols=60 & ping " + text + " -t");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		private void btnAutoFill_Click(object sender, RoutedEventArgs e)
		{
			string text = (this.dgAttackHub.SelectedCells[0].Column.GetCellContent(this.dgAttackHub.SelectedCells[0].Item) as TextBlock).Text;
			string text2 = (this.dgAttackHub.SelectedCells[1].Column.GetCellContent(this.dgAttackHub.SelectedCells[1].Item) as TextBlock).Text;
			string text3 = (this.dgAttackHub.SelectedCells[2].Column.GetCellContent(this.dgAttackHub.SelectedCells[2].Item) as TextBlock).Text;
			this.host.Text = text;
			this.port.Text = text2;
			this.time.Text = text3;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		private void PingBTN_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.host.Text))
			{
				Process.Start("CMD.exe", "/K mode con lines=25 cols=60 & ping " + this.host.Text + " -t");
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		private void server_DropDownClosed(object sender, EventArgs e)
		{
			try
			{
				ServerInfo serverInfo = this.ServerList[this.server.Text];
				this.method.ItemsSource = serverInfo.Methods;
				ucHub.IPSlot = serverInfo.IPSlot;
				ucHub.SafeResp = serverInfo.SafeResponse;
			}
			catch
			{
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000C54C File Offset: 0x0000A74C
		private void TCPBTN_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.host.Text) && !string.IsNullOrWhiteSpace(this.port.Text))
			{
				try
				{
					Process.GetProcessesByName("paping");
					new Process
					{
						StartInfo = 
						{
							UseShellExecute = false,
							FileName = "paping.exe",
							Arguments = this.host.Text + " -p " + this.port.Text
						}
					}.Start();
				}
				catch
				{
					MessageHost.warningBox("WARNING", "paping.exe was not found", 5);
				}
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000C604 File Offset: 0x0000A804
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/uchub.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000C634 File Offset: 0x0000A834
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.APIResponse = (TextBlock)target;
				return;
			case 2:
				this.bGeoLocation = (Border)target;
				return;
			case 3:
				this.country = (Label)target;
				return;
			case 4:
				this.region = (Label)target;
				return;
			case 5:
				this.city = (Label)target;
				return;
			case 6:
				this.org = (Label)target;
				return;
			case 7:
				this._protected = (Label)target;
				return;
			case 8:
				this.timezone = (Label)target;
				return;
			case 9:
				this.btnBack2Hub = (Button)target;
				this.btnBack2Hub.Click += this.btnBack2Hub_Click;
				return;
			case 10:
				this.countLBL = (Label)target;
				return;
			case 11:
				this.dgAttackHub = (DataGrid)target;
				return;
			case 14:
				this.DeleteAllLogs = (Button)target;
				this.DeleteAllLogs.Click += this.DeleteAllLogs_Click;
				return;
			case 15:
				this.bTargetInfo = (Border)target;
				return;
			case 16:
				this.host = (TextBox)target;
				return;
			case 17:
				this.port = (TextBox)target;
				return;
			case 18:
				this.time = (TextBox)target;
				return;
			case 19:
				this.server = (ComboBox)target;
				this.server.DropDownClosed += this.server_DropDownClosed;
				return;
			case 20:
				this.method = (ComboBox)target;
				return;
			case 21:
				this.SendAttackBTN = (Button)target;
				this.SendAttackBTN.Click += this.SendAttackBTN_Click;
				return;
			case 22:
				this.PingBTN = (Button)target;
				this.PingBTN.Click += this.PingBTN_Click;
				return;
			case 23:
				this.TCPBTN = (Button)target;
				this.TCPBTN.Click += this.TCPBTN_Click;
				return;
			case 24:
				this.btnGEO = (Button)target;
				this.btnGEO.Click += this.btnGEO_Click;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId != 12)
			{
				if (connectionId == 13)
				{
					((Button)target).Click += this.btnAutoFill_Click;
				}
			}
			else
			{
				((Button)target).Click += this.btnPing_Click;
			}
		}

		// Token: 0x0400023E RID: 574
		public Dictionary<string, ServerInfo> ServerList;

		// Token: 0x0400023F RID: 575
		private bool IsAttackEnabled = true;

		// Token: 0x04000240 RID: 576
		private static string IPSlot;

		// Token: 0x04000241 RID: 577
		private static bool SafeResp;

		// Token: 0x04000242 RID: 578
		internal TextBlock APIResponse;

		// Token: 0x04000243 RID: 579
		internal Border bGeoLocation;

		// Token: 0x04000244 RID: 580
		internal Label country;

		// Token: 0x04000245 RID: 581
		internal Label region;

		// Token: 0x04000246 RID: 582
		internal Label city;

		// Token: 0x04000247 RID: 583
		internal Label org;

		// Token: 0x04000248 RID: 584
		internal Label _protected;

		// Token: 0x04000249 RID: 585
		internal Label timezone;

		// Token: 0x0400024A RID: 586
		internal Button btnBack2Hub;

		// Token: 0x0400024B RID: 587
		internal Label countLBL;

		// Token: 0x0400024C RID: 588
		internal DataGrid dgAttackHub;

		// Token: 0x0400024D RID: 589
		internal Button DeleteAllLogs;

		// Token: 0x0400024E RID: 590
		internal Border bTargetInfo;

		// Token: 0x0400024F RID: 591
		internal TextBox host;

		// Token: 0x04000250 RID: 592
		internal TextBox port;

		// Token: 0x04000251 RID: 593
		internal TextBox time;

		// Token: 0x04000252 RID: 594
		internal ComboBox server;

		// Token: 0x04000253 RID: 595
		internal ComboBox method;

		// Token: 0x04000254 RID: 596
		internal Button SendAttackBTN;

		// Token: 0x04000255 RID: 597
		internal Button PingBTN;

		// Token: 0x04000256 RID: 598
		internal Button TCPBTN;

		// Token: 0x04000257 RID: 599
		internal Button btnGEO;

		// Token: 0x04000258 RID: 600
		private bool _contentLoaded;
	}
}
