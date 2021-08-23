using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AstroStrike.Modules;
using AstroStrike.User_Controls.Notifications;

namespace AstroStrike.User_Controls
{
	// Token: 0x02000030 RID: 48
	public class ucEnemyLogger : UserControl, IComponentConnector, IStyleConnector
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00002516 File Offset: 0x00000716
		public ucEnemyLogger()
		{
			this.InitializeComponent();
			this.LoadLogs();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007ACC File Offset: 0x00005CCC
		private void LoadLogs()
		{
			SettingsModel settingsModel = SettingsManager.Load();
			this.dgAttackHub.Items.Clear();
			this.countLBL.Content = settingsModel.EnemyList.Count;
			foreach (EnemyLog enemyLog in settingsModel.EnemyList)
			{
				EnemyLog newItem = new EnemyLog
				{
					Username = enemyLog.Username,
					Host = enemyLog.Host,
					Port = enemyLog.Port,
					Type = enemyLog.Type
				};
				this.dgAttackHub.Items.Add(newItem);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007B94 File Offset: 0x00005D94
		private void AddUserBTN_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.username.Text) && !string.IsNullOrWhiteSpace(this.host.Text))
			{
				SettingsModel settingsModel = SettingsManager.Load();
				if (settingsModel.EnemyList.Any((EnemyLog user) => user.Username == this.username.Text))
				{
					MessageHost.warningBox("Enemy Logger", "Username already exist in log", 5);
				}
				else
				{
					settingsModel.EnemyList.Add(new EnemyLog
					{
						Username = this.username.Text,
						Host = this.host.Text,
						Port = (string.IsNullOrWhiteSpace(this.port.Text) ? "80" : this.port.Text),
						Reason = (string.IsNullOrWhiteSpace(this.reason.Text) ? "None" : this.reason.Text),
						Type = (string.IsNullOrWhiteSpace(this.type.Text) ? "PC" : this.type.Text),
						TimeEntered = DateTime.Now
					});
					settingsModel.Save();
					MessageHost.successBox("Enemy Logger", "Successfully added new enemy", 5);
					this.LoadLogs();
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007CD8 File Offset: 0x00005ED8
		private void btnMore_Click(object sender, RoutedEventArgs e)
		{
			string user = (this.dgAttackHub.SelectedCells[0].Column.GetCellContent(this.dgAttackHub.SelectedCells[0].Item) as TextBlock).Text;
			SettingsModel settingsModel = SettingsManager.Load();
			EnemyLog enemyLog = settingsModel.EnemyList.Find((EnemyLog x) => x.Username == user);
			MessageBox.Show(string.Format("Username: {0}\nHost: {1}\nPort: {2}\nReason: {3}\nType: {4}\nTime Logged: {5}", new object[]
			{
				enemyLog.Username,
				enemyLog.Host,
				enemyLog.Port,
				enemyLog.Reason,
				enemyLog.Type,
				enemyLog.TimeEntered
			}), "About Enemy", MessageBoxButton.OK, MessageBoxImage.Asterisk);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007DAC File Offset: 0x00005FAC
		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			string user = (this.dgAttackHub.SelectedCells[0].Column.GetCellContent(this.dgAttackHub.SelectedCells[0].Item) as TextBlock).Text;
			SettingsModel settingsModel = SettingsManager.Load();
			settingsModel.EnemyList.Remove(settingsModel.EnemyList.First((EnemyLog x) => x.Username == user));
			settingsModel.Save();
			MessageHost.infoBox("Enemy Logger", "User removed from logs", 5);
			this.LoadLogs();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007E4C File Offset: 0x0000604C
		private void btnCopy_Click(object sender, RoutedEventArgs e)
		{
			string text = (this.dgAttackHub.SelectedCells[0].Column.GetCellContent(this.dgAttackHub.SelectedCells[0].Item) as TextBlock).Text;
			string text2 = (this.dgAttackHub.SelectedCells[1].Column.GetCellContent(this.dgAttackHub.SelectedCells[1].Item) as TextBlock).Text;
			string text3 = (this.dgAttackHub.SelectedCells[2].Column.GetCellContent(this.dgAttackHub.SelectedCells[2].Item) as TextBlock).Text;
			Clipboard.SetText(string.Concat(new string[]
			{
				text,
				":",
				text2,
				":",
				text3
			}));
			MessageHost.infoBox("Enemy Logger", "User copied to your clipboard", 5);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007F5C File Offset: 0x0000615C
		private void ClearAllBTN_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			if (settingsModel.EnemyList.Count != 0)
			{
				settingsModel.EnemyList.Clear();
				settingsModel.Save();
				this.LoadLogs();
				MessageHost.infoBox("Enemy Logger", "List cleared successfully", 5);
			}
			else
			{
				MessageHost.warningBox("Enemy Logger", "List is already empty", 5);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007FB8 File Offset: 0x000061B8
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocator = new Uri("/AstroStrike;component/user%20controls/ucenemylogger.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00007FE8 File Offset: 0x000061E8
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.AddUserBTN = (Button)target;
				this.AddUserBTN.Click += this.AddUserBTN_Click;
				return;
			case 2:
				this.type = (ComboBox)target;
				return;
			case 3:
				this.username = (TextBox)target;
				return;
			case 4:
				this.host = (TextBox)target;
				return;
			case 5:
				this.port = (TextBox)target;
				return;
			case 6:
				this.reason = (TextBox)target;
				return;
			case 7:
				this.countLBL = (Label)target;
				return;
			case 8:
				this.dgAttackHub = (DataGrid)target;
				return;
			case 12:
				this.ClearAllBTN = (Button)target;
				this.ClearAllBTN.Click += this.ClearAllBTN_Click;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000080F0 File Offset: 0x000062F0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 9:
				((Button)target).Click += this.btnMore_Click;
				break;
			case 10:
				((Button)target).Click += this.btnDelete_Click;
				break;
			case 11:
				((Button)target).Click += this.btnCopy_Click;
				break;
			}
		}

		// Token: 0x04000180 RID: 384
		internal Button AddUserBTN;

		// Token: 0x04000181 RID: 385
		internal ComboBox type;

		// Token: 0x04000182 RID: 386
		internal TextBox username;

		// Token: 0x04000183 RID: 387
		internal TextBox host;

		// Token: 0x04000184 RID: 388
		internal TextBox port;

		// Token: 0x04000185 RID: 389
		internal TextBox reason;

		// Token: 0x04000186 RID: 390
		internal Label countLBL;

		// Token: 0x04000187 RID: 391
		internal DataGrid dgAttackHub;

		// Token: 0x04000188 RID: 392
		internal Button ClearAllBTN;

		// Token: 0x04000189 RID: 393
		private bool _contentLoaded;
	}
}
