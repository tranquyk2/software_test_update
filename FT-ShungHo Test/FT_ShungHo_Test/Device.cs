using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FT_ShungHo_Test
{
	// Token: 0x02000004 RID: 4
	public partial class Device : Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002AD8 File Offset: 0x00000CD8
		public Device()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022C4 File Offset: 0x000004C4
		private void button3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002AF4 File Offset: 0x00000CF4
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = this.comboBox1.Text != VariableCommon.comload1save || this.comboBox3.Text != VariableCommon.comPowerMeter1save || this.comboBox10.Text != VariableCommon.comACSource1save || this.comboBox14.Text != VariableCommon.complcsave;
			if (flag)
			{
				VariableCommon.comload1save = this.comboBox1.Text;
				VariableCommon.comPowerMeter1save = this.comboBox3.Text;
				VariableCommon.comACSource1save = this.comboBox10.Text;
				VariableCommon.complcsave = this.comboBox14.Text;
			}
			bool flag2 = MessageBox.Show("Bạn có muốn thay đổi cài đặt ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes;
			if (flag2)
			{
				this.SaveInitialSystemParam(VariableCommon.configFile);
				Application.Restart();
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002BD4 File Offset: 0x00000DD4
		private void btnDefaults_Click(object sender, EventArgs e)
		{
			this.comboBox1.Text = VariableCommon.comload1save;
			this.comboBox3.Text = VariableCommon.comPowerMeter1save;
			this.comboBox10.Text = VariableCommon.comACSource1save;
			this.comboBox14.Text = VariableCommon.complcsave;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002C28 File Offset: 0x00000E28
		private void SaveInitialSystemParam(string path)
		{
			new SystemSetting();
			this.systemSetting.ConfigName = "SystemSetting.xml";
			this.systemSetting.EnableComPLC = true;
			this.systemSetting.ComPLCPort = VariableCommon.complcsave;
			this.systemSetting.ComPLCBaudrate = 9600;
			this.systemSetting.ComPLCStopBit = 1;
			this.systemSetting.ComPLCParity = "Even";
			this.systemSetting.ComPLCDataBit = 7;
			this.systemSetting.EnableComLoad1 = true;
			this.systemSetting.ComLoad1Port = VariableCommon.comload1save;
			this.systemSetting.ComLoad1Baudrate = 9600;
			this.systemSetting.ComLoad1StopBit = 1;
			this.systemSetting.ComLoad1Parity = "None";
			this.systemSetting.ComLoad1DataBit = 8;
			this.systemSetting.EnableComPowermeter1 = true;
			this.systemSetting.ComPowerMeter1Port = VariableCommon.comPowerMeter1save;
			this.systemSetting.ComPowerMeter1Baudrate = 9600;
			this.systemSetting.ComPowerMeter1StopBit = 1;
			this.systemSetting.ComPowerMeter1Parity = "None";
			this.systemSetting.ComPowerMeter1DataBit = 8;
			this.systemSetting.EnableACSource1 = true;
			this.systemSetting.ComACSource1Port = VariableCommon.comACSource1save;
			this.systemSetting.ComACSource1Baudrate = 9600;
			this.systemSetting.ComACSource1StopBit = 1;
			this.systemSetting.ComACSource1Parity = "None";
			this.systemSetting.ComACSource1DataBit = 8;
			SystemSetting.WriteXML<SystemSetting>(this.systemSetting, path);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002DC4 File Offset: 0x00000FC4
		private void Device_Load(object sender, EventArgs e)
		{
			this.comboBox1.Text = VariableCommon.comload1save;
			this.comboBox3.Text = VariableCommon.comPowerMeter1save;
			this.comboBox10.Text = VariableCommon.comACSource1save;
			this.comboBox14.Text = VariableCommon.complcsave;
		}

		// Token: 0x0400000A RID: 10
		private SystemSetting systemSetting = new SystemSetting();
	}
}
