using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FT_ShungHo_Test.Properties;
using HVLModbus.DeltaElectronics;
using Zen.Barcode;

namespace FT_ShungHo_Test
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x0000445C File Offset: 0x0000265C
		public Form1()
		{
			this.InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000450E File Offset: 0x0000270E
		private void tsbIntrusment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000450E File Offset: 0x0000270E
		private void tsbSetting_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004511 File Offset: 0x00002711
		private void tsbExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000451A File Offset: 0x0000271A
		private void tsbComport_Click(object sender, EventArgs e)
		{
			new Device().ShowDialog();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004528 File Offset: 0x00002728
		private void thToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutUs().ShowDialog();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004538 File Offset: 0x00002738
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.lbTime.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004564 File Offset: 0x00002764
		public void SavePassRate(string filePath, string model, int tong, int pass, int fail)
		{
			string text = "Model:" + model + "\r\n";
			text = text + "Total:\r\n" + tong.ToString() + "\r\n";
			text = text + "Pass:\r\n" + pass.ToString() + "\r\n";
			text = text + "Fail:\r\n" + fail.ToString();
			using (StreamWriter streamWriter = new StreamWriter(filePath, false))
			{
				streamWriter.WriteLine(text);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000045F8 File Offset: 0x000027F8
		private void SaveReportFile(string path, string model)
		{
			this.fileNameFolder = Path.GetFileNameWithoutExtension(path);
			this.fileReport = string.Concat(new string[]
			{
				VariableCommon.reportPath,
				"\\",
				this.fileNameFolder,
				"\\",
				this.FormatNgayCasx(),
				".csv"
			});
			bool flag = Directory.Exists(VariableCommon.reportPath + "\\" + this.fileNameFolder);
			if (flag)
			{
				bool flag2 = File.Exists(this.fileReport);
				if (flag2)
				{
					return;
				}
				using (StreamWriter streamWriter = new StreamWriter(this.fileReport, false))
				{
					streamWriter.WriteLine(model);
					string value = string.Concat(new string[]
					{
						"No",
						",",
						VariableCommon.acInputparam[0].ToString() + " load 0%",
						",",
						VariableCommon.acInputparam[1].ToString() + " load 0%",
						",",
						VariableCommon.acInputparam[2].ToString() + " load 0%",
						",",
						VariableCommon.acInputparam[3].ToString() + " load 50%",
						",",
						VariableCommon.acInputparam[4].ToString() + " load 50%",
						",",
						VariableCommon.acInputparam[5].ToString() + " load 50%",
						",",
						VariableCommon.acInputparam[6].ToString() + " load 50%",
						",",
						VariableCommon.acInputparam[7].ToString() + " load 100%",
						",",
						VariableCommon.acInputparam[8].ToString() + " load 100%",
						",",
						VariableCommon.acInputparam[9].ToString() + " load 100%",
						",",
						"OCP",
						",",
						"SHORT TEST",
						",",
						"Power",
						",",
						"STATUS"
					});
					streamWriter.WriteLine(value);
					return;
				}
			}
			Directory.CreateDirectory(VariableCommon.reportPath + "\\" + this.fileNameFolder);
			using (StreamWriter streamWriter2 = new StreamWriter(this.fileReport, false))
			{
				streamWriter2.WriteLine(model);
				string value2 = string.Concat(new string[]
				{
					"No",
					",",
					VariableCommon.acInputparam[0].ToString() + " load 0%",
					",",
					VariableCommon.acInputparam[1].ToString() + " load 0%",
					",",
					VariableCommon.acInputparam[2].ToString() + " load 0%",
					",",
					VariableCommon.acInputparam[3].ToString() + " load 50%",
					",",
					VariableCommon.acInputparam[4].ToString() + " load 50%",
					",",
					VariableCommon.acInputparam[5].ToString() + " load 50%",
					",",
					VariableCommon.acInputparam[6].ToString() + " load 50%",
					",",
					VariableCommon.acInputparam[7].ToString() + " load 100%",
					",",
					VariableCommon.acInputparam[8].ToString() + " load 100%",
					",",
					VariableCommon.acInputparam[9].ToString() + " load 100%",
					",",
					"OCP",
					",",
					"SHORT TEST",
					",",
					"Power",
					",",
					"STATUS"
				});
				streamWriter2.WriteLine(value2);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004AF4 File Offset: 0x00002CF4
		private void LoadPassRate(string Pathfile)
		{
			this.fileNameFolder = Path.GetFileNameWithoutExtension(Pathfile);
			this.filePassrate = string.Concat(new string[]
			{
				VariableCommon.passratePath,
				"\\",
				this.fileNameFolder,
				"\\",
				this.FormatNgayCasx(),
				".csv"
			});
			bool flag = !Directory.Exists(VariableCommon.passratePath + "\\" + this.fileNameFolder);
			if (flag)
			{
				VariableCommon.noTotal = (VariableCommon.noPass = (VariableCommon.noFail = 0));
				Directory.CreateDirectory(VariableCommon.passratePath + "\\" + this.fileNameFolder);
				this.SavePassRate(this.filePassrate, this.fileNameFolder, VariableCommon.noTotal, VariableCommon.noPass, VariableCommon.noFail);
			}
			else
			{
				bool flag2 = !File.Exists(this.filePassrate);
				if (flag2)
				{
					VariableCommon.noTotal = (VariableCommon.noPass = (VariableCommon.noFail = 0));
					this.SavePassRate(this.filePassrate, this.fileNameFolder, VariableCommon.noTotal, VariableCommon.noPass, VariableCommon.noFail);
				}
				else
				{
					VariableCommon.noTotal = int.Parse(VariableCommon.ReadTextFile(this.filePassrate, 3));
					VariableCommon.noPass = int.Parse(VariableCommon.ReadTextFile(this.filePassrate, 5));
					VariableCommon.noFail = int.Parse(VariableCommon.ReadTextFile(this.filePassrate, 7));
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004C54 File Offset: 0x00002E54
		public bool CheckCaSX()
		{
			return DateTime.Now.Hour >= 8 && DateTime.Now.Hour <= 19;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004C90 File Offset: 0x00002E90
		public string FormatNgayCasx()
		{
			string text = "";
			bool flag = this.CheckCaSX();
			if (flag)
			{
				text = DateTime.Now.Date.ToString("dd-MM-yyyy") + "_Ngay";
			}
			else
			{
				bool flag2 = DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 7;
				if (flag2)
				{
					bool flag3 = DateTime.Now.Day > 1;
					if (flag3)
					{
						text = string.Concat(new object[]
						{
							(DateTime.Now.Day - 1).ToString().PadLeft(2, '0'),
							"-",
							DateTime.Now.Month.ToString().PadLeft(2, '0'),
							"-",
							DateTime.Now.Year
						});
					}
					else
					{
						switch (DateTime.Now.Month - 1)
						{
						case 1:
							text = (DateTime.Now.Year - 1).ToString() + "1231";
							break;
						case 2:
						{
							bool flag4 = (DateTime.Now.Year % 4 == 0 & DateTime.Now.Year % 100 != 0) | DateTime.Now.Year % 400 == 0;
							if (flag4)
							{
								text = "29-02" + DateTime.Now.Year.ToString();
							}
							else
							{
								text = "28-02" + DateTime.Now.Year.ToString();
							}
							break;
						}
						case 3:
						case 5:
						case 7:
						case 8:
						case 10:
						case 12:
							text = string.Concat(new object[]
							{
								"31-",
								(DateTime.Now.Month - 1).ToString().PadLeft(2, '0'),
								"-",
								DateTime.Now.Year
							});
							break;
						case 4:
						case 6:
						case 9:
						case 11:
							text = string.Concat(new object[]
							{
								"30-",
								(DateTime.Now.Month - 1).ToString().PadLeft(2, '0'),
								"-",
								DateTime.Now.Year
							});
							break;
						}
					}
				}
				else
				{
					text = DateTime.Now.Date.ToString("dd-MM-yyyy");
				}
				text += "_Dem";
			}
			return text;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004F88 File Offset: 0x00003188
		private void LoadSystemParam(string path)
		{
			SystemSetting.ReadXML<SystemSetting>(out this.systemSetting, path);
			this.configName = this.systemSetting.ConfigName;
			this.enableComPLC = this.systemSetting.EnableComPLC;
			this.ComPLCPort = this.systemSetting.ComPLCPort;
			this.ComPLCBaudrate = this.systemSetting.ComPLCBaudrate;
			this.ComPLCStopBit = this.systemSetting.ComPLCStopBit;
			this.ComPLCParity = this.systemSetting.ComPLCParity;
			this.ComPLCDataBit = this.systemSetting.ComPLCDataBit;
			this.enableComLoad1 = this.systemSetting.EnableComLoad1;
			this.ComLoad1Port = this.systemSetting.ComLoad1Port;
			this.ComLoad1Baudrate = this.systemSetting.ComLoad1Baudrate;
			this.ComLoad1Stopbit = this.systemSetting.ComLoad1StopBit;
			this.ComLoad1Parity = this.systemSetting.ComLoad1Parity;
			this.ComLoad1DataBit = this.systemSetting.ComLoad1DataBit;
			this.enableComPowermeter1 = this.systemSetting.EnableComPowermeter1;
			this.ComPowermeter1Port = this.systemSetting.ComPowerMeter1Port;
			this.ComPowermeter1Baudrate = this.systemSetting.ComPowerMeter1Baudrate;
			this.ComPowermeter1StopBit = this.systemSetting.ComPowerMeter1StopBit;
			this.ComPowermeter1Parity = this.systemSetting.ComPowerMeter1Parity;
			this.ComPowermeter1DataBit = this.systemSetting.ComPowerMeter1DataBit;
			this.enableComACSource1 = this.systemSetting.EnableACSource1;
			this.ComACSource1Port = this.systemSetting.ComACSource1Port;
			this.ComACSource1Baudrate = this.systemSetting.ComACSource1Baudrate;
			this.ComACSource1StopBit = this.systemSetting.ComACSource1StopBit;
			this.ComACSource1Parity = this.systemSetting.ComACSource1Parity;
			this.ComACSource1DataBit = this.systemSetting.ComACSource1DataBit;
			VariableCommon.complcsave = this.ComPLCPort;
			VariableCommon.comload1save = this.ComLoad1Port;
			VariableCommon.comPowerMeter1save = this.ComPowermeter1Port;
			VariableCommon.comACSource1save = this.ComACSource1Port;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005178 File Offset: 0x00003378
		private void SaveInitialSystemParam(string path)
		{
			new SystemSetting();
			this.systemSetting.ConfigName = "SystemSetting.xml";
			this.systemSetting.EnableComPLC = true;
			this.systemSetting.ComPLCPort = "COM11";
			this.systemSetting.ComPLCBaudrate = 9600;
			this.systemSetting.ComPLCStopBit = 1;
			this.systemSetting.ComPLCParity = "Even";
			this.systemSetting.ComPLCDataBit = 7;
			this.systemSetting.EnableComLoad1 = true;
			this.systemSetting.ComLoad1Port = "COM12";
			this.systemSetting.ComLoad1Baudrate = 9600;
			this.systemSetting.ComLoad1StopBit = 1;
			this.systemSetting.ComLoad1Parity = "None";
			this.systemSetting.ComLoad1DataBit = 8;
			this.systemSetting.EnableComLoad2 = true;
			this.systemSetting.ComLoad2Port = "COM13";
			this.systemSetting.ComLoad2Baudrate = 9600;
			this.systemSetting.ComLoad2StopBit = 1;
			this.systemSetting.ComLoad2Parity = "None";
			this.systemSetting.ComLoad2DataBit = 8;
			this.systemSetting.EnableComPowermeter1 = true;
			this.systemSetting.ComPowerMeter1Port = "COM14";
			this.systemSetting.ComPowerMeter1Baudrate = 9600;
			this.systemSetting.ComPowerMeter1StopBit = 1;
			this.systemSetting.ComPowerMeter1Parity = "None";
			this.systemSetting.ComPowerMeter1DataBit = 8;
			this.systemSetting.EnableComPowermeter2 = true;
			this.systemSetting.ComPowerMeter2Port = "COM15";
			this.systemSetting.ComPowerMeter2Baudrate = 9600;
			this.systemSetting.ComPowerMeter2StopBit = 1;
			this.systemSetting.ComPowerMeter2Parity = "None";
			this.systemSetting.ComPowerMeter2DataBit = 8;
			this.systemSetting.EnableACSource1 = true;
			this.systemSetting.ComACSource1Port = "COM16";
			this.systemSetting.ComACSource1Baudrate = 9600;
			this.systemSetting.ComACSource1StopBit = 1;
			this.systemSetting.ComACSource1Parity = "None";
			this.systemSetting.ComACSource1DataBit = 8;
			this.systemSetting.EnableACSource2 = true;
			this.systemSetting.ComACSource2Port = "COM17";
			this.systemSetting.ComACSource2Baudrate = 9600;
			this.systemSetting.ComACSource2StopBit = 1;
			this.systemSetting.ComACSource2Parity = "None";
			this.systemSetting.ComACSource2DataBit = 8;
			SystemSetting.WriteXML<SystemSetting>(this.systemSetting, path);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005420 File Offset: 0x00003620
		private bool OpenComPLC(bool enable)
		{
			this.comPLC.PortName = this.ComPLCPort;
			this.comPLC.DataBits = this.ComPLCDataBit;
			this.comPLC.BaudRate = this.ComPLCBaudrate;
			bool flag = this.ComPLCParity == "Even";
			if (flag)
			{
				this.comPLC.Parity = Parity.Even;
			}
			else
			{
				bool flag2 = this.ComPLCParity == "None";
				if (flag2)
				{
					this.comPLC.Parity = Parity.None;
				}
				else
				{
					bool flag3 = this.ComPLCParity == "Odd";
					if (flag3)
					{
						this.comPLC.Parity = Parity.Odd;
					}
					else
					{
						bool flag4 = this.ComPLCParity == "Space";
						if (flag4)
						{
							this.comPLC.Parity = Parity.Space;
						}
						else
						{
							bool flag5 = this.ComPLCParity == "Mark";
							if (flag5)
							{
								this.comPLC.Parity = Parity.Mark;
							}
							else
							{
								this.comPLC.Parity = Parity.Even;
							}
						}
					}
				}
			}
			bool flag6 = this.ComPLCStopBit == 1;
			if (flag6)
			{
				this.comPLC.StopBits = StopBits.One;
			}
			else
			{
				bool flag7 = this.ComPLCStopBit == 1;
				if (flag7)
				{
					this.comPLC.StopBits = StopBits.Two;
				}
				else
				{
					this.comPLC.StopBits = StopBits.One;
				}
			}
			bool result;
			if (enable)
			{
				try
				{
					this.comPLC.Open();
					this.comPLC.DiscardInBuffer();
					this.comPLC.DiscardOutBuffer();
				}
				catch (Exception)
				{
					MessageBox.Show("Kết nối PLC không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				result = true;
			}
			else
			{
				MessageBox.Show("Bạn đã tắt cổng kết nối PLC", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000055FC File Offset: 0x000037FC
		private bool OpenComLoad1(bool enable)
		{
			this.comLoad1.PortName = this.ComLoad1Port;
			this.comLoad1.DataBits = this.ComLoad1DataBit;
			this.comLoad1.BaudRate = this.ComLoad1Baudrate;
			bool flag = this.ComLoad1Parity == "Even";
			if (flag)
			{
				this.comLoad1.Parity = Parity.Even;
			}
			else
			{
				bool flag2 = this.ComLoad1Parity == "None";
				if (flag2)
				{
					this.comLoad1.Parity = Parity.None;
				}
				else
				{
					bool flag3 = this.ComLoad1Parity == "Odd";
					if (flag3)
					{
						this.comLoad1.Parity = Parity.Odd;
					}
					else
					{
						bool flag4 = this.ComLoad1Parity == "Space";
						if (flag4)
						{
							this.comLoad1.Parity = Parity.Space;
						}
						else
						{
							bool flag5 = this.ComLoad1Parity == "Mark";
							if (flag5)
							{
								this.comLoad1.Parity = Parity.Mark;
							}
							else
							{
								this.comLoad1.Parity = Parity.Even;
							}
						}
					}
				}
			}
			bool flag6 = this.ComLoad1Stopbit == 1;
			if (flag6)
			{
				this.comLoad1.StopBits = StopBits.One;
			}
			else
			{
				bool flag7 = this.ComLoad1Stopbit == 1;
				if (flag7)
				{
					this.comLoad1.StopBits = StopBits.Two;
				}
				else
				{
					this.comLoad1.StopBits = StopBits.One;
				}
			}
			bool result;
			if (enable)
			{
				try
				{
					this.comLoad1.Open();
					this.comLoad1.DiscardInBuffer();
					this.comLoad1.DiscardOutBuffer();
				}
				catch (Exception)
				{
					MessageBox.Show("Kết nối Load 1 không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				result = true;
			}
			else
			{
				MessageBox.Show("Bạn đã tắt cổng kết nối Load 1", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000057D8 File Offset: 0x000039D8
		private bool OpenComLoad2(bool enable)
		{
			this.comLoad2.PortName = this.ComLoad2Port;
			this.comLoad2.DataBits = this.ComLoad2DataBit;
			this.comLoad2.BaudRate = this.ComLoad2Baudrate;
			bool flag = this.ComLoad2Parity == "Even";
			if (flag)
			{
				this.comLoad2.Parity = Parity.Even;
			}
			else
			{
				bool flag2 = this.ComLoad2Parity == "None";
				if (flag2)
				{
					this.comLoad2.Parity = Parity.None;
				}
				else
				{
					bool flag3 = this.ComLoad2Parity == "Odd";
					if (flag3)
					{
						this.comLoad2.Parity = Parity.Odd;
					}
					else
					{
						bool flag4 = this.ComLoad2Parity == "Space";
						if (flag4)
						{
							this.comLoad2.Parity = Parity.Space;
						}
						else
						{
							bool flag5 = this.ComLoad2Parity == "Mark";
							if (flag5)
							{
								this.comLoad2.Parity = Parity.Mark;
							}
							else
							{
								this.comLoad2.Parity = Parity.Even;
							}
						}
					}
				}
			}
			bool flag6 = this.ComLoad2Stopbit == 1;
			if (flag6)
			{
				this.comLoad2.StopBits = StopBits.One;
			}
			else
			{
				bool flag7 = this.ComLoad2Stopbit == 1;
				if (flag7)
				{
					this.comLoad2.StopBits = StopBits.Two;
				}
				else
				{
					this.comLoad2.StopBits = StopBits.One;
				}
			}
			bool result;
			if (enable)
			{
				try
				{
					this.comLoad2.Open();
					this.comLoad2.DiscardInBuffer();
					this.comLoad2.DiscardOutBuffer();
				}
				catch (Exception)
				{
					MessageBox.Show("Kết nối Load 2 không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				result = true;
			}
			else
			{
				MessageBox.Show("Bạn đã tắt cổng kết nối Load 2", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000059B4 File Offset: 0x00003BB4
		private bool OpenComPowermeter1(bool enable)
		{
			this.comPowermeter1.PortName = this.ComPowermeter1Port;
			this.comPowermeter1.DataBits = this.ComPowermeter1DataBit;
			this.comPowermeter1.BaudRate = this.ComPowermeter1Baudrate;
			bool flag = this.ComPowermeter1Parity == "Even";
			if (flag)
			{
				this.comPowermeter1.Parity = Parity.Even;
			}
			else
			{
				bool flag2 = this.ComPowermeter1Parity == "None";
				if (flag2)
				{
					this.comPowermeter1.Parity = Parity.None;
				}
				else
				{
					bool flag3 = this.ComPowermeter1Parity == "Odd";
					if (flag3)
					{
						this.comPowermeter1.Parity = Parity.Odd;
					}
					else
					{
						bool flag4 = this.ComPowermeter1Parity == "Space";
						if (flag4)
						{
							this.comPowermeter1.Parity = Parity.Space;
						}
						else
						{
							bool flag5 = this.ComPowermeter1Parity == "Mark";
							if (flag5)
							{
								this.comPowermeter1.Parity = Parity.Mark;
							}
							else
							{
								this.comPowermeter1.Parity = Parity.Even;
							}
						}
					}
				}
			}
			bool flag6 = this.ComPowermeter1StopBit == 1;
			if (flag6)
			{
				this.comPowermeter1.StopBits = StopBits.One;
			}
			else
			{
				bool flag7 = this.ComPowermeter1StopBit == 1;
				if (flag7)
				{
					this.comPowermeter1.StopBits = StopBits.Two;
				}
				else
				{
					this.comPowermeter1.StopBits = StopBits.One;
				}
			}
			bool result;
			if (enable)
			{
				try
				{
					this.comPowermeter1.Open();
					this.comPowermeter1.DiscardInBuffer();
					this.comPowermeter1.DiscardOutBuffer();
				}
				catch (Exception)
				{
					MessageBox.Show("Kết nối Powermeter 1 không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				result = true;
			}
			else
			{
				MessageBox.Show("Bạn đã tắt cổng kết nối Powermeter 1", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005B90 File Offset: 0x00003D90
		private bool OpenComPowermeter2(bool enable)
		{
			this.comPowermeter2.PortName = this.ComPowermeter2Port;
			this.comPowermeter2.DataBits = this.ComPowermeter2DataBit;
			this.comPowermeter2.BaudRate = this.ComPowermeter2Baudrate;
			bool flag = this.ComPowermeter2Parity == "Even";
			if (flag)
			{
				this.comPowermeter2.Parity = Parity.Even;
			}
			else
			{
				bool flag2 = this.ComPowermeter2Parity == "None";
				if (flag2)
				{
					this.comPowermeter2.Parity = Parity.None;
				}
				else
				{
					bool flag3 = this.ComPowermeter2Parity == "Odd";
					if (flag3)
					{
						this.comPowermeter2.Parity = Parity.Odd;
					}
					else
					{
						bool flag4 = this.ComPowermeter2Parity == "Space";
						if (flag4)
						{
							this.comPowermeter2.Parity = Parity.Space;
						}
						else
						{
							bool flag5 = this.ComPowermeter2Parity == "Mark";
							if (flag5)
							{
								this.comPowermeter2.Parity = Parity.Mark;
							}
							else
							{
								this.comPowermeter2.Parity = Parity.Even;
							}
						}
					}
				}
			}
			bool flag6 = this.ComPowermeter2StopBit == 1;
			if (flag6)
			{
				this.comPowermeter2.StopBits = StopBits.One;
			}
			else
			{
				bool flag7 = this.ComPowermeter2StopBit == 1;
				if (flag7)
				{
					this.comPowermeter2.StopBits = StopBits.Two;
				}
				else
				{
					this.comPowermeter2.StopBits = StopBits.One;
				}
			}
			bool result;
			if (enable)
			{
				try
				{
					this.comPowermeter2.Open();
					this.comPowermeter2.DiscardInBuffer();
					this.comPowermeter2.DiscardOutBuffer();
				}
				catch (Exception)
				{
					MessageBox.Show("Kết nối Powermeter 2 không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				result = true;
			}
			else
			{
				MessageBox.Show("Bạn đã tắt cổng kết nối Powermeter 2", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005D6C File Offset: 0x00003F6C
		private bool OpenComAC1(bool enable)
		{
			this.comACSource1.PortName = this.ComACSource1Port;
			this.comACSource1.DataBits = this.ComACSource1DataBit;
			this.comACSource1.BaudRate = this.ComACSource1Baudrate;
			bool flag = this.ComACSource1Parity == "Even";
			if (flag)
			{
				this.comACSource1.Parity = Parity.Even;
			}
			else
			{
				bool flag2 = this.ComACSource1Parity == "None";
				if (flag2)
				{
					this.comACSource1.Parity = Parity.None;
				}
				else
				{
					bool flag3 = this.ComACSource1Parity == "Odd";
					if (flag3)
					{
						this.comACSource1.Parity = Parity.Odd;
					}
					else
					{
						bool flag4 = this.ComACSource1Parity == "Space";
						if (flag4)
						{
							this.comACSource1.Parity = Parity.Space;
						}
						else
						{
							bool flag5 = this.ComACSource1Parity == "Mark";
							if (flag5)
							{
								this.comACSource1.Parity = Parity.Mark;
							}
							else
							{
								this.comACSource1.Parity = Parity.Even;
							}
						}
					}
				}
			}
			bool flag6 = this.ComACSource1StopBit == 1;
			if (flag6)
			{
				this.comACSource1.StopBits = StopBits.One;
			}
			else
			{
				bool flag7 = this.ComACSource1StopBit == 1;
				if (flag7)
				{
					this.comACSource1.StopBits = StopBits.Two;
				}
				else
				{
					this.comACSource1.StopBits = StopBits.One;
				}
			}
			bool result;
			if (enable)
			{
				try
				{
					this.comACSource1.Open();
					this.comACSource1.DiscardInBuffer();
					this.comACSource1.DiscardOutBuffer();
				}
				catch (Exception)
				{
					MessageBox.Show("Kết nối AC source 1 không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				result = true;
			}
			else
			{
				MessageBox.Show("Bạn đã tắt cổng kết nối AC source 1", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005F48 File Offset: 0x00004148
		private bool OpenComAC2(bool enable)
		{
			this.comACSource2.PortName = this.ComACSource2Port;
			this.comACSource2.DataBits = this.ComACSource2DataBit;
			this.comACSource2.BaudRate = this.ComACSource2Baudrate;
			bool flag = this.ComACSource2Parity == "Even";
			if (flag)
			{
				this.comACSource2.Parity = Parity.Even;
			}
			else
			{
				bool flag2 = this.ComACSource2Parity == "None";
				if (flag2)
				{
					this.comACSource2.Parity = Parity.None;
				}
				else
				{
					bool flag3 = this.ComACSource2Parity == "Odd";
					if (flag3)
					{
						this.comACSource2.Parity = Parity.Odd;
					}
					else
					{
						bool flag4 = this.ComACSource2Parity == "Space";
						if (flag4)
						{
							this.comACSource2.Parity = Parity.Space;
						}
						else
						{
							bool flag5 = this.ComACSource2Parity == "Mark";
							if (flag5)
							{
								this.comACSource2.Parity = Parity.Mark;
							}
							else
							{
								this.comACSource2.Parity = Parity.Even;
							}
						}
					}
				}
			}
			bool flag6 = this.ComACSource2StopBit == 1;
			if (flag6)
			{
				this.comACSource2.StopBits = StopBits.One;
			}
			else
			{
				bool flag7 = this.ComACSource2StopBit == 1;
				if (flag7)
				{
					this.comACSource2.StopBits = StopBits.Two;
				}
				else
				{
					this.comACSource2.StopBits = StopBits.One;
				}
			}
			bool result;
			if (enable)
			{
				try
				{
					this.comACSource2.Open();
					this.comACSource2.DiscardInBuffer();
					this.comACSource2.DiscardOutBuffer();
				}
				catch (Exception)
				{
					MessageBox.Show("Kết nối AC source 2 không thành công", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
				result = true;
			}
			else
			{
				MessageBox.Show("Bạn đã tắt cổng kết nối AC source 2", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006124 File Offset: 0x00004324
		public byte[] HexToBytes(string hex)
		{
			bool flag = hex == null;
			if (flag)
			{
				throw new ArgumentNullException("The data is null");
			}
			bool flag2 = hex.Length % 2 != 0;
			if (flag2)
			{
				throw new FormatException("Hex Character Count Not Even");
			}
			byte[] array = new byte[hex.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
			}
			return array;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000061A0 File Offset: 0x000043A0
		public byte CalculateLRC(byte[] data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("The data is null");
			}
			byte b = 0;
			foreach (byte b2 in data)
			{
				b = (byte)(b+ b2);
			}
			return (byte)((int)b ^ 256);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000061F0 File Offset: 0x000043F0
		public string CHECK(string slaveAddr, string command, string funcAddr, string countword, string[] datas)
		{
			string result;
			try
			{
				string text = ("00" + slaveAddr).Right(2);
				string text2 = ("000" + command).Right(2);
				string text3 = ("0000" + funcAddr).Right(4);
				string text4 = ("0000" + countword).Right(4);
				string text5 = ("00" + datas.Length.ToString()).Right(2);
				string text6 = text;
				text6 = string.Concat(new string[]
				{
					text6,
					text2,
					text3,
					text4,
					text5
				});
				for (int i = 0; i < datas.Length; i++)
				{
					text6 += ("00" + datas[i]).Right(2);
				}
				result = ":" + text6 + this.CalculateLRC(this.HexToBytes(text6)).ToString("X2") + "\r";
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006318 File Offset: 0x00004518
		private bool CheckPLCRun()
		{
			string text = Modbus.BuildMessage("1", "11");
			string text2 = null;
			this.comPLC.WriteLine(text);
			Program.delay.Delay1(500.0);
			try
			{
				text2 = this.comPLC.ReadLine();
			}
			catch (Exception)
			{
				MessageBox.Show("Thiết bị điều khiển PLC đã bị dừng. Làm ơn hãy chạy PLC", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			bool flag = text2.Contains(":") && text2.Contains("FF") && text2.Contains("01");
			bool result;
			if (flag)
			{
				bool flag2 = text2.Substring(9, 2) == "FF";
				if (flag2)
				{
					result = true;
				}
				else
				{
					MessageBox.Show("Thiết bị điều khiển PLC đã bị dừng. Làm ơn hãy chạy PLC", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = false;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006400 File Offset: 0x00004600
		public string PLCDeltaFormat(string slaveAddr, string command, string funcAddr, int value)
		{
			string result;
			try
			{
				string text = ("00" + slaveAddr).Right(2);
				string str = ("00" + command).Right(2);
				string str2 = ("0000" + funcAddr).Right(4);
				string str3 = ("0000" + value.ToString("X")).Right(4);
				string text2 = text;
				text2 = text2 + str + str2 + str3;
				result = ":" + text2 + this.CalculateLRC(this.HexToBytes(text2)).ToString("X2") + "\r";
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000064C4 File Offset: 0x000046C4
		private void WriteDataAddress(string address, int value)
		{
			try
			{
				string text = int.Parse(address).ToString("X");
				int length = text.Length;
				switch (length)
				{
				case 1:
					text = "100" + text;
					break;
				case 2:
					text = "10" + text;
					break;
				case 3:
					text = "1" + text;
					break;
				}
				bool flag = length > 0 && length < 4;
				if (flag)
				{
					string text2 = this.PLCDeltaFormat("1", "06", text, value);
					bool comPlcOk = VariableCommon.comPlcOk1;
					if (comPlcOk)
					{
						this.comPLC.WriteLine(text2);
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ghi dữ liệu xuống PLC không thành công , kiểm tra lại kết nối");
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000659C File Offset: 0x0000479C
		private int ReadDataAddress(string address)
		{
			string text = int.Parse(address).ToString("X");
			int length = text.Length;
			int result = 0;
			switch (length)
			{
			case 1:
				text = "100" + text;
				break;
			case 2:
				text = "10" + text;
				break;
			case 3:
				text = "1" + text;
				break;
			}
			try
			{
				bool flag = length > 0 && length < 4;
				if (flag)
				{
					this.comPLC.ReadExisting();
					string text2 = Modbus.BuildMessage("1", "03", text, "1");
					this.comPLC.WriteLine(text2);
					bool flag2 = this.comPLC.NewLine != null;
					if (flag2)
					{
						string text3 = this.comPLC.ReadLine();
						int num = text3.IndexOf(":");
						bool flag3 = text3.Length >= 11 && num > -1 && text3.Contains(":0103");
						if (flag3)
						{
							result = Convert.ToInt32(text3.Substring(num + 7, 4), 16);
						}
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Đọc dữ liệu PLC không thành công, kiểm tra kết nối PLC");
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000066F0 File Offset: 0x000048F0
		private int[] ReadPLCDelta(string fistAddress, int numAddress)
		{
			string text = int.Parse(fistAddress).ToString("X");
			switch (text.Length)
			{
			case 1:
				text = "100" + text;
				break;
			case 2:
				text = "10" + text;
				break;
			case 3:
				text = "1" + text;
				break;
			}
			int[] array = new int[numAddress];
			this.comPLC.DiscardInBuffer();
			this.comPLC.DiscardOutBuffer();
			this.comPLC.ReadExisting();
			string text2 = Modbus.BuildMessage("1", "03", text, numAddress.ToString());
			this.comPLC.WriteLine(text2);
			bool flag = this.comPLC.NewLine != null;
			if (flag)
			{
				string text3 = this.comPLC.ReadLine();
				int num = text3.IndexOf(":");
				bool flag2 = text3.Length >= 11 && num > -1 && text3.Contains(":0103");
				if (flag2)
				{
					for (int i = 0; i < numAddress; i++)
					{
						string value = text3.Substring(num + 7 + 4 * i, 4);
						array[i] = Convert.ToInt32(value, 16);
					}
				}
			}
			return array;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006848 File Offset: 0x00004A48
		public bool CheckComPLC()
		{
			try
			{
				this.comPLC.PortName = VariableCommon.complcsave;
				this.comPLC.BaudRate = 9600;
				this.comPLC.DataBits = 7;
				this.comPLC.Parity = Parity.Even;
				this.comPLC.StopBits = StopBits.One;
				this.comPLC.Open();
				this.comPLC.DiscardInBuffer();
				this.comPLC.DiscardOutBuffer();
			}
			catch (Exception)
			{
				return false;
			}
			return this.CheckPLCRun();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000068E8 File Offset: 0x00004AE8
		private bool SetRemotepowermeter(int noPow)
		{
			bool flag = noPow != 1;
			if (flag)
			{
				bool flag2 = noPow != 2;
				if (flag2)
				{
					return false;
				}
				bool flag3 = this.comPowermeter2Ok;
				if (flag3)
				{
					this.comPowermeter2.WriteLine(ReadWritePowerMetter.setRemoteCommand);
					this.comPowermeter2.WriteLine(ReadWritePowerMetter.getRemoteCommand);
					return this.comPowermeter2.ReadLine() == "1";
				}
			}
			else
			{
				bool flag4 = this.comPowermeter1Ok;
				if (flag4)
				{
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.setRemoteCommand);
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.getRemoteCommand);
					return this.comPowermeter1.ReadLine() == "1";
				}
			}
			return false;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000069AC File Offset: 0x00004BAC
		private void SetFunctionDisplay(int noPower)
		{
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comPowermeter2Ok;
					if (flag3)
					{
						this.comPowermeter2.WriteLine(ReadWritePowerMetter.settingDisplay1functionV);
						this.comPowermeter2.WriteLine(ReadWritePowerMetter.settingDisplay2functionA);
						this.comPowermeter2.WriteLine(ReadWritePowerMetter.settingDisplay3functionW);
					}
				}
			}
			else
			{
				bool flag4 = this.comPowermeter1Ok;
				if (flag4)
				{
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.settingDisplay1functionV);
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.settingDisplay2functionA);
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.settingDisplay3functionW);
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006A5C File Offset: 0x00004C5C
		private void StartCheckPowermeter(int noPower)
		{
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comPowermeter2Ok;
					if (flag3)
					{
						this.comPowermeter2.WriteLine(ReadWritePowerMetter.stopCheckCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.comPowermeter1Ok;
				if (flag4)
				{
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.startCheckCommand);
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006AC4 File Offset: 0x00004CC4
		private void StopCheckPowermeter(int noPower)
		{
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comPowermeter2Ok;
					if (flag3)
					{
						this.comPowermeter2.WriteLine(ReadWritePowerMetter.stopCheckCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.comPowermeter1Ok;
				if (flag4)
				{
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.stopCheckCommand);
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006B2C File Offset: 0x00004D2C
		private void ResetCheckPowermeter(int noPower)
		{
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comPowermeter2Ok;
					if (flag3)
					{
						this.comPowermeter2.WriteLine(ReadWritePowerMetter.resetCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.comPowermeter1Ok;
				if (flag4)
				{
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.resetCommand);
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006B94 File Offset: 0x00004D94
		private void SetVoltageRangePowerMeter(int noPower, double volt)
		{
			ReadWritePowerMetter.VoltageRange = volt;
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comPowermeter2Ok;
					if (flag3)
					{
						this.comPowermeter2.WriteLine(ReadWritePowerMetter.voltageRangeCommand + ReadWritePowerMetter.VoltageRange.ToString() + "V");
					}
				}
			}
			else
			{
				bool flag4 = this.comPowermeter1Ok;
				if (flag4)
				{
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.voltageRangeCommand + ReadWritePowerMetter.VoltageRange.ToString() + "V");
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006C28 File Offset: 0x00004E28
		private void SetCurrentRangePowerMeter(int noPower, double current)
		{
			ReadWritePowerMetter.CurrentRange = current;
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comPowermeter2Ok;
					if (flag3)
					{
						this.comPowermeter2.WriteLine(ReadWritePowerMetter.currentRangeCommand + ReadWritePowerMetter.CurrentRange.ToString() + "A");
					}
				}
			}
			else
			{
				bool flag4 = this.comPowermeter1Ok;
				if (flag4)
				{
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.currentRangeCommand + ReadWritePowerMetter.CurrentRange.ToString() + "A");
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006CBC File Offset: 0x00004EBC
		private string MeasureValuePower(int noPower)
		{
			string result = "";
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (flag2)
				{
					return "";
				}
				bool flag3 = this.comPowermeter2Ok;
				if (flag3)
				{
					this.comPowermeter2.WriteLine(ReadWritePowerMetter.getValueMeasureCommand);
					return this.comPowermeter2.ReadLine();
				}
			}
			else
			{
				bool flag4 = this.comPowermeter1Ok;
				if (flag4)
				{
					this.comPowermeter1.WriteLine(ReadWritePowerMetter.getValueMeasureCommand);
					return this.comPowermeter1.ReadLine();
				}
			}
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006D50 File Offset: 0x00004F50
		private double[] GetMeasureValuePower(int noPower)
		{
			double[] array = new double[128];
			string text = this.MeasureValuePower(noPower);
			bool flag = text != "";
			double[] result;
			if (flag)
			{
				string[] array2 = text.Split(new char[]
				{
					','
				});
				for (int i = 0; i < array2.Length; i++)
				{
					array[i] = Convert.ToDouble(array2[i]);
				}
				result = array;
			}
			else
			{
				result = array;
			}
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006DC8 File Offset: 0x00004FC8
		private void OnOutputACSource(int noPower)
		{
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comAC2Ok;
					if (flag3)
					{
						this.comACSource2.WriteLine(ReadWriteACSource.outputOnCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.comAC1Ok;
				if (flag4)
				{
					this.comACSource1.WriteLine(ReadWriteACSource.outputOnCommand);
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006E30 File Offset: 0x00005030
		private void OffOutputACSource(int noPower)
		{
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comAC2Ok;
					if (flag3)
					{
						this.comACSource2.WriteLine(ReadWriteACSource.outputOffCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.comAC1Ok;
				if (flag4)
				{
					this.comACSource1.WriteLine(ReadWriteACSource.outputOffCommand);
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006E98 File Offset: 0x00005098
		private void SetVoltageOutputACSource(int noPower, double voltage)
		{
			ReadWriteACSource.voltageSetCommand = voltage;
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comAC2Ok;
					if (flag3)
					{
						this.comACSource2.WriteLine(ReadWriteACSource.outputOffCommand);
						Program.delay.Delay1(200.0);
						this.comACSource2.WriteLine(ReadWriteACSource.voltageOutputCommand + ReadWriteACSource.voltageSetCommand.ToString());
						Program.delay.Delay1(200.0);
						this.comACSource2.WriteLine(ReadWriteACSource.outputOnCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.comAC1Ok;
				if (flag4)
				{
					this.comACSource1.WriteLine(ReadWriteACSource.outputOffCommand);
					Program.delay.Delay1(200.0);
					this.comACSource1.WriteLine(ReadWriteACSource.voltageOutputCommand + ReadWriteACSource.voltageSetCommand.ToString());
					Program.delay.Delay1(200.0);
					this.comACSource1.WriteLine(ReadWriteACSource.outputOnCommand);
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006FA8 File Offset: 0x000051A8
		private void SetFreqOutputACSource(int noPower)
		{
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (!flag2)
				{
					bool flag3 = this.comAC2Ok;
					if (flag3)
					{
						this.comACSource2.WriteLine(ReadWriteACSource.freqRangeCommand + ReadWriteACSource.freqSetCommand.ToString());
					}
				}
			}
			else
			{
				bool flag4 = this.comAC1Ok;
				if (flag4)
				{
					this.comACSource1.WriteLine(ReadWriteACSource.freqRangeCommand + ReadWriteACSource.freqSetCommand.ToString());
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000702C File Offset: 0x0000522C
		private string presentVoltACSource(int noPower)
		{
			string result = "";
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (flag2)
				{
					return "";
				}
				bool flag3 = this.comAC2Ok;
				if (flag3)
				{
					this.comACSource2.WriteLine(ReadWriteACSource.queryVoltSetCommand);
					return this.comACSource2.ReadLine();
				}
			}
			else
			{
				bool flag4 = this.comAC1Ok;
				if (flag4)
				{
					this.comACSource1.WriteLine(ReadWriteACSource.queryVoltSetCommand);
					return this.comACSource1.ReadLine();
				}
			}
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000070C0 File Offset: 0x000052C0
		private string presentFreqACSource(int noPower)
		{
			string result = "";
			bool flag = noPower != 1;
			if (flag)
			{
				bool flag2 = noPower != 2;
				if (flag2)
				{
					return "";
				}
				bool flag3 = this.comAC2Ok;
				if (flag3)
				{
					this.comACSource2.WriteLine(ReadWriteACSource.queryFreqSetCommand);
					return this.comACSource2.ReadLine();
				}
			}
			else
			{
				bool flag4 = this.comAC1Ok;
				if (flag4)
				{
					this.comACSource1.WriteLine(ReadWriteACSource.queryFreqSetCommand);
					return this.comACSource1.ReadLine();
				}
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00007154 File Offset: 0x00005354
		private void ClearErrorLoad(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.clearErrorCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.clearErrorCommand);
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000071BC File Offset: 0x000053BC
		private void RemoteLoad(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.systemRemoteCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.systemRemoteCommand);
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007224 File Offset: 0x00005424
		private void OnLoad(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.inputONCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.inputONCommand);
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000728C File Offset: 0x0000548C
		private void OffLoad(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.inputOFFCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.inputOFFCommand);
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000072F4 File Offset: 0x000054F4
		private void OffSense(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.SenseModeOffCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.SenseModeOffCommand);
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000735C File Offset: 0x0000555C
		private void OnSense(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.SenseModeOnCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.SenseModeOnCommand);
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000073C4 File Offset: 0x000055C4
		private void SetCCHMode(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.modeCCCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.modeCCCommand);
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000742C File Offset: 0x0000562C
		private void SetCWMode(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.modeCWCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.modeCWCommand);
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007494 File Offset: 0x00005694
		private void SetCRMMode(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.modeCRCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.modeCRCommand);
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000074FC File Offset: 0x000056FC
		private void SetCVMMode(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.modeCVCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.modeCVCommand);
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007564 File Offset: 0x00005764
		private void SetCurrentLoad(int noLoad, double current)
		{
			ReadWriteLoad.currentValueCommand = current;
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.currentCommand + ReadWriteLoad.currentValueCommand.ToString());
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.currentCommand + ReadWriteLoad.currentValueCommand.ToString());
				}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000075F0 File Offset: 0x000057F0
		private void SetPowtLoad(int noLoad, double pow)
		{
			ReadWriteLoad.powerValueCommand = pow;
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.powerCommand + ReadWriteLoad.powerValueCommand.ToString());
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.powerCommand + ReadWriteLoad.powerValueCommand.ToString());
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000767C File Offset: 0x0000587C
		private void SetResLoad(int noLoad, double res)
		{
			ReadWriteLoad.resValueCommand = res;
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.resCommand + ReadWriteLoad.resValueCommand.ToString());
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.resCommand + ReadWriteLoad.resValueCommand.ToString());
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007708 File Offset: 0x00005908
		private void SetVoltLoad(int noLoad, double volt)
		{
			ReadWriteLoad.voltValueCommand = volt;
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.voltCommand + ReadWriteLoad.voltValueCommand.ToString());
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.voltCommand + ReadWriteLoad.voltValueCommand.ToString());
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007794 File Offset: 0x00005994
		private void EnableOCPLoad(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.OCPEnableCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.OCPEnableCommand);
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000077FC File Offset: 0x000059FC
		private void DisableOCPLoad(int noLoad)
		{
			bool flag = noLoad != 1;
			if (flag)
			{
				bool flag2 = noLoad != 2;
				if (!flag2)
				{
					bool flag3 = this.coml2OK;
					if (flag3)
					{
						this.comLoad2.WriteLine(ReadWriteLoad.OCPDisableCommand);
					}
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.OCPDisableCommand);
				}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007864 File Offset: 0x00005A64
		private string checkModeCommandLoad(int NoLoad)
		{
			string result = "";
			bool flag = NoLoad != 1;
			if (flag)
			{
				bool flag2 = NoLoad != 2;
				if (flag2)
				{
					return result;
				}
				bool flag3 = this.coml2OK;
				if (flag3)
				{
					this.comLoad2.WriteLine(ReadWriteLoad.modeCheckCommand);
					return this.comLoad2.ReadLine();
				}
			}
			else
			{
				bool flag4 = this.coml1OK;
				if (flag4)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.modeCheckCommand);
					return this.comLoad1.ReadLine();
				}
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000078F4 File Offset: 0x00005AF4
		private double MeasureCurrentLoad(int noload)
		{
			double result = 0.0;
			bool flag = noload != 1;
			if (flag)
			{
				bool flag2 = noload != 2;
				if (flag2)
				{
					return result;
				}
				bool flag3 = this.coml2OK;
				if (flag3)
				{
					this.comLoad2.WriteLine(ReadWriteLoad.measureCurrentCommand);
					string text = this.comLoad2.ReadLine();
					bool flag4 = text != "";
					if (flag4)
					{
						result = Convert.ToDouble(text);
					}
					return result;
				}
			}
			else
			{
				bool flag5 = this.coml1OK;
				if (flag5)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.measureCurrentCommand);
					string text2 = this.comLoad1.ReadLine();
					bool flag6 = text2 != "";
					if (flag6)
					{
						result = Convert.ToDouble(text2);
					}
					return result;
				}
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000079CC File Offset: 0x00005BCC
		private double MeasureVolttLoad(int noload)
		{
			double result = 0.0;
			bool flag = noload != 1;
			if (flag)
			{
				bool flag2 = noload != 2;
				if (flag2)
				{
					return result;
				}
				bool flag3 = this.coml2OK;
				if (flag3)
				{
					this.comLoad2.WriteLine(ReadWriteLoad.measureVoltCommand);
					string text = this.comLoad2.ReadLine();
					bool flag4 = text != "";
					if (flag4)
					{
						result = Convert.ToDouble(text);
					}
					return result;
				}
			}
			else
			{
				bool flag5 = this.coml1OK;
				if (flag5)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.measureVoltCommand);
					string text2 = this.comLoad1.ReadLine();
					bool flag6 = text2 != "";
					if (flag6)
					{
						result = Convert.ToDouble(text2);
					}
					return result;
				}
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007AA4 File Offset: 0x00005CA4
		private double MeasurePowerLoad(int noload)
		{
			double result = 0.0;
			bool flag = noload != 1;
			if (flag)
			{
				bool flag2 = noload != 2;
				if (flag2)
				{
					return result;
				}
				bool flag3 = this.coml2OK;
				if (flag3)
				{
					this.comLoad2.WriteLine(ReadWriteLoad.measurePowerInputCommand);
					string text = this.comLoad2.ReadLine();
					bool flag4 = text != "";
					if (flag4)
					{
						result = Convert.ToDouble(text);
					}
					return result;
				}
			}
			else
			{
				bool flag5 = this.coml1OK;
				if (flag5)
				{
					this.comLoad1.WriteLine(ReadWriteLoad.measurePowerInputCommand);
					string text2 = this.comLoad1.ReadLine();
					bool flag6 = text2 != "";
					if (flag6)
					{
						result = Convert.ToDouble(text2);
					}
					return result;
				}
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007B7C File Offset: 0x00005D7C
		private void SaveConfigProgram(string pathsave)
		{
			using (StreamWriter streamWriter = new StreamWriter(pathsave, false))
			{
				string value = string.Concat(new string[]
				{
					"Load1High",
					",",
					"Load1Low",
					",",
					"Power1High",
					",",
					"Power1Low",
					",",
					"Load2High",
					",",
					"Load2Low",
					",",
					"Power1High",
					",",
					"Power1Low"
				});
				streamWriter.WriteLine(value);
				string value2 = string.Concat(new object[]
				{
					VariableCommon.LOAD1VALUEMAX,
					",",
					VariableCommon.LOAD1VALUEMIN,
					",",
					VariableCommon.PW1VALUEMAX,
					",",
					VariableCommon.PW1VALUEMIN,
					",",
					VariableCommon.LOAD2VALUEMAX,
					",",
					VariableCommon.LOAD2VALUEMIN,
					",",
					VariableCommon.PW2VALUEMAX,
					",",
					VariableCommon.PW2VALUEMIN
				});
				streamWriter.WriteLine(value2);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007D0C File Offset: 0x00005F0C
		private void LoadConfigProgram(string path)
		{
			bool flag = File.Exists(path);
			if (flag)
			{
				string text = ReadCsvFile.ReadTextFile(path, 2);
				string[] array = text.Split(new char[]
				{
					','
				});
				VariableCommon.LOAD1VALUEMAX = double.Parse(array[0]);
				VariableCommon.LOAD1VALUEMIN = double.Parse(array[1]);
				VariableCommon.PW1VALUEMAX = double.Parse(array[2]);
				VariableCommon.PW1VALUEMIN = double.Parse(array[3]);
				VariableCommon.LOAD2VALUEMAX = double.Parse(array[4]);
				VariableCommon.LOAD2VALUEMIN = double.Parse(array[5]);
				VariableCommon.PW2VALUEMAX = double.Parse(array[6]);
				VariableCommon.PW2VALUEMIN = double.Parse(array[7]);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007DAC File Offset: 0x00005FAC
		private void Form1_Load(object sender, EventArgs e)
		{
			bool flag = DateTime.Now.Day <= 12;
			if (flag)
			{
				int month = DateTime.Now.Month;
			}
			this.timer1.Enabled = true;
			VariableCommon.stCurrentDir = this.pathApp;
			VariableCommon.programPath = VariableCommon.stCurrentDir + "\\program";
			VariableCommon.configPath = VariableCommon.stCurrentDir + "\\Config";
			VariableCommon.configFile = VariableCommon.configPath + "\\SystemSetting.xml";
			VariableCommon.configFileProgram = VariableCommon.configPath + "\\Program.csv";
			VariableCommon.configFilePass = VariableCommon.configPath + "\\pw.org";
			VariableCommon.passratePath = VariableCommon.stCurrentDir + "\\passrate";
			bool flag2 = Directory.Exists(VariableCommon.configPath);
			if (flag2)
			{
				bool flag3 = !File.Exists(VariableCommon.configFile);
				if (flag3)
				{
					this.SaveInitialSystemParam(VariableCommon.configFile);
					this.LoadSystemParam(VariableCommon.configFile);
				}
			}
			else
			{
				Directory.CreateDirectory(VariableCommon.configPath);
				this.SaveInitialSystemParam(VariableCommon.configFile);
				this.LoadSystemParam(VariableCommon.configFile);
			}
			bool flag4 = Directory.Exists(VariableCommon.programPath);
			if (flag4)
			{
				bool flag5 = !File.Exists(VariableCommon.programPath + "\\ProgramFile.csv");
				if (flag5)
				{
					VariableCommon.LOAD1VALUEMAX = 12.25;
					VariableCommon.LOAD1VALUEMIN = 11.45;
					VariableCommon.LOAD2VALUEMAX = 12.25;
					VariableCommon.LOAD2VALUEMIN = 11.45;
					VariableCommon.PW1VALUEMAX = 109.0;
					VariableCommon.PW1VALUEMIN = 90.0;
					VariableCommon.PW2VALUEMAX = 109.0;
					VariableCommon.PW2VALUEMIN = 90.0;
				}
			}
			else
			{
				Directory.CreateDirectory(VariableCommon.programPath);
			}
			this.LoadSystemParam(VariableCommon.configFile);
			bool flag6 = !Directory.Exists(VariableCommon.passratePath);
			if (flag6)
			{
				Directory.CreateDirectory(VariableCommon.passratePath);
			}
			bool flag7 = this.CheckComPLC();
			if (flag7)
			{
				VariableCommon.comPlcOk1 = (this.comPlcOk = true);
				MessageBox.Show("Kết nối PLC thành công");
			}
			else
			{
				VariableCommon.comPlcOk1 = (this.comPlcOk = false);
				MessageBox.Show("Kết nối PLC không thành công");
			}
			bool flag8 = this.OpenComLoad1(true);
			if (flag8)
			{
				VariableCommon.coml1OK = (this.coml1OK = true);
			}
			else
			{
				VariableCommon.coml1OK = (this.coml1OK = false);
			}
			bool flag9 = this.OpenComAC1(true);
			if (flag9)
			{
				VariableCommon.comac1OK = (this.comAC1Ok = true);
			}
			else
			{
				VariableCommon.comac1OK = (this.comAC1Ok = false);
			}
			bool flag10 = this.OpenComPowermeter1(true);
			if (flag10)
			{
				VariableCommon.compw1OK = (this.comPowermeter1Ok = true);
			}
			else
			{
				VariableCommon.compw1OK = (this.comPowermeter1Ok = false);
			}
			this.GetListFileInFolder(VariableCommon.programPath);
			for (int i = 0; i < 10; i++)
			{
				this.dataGridView1.Rows.Add();
			}
			this.dataGridView1.Rows[0].Cells[0].Value = "0%";
			this.dataGridView1.Rows[1].Cells[0].Value = "0%";
			this.dataGridView1.Rows[2].Cells[0].Value = "0%";
			this.dataGridView1.Rows[3].Cells[0].Value = "50%";
			this.dataGridView1.Rows[4].Cells[0].Value = "50%";
			this.dataGridView1.Rows[5].Cells[0].Value = "50%";
			this.dataGridView1.Rows[6].Cells[0].Value = "50%";
			this.dataGridView1.Rows[7].Cells[0].Value = "100%";
			this.dataGridView1.Rows[8].Cells[0].Value = "100%";
			this.dataGridView1.Rows[9].Cells[0].Value = "100%";
			this.dataGridView1.Rows.Add(new object[]
			{
				"Power Test"
			});
			this.toolStrip1.Visible = false;
			bool flag11 = this.comPlcOk;
			if (flag11)
			{
				this.timer3.Enabled = true;
			}
			this.timer2.Enabled = true;
			this.chart1.Series["PassRate2"].Points.AddXY("OK", new object[]
			{
				"0"
			});
			this.chart1.Series["PassRate2"].Points.AddXY("NG", new object[]
			{
				"0"
			});
			this.chart1.Titles.Add("PASS RATE");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000832B File Offset: 0x0000652B
		private void work_DoWork(object sender, DoWorkEventArgs e)
		{
			for (;;)
			{
				this.Labelupdate();
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008348 File Offset: 0x00006548
		private void LoadSetupData(string path)
		{
			bool flag = File.Exists(path);
			if (flag)
			{
				string text = ReadCsvFile.ReadTextFile(path, 2);
				VariableCommon.parameterSetupLoad = text.Split(new char[]
				{
					','
				});
				VariableCommon.parametervalueupdate[0] = Convert.ToDouble(VariableCommon.parameterSetupLoad[2]);
				string text2 = ReadCsvFile.ReadTextFile(path, 10);
				VariableCommon.parameterSetupLoad3 = text2.Split(new char[]
				{
					','
				});
				VariableCommon.acInputparam[0] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[1]);
				VariableCommon.acInputparam[1] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[2]);
				VariableCommon.acInputparam[2] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[3]);
				VariableCommon.acInputparam[3] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[4]);
				VariableCommon.acInputparam[4] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[5]);
				VariableCommon.acInputparam[5] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[6]);
				VariableCommon.acInputparam[6] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[7]);
				VariableCommon.acInputparam[7] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[8]);
				VariableCommon.acInputparam[8] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[9]);
				VariableCommon.acInputparam[9] = Convert.ToDouble(VariableCommon.parameterSetupLoad3[10]);
				this.dataGridView1.Rows[0].Cells[1].Value = VariableCommon.acInputparam[0].ToString();
				this.dataGridView1.Rows[1].Cells[1].Value = VariableCommon.acInputparam[1].ToString();
				this.dataGridView1.Rows[2].Cells[1].Value = VariableCommon.acInputparam[2].ToString();
				this.dataGridView1.Rows[3].Cells[1].Value = VariableCommon.acInputparam[3].ToString();
				this.dataGridView1.Rows[4].Cells[1].Value = VariableCommon.acInputparam[4].ToString();
				this.dataGridView1.Rows[5].Cells[1].Value = VariableCommon.acInputparam[5].ToString();
				this.dataGridView1.Rows[6].Cells[1].Value = VariableCommon.acInputparam[6].ToString();
				this.dataGridView1.Rows[7].Cells[1].Value = VariableCommon.acInputparam[7].ToString();
				this.dataGridView1.Rows[8].Cells[1].Value = VariableCommon.acInputparam[8].ToString();
				this.dataGridView1.Rows[9].Cells[1].Value = VariableCommon.acInputparam[9].ToString();
				this.dataGridView1.Rows[10].Cells[1].Value = VariableCommon.parametervalueupdate[0].ToString();
				string text3 = ReadCsvFile.ReadTextFile(path, 11);
				VariableCommon.parameterSetupLoad4 = text3.Split(new char[]
				{
					','
				});
				VariableCommon.resInputparam[0] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[1]);
				VariableCommon.resInputparam[1] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[2]);
				VariableCommon.resInputparam[2] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[3]);
				VariableCommon.resInputparam[3] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[4]);
				VariableCommon.resInputparam[4] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[5]);
				VariableCommon.resInputparam[5] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[6]);
				VariableCommon.resInputparam[6] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[7]);
				VariableCommon.resInputparam[7] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[8]);
				VariableCommon.resInputparam[8] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[9]);
				VariableCommon.resInputparam[9] = Convert.ToDouble(VariableCommon.parameterSetupLoad4[10]);
				string text4 = ReadCsvFile.ReadTextFile(path, 12);
				VariableCommon.parameterSetupLoad5 = text4.Split(new char[]
				{
					','
				});
				VariableCommon.curInputparam[0] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[1]);
				VariableCommon.curInputparam[1] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[2]);
				VariableCommon.curInputparam[2] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[3]);
				VariableCommon.curInputparam[3] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[4]);
				VariableCommon.curInputparam[4] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[5]);
				VariableCommon.curInputparam[5] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[6]);
				VariableCommon.curInputparam[6] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[7]);
				VariableCommon.curInputparam[7] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[8]);
				VariableCommon.curInputparam[8] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[9]);
				VariableCommon.curInputparam[9] = Convert.ToDouble(VariableCommon.parameterSetupLoad5[10]);
				string text5 = ReadCsvFile.ReadTextFile(path, 13);
				VariableCommon.parameterSetupLoad6 = text5.Split(new char[]
				{
					','
				});
				VariableCommon.dcvoltInputparam[0] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[1]);
				VariableCommon.dcvoltInputparam[1] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[2]);
				VariableCommon.dcvoltInputparam[2] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[3]);
				VariableCommon.dcvoltInputparam[3] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[4]);
				VariableCommon.dcvoltInputparam[4] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[5]);
				VariableCommon.dcvoltInputparam[5] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[6]);
				VariableCommon.dcvoltInputparam[6] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[7]);
				VariableCommon.dcvoltInputparam[7] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[8]);
				VariableCommon.dcvoltInputparam[8] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[9]);
				VariableCommon.dcvoltInputparam[9] = Convert.ToDouble(VariableCommon.parameterSetupLoad6[10]);
				string text6 = ReadCsvFile.ReadTextFile(path, 14);
				string[] array = new string[128];
				array = text6.Split(new char[]
				{
					','
				});
				VariableCommon.offsetmeasureValue[0] = Convert.ToDouble(array[1]);
				VariableCommon.offsetmeasureValue[1] = Convert.ToDouble(array[2]);
				VariableCommon.offsetmeasureValue[2] = Convert.ToDouble(array[3]);
				VariableCommon.offsetmeasureValue[3] = Convert.ToDouble(array[4]);
				VariableCommon.offsetmeasureValue[4] = Convert.ToDouble(array[5]);
				VariableCommon.offsetmeasureValue[5] = Convert.ToDouble(array[6]);
				VariableCommon.offsetmeasureValue[6] = Convert.ToDouble(array[7]);
				VariableCommon.offsetmeasureValue[7] = Convert.ToDouble(array[8]);
				VariableCommon.offsetmeasureValue[8] = Convert.ToDouble(array[9]);
				VariableCommon.offsetmeasureValue[9] = Convert.ToDouble(array[10]);
				string text7 = ReadCsvFile.ReadTextFile(path, 4);
				VariableCommon.measureValueSetup = text7.Split(new char[]
				{
					','
				});
				for (int i = 0; i < VariableCommon.measureValueSetup.Length; i++)
				{
					VariableCommon.measureValueUpdate[i] = Convert.ToDouble(VariableCommon.measureValueSetup[i]);
				}
				VariableCommon.powerSpec = VariableCommon.measureValueUpdate[20];
				VariableCommon.ocpSpec = VariableCommon.measureValueUpdate[21];
				VariableCommon.offsetPower = VariableCommon.measureValueUpdate[22];
				string text8 = ReadCsvFile.ReadTextFile(path, 6);
				string[] array2 = new string[15];
				array2 = text8.Split(new char[]
				{
					','
				});
				int num = 0;
				while (num < array2.Length && num < VariableCommon.enableMeasurestep.Length)
				{
					bool flag2 = array2[num] == "True";
					if (flag2)
					{
						VariableCommon.enableMeasurestep[num] = true;
					}
					else
					{
						VariableCommon.enableMeasurestep[num] = false;
					}
					num++;
				}
				bool flag3 = array2[11] == "True";
				if (flag3)
				{
					VariableCommon.presentMode = 0;
				}
				bool flag4 = array2[12] == "True";
				if (flag4)
				{
					VariableCommon.presentMode = 1;
				}
				bool flag5 = array2[13] == "True";
				if (flag5)
				{
					VariableCommon.presentMode = 2;
				}
				string text9 = ReadCsvFile.ReadTextFile(path, 8);
				string[] array3 = text9.Split(new char[]
				{
					','
				});
				VariableCommon.lowValuePer = Convert.ToDouble(array3[0]);
				VariableCommon.normalValuePer = Convert.ToDouble(array3[1]);
				VariableCommon.highValuePer = Convert.ToDouble(array3[2]);
				bool flag6 = VariableCommon.resInputparam[0] > 0.0;
				if (flag6)
				{
					VariableCommon.lowResValue1 = VariableCommon.resInputparam[0];
				}
				else
				{
					VariableCommon.lowResValue1 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag7 = VariableCommon.resInputparam[1] > 0.0;
				if (flag7)
				{
					VariableCommon.lowResValue2 = VariableCommon.resInputparam[1];
				}
				else
				{
					VariableCommon.lowResValue2 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag8 = VariableCommon.resInputparam[2] > 0.0;
				if (flag8)
				{
					VariableCommon.lowResValue3 = VariableCommon.resInputparam[2];
				}
				else
				{
					VariableCommon.lowResValue3 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag9 = VariableCommon.resInputparam[3] > 0.0;
				if (flag9)
				{
					VariableCommon.normalResValue1 = VariableCommon.resInputparam[3];
				}
				else
				{
					VariableCommon.normalResValue1 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag10 = VariableCommon.resInputparam[4] > 0.0;
				if (flag10)
				{
					VariableCommon.normalResValue2 = VariableCommon.resInputparam[4];
				}
				else
				{
					VariableCommon.normalResValue2 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag11 = VariableCommon.resInputparam[5] > 0.0;
				if (flag11)
				{
					VariableCommon.normalResValue3 = VariableCommon.resInputparam[5];
				}
				else
				{
					VariableCommon.normalResValue3 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag12 = VariableCommon.resInputparam[6] > 0.0;
				if (flag12)
				{
					VariableCommon.normalResValue4 = VariableCommon.resInputparam[6];
				}
				else
				{
					VariableCommon.normalResValue4 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag13 = VariableCommon.resInputparam[7] > 0.0;
				if (flag13)
				{
					VariableCommon.highResValue1 = VariableCommon.resInputparam[7];
				}
				else
				{
					VariableCommon.highResValue1 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag14 = VariableCommon.resInputparam[8] > 0.0;
				if (flag14)
				{
					VariableCommon.highResValue2 = VariableCommon.resInputparam[8];
				}
				else
				{
					VariableCommon.highResValue2 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag15 = VariableCommon.resInputparam[9] > 0.0;
				if (flag15)
				{
					VariableCommon.highResValue3 = VariableCommon.resInputparam[9];
				}
				else
				{
					VariableCommon.highResValue3 = VariableCommon.resInputparam[8] * 100.0;
				}
				bool flag16 = VariableCommon.curInputparam[0] > 0.0;
				if (flag16)
				{
					VariableCommon.lowCurValue1 = VariableCommon.curInputparam[0];
				}
				else
				{
					VariableCommon.lowCurValue1 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag17 = VariableCommon.curInputparam[1] > 0.0;
				if (flag17)
				{
					VariableCommon.lowCurValue2 = VariableCommon.curInputparam[1];
				}
				else
				{
					VariableCommon.lowCurValue2 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag18 = VariableCommon.curInputparam[2] > 0.0;
				if (flag18)
				{
					VariableCommon.lowCurValue3 = VariableCommon.curInputparam[2];
				}
				else
				{
					VariableCommon.lowCurValue3 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag19 = VariableCommon.curInputparam[3] > 0.0;
				if (flag19)
				{
					VariableCommon.normalCurValue1 = VariableCommon.curInputparam[3];
				}
				else
				{
					VariableCommon.normalCurValue1 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag20 = VariableCommon.curInputparam[4] > 0.0;
				if (flag20)
				{
					VariableCommon.normalCurValue2 = VariableCommon.curInputparam[4];
				}
				else
				{
					VariableCommon.normalCurValue2 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag21 = VariableCommon.curInputparam[5] > 0.0;
				if (flag21)
				{
					VariableCommon.normalCurValue3 = VariableCommon.curInputparam[5];
				}
				else
				{
					VariableCommon.normalCurValue3 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag22 = VariableCommon.curInputparam[6] > 0.0;
				if (flag22)
				{
					VariableCommon.normalCurValue4 = VariableCommon.curInputparam[6];
				}
				else
				{
					VariableCommon.normalCurValue4 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag23 = VariableCommon.curInputparam[7] > 0.0;
				if (flag23)
				{
					VariableCommon.highCurValue1 = VariableCommon.curInputparam[7];
				}
				else
				{
					VariableCommon.highCurValue1 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag24 = VariableCommon.curInputparam[8] > 0.0;
				if (flag24)
				{
					VariableCommon.highCurValue2 = VariableCommon.curInputparam[8];
				}
				else
				{
					VariableCommon.highCurValue2 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag25 = VariableCommon.curInputparam[9] > 0.0;
				if (flag25)
				{
					VariableCommon.highCurValue3 = VariableCommon.curInputparam[9];
				}
				else
				{
					VariableCommon.highCurValue3 = VariableCommon.curInputparam[8] / 100.0;
				}
				bool flag26 = VariableCommon.dcvoltInputparam[0] > 0.0;
				if (flag26)
				{
					VariableCommon.lowVoltValue1 = VariableCommon.dcvoltInputparam[0];
				}
				else
				{
					VariableCommon.lowVoltValue1 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag27 = VariableCommon.dcvoltInputparam[1] > 0.0;
				if (flag27)
				{
					VariableCommon.lowVoltValue2 = VariableCommon.dcvoltInputparam[1];
				}
				else
				{
					VariableCommon.lowVoltValue2 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag28 = VariableCommon.dcvoltInputparam[2] > 0.0;
				if (flag28)
				{
					VariableCommon.lowVoltValue3 = VariableCommon.dcvoltInputparam[2];
				}
				else
				{
					VariableCommon.lowVoltValue3 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag29 = VariableCommon.dcvoltInputparam[3] > 0.0;
				if (flag29)
				{
					VariableCommon.normalVoltValue1 = VariableCommon.dcvoltInputparam[3];
				}
				else
				{
					VariableCommon.normalVoltValue1 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag30 = VariableCommon.dcvoltInputparam[4] > 0.0;
				if (flag30)
				{
					VariableCommon.normalVoltValue2 = VariableCommon.dcvoltInputparam[4];
				}
				else
				{
					VariableCommon.normalVoltValue2 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag31 = VariableCommon.dcvoltInputparam[5] > 0.0;
				if (flag31)
				{
					VariableCommon.normalVoltValue3 = VariableCommon.dcvoltInputparam[5];
				}
				else
				{
					VariableCommon.normalVoltValue3 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag32 = VariableCommon.dcvoltInputparam[6] > 0.0;
				if (flag32)
				{
					VariableCommon.normalVoltValue4 = VariableCommon.dcvoltInputparam[6];
				}
				else
				{
					VariableCommon.normalVoltValue4 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag33 = VariableCommon.dcvoltInputparam[7] > 0.0;
				if (flag33)
				{
					VariableCommon.highVoltValue1 = VariableCommon.dcvoltInputparam[7];
				}
				else
				{
					VariableCommon.highVoltValue1 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag34 = VariableCommon.dcvoltInputparam[8] > 0.0;
				if (flag34)
				{
					VariableCommon.highVoltValue2 = VariableCommon.dcvoltInputparam[8];
				}
				else
				{
					VariableCommon.highVoltValue2 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
				bool flag35 = VariableCommon.dcvoltInputparam[9] > 0.0;
				if (flag35)
				{
					VariableCommon.highVoltValue3 = VariableCommon.dcvoltInputparam[9];
				}
				else
				{
					VariableCommon.highVoltValue3 = VariableCommon.dcvoltInputparam[8] / 100.0;
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00009327 File Offset: 0x00007527
		private void tsbFile_Click(object sender, EventArgs e)
		{
			new ProgramSetup().ShowDialog();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00009338 File Offset: 0x00007538
		private void InitReset()
		{
			this.OffOutputACSource(1);
			Program.delay.Delay1(200.0);
			this.SetFreqOutputACSource(1);
			this.StopCheckPowermeter(1);
			this.ResetCheckPowermeter(1);
			this.SetFunctionDisplay(1);
			this.SetCurrentRangePowerMeter(1, 2.0);
			this.SetVoltageRangePowerMeter(1, 300.0);
			this.RemoteLoad(1);
			this.OnSense(1);
			this.ClearErrorLoad(1);
			this.OffLoad(1);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000093C0 File Offset: 0x000075C0
		private void Testing1()
		{
			VariableCommon.status1 = 1;
			Array.Clear(VariableCommon.dataPrint, 0, VariableCommon.dataPrint.Length);
			double num = 0.0;
			bool flag = true;
			double num2 = 0.0;
			bool flag2 = true;
			double num3 = 0.0;
			bool flag3 = true;
			double num4 = 0.0;
			bool flag4 = true;
			double num5 = 0.0;
			bool flag5 = true;
			double num6 = 0.0;
			bool flag6 = true;
			bool flag7 = true;
			double num7 = 0.0;
			bool flag8 = true;
			double num8 = 0.0;
			bool flag9 = true;
			double num9 = 0.0;
			bool flag10 = true;
			double num10 = 0.0;
			bool flag11 = true;
			double num11 = 0.0;
			bool flag12 = true;
			double num12 = 0.0;
			bool flag13 = true;
			bool flag14 = false;
			double num13 = 0.0;
			for (int i = 0; i < 10; i++)
			{
				this.dataGridView1.Rows[i].Cells[2].Value = "";
			}
			for (int j = 0; j < 10; j++)
			{
				this.dataGridView1.Rows[j].Cells[3].Value = "";
			}
			this.dataGridView1.Rows[11].Cells[2].Value = "";
			this.dataGridView1.Rows[11].Cells[3].Value = "";
			this.StartCheckPowermeter(1);
			bool flag15 = VariableCommon.enableMeasurestep[10];
			if (flag15)
			{
				this.OffLoad(1);
				this.SetCCHMode(1);
				this.SetVoltageOutputACSource(1, VariableCommon.parametervalueupdate[0]);
				this.OnLoad(1);
				this.txtOCP_Measured.ForeColor = Color.Black;
				this.SetCurrentLoad(1, VariableCommon.ocpSpec - Settings.Default.OCP_LowerOffset);
				num12 = 0.0;
				Thread.Sleep(500);
				for (double num14 = VariableCommon.ocpSpec - Settings.Default.OCP_LowerOffset; num14 < VariableCommon.ocpSpec + Settings.Default.OCP_HigherOffset; num14 += Settings.Default.OCP_CurrentStep)
				{
					Thread.Sleep(Convert.ToInt32(Settings.Default.OCP_StepDelay));
					double num15 = Math.Round(this.MeasureCurrentLoad(1), 3);
					bool flag16 = num15 >= num12;
					if (!flag16)
					{
						break;
					}
					num12 = num15;
					this.txtOCP_Measured.Text = num12.ToString();
					this.SetCurrentLoad(1, num14);
				}
				bool flag17 = false;
				bool flag18 = num12 >= Settings.Default.OCP_LowerLimit && num12 <= Settings.Default.OCP_UpperLimit;
				if (flag18)
				{
					flag17 = true;
				}
				bool flag19 = true;
				this.OffOutputACSource(1);
				bool flag20 = !flag17 || !flag19;
				if (flag20)
				{
					this.lbResult1.Text = "Test OCP NG";
					this.lbResult1.ForeColor = Color.Red;
					this.txtOCP_Measured.ForeColor = Color.Red;
					flag10 = false;
					goto IL_2563;
				}
				this.lbResult1.Text = "Test OCP  OK";
				this.lbResult1.ForeColor = Color.Green;
				this.txtOCP_Measured.ForeColor = Color.Green;
				flag10 = true;
				for (int k = 24; k < 33; k++)
				{
					VariableCommon.dataPrint[k] = num12.ToString();
				}
			}
			else
			{
				for (int l = 24; l < 33; l++)
				{
					VariableCommon.dataPrint[l] = "X";
				}
			}
			bool shortTest_Enable = Settings.Default.ShortTest_Enable;
			if (shortTest_Enable)
			{
				this.OffLoad(1);
				this.SetCCHMode(1);
				this.SetVoltageOutputACSource(1, VariableCommon.parametervalueupdate[0]);
				Thread.Sleep(100);
				this.OnLoad(1);
				this.txtShortTestMeasured.ForeColor = Color.Black;
				this.SetCurrentLoad(1, Settings.Default.ShortTest_MaximumCurrent);
				Thread.Sleep(Convert.ToInt32(Settings.Default.ShortTest_Delay));
				num13 = Math.Round(this.MeasureVolttLoad(1), 3);
				bool flag21 = num13 <= Settings.Default.ShortTest_JudgementVoltage;
				if (flag21)
				{
					flag14 = true;
				}
				bool flag22 = true;
				this.txtShortTestMeasured.Text = num13.ToString();
				this.OffOutputACSource(1);
				bool flag23 = !flag14 || !flag22;
				if (flag23)
				{
					this.lbResult1.Text = "Test SHORT NG";
					this.lbResult1.ForeColor = Color.Red;
					this.txtShortTestMeasured.ForeColor = Color.Red;
					flag13 = false;
					goto IL_2563;
				}
				this.lbResult1.Text = "Test SHORT  OK";
				this.lbResult1.ForeColor = Color.Green;
				this.txtShortTestMeasured.ForeColor = Color.Green;
				flag13 = true;
				for (int m = 24; m < 33; m++)
				{
					VariableCommon.dataPrint[m] = num13.ToString();
				}
			}
			else
			{
				for (int n = 24; n < 33; n++)
				{
					VariableCommon.dataPrint[n] = "X";
				}
			}
			bool flag24 = VariableCommon.presentMode == 1;
			if (flag24)
			{
				this.SetCRMMode(1);
			}
			bool flag25 = VariableCommon.presentMode == 0;
			if (flag25)
			{
				this.SetCCHMode(1);
			}
			bool flag26 = VariableCommon.presentMode == 2;
			if (flag26)
			{
				this.SetCVMMode(1);
			}
			bool flag27 = VariableCommon.enableMeasurestep[0];
			if (flag27)
			{
				this.OffLoad(1);
				bool flag28 = VariableCommon.presentMode == 1;
				if (flag28)
				{
					this.SetResLoad(1, VariableCommon.lowResValue1);
				}
				bool flag29 = VariableCommon.presentMode == 0;
				if (flag29)
				{
					this.SetCurrentLoad(1, VariableCommon.lowCurValue1);
				}
				bool flag30 = VariableCommon.presentMode == 2;
				if (flag30)
				{
					this.SetVoltLoad(1, VariableCommon.lowVoltValue1);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[0]);
				Program.delay.Delay1(600);
				bool flag31 = (VariableCommon.resInputparam[0] > 0.0 && VariableCommon.presentMode == 1) || (VariableCommon.curInputparam[0] > 0.0 && VariableCommon.presentMode == 0) || (VariableCommon.dcvoltInputparam[0] > 0.0 && VariableCommon.presentMode == 2);
				if (flag31)
				{
					this.OnLoad(1);
				}
				Program.delay.Delay1(600);
				bool flag32 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag32)
				{
					num = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[0];
				}
				else
				{
					num = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[0];
				}
				bool flag33 = num >= VariableCommon.measureValueUpdate[0] && num <= VariableCommon.measureValueUpdate[1];
				bool flag34 = true;
				this.OffOutputACSource(1);
				bool flag35 = !flag33 || !flag34;
				if (flag35)
				{
					flag = false;
					bool flag36 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag36)
					{
						this.dataGridView1.Rows[0].Cells[2].Value = num.ToString() + "V";
					}
					bool flag37 = VariableCommon.presentMode == 2;
					if (flag37)
					{
						this.dataGridView1.Rows[0].Cells[2].Value = num.ToString() + "W";
					}
					this.dataGridView1.Rows[0].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag = true;
				bool flag38 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag38)
				{
					this.dataGridView1.Rows[0].Cells[2].Value = num.ToString() + "V";
				}
				else
				{
					this.dataGridView1.Rows[0].Cells[2].Value = num.ToString() + "W";
				}
				this.dataGridView1.Rows[0].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[0].Cells[3].Value = "Uncheck";
			}
			bool flag39 = VariableCommon.enableMeasurestep[1];
			if (flag39)
			{
				this.OffLoad(1);
				bool flag40 = VariableCommon.presentMode == 1;
				if (flag40)
				{
					this.SetResLoad(1, VariableCommon.lowResValue2);
				}
				bool flag41 = VariableCommon.presentMode == 0;
				if (flag41)
				{
					this.SetCurrentLoad(1, VariableCommon.lowCurValue2);
				}
				bool flag42 = VariableCommon.presentMode == 2;
				if (flag42)
				{
					this.SetVoltLoad(1, VariableCommon.lowVoltValue2);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[1]);
				Program.delay.Delay1(600);
				bool flag43 = (VariableCommon.resInputparam[1] > 0.0 && VariableCommon.presentMode == 1) || (VariableCommon.curInputparam[1] > 0.0 && VariableCommon.presentMode == 0) || (VariableCommon.dcvoltInputparam[1] > 0.0 && VariableCommon.presentMode == 2);
				if (flag43)
				{
					this.OnLoad(1);
				}
				Program.delay.Delay1(600);
				bool flag44 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag44)
				{
					num2 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[1];
				}
				else
				{
					num2 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[1];
				}
				bool flag45 = num2 >= VariableCommon.measureValueUpdate[2] && num2 <= VariableCommon.measureValueUpdate[3];
				bool flag46 = true;
				this.OffOutputACSource(1);
				bool flag47 = !flag45 || !flag46;
				if (flag47)
				{
					flag2 = false;
					bool flag48 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag48)
					{
						this.dataGridView1.Rows[1].Cells[2].Value = num2.ToString() + "V";
					}
					bool flag49 = VariableCommon.presentMode == 2;
					if (flag49)
					{
						this.dataGridView1.Rows[1].Cells[2].Value = num2.ToString() + "W";
					}
					this.dataGridView1.Rows[1].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag2 = true;
				bool flag50 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag50)
				{
					this.dataGridView1.Rows[1].Cells[2].Value = num2.ToString() + "V";
				}
				bool flag51 = VariableCommon.presentMode == 2;
				if (flag51)
				{
					this.dataGridView1.Rows[1].Cells[2].Value = num2.ToString() + "W";
				}
				this.dataGridView1.Rows[1].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[1].Cells[3].Value = "Uncheck";
			}
			bool flag52 = VariableCommon.enableMeasurestep[2];
			if (flag52)
			{
				this.OffLoad(1);
				bool flag53 = VariableCommon.presentMode == 1;
				if (flag53)
				{
					this.SetResLoad(1, VariableCommon.lowResValue3);
				}
				bool flag54 = VariableCommon.presentMode == 0;
				if (flag54)
				{
					this.SetCurrentLoad(1, VariableCommon.lowCurValue3);
				}
				bool flag55 = VariableCommon.presentMode == 2;
				if (flag55)
				{
					this.SetVoltLoad(1, VariableCommon.lowVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[2]);
				Program.delay.Delay1(600);
				bool flag56 = (VariableCommon.resInputparam[2] > 0.0 && VariableCommon.presentMode == 1) || (VariableCommon.curInputparam[2] > 0.0 && VariableCommon.presentMode == 0) || (VariableCommon.dcvoltInputparam[2] > 0.0 && VariableCommon.presentMode == 2);
				if (flag56)
				{
					this.OnLoad(1);
				}
				Program.delay.Delay1(600);
				bool flag57 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag57)
				{
					num3 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[2];
				}
				else
				{
					num3 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[2];
				}
				bool flag58 = num3 >= VariableCommon.measureValueUpdate[4] && num3 <= VariableCommon.measureValueUpdate[5];
				bool flag59 = true;
				this.OffOutputACSource(1);
				bool flag60 = !flag58 || !flag59;
				if (flag60)
				{
					flag3 = false;
					bool flag61 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag61)
					{
						this.dataGridView1.Rows[2].Cells[2].Value = num3.ToString() + "V";
					}
					bool flag62 = VariableCommon.presentMode == 2;
					if (flag62)
					{
						this.dataGridView1.Rows[2].Cells[2].Value = num3.ToString() + "W";
					}
					this.dataGridView1.Rows[2].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag3 = true;
				bool flag63 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag63)
				{
					this.dataGridView1.Rows[2].Cells[2].Value = num3.ToString() + "V";
				}
				bool flag64 = VariableCommon.presentMode == 2;
				if (flag64)
				{
					this.dataGridView1.Rows[2].Cells[2].Value = num3.ToString() + "W";
				}
				this.dataGridView1.Rows[2].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[2].Cells[3].Value = "Uncheck";
			}
			bool flag65 = VariableCommon.enableMeasurestep[3];
			if (flag65)
			{
				this.OffLoad(1);
				bool flag66 = VariableCommon.presentMode == 1;
				if (flag66)
				{
					this.SetResLoad(1, VariableCommon.normalResValue1);
				}
				bool flag67 = VariableCommon.presentMode == 0;
				if (flag67)
				{
					this.SetCurrentLoad(1, VariableCommon.normalCurValue1);
				}
				bool flag68 = VariableCommon.presentMode == 2;
				if (flag68)
				{
					this.SetVoltLoad(1, VariableCommon.normalVoltValue1);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[3]);
				Program.delay.Delay1(600);
				this.OnLoad(1);
				Program.delay.Delay1(800);
				bool flag69 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag69)
				{
					num4 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[3];
				}
				else
				{
					num4 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[3];
				}
				bool flag70 = num4 >= VariableCommon.measureValueUpdate[6] && num4 <= VariableCommon.measureValueUpdate[7];
				bool flag71 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag72 = !flag70 || !flag71;
				if (flag72)
				{
					flag4 = false;
					bool flag73 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag73)
					{
						this.dataGridView1.Rows[3].Cells[2].Value = num4.ToString() + "V";
					}
					bool flag74 = VariableCommon.presentMode == 2;
					if (flag74)
					{
						this.dataGridView1.Rows[3].Cells[2].Value = num4.ToString() + "W";
					}
					this.dataGridView1.Rows[3].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag4 = true;
				bool flag75 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag75)
				{
					this.dataGridView1.Rows[3].Cells[2].Value = num4.ToString() + "V";
				}
				bool flag76 = VariableCommon.presentMode == 2;
				if (flag76)
				{
					this.dataGridView1.Rows[3].Cells[2].Value = num4.ToString() + "W";
				}
				this.dataGridView1.Rows[3].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[3].Cells[3].Value = "Uncheck";
			}
			bool flag77 = VariableCommon.enableMeasurestep[4];
			if (flag77)
			{
				this.OffLoad(1);
				bool flag78 = VariableCommon.presentMode == 1;
				if (flag78)
				{
					this.SetResLoad(1, VariableCommon.normalResValue2);
				}
				bool flag79 = VariableCommon.presentMode == 0;
				if (flag79)
				{
					this.SetCurrentLoad(1, VariableCommon.normalCurValue2);
				}
				bool flag80 = VariableCommon.presentMode == 2;
				if (flag80)
				{
					this.SetVoltLoad(1, VariableCommon.normalVoltValue2);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[4]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag81 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag81)
				{
					num5 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[4];
				}
				else
				{
					num5 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[4];
				}
				bool flag82 = num5 >= VariableCommon.measureValueUpdate[8] && num5 <= VariableCommon.measureValueUpdate[9];
				bool flag83 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag84 = !flag82 || !flag83;
				if (flag84)
				{
					flag5 = false;
					bool flag85 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag85)
					{
						this.dataGridView1.Rows[4].Cells[2].Value = num5.ToString() + "V";
					}
					bool flag86 = VariableCommon.presentMode == 2;
					if (flag86)
					{
						this.dataGridView1.Rows[4].Cells[2].Value = num5.ToString() + "W";
					}
					this.dataGridView1.Rows[4].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag5 = true;
				bool flag87 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag87)
				{
					this.dataGridView1.Rows[4].Cells[2].Value = num5.ToString() + "V";
				}
				bool flag88 = VariableCommon.presentMode == 2;
				if (flag88)
				{
					this.dataGridView1.Rows[4].Cells[2].Value = num5.ToString() + "W";
				}
				this.dataGridView1.Rows[4].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[4].Cells[3].Value = "Uncheck";
			}
			bool flag89 = VariableCommon.enableMeasurestep[5];
			if (flag89)
			{
				this.OffLoad(1);
				bool flag90 = VariableCommon.presentMode == 1;
				if (flag90)
				{
					this.SetResLoad(1, VariableCommon.normalResValue3);
				}
				bool flag91 = VariableCommon.presentMode == 0;
				if (flag91)
				{
					this.SetCurrentLoad(1, VariableCommon.normalCurValue3);
				}
				bool flag92 = VariableCommon.presentMode == 2;
				if (flag92)
				{
					this.SetVoltLoad(1, VariableCommon.normalVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[5]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag93 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag93)
				{
					num6 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[5];
				}
				else
				{
					num6 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[5];
				}
				bool flag94 = num6 >= VariableCommon.measureValueUpdate[10] && num6 <= VariableCommon.measureValueUpdate[11];
				bool flag95 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag96 = !flag94 || !flag95;
				if (flag96)
				{
					flag6 = false;
					bool flag97 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag97)
					{
						this.dataGridView1.Rows[5].Cells[2].Value = num6.ToString() + "V";
					}
					bool flag98 = VariableCommon.presentMode == 2;
					if (flag98)
					{
						this.dataGridView1.Rows[5].Cells[2].Value = num6.ToString() + "W";
					}
					this.dataGridView1.Rows[5].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag6 = true;
				bool flag99 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag99)
				{
					this.dataGridView1.Rows[5].Cells[2].Value = num6.ToString() + "V";
				}
				bool flag100 = VariableCommon.presentMode == 2;
				if (flag100)
				{
					this.dataGridView1.Rows[5].Cells[2].Value = num6.ToString() + "W";
				}
				this.dataGridView1.Rows[5].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[5].Cells[3].Value = "Uncheck";
			}
			bool flag101 = VariableCommon.enableMeasurestep[6];
			if (flag101)
			{
				this.OffLoad(1);
				bool flag102 = VariableCommon.presentMode == 1;
				if (flag102)
				{
					this.SetResLoad(1, VariableCommon.normalResValue4);
				}
				bool flag103 = VariableCommon.presentMode == 0;
				if (flag103)
				{
					this.SetCurrentLoad(1, VariableCommon.normalCurValue4);
				}
				bool flag104 = VariableCommon.presentMode == 2;
				if (flag104)
				{
					this.SetVoltLoad(1, VariableCommon.normalVoltValue4);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[6]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag105 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag105)
				{
					num11 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[6];
				}
				else
				{
					num11 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[6];
				}
				bool flag106 = num11 >= VariableCommon.measureValueUpdate[12] && num6 <= VariableCommon.measureValueUpdate[13];
				bool flag107 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag108 = !flag106 || !flag107;
				if (flag108)
				{
					flag12 = false;
					bool flag109 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag109)
					{
						this.dataGridView1.Rows[6].Cells[2].Value = num11.ToString() + "V";
					}
					bool flag110 = VariableCommon.presentMode == 2;
					if (flag110)
					{
						this.dataGridView1.Rows[6].Cells[2].Value = num11.ToString() + "W";
					}
					this.dataGridView1.Rows[6].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag12 = true;
				bool flag111 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag111)
				{
					this.dataGridView1.Rows[6].Cells[2].Value = num11.ToString() + "V";
				}
				bool flag112 = VariableCommon.presentMode == 2;
				if (flag112)
				{
					this.dataGridView1.Rows[6].Cells[2].Value = num11.ToString() + "W";
				}
				this.dataGridView1.Rows[6].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[6].Cells[3].Value = "Uncheck";
			}
			bool flag113 = VariableCommon.enableMeasurestep[7];
			if (flag113)
			{
				this.OffLoad(1);
				bool flag114 = VariableCommon.presentMode == 1;
				if (flag114)
				{
					this.SetResLoad(1, VariableCommon.highResValue1);
				}
				bool flag115 = VariableCommon.presentMode == 0;
				if (flag115)
				{
					this.SetCurrentLoad(1, VariableCommon.highCurValue1);
				}
				bool flag116 = VariableCommon.presentMode == 2;
				if (flag116)
				{
					this.SetVoltLoad(1, VariableCommon.highVoltValue1);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[7]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag117 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag117)
				{
					num7 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[7];
				}
				else
				{
					num7 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[7];
				}
				bool flag118 = num7 >= VariableCommon.measureValueUpdate[14] && num7 <= VariableCommon.measureValueUpdate[15];
				bool flag119 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag120 = !flag118 || !flag119;
				if (flag120)
				{
					flag7 = false;
					bool flag121 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag121)
					{
						this.dataGridView1.Rows[7].Cells[2].Value = num7.ToString() + "V";
					}
					bool flag122 = VariableCommon.presentMode == 2;
					if (flag122)
					{
						this.dataGridView1.Rows[7].Cells[2].Value = num7.ToString() + "W";
					}
					this.dataGridView1.Rows[7].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag7 = true;
				bool flag123 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag123)
				{
					this.dataGridView1.Rows[7].Cells[2].Value = num7.ToString() + "V";
				}
				bool flag124 = VariableCommon.presentMode == 2;
				if (flag124)
				{
					this.dataGridView1.Rows[7].Cells[2].Value = num7.ToString() + "W";
				}
				this.dataGridView1.Rows[7].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[7].Cells[3].Value = "Uncheck";
			}
			bool flag125 = VariableCommon.enableMeasurestep[8];
			if (flag125)
			{
				this.OffLoad(1);
				bool flag126 = VariableCommon.presentMode == 1;
				if (flag126)
				{
					this.SetResLoad(1, VariableCommon.highResValue2);
				}
				bool flag127 = VariableCommon.presentMode == 0;
				if (flag127)
				{
					this.SetCurrentLoad(1, VariableCommon.highCurValue2);
				}
				bool flag128 = VariableCommon.presentMode == 2;
				if (flag128)
				{
					this.SetVoltLoad(1, VariableCommon.highVoltValue2);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[8]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag129 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag129)
				{
					num8 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[8];
				}
				else
				{
					num8 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[8];
				}
				bool flag130 = num8 >= VariableCommon.measureValueUpdate[16] && num8 <= VariableCommon.measureValueUpdate[17];
				bool flag131 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag132 = !flag130 || !flag131;
				if (flag132)
				{
					flag8 = false;
					bool flag133 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag133)
					{
						this.dataGridView1.Rows[8].Cells[2].Value = num8.ToString() + "V";
					}
					bool flag134 = VariableCommon.presentMode == 2;
					if (flag134)
					{
						this.dataGridView1.Rows[8].Cells[2].Value = num8.ToString() + "W";
					}
					this.dataGridView1.Rows[8].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag8 = true;
				bool flag135 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag135)
				{
					this.dataGridView1.Rows[8].Cells[2].Value = num8.ToString() + "V";
				}
				bool flag136 = VariableCommon.presentMode == 2;
				if (flag136)
				{
					this.dataGridView1.Rows[8].Cells[2].Value = num8.ToString() + "W";
				}
				this.dataGridView1.Rows[8].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[8].Cells[3].Value = "Uncheck";
			}
			bool flag137 = VariableCommon.enableMeasurestep[9];
			if (flag137)
			{
				this.OffLoad(1);
				bool flag138 = VariableCommon.presentMode == 1;
				if (flag138)
				{
					this.SetResLoad(1, VariableCommon.highResValue3);
				}
				bool flag139 = VariableCommon.presentMode == 0;
				if (flag139)
				{
					this.SetCurrentLoad(1, VariableCommon.highCurValue3);
				}
				bool flag140 = VariableCommon.presentMode == 2;
				if (flag140)
				{
					this.SetVoltLoad(1, VariableCommon.highVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[9]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag141 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag141)
				{
					num9 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[9];
				}
				else
				{
					num9 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[9];
				}
				bool flag142 = num9 >= VariableCommon.measureValueUpdate[18] && num9 <= VariableCommon.measureValueUpdate[19];
				bool flag143 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag144 = !flag142 || !flag143;
				if (flag144)
				{
					flag9 = false;
					bool flag145 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag145)
					{
						this.dataGridView1.Rows[9].Cells[2].Value = num9.ToString() + "V";
					}
					bool flag146 = VariableCommon.presentMode == 2;
					if (flag146)
					{
						this.dataGridView1.Rows[9].Cells[2].Value = num9.ToString() + "W";
					}
					this.dataGridView1.Rows[9].Cells[3].Value = "NG";
					goto IL_2563;
				}
				flag9 = true;
				bool flag147 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				if (flag147)
				{
					this.dataGridView1.Rows[9].Cells[2].Value = num9.ToString() + "V";
				}
				bool flag148 = VariableCommon.presentMode == 2;
				if (flag148)
				{
					this.dataGridView1.Rows[9].Cells[2].Value = num9.ToString() + "W";
				}
				this.dataGridView1.Rows[9].Cells[3].Value = "OK";
			}
			else
			{
				this.dataGridView1.Rows[9].Cells[3].Value = "Uncheck";
			}
			bool flag149 = VariableCommon.enableMeasurestep[14];
			if (flag149)
			{
				this.OffLoad(1);
				bool flag150 = VariableCommon.presentMode == 1;
				if (flag150)
				{
					this.SetResLoad(1, VariableCommon.highResValue3);
				}
				bool flag151 = VariableCommon.presentMode == 0;
				if (flag151)
				{
					this.SetCurrentLoad(1, VariableCommon.highCurValue3);
				}
				bool flag152 = VariableCommon.presentMode == 2;
				if (flag152)
				{
					this.SetVoltLoad(1, VariableCommon.highVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.parametervalueupdate[0]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				num10 = Math.Round(this.GetMeasureValuePower(1)[2], 2);
				flag11 = (num10 - VariableCommon.offsetPower / 100.0 * num10 <= VariableCommon.powerSpec && num10 + VariableCommon.offsetPower / 100.0 * num10 >= VariableCommon.powerSpec);
				this.OffOutputACSource(1);
				bool flag153 = flag11;
				if (flag153)
				{
					this.dataGridView1.Rows[10].Cells[2].Value = num10.ToString() + "W";
					this.dataGridView1.Rows[10].Cells[3].Value = "OK";
				}
				else
				{
					this.dataGridView1.Rows[10].Cells[2].Value = num10.ToString() + "W";
					this.dataGridView1.Rows[10].Cells[3].Value = "NG";
				}
			}
			else
			{
				this.dataGridView1.Rows[10].Cells[3].Value = "Uncheck";
			}
			IL_2563:
			Program.delay.Delay1(1500.0);
			this.OffLoad(1);
			this.StopCheckPowermeter(1);
			bool flag154 = !flag || !flag2 || !flag3 || !flag4 || !flag5 || !flag6 || !flag7 || !flag8 || !flag9 || !flag10 || !flag11 || !flag12 || !flag13;
			string text;
			if (flag154)
			{
				this.WriteDataAddress("4", 1);
				VariableCommon.status1 = 2;
				VariableCommon.noFail++;
				VariableCommon.noTotal = VariableCommon.noPass + VariableCommon.noFail;
				this.SavePassRate(this.filePassrate, this.fileNameFolder, VariableCommon.noTotal, VariableCommon.noPass, VariableCommon.noFail);
				this.LoadPassRate(VariableCommon.passratePath + "\\" + this.cbbSelectProgram.Text + ".csv");
				text = "Fail";
			}
			else
			{
				VariableCommon.status1 = 3;
				VariableCommon.dataPrint[0] = VariableCommon.parameterSetupLoad[1];
				VariableCommon.dataPrint[1] = DateTime.Now.Year.ToString();
				VariableCommon.dataPrint[2] = DateTime.Now.Month.ToString();
				VariableCommon.dataPrint[3] = DateTime.Now.Day.ToString();
				VariableCommon.dataPrint[4] = VariableCommon.parameterSetupLoad[3];
				VariableCommon.dataPrint[5] = " ";
				VariableCommon.dataPrint[6] = DateTime.Now.Hour.ToString();
				VariableCommon.dataPrint[7] = ":";
				VariableCommon.dataPrint[8] = DateTime.Now.Minute.ToString();
				VariableCommon.strPrint = string.Concat(new string[]
				{
					VariableCommon.dataPrint[0],
					VariableCommon.dataPrint[1],
					VariableCommon.dataPrint[2],
					VariableCommon.dataPrint[3],
					VariableCommon.dataPrint[4],
					VariableCommon.dataPrint[5],
					VariableCommon.dataPrint[6],
					VariableCommon.dataPrint[7],
					VariableCommon.dataPrint[8],
					":",
					DateTime.Now.Second.ToString(),
					VariableCommon.parameterSetupLoad[4].ToString()
				});
				this.ZENBARCODE(VariableCommon.strPrint);
				PrintDialog printDialog = new PrintDialog();
				printDialog.Document = this.printDocument1;
				printDialog.AllowSelection = true;
				printDialog.AllowSomePages = true;
				this.printDocument1.Print();
				VariableCommon.noPass++;
				VariableCommon.noTotal = VariableCommon.noPass + VariableCommon.noFail;
				this.SavePassRate(this.filePassrate, this.fileNameFolder, VariableCommon.noTotal, VariableCommon.noPass, VariableCommon.noFail);
				this.LoadPassRate(VariableCommon.passratePath + "\\" + this.cbbSelectProgram.Text + ".csv");
				this.WriteDataAddress("8", 1);
				text = "Pass";
			}
			bool flag155 = File.Exists(this.fileReport);
			if (flag155)
			{
				Array.Clear(VariableCommon.dataReport, 0, VariableCommon.dataReport.Length);
				VariableCommon.dataReport[0] = VariableCommon.parameterSetupLoad[0].ToString();
				VariableCommon.dataReport[1] = VariableCommon.parameterSetupLoad[1].ToString();
				VariableCommon.dataReport[2] = VariableCommon.parameterSetupLoad[2].ToString();
				bool flag156 = VariableCommon.enableMeasurestep[0];
				if (flag156)
				{
					VariableCommon.dataReport[3] = num.ToString();
				}
				else
				{
					VariableCommon.dataReport[3] = "X";
				}
				bool flag157 = VariableCommon.enableMeasurestep[1];
				if (flag157)
				{
					VariableCommon.dataReport[4] = num2.ToString();
				}
				else
				{
					VariableCommon.dataReport[4] = "X";
				}
				bool flag158 = VariableCommon.enableMeasurestep[2];
				if (flag158)
				{
					VariableCommon.dataReport[5] = num3.ToString();
				}
				else
				{
					VariableCommon.dataReport[5] = "X";
				}
				bool flag159 = VariableCommon.enableMeasurestep[3];
				if (flag159)
				{
					VariableCommon.dataReport[6] = num4.ToString();
				}
				else
				{
					VariableCommon.dataReport[6] = "X";
				}
				bool flag160 = VariableCommon.enableMeasurestep[4];
				if (flag160)
				{
					VariableCommon.dataReport[7] = num5.ToString();
				}
				else
				{
					VariableCommon.dataReport[7] = "X";
				}
				bool flag161 = VariableCommon.enableMeasurestep[5];
				if (flag161)
				{
					VariableCommon.dataReport[8] = num6.ToString();
				}
				else
				{
					VariableCommon.dataReport[8] = "X";
				}
				bool flag162 = VariableCommon.enableMeasurestep[6];
				if (flag162)
				{
					VariableCommon.dataReport[9] = num11.ToString();
				}
				else
				{
					VariableCommon.dataReport[9] = "X";
				}
				bool flag163 = VariableCommon.enableMeasurestep[7];
				if (flag163)
				{
					VariableCommon.dataReport[10] = num7.ToString();
				}
				else
				{
					VariableCommon.dataReport[10] = "X";
				}
				bool flag164 = VariableCommon.enableMeasurestep[8];
				if (flag164)
				{
					VariableCommon.dataReport[11] = num8.ToString();
				}
				else
				{
					VariableCommon.dataReport[11] = "X";
				}
				bool flag165 = VariableCommon.enableMeasurestep[9];
				if (flag165)
				{
					VariableCommon.dataReport[12] = num9.ToString();
				}
				else
				{
					VariableCommon.dataReport[12] = "X";
				}
				bool flag166 = VariableCommon.enableMeasurestep[10];
				if (flag166)
				{
					VariableCommon.dataReport[13] = num12.ToString();
				}
				else
				{
					VariableCommon.dataReport[13] = "X";
				}
				bool shortTest_Enable2 = Settings.Default.ShortTest_Enable;
				if (shortTest_Enable2)
				{
					VariableCommon.dataReport[14] = num13.ToString();
				}
				else
				{
					VariableCommon.dataReport[14] = "X";
				}
				bool flag167 = VariableCommon.enableMeasurestep[14];
				if (flag167)
				{
					VariableCommon.dataReport[22] = num10.ToString();
				}
				else
				{
					VariableCommon.dataReport[22] = "X";
				}
				string text2 = string.Concat(new string[]
				{
					(VariableCommon.noTotal + 1).ToString(),
					" ",
					DateTime.Now.Hour.ToString(),
					":",
					DateTime.Now.Minute.ToString(),
					":",
					DateTime.Now.Second.ToString(),
					" ",
					VariableCommon.parameterSetupLoad[4].ToString()
				});
				try
				{
					using (StreamWriter streamWriter = new StreamWriter(this.fileReport, true))
					{
						string value = string.Concat(new string[]
						{
							text2,
							",",
							VariableCommon.dataReport[3],
							",",
							VariableCommon.dataReport[4],
							",",
							VariableCommon.dataReport[5],
							",",
							VariableCommon.dataReport[6],
							",",
							VariableCommon.dataReport[7],
							",",
							VariableCommon.dataReport[8],
							",",
							VariableCommon.dataReport[9],
							",",
							VariableCommon.dataReport[10],
							",",
							VariableCommon.dataReport[11],
							",",
							VariableCommon.dataReport[12],
							",",
							VariableCommon.dataReport[13],
							",",
							VariableCommon.dataReport[14],
							",",
							VariableCommon.dataReport[22],
							",",
							text
						});
						streamWriter.WriteLine(value);
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000C124 File Offset: 0x0000A324
		private void cbbSelectProgram_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.LoadSetupData(VariableCommon.programPath + "\\" + this.cbbSelectProgram.Text + ".csv");
			this.lbProgramName.Text = this.cbbSelectProgram.Text;
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				this.InitReset();
			}
			this.toolStrip1.Visible = true;
			this.LoadPassRate(VariableCommon.passratePath + "\\" + this.cbbSelectProgram.Text + ".csv");
			this.SaveReportFile(VariableCommon.reportPath + "\\" + this.cbbSelectProgram.Text + ".csv", this.cbbSelectProgram.Text);
			this.lblNumberTest.Text = VariableCommon.noTotal.ToString();
			this.lblNoPass.Text = VariableCommon.noPass.ToString();
			this.lblNoFail.Text = VariableCommon.noFail.ToString();
			VariableCommon.datachart[0] = VariableCommon.noPass;
			VariableCommon.datachart[1] = VariableCommon.noFail;
			this.chart1.Series["PassRate2"].Points.DataBindY(new IEnumerable[]
			{
				VariableCommon.datachart
			});
			this.chart1.Series["PassRate2"].Points.ResumeUpdates();
			MessageBox.Show("Khởi tạo thành công");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		private void GetListFileInFolder(string path)
		{
			FileInfo[] files = new DirectoryInfo(path).GetFiles("*.csv");
			string str = "";
			foreach (FileInfo fileInfo in files)
			{
				str = str + ", " + fileInfo.Name;
				this.cbbSelectProgram.Items.Add(fileInfo.Name.Remove(fileInfo.Name.Length - 4));
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000C31C File Offset: 0x0000A51C
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool isOpen = this.comLoad1.IsOpen;
			if (isOpen)
			{
				this.comLoad1.Close();
			}
			bool isOpen2 = this.comPowermeter1.IsOpen;
			if (isOpen2)
			{
				this.comPowermeter1.Close();
			}
			bool isOpen3 = this.comACSource1.IsOpen;
			if (isOpen3)
			{
				this.comACSource1.Close();
			}
			bool isOpen4 = this.comPLC.IsOpen;
			if (isOpen4)
			{
				this.comPLC.Close();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		private void tsbStop_Click(object sender, EventArgs e)
		{
			bool flag = !this.checkBox1.Checked;
			if (flag)
			{
				this.bitStart1 = true;
				this.Test1button();
			}
			else
			{
				MessageBox.Show("Hãy tắt chế độ auto test");
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000C3DC File Offset: 0x0000A5DC
		private void Test1button()
		{
			this.toolStrip1.Visible = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				this.txtOCP_Measured.Text = "";
				this.txtShortTestMeasured.Text = "";
				this.Testing1();
			}
			catch (Exception)
			{
			}
			stopwatch.Stop();
			string text = stopwatch.Elapsed.ToString("ss\\.fff");
			this.lbCycletime.Text = text;
			this.lblNumberTest.Text = VariableCommon.noTotal.ToString();
			this.lblNoPass.Text = VariableCommon.noPass.ToString();
			this.lblNoFail.Text = VariableCommon.noFail.ToString();
			VariableCommon.datachart[0] = VariableCommon.noPass;
			VariableCommon.datachart[1] = VariableCommon.noFail;
			this.chart1.Series["PassRate2"].Points.DataBindY(new IEnumerable[]
			{
				VariableCommon.datachart
			});
			this.chart1.Series["PassRate2"].Points.ResumeUpdates();
			this.toolStrip1.Visible = true;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000450E File Offset: 0x0000270E
		private void Test2button()
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000C524 File Offset: 0x0000A724
		private void Test()
		{
			bool flag = this.ReadDataAddress("0") == 1 && VariableCommon.status2 != 1 && VariableCommon.status1 != 1;
			if (flag)
			{
				this.WriteDataAddress("0", 0);
				this.toolStrip1.Visible = false;
				this.WriteDataAddress("8", 0);
				Program.delay.Delay1(200.0);
				this.WriteDataAddress("12", 1);
				Program.delay.Delay1(200.0);
				this.WriteDataAddress("14", 1);
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				this.Testing1();
				stopwatch.Stop();
				string text = stopwatch.Elapsed.ToString("ss\\.fff");
				this.lbCycletime.Text = text;
				this.lblNumberTest.Text = VariableCommon.noTotal.ToString();
				this.lblNoPass.Text = VariableCommon.noPass.ToString();
				this.lblNoFail.Text = VariableCommon.noFail.ToString();
				VariableCommon.datachart[0] = VariableCommon.noPass;
				VariableCommon.datachart[1] = VariableCommon.noFail;
				this.chart1.Series["PassRate2"].Points.DataBindY(new IEnumerable[]
				{
					VariableCommon.datachart
				});
				this.chart1.Series["PassRate2"].Points.ResumeUpdates();
				this.WriteDataAddress("12", 0);
				Program.delay.Delay1(200.0);
				this.WriteDataAddress("14", 0);
				this.toolStrip1.Visible = true;
			}
			bool flag2 = this.bitStart1;
			if (flag2)
			{
				this.Test1button();
				this.bitStart1 = false;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.Labelupdate();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000C700 File Offset: 0x0000A900
		private void timer3_Tick(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				try
				{
					this.Test();
				}
				catch (Exception)
				{
					this.comPLC.Close();
					this.comACSource1.Close();
					this.comLoad1.Close();
					this.comPowermeter1.Close();
					MessageBox.Show("Kiểm tra kết nối và mở lại phần mềm");
					Application.Exit();
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000C780 File Offset: 0x0000A980
		private void Labelupdate()
		{
			bool flag = VariableCommon.status1 == 1;
			if (flag)
			{
				this.lbResult1.Text = "Testing";
				this.lbResult1.ForeColor = Color.Blue;
			}
			bool flag2 = VariableCommon.status1 == 2;
			if (flag2)
			{
				this.lbResult1.Text = "NG";
				this.lbResult1.ForeColor = Color.Red;
			}
			bool flag3 = VariableCommon.status1 == 3;
			if (flag3)
			{
				this.lbResult1.Text = "OK";
				this.lbResult1.ForeColor = Color.Green;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000C81E File Offset: 0x0000AA1E
		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			this.printing1(e, VariableCommon.strPrint);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000C830 File Offset: 0x0000AA30
		private void printing1(PrintPageEventArgs e, string strprint)
		{
			e.Graphics.DrawImage(this.pictureBox1.Image, 3f, 3f, (float)this.pictureBox1.Width / 4.13f, (float)this.pictureBox1.Height / 4.13f);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000C884 File Offset: 0x0000AA84
		public static Image resizeImage(Image imgToResize, Size size)
		{
			return new Bitmap(imgToResize, size);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		private static Image resizeImage1(Image imgToResize, Size size)
		{
			int width = imgToResize.Width;
			int height = imgToResize.Height;
			float num = (float)size.Width / (float)width;
			float num2 = (float)size.Height / (float)height;
			bool flag = num2 < num;
			float num3;
			if (flag)
			{
				num3 = num2;
			}
			else
			{
				num3 = num;
			}
			int width2 = (int)((float)width * num3);
			int height2 = (int)((float)height * num3);
			Bitmap bitmap = new Bitmap(width2, height2);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.DrawImage(imgToResize, 0, 0, width2, height2);
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000C938 File Offset: 0x0000AB38
		private void ZENBARCODE(string barcode)
		{
			CodeQrBarcodeDraw codeQr = BarcodeDrawFactory.CodeQr;
			this.pictureBox1.Image = (this.barcodeimage = codeQr.Draw(barcode, 6));
			this.pictureBox1.Width = this.barcodeimage.Width;
			this.pictureBox1.Height = this.barcodeimage.Height;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000C998 File Offset: 0x0000AB98
		private static void RenderBarcodeInfoToGraphics(Graphics g, string code, string info, Rectangle rect)
		{
			g.Clear(Color.White);
			g.InterpolationMode = InterpolationMode.NearestNeighbor;
			using (Image image = BarcodeDrawFactory.Code128WithChecksum.Draw(code, 50))
			{
				g.DrawImage(image, new Point(rect.X + (rect.Width / 2 - image.Width / 2), rect.Y + 20));
			}
			using (SolidBrush solidBrush = new SolidBrush(Color.Black))
			{
				int num = rect.Y + 20 + 50 + 10;
				StringFormat format = new StringFormat
				{
					Alignment = StringAlignment.Center,
					LineAlignment = StringAlignment.Near
				};
				int num2 = 0;
				using (Font font = new Font("Courier New", 10f, FontStyle.Regular))
				{
					num2 = (int)Math.Round((double)g.MeasureString(code, font).Height);
					g.DrawString(code, font, solidBrush, new Rectangle(rect.X, num, rect.Width, 0), format);
				}
				using (Font font2 = new Font("Arial", 12f, FontStyle.Regular))
				{
					g.DrawString(info, font2, solidBrush, new Rectangle(rect.X, num + num2 + 10, rect.Width, 0), format);
				}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000CB34 File Offset: 0x0000AD34
		private void btnPrint_Click(object sender, EventArgs e)
		{
			int num = 0;
			while (num <= this.numericUpDown1.Value)
			{
				VariableCommon.dataPrint[0] = VariableCommon.parameterSetupLoad[1];
				VariableCommon.dataPrint[1] = DateTime.Now.Year.ToString();
				VariableCommon.dataPrint[2] = DateTime.Now.Month.ToString();
				VariableCommon.dataPrint[3] = DateTime.Now.Day.ToString();
				VariableCommon.dataPrint[4] = VariableCommon.parameterSetupLoad[3];
				VariableCommon.dataPrint[5] = " ";
				VariableCommon.dataPrint[6] = this.numericUpDown3.Value.ToString();
				VariableCommon.dataPrint[7] = ":";
				VariableCommon.dataPrint[8] = ((this.numericUpDown2.Value + num) % 60m).ToString();
				VariableCommon.strPrint = string.Concat(new string[]
				{
					VariableCommon.dataPrint[0],
					VariableCommon.dataPrint[1],
					VariableCommon.dataPrint[2],
					VariableCommon.dataPrint[3],
					VariableCommon.dataPrint[4],
					VariableCommon.dataPrint[5],
					VariableCommon.dataPrint[6],
					VariableCommon.dataPrint[7],
					VariableCommon.dataPrint[8],
					":",
					DateTime.Now.Second.ToString(),
					VariableCommon.parameterSetupLoad[4].ToString()
				});
				this.ZENBARCODE(VariableCommon.strPrint);
				PrintDialog printDialog = new PrintDialog();
				printDialog.Document = this.printDocument1;
				printDialog.AllowSelection = true;
				printDialog.AllowSomePages = true;
				this.printDocument1.Print();
				num++;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000450E File Offset: 0x0000270E
		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		private void btnManualCheck_Click(object sender, EventArgs e)
		{
			int index = this.dataGridView1.CurrentRow.Index;
			bool flag = index == 0;
			if (flag)
			{
				this.OffLoad(1);
				bool flag2 = VariableCommon.presentMode == 1;
				if (flag2)
				{
					this.SetResLoad(1, VariableCommon.lowResValue1);
				}
				bool flag3 = VariableCommon.presentMode == 0;
				if (flag3)
				{
					this.SetCurrentLoad(1, VariableCommon.lowCurValue1);
				}
				bool flag4 = VariableCommon.presentMode == 2;
				if (flag4)
				{
					this.SetVoltLoad(1, VariableCommon.lowVoltValue1);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[0]);
				Program.delay.Delay1(600);
				bool flag5 = (VariableCommon.resInputparam[0] > 0.0 && VariableCommon.presentMode == 1) || (VariableCommon.curInputparam[0] > 0.0 && VariableCommon.presentMode == 0) || (VariableCommon.dcvoltInputparam[0] > 0.0 && VariableCommon.presentMode == 2);
				if (flag5)
				{
					this.OnLoad(1);
				}
				Program.delay.Delay1(600);
				bool flag6 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num;
				if (flag6)
				{
					num = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[0];
				}
				else
				{
					num = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[0];
				}
				bool flag7 = num >= VariableCommon.measureValueUpdate[0] && num <= VariableCommon.measureValueUpdate[1];
				bool flag8 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag9 = flag7 && flag8;
				if (flag9)
				{
					bool flag10 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag10)
					{
						this.dataGridView1.Rows[0].Cells[2].Value = num.ToString() + "V";
					}
					else
					{
						this.dataGridView1.Rows[0].Cells[2].Value = num.ToString() + "W";
					}
					this.dataGridView1.Rows[0].Cells[3].Value = "OK";
				}
				else
				{
					bool flag11 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag11)
					{
						this.dataGridView1.Rows[0].Cells[2].Value = num.ToString() + "V";
					}
					bool flag12 = VariableCommon.presentMode == 2;
					if (flag12)
					{
						this.dataGridView1.Rows[0].Cells[2].Value = num.ToString() + "W";
					}
					this.dataGridView1.Rows[0].Cells[3].Value = "NG";
				}
			}
			bool flag13 = index == 1;
			if (flag13)
			{
				this.OffLoad(1);
				bool flag14 = VariableCommon.presentMode == 1;
				if (flag14)
				{
					this.SetResLoad(1, VariableCommon.lowResValue2);
				}
				bool flag15 = VariableCommon.presentMode == 0;
				if (flag15)
				{
					this.SetCurrentLoad(1, VariableCommon.lowCurValue2);
				}
				bool flag16 = VariableCommon.presentMode == 2;
				if (flag16)
				{
					this.SetVoltLoad(1, VariableCommon.lowVoltValue2);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[1]);
				Program.delay.Delay1(600);
				bool flag17 = (VariableCommon.resInputparam[1] > 0.0 && VariableCommon.presentMode == 1) || (VariableCommon.curInputparam[1] > 0.0 && VariableCommon.presentMode == 0) || (VariableCommon.dcvoltInputparam[1] > 0.0 && VariableCommon.presentMode == 2);
				if (flag17)
				{
					this.OnLoad(1);
				}
				Program.delay.Delay1(600);
				bool flag18 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num2;
				if (flag18)
				{
					num2 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[1];
				}
				else
				{
					num2 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[1];
				}
				bool flag19 = num2 >= VariableCommon.measureValueUpdate[2] && num2 <= VariableCommon.measureValueUpdate[3];
				bool flag20 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag21 = flag19 && flag20;
				if (flag21)
				{
					bool flag22 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag22)
					{
						this.dataGridView1.Rows[1].Cells[2].Value = num2.ToString() + "V";
					}
					bool flag23 = VariableCommon.presentMode == 2;
					if (flag23)
					{
						this.dataGridView1.Rows[1].Cells[2].Value = num2.ToString() + "W";
					}
					this.dataGridView1.Rows[1].Cells[3].Value = "OK";
				}
				else
				{
					bool flag24 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag24)
					{
						this.dataGridView1.Rows[1].Cells[2].Value = num2.ToString() + "V";
					}
					bool flag25 = VariableCommon.presentMode == 2;
					if (flag25)
					{
						this.dataGridView1.Rows[1].Cells[2].Value = num2.ToString() + "W";
					}
					this.dataGridView1.Rows[1].Cells[3].Value = "NG";
				}
			}
			bool flag26 = index == 2;
			if (flag26)
			{
				this.OffLoad(1);
				bool flag27 = VariableCommon.presentMode == 1;
				if (flag27)
				{
					this.SetResLoad(1, VariableCommon.lowResValue3);
				}
				bool flag28 = VariableCommon.presentMode == 0;
				if (flag28)
				{
					this.SetCurrentLoad(1, VariableCommon.lowCurValue3);
				}
				bool flag29 = VariableCommon.presentMode == 2;
				if (flag29)
				{
					this.SetVoltLoad(1, VariableCommon.lowVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[2]);
				Program.delay.Delay1(600);
				bool flag30 = (VariableCommon.resInputparam[2] > 0.0 && VariableCommon.presentMode == 1) || (VariableCommon.curInputparam[2] > 0.0 && VariableCommon.presentMode == 0) || (VariableCommon.dcvoltInputparam[2] > 0.0 && VariableCommon.presentMode == 2);
				if (flag30)
				{
					this.OnLoad(1);
				}
				Program.delay.Delay1(600);
				bool flag31 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num3;
				if (flag31)
				{
					num3 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[2];
				}
				else
				{
					num3 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[2];
				}
				bool flag32 = num3 >= VariableCommon.measureValueUpdate[4] && num3 <= VariableCommon.measureValueUpdate[5];
				bool flag33 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag34 = flag32 && flag33;
				if (flag34)
				{
					bool flag35 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag35)
					{
						this.dataGridView1.Rows[2].Cells[2].Value = num3.ToString() + "V";
					}
					bool flag36 = VariableCommon.presentMode == 2;
					if (flag36)
					{
						this.dataGridView1.Rows[2].Cells[2].Value = num3.ToString() + "W";
					}
					this.dataGridView1.Rows[2].Cells[3].Value = "OK";
				}
				else
				{
					bool flag37 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag37)
					{
						this.dataGridView1.Rows[2].Cells[2].Value = num3.ToString() + "V";
					}
					bool flag38 = VariableCommon.presentMode == 2;
					if (flag38)
					{
						this.dataGridView1.Rows[2].Cells[2].Value = num3.ToString() + "W";
					}
					this.dataGridView1.Rows[2].Cells[3].Value = "NG";
				}
			}
			bool flag39 = index == 3;
			if (flag39)
			{
				this.OffLoad(1);
				bool flag40 = VariableCommon.presentMode == 1;
				if (flag40)
				{
					this.SetResLoad(1, VariableCommon.normalResValue1);
				}
				bool flag41 = VariableCommon.presentMode == 0;
				if (flag41)
				{
					this.SetCurrentLoad(1, VariableCommon.normalCurValue1);
				}
				bool flag42 = VariableCommon.presentMode == 2;
				if (flag42)
				{
					this.SetVoltLoad(1, VariableCommon.normalVoltValue1);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[3]);
				Program.delay.Delay1(600);
				this.OnLoad(1);
				Program.delay.Delay1(600);
				bool flag43 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num4;
				if (flag43)
				{
					num4 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[3];
				}
				else
				{
					num4 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[3];
				}
				bool flag44 = num4 >= VariableCommon.measureValueUpdate[6] && num4 <= VariableCommon.measureValueUpdate[7];
				bool flag45 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag46 = flag44 && flag45;
				if (flag46)
				{
					bool flag47 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag47)
					{
						this.dataGridView1.Rows[3].Cells[2].Value = num4.ToString() + "V";
					}
					bool flag48 = VariableCommon.presentMode == 2;
					if (flag48)
					{
						this.dataGridView1.Rows[3].Cells[2].Value = num4.ToString() + "W";
					}
					this.dataGridView1.Rows[3].Cells[3].Value = "OK";
				}
				else
				{
					bool flag49 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag49)
					{
						this.dataGridView1.Rows[3].Cells[2].Value = num4.ToString() + "V";
					}
					bool flag50 = VariableCommon.presentMode == 2;
					if (flag50)
					{
						this.dataGridView1.Rows[3].Cells[2].Value = num4.ToString() + "W";
					}
					this.dataGridView1.Rows[3].Cells[3].Value = "NG";
				}
			}
			bool flag51 = index == 4;
			if (flag51)
			{
				this.OffLoad(1);
				bool flag52 = VariableCommon.presentMode == 1;
				if (flag52)
				{
					this.SetResLoad(1, VariableCommon.normalResValue2);
				}
				bool flag53 = VariableCommon.presentMode == 0;
				if (flag53)
				{
					this.SetCurrentLoad(1, VariableCommon.normalCurValue2);
				}
				bool flag54 = VariableCommon.presentMode == 2;
				if (flag54)
				{
					this.SetVoltLoad(1, VariableCommon.normalVoltValue2);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[4]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag55 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num5;
				if (flag55)
				{
					num5 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[4];
				}
				else
				{
					num5 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[4];
				}
				bool flag56 = num5 >= VariableCommon.measureValueUpdate[8] && num5 <= VariableCommon.measureValueUpdate[9];
				bool flag57 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag58 = flag56 && flag57;
				if (flag58)
				{
					bool flag59 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag59)
					{
						this.dataGridView1.Rows[4].Cells[2].Value = num5.ToString() + "V";
					}
					bool flag60 = VariableCommon.presentMode == 2;
					if (flag60)
					{
						this.dataGridView1.Rows[4].Cells[2].Value = num5.ToString() + "W";
					}
					this.dataGridView1.Rows[4].Cells[3].Value = "OK";
				}
				else
				{
					bool flag61 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag61)
					{
						this.dataGridView1.Rows[4].Cells[2].Value = num5.ToString() + "V";
					}
					bool flag62 = VariableCommon.presentMode == 2;
					if (flag62)
					{
						this.dataGridView1.Rows[4].Cells[2].Value = num5.ToString() + "W";
					}
					this.dataGridView1.Rows[4].Cells[3].Value = "NG";
				}
			}
			bool flag63 = index == 5;
			if (flag63)
			{
				this.OffLoad(1);
				bool flag64 = VariableCommon.presentMode == 1;
				if (flag64)
				{
					this.SetResLoad(1, VariableCommon.normalResValue3);
				}
				bool flag65 = VariableCommon.presentMode == 0;
				if (flag65)
				{
					this.SetCurrentLoad(1, VariableCommon.normalCurValue3);
				}
				bool flag66 = VariableCommon.presentMode == 2;
				if (flag66)
				{
					this.SetVoltLoad(1, VariableCommon.normalVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[5]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag67 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num6;
				if (flag67)
				{
					num6 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[5];
				}
				else
				{
					num6 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[5];
				}
				bool flag68 = num6 >= VariableCommon.measureValueUpdate[10] && num6 <= VariableCommon.measureValueUpdate[11];
				bool flag69 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag70 = flag68 && flag69;
				if (flag70)
				{
					bool flag71 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag71)
					{
						this.dataGridView1.Rows[5].Cells[2].Value = num6.ToString() + "V";
					}
					bool flag72 = VariableCommon.presentMode == 2;
					if (flag72)
					{
						this.dataGridView1.Rows[5].Cells[2].Value = num6.ToString() + "W";
					}
					this.dataGridView1.Rows[5].Cells[3].Value = "OK";
				}
				else
				{
					bool flag73 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag73)
					{
						this.dataGridView1.Rows[5].Cells[2].Value = num6.ToString() + "V";
					}
					bool flag74 = VariableCommon.presentMode == 2;
					if (flag74)
					{
						this.dataGridView1.Rows[5].Cells[2].Value = num6.ToString() + "W";
					}
					this.dataGridView1.Rows[5].Cells[3].Value = "NG";
				}
			}
			bool flag75 = index == 6;
			if (flag75)
			{
				this.OffLoad(1);
				bool flag76 = VariableCommon.presentMode == 1;
				if (flag76)
				{
					this.SetResLoad(1, VariableCommon.normalResValue3);
				}
				bool flag77 = VariableCommon.presentMode == 0;
				if (flag77)
				{
					this.SetCurrentLoad(1, VariableCommon.normalCurValue3);
				}
				bool flag78 = VariableCommon.presentMode == 2;
				if (flag78)
				{
					this.SetVoltLoad(1, VariableCommon.normalVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[6]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag79 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num7;
				if (flag79)
				{
					num7 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[6];
				}
				else
				{
					num7 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[6];
				}
				bool flag80 = num7 >= VariableCommon.measureValueUpdate[12] && num7 <= VariableCommon.measureValueUpdate[13];
				bool flag81 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag82 = flag80 && flag81;
				if (flag82)
				{
					bool flag83 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag83)
					{
						this.dataGridView1.Rows[6].Cells[2].Value = num7.ToString() + "V";
					}
					bool flag84 = VariableCommon.presentMode == 2;
					if (flag84)
					{
						this.dataGridView1.Rows[6].Cells[2].Value = num7.ToString() + "W";
					}
					this.dataGridView1.Rows[6].Cells[3].Value = "OK";
				}
				else
				{
					bool flag85 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag85)
					{
						this.dataGridView1.Rows[6].Cells[2].Value = num7.ToString() + "V";
					}
					bool flag86 = VariableCommon.presentMode == 2;
					if (flag86)
					{
						this.dataGridView1.Rows[6].Cells[2].Value = num7.ToString() + "W";
					}
					this.dataGridView1.Rows[6].Cells[3].Value = "NG";
				}
			}
			bool flag87 = index == 7;
			if (flag87)
			{
				this.OffLoad(1);
				bool flag88 = VariableCommon.presentMode == 1;
				if (flag88)
				{
					this.SetResLoad(1, VariableCommon.highResValue1);
				}
				bool flag89 = VariableCommon.presentMode == 0;
				if (flag89)
				{
					this.SetCurrentLoad(1, VariableCommon.highCurValue1);
				}
				bool flag90 = VariableCommon.presentMode == 2;
				if (flag90)
				{
					this.SetVoltLoad(1, VariableCommon.highVoltValue1);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[6]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag91 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num8;
				if (flag91)
				{
					num8 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[7];
				}
				else
				{
					num8 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[7];
				}
				bool flag92 = num8 >= VariableCommon.measureValueUpdate[14] && num8 <= VariableCommon.measureValueUpdate[15];
				bool flag93 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag94 = flag92 && flag93;
				if (flag94)
				{
					bool flag95 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag95)
					{
						this.dataGridView1.Rows[7].Cells[2].Value = num8.ToString() + "V";
					}
					bool flag96 = VariableCommon.presentMode == 2;
					if (flag96)
					{
						this.dataGridView1.Rows[7].Cells[2].Value = num8.ToString() + "W";
					}
					this.dataGridView1.Rows[7].Cells[3].Value = "OK";
				}
				else
				{
					bool flag97 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag97)
					{
						this.dataGridView1.Rows[7].Cells[2].Value = num8.ToString() + "V";
					}
					bool flag98 = VariableCommon.presentMode == 2;
					if (flag98)
					{
						this.dataGridView1.Rows[7].Cells[2].Value = num8.ToString() + "W";
					}
					this.dataGridView1.Rows[7].Cells[3].Value = "NG";
				}
			}
			bool flag99 = index == 8;
			if (flag99)
			{
				this.OffLoad(1);
				bool flag100 = VariableCommon.presentMode == 1;
				if (flag100)
				{
					this.SetResLoad(1, VariableCommon.highResValue2);
				}
				bool flag101 = VariableCommon.presentMode == 0;
				if (flag101)
				{
					this.SetCurrentLoad(1, VariableCommon.highCurValue2);
				}
				bool flag102 = VariableCommon.presentMode == 2;
				if (flag102)
				{
					this.SetVoltLoad(1, VariableCommon.highVoltValue2);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[8]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag103 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num9;
				if (flag103)
				{
					num9 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[8];
				}
				else
				{
					num9 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[8];
				}
				bool flag104 = num9 >= VariableCommon.measureValueUpdate[16] && num9 <= VariableCommon.measureValueUpdate[17];
				bool flag105 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag106 = flag104 && flag105;
				if (flag106)
				{
					bool flag107 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag107)
					{
						this.dataGridView1.Rows[8].Cells[2].Value = num9.ToString() + "V";
					}
					bool flag108 = VariableCommon.presentMode == 2;
					if (flag108)
					{
						this.dataGridView1.Rows[8].Cells[2].Value = num9.ToString() + "W";
					}
					this.dataGridView1.Rows[8].Cells[3].Value = "OK";
				}
				else
				{
					bool flag109 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag109)
					{
						this.dataGridView1.Rows[8].Cells[2].Value = num9.ToString() + "V";
					}
					bool flag110 = VariableCommon.presentMode == 2;
					if (flag110)
					{
						this.dataGridView1.Rows[8].Cells[2].Value = num9.ToString() + "W";
					}
					this.dataGridView1.Rows[8].Cells[3].Value = "NG";
				}
			}
			bool flag111 = index == 9;
			if (flag111)
			{
				this.OffLoad(1);
				bool flag112 = VariableCommon.presentMode == 1;
				if (flag112)
				{
					this.SetResLoad(1, VariableCommon.highResValue3);
				}
				bool flag113 = VariableCommon.presentMode == 0;
				if (flag113)
				{
					this.SetCurrentLoad(1, VariableCommon.highCurValue3);
				}
				bool flag114 = VariableCommon.presentMode == 2;
				if (flag114)
				{
					this.SetVoltLoad(1, VariableCommon.highVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.acInputparam[9]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				bool flag115 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
				double num10;
				if (flag115)
				{
					num10 = Math.Round(this.MeasureVolttLoad(1), 2) + VariableCommon.offsetmeasureValue[9];
				}
				else
				{
					num10 = Math.Round(this.GetMeasureValuePower(1)[2], 2) + VariableCommon.offsetmeasureValue[9];
				}
				bool flag116 = num10 >= VariableCommon.measureValueUpdate[18] && num10 <= VariableCommon.measureValueUpdate[19];
				bool flag117 = true;
				this.OffOutputACSource(1);
				this.OffLoad(1);
				bool flag118 = flag116 && flag117;
				if (flag118)
				{
					bool flag119 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag119)
					{
						this.dataGridView1.Rows[9].Cells[2].Value = num10.ToString() + "V";
					}
					bool flag120 = VariableCommon.presentMode == 2;
					if (flag120)
					{
						this.dataGridView1.Rows[9].Cells[2].Value = num10.ToString() + "W";
					}
					this.dataGridView1.Rows[9].Cells[3].Value = "OK";
				}
				else
				{
					bool flag121 = VariableCommon.presentMode == 0 || VariableCommon.presentMode == 1;
					if (flag121)
					{
						this.dataGridView1.Rows[9].Cells[2].Value = num10.ToString() + "V";
					}
					bool flag122 = VariableCommon.presentMode == 2;
					if (flag122)
					{
						this.dataGridView1.Rows[9].Cells[2].Value = num10.ToString() + "W";
					}
					this.dataGridView1.Rows[9].Cells[3].Value = "NG";
				}
			}
			bool flag123 = index == 10;
			if (flag123)
			{
				this.OffLoad(1);
				bool flag124 = VariableCommon.presentMode == 1;
				if (flag124)
				{
					this.SetResLoad(1, VariableCommon.highResValue3);
				}
				bool flag125 = VariableCommon.presentMode == 0;
				if (flag125)
				{
					this.SetCurrentLoad(1, VariableCommon.highCurValue3);
				}
				bool flag126 = VariableCommon.presentMode == 2;
				if (flag126)
				{
					this.SetVoltLoad(1, VariableCommon.highVoltValue3);
				}
				this.SetVoltageOutputACSource(1, VariableCommon.parametervalueupdate[0]);
				Program.delay.Delay1(800);
				this.OnLoad(1);
				Program.delay.Delay1(1000);
				double num11 = Math.Round(this.GetMeasureValuePower(1)[2], 2);
				bool flag127 = num11 - VariableCommon.offsetPower / 100.0 * num11 <= VariableCommon.powerSpec && num11 + VariableCommon.offsetPower / 100.0 * num11 >= VariableCommon.powerSpec;
				this.OffOutputACSource(1);
				bool flag128 = flag127;
				if (flag128)
				{
					this.dataGridView1.Rows[10].Cells[2].Value = num11.ToString() + "W";
					this.dataGridView1.Rows[10].Cells[3].Value = "OK";
				}
				else
				{
					this.dataGridView1.Rows[10].Cells[2].Value = num11.ToString() + "W";
					this.dataGridView1.Rows[10].Cells[3].Value = "NG";
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000450E File Offset: 0x0000270E
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000EA93 File Offset: 0x0000CC93
		private void button1_Click(object sender, EventArgs e)
		{
			this.Test1button();
		}

		// Token: 0x04000025 RID: 37
		private BackgroundWorker work = new BackgroundWorker();

		// Token: 0x04000026 RID: 38
		private string fileNameFolder = "";

		// Token: 0x04000027 RID: 39
		private string filePassrate = "";

		// Token: 0x04000028 RID: 40
		private string fileReport = "";

		// Token: 0x04000029 RID: 41
		private SystemSetting systemSetting = new SystemSetting();

		// Token: 0x0400002A RID: 42
		private int status1;

		// Token: 0x0400002B RID: 43
		private int status2;

		// Token: 0x0400002C RID: 44
		private bool bitStart1;

		// Token: 0x0400002D RID: 45
		private bool bitStart2;

		// Token: 0x0400002E RID: 46
		public string configName;

		// Token: 0x0400002F RID: 47
		public bool enableComPLC;

		// Token: 0x04000030 RID: 48
		public string ComPLCPort;

		// Token: 0x04000031 RID: 49
		public int ComPLCBaudrate;

		// Token: 0x04000032 RID: 50
		public int ComPLCStopBit;

		// Token: 0x04000033 RID: 51
		public string ComPLCParity;

		// Token: 0x04000034 RID: 52
		public int ComPLCDataBit;

		// Token: 0x04000035 RID: 53
		public string ComLoad1Port;

		// Token: 0x04000036 RID: 54
		public bool enableComLoad1;

		// Token: 0x04000037 RID: 55
		public int ComLoad1Baudrate;

		// Token: 0x04000038 RID: 56
		public int ComLoad1Stopbit;

		// Token: 0x04000039 RID: 57
		public string ComLoad1Parity;

		// Token: 0x0400003A RID: 58
		public int ComLoad1DataBit;

		// Token: 0x0400003B RID: 59
		public string ComLoad2Port;

		// Token: 0x0400003C RID: 60
		public bool enableComLoad2;

		// Token: 0x0400003D RID: 61
		public int ComLoad2Baudrate;

		// Token: 0x0400003E RID: 62
		public int ComLoad2Stopbit;

		// Token: 0x0400003F RID: 63
		public string ComLoad2Parity;

		// Token: 0x04000040 RID: 64
		public int ComLoad2DataBit;

		// Token: 0x04000041 RID: 65
		public string ComPowermeter1Port;

		// Token: 0x04000042 RID: 66
		public bool enableComPowermeter1;

		// Token: 0x04000043 RID: 67
		public int ComPowermeter1Baudrate;

		// Token: 0x04000044 RID: 68
		public int ComPowermeter1StopBit;

		// Token: 0x04000045 RID: 69
		public string ComPowermeter1Parity;

		// Token: 0x04000046 RID: 70
		public int ComPowermeter1DataBit;

		// Token: 0x04000047 RID: 71
		public string ComPowermeter2Port;

		// Token: 0x04000048 RID: 72
		public bool enableComPowermeter2;

		// Token: 0x04000049 RID: 73
		public int ComPowermeter2Baudrate;

		// Token: 0x0400004A RID: 74
		public int ComPowermeter2StopBit;

		// Token: 0x0400004B RID: 75
		public string ComPowermeter2Parity;

		// Token: 0x0400004C RID: 76
		public int ComPowermeter2DataBit;

		// Token: 0x0400004D RID: 77
		public string ComACSource1Port;

		// Token: 0x0400004E RID: 78
		public bool enableComACSource1;

		// Token: 0x0400004F RID: 79
		public int ComACSource1Baudrate;

		// Token: 0x04000050 RID: 80
		public int ComACSource1StopBit;

		// Token: 0x04000051 RID: 81
		public string ComACSource1Parity;

		// Token: 0x04000052 RID: 82
		public int ComACSource1DataBit;

		// Token: 0x04000053 RID: 83
		public string ComACSource2Port;

		// Token: 0x04000054 RID: 84
		public bool enableComACSource2;

		// Token: 0x04000055 RID: 85
		public int ComACSource2Baudrate;

		// Token: 0x04000056 RID: 86
		public int ComACSource2StopBit;

		// Token: 0x04000057 RID: 87
		public string ComACSource2Parity;

		// Token: 0x04000058 RID: 88
		public int ComACSource2DataBit;

		// Token: 0x04000059 RID: 89
		private SerialPort comPLC = new SerialPort();

		// Token: 0x0400005A RID: 90
		private SerialPort comLoad1 = new SerialPort();

		// Token: 0x0400005B RID: 91
		private SerialPort comLoad2 = new SerialPort();

		// Token: 0x0400005C RID: 92
		private SerialPort comPowermeter1 = new SerialPort();

		// Token: 0x0400005D RID: 93
		private SerialPort comPowermeter2 = new SerialPort();

		// Token: 0x0400005E RID: 94
		private SerialPort comACSource1 = new SerialPort();

		// Token: 0x0400005F RID: 95
		private SerialPort comACSource2 = new SerialPort();

		// Token: 0x04000060 RID: 96
		public bool coml1OK;

		// Token: 0x04000061 RID: 97
		public bool coml2OK;

		// Token: 0x04000062 RID: 98
		public bool comPlcOk;

		// Token: 0x04000063 RID: 99
		public bool comAC1Ok;

		// Token: 0x04000064 RID: 100
		public bool comAC2Ok;

		// Token: 0x04000065 RID: 101
		public bool comPowermeter1Ok;

		// Token: 0x04000066 RID: 102
		public bool comPowermeter2Ok;

		// Token: 0x04000067 RID: 103
		public string pathApp = Application.StartupPath;

		// Token: 0x04000068 RID: 104
		private Image barcodeimage;

		// Token: 0x04000069 RID: 105
		private Image resizeimage;
	}
}
