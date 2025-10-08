using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FT_ShungHo_Test.Properties;

namespace FT_ShungHo_Test
{
	// Token: 0x02000008 RID: 8
	public partial class ProgramSetup : Form
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00011E9A File Offset: 0x0001009A
		public ProgramSetup()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00011EAC File Offset: 0x000100AC
		private void ProgramSetup_Load(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Add();
			this.dataGridView1.Rows.Add();
			this.dataGridView3.Rows.Add();
			this.dataGridView3.Rows.Add();
			this.dataGridView3.Rows.Add();
			this.dataGridView3.Rows.Add();
			this.GetListFileInFolder(VariableCommon.programPath);
			this.cbbSelectModel.SelectedIndex = 0;
			this.LoadSetupData(VariableCommon.programPath + "\\" + this.txtNewModelName.Text + ".csv");
			this.txtOCP_LowerOffset.Text = Settings.Default.OCP_LowerOffset.ToString();
			this.txtOCP_HigherOffset.Text = Settings.Default.OCP_HigherOffset.ToString();
			this.txtOCP_CurrentStep.Text = Settings.Default.OCP_CurrentStep.ToString();
			this.txtOCP_StepDelay.Text = Settings.Default.OCP_StepDelay.ToString();
			this.txtOCP_LowerLimit.Text = Settings.Default.OCP_LowerLimit.ToString();
			this.txtOCP_UpperLimit.Text = Settings.Default.OCP_UpperLimit.ToString();
			this.txtShortTest_MaximumCurrent.Text = Settings.Default.ShortTest_MaximumCurrent.ToString();
			this.txtShortTest_Delay.Text = Settings.Default.ShortTest_Delay.ToString();
			this.txtShortTest_JudgementVoltage.Text = Settings.Default.ShortTest_JudgementVoltage.ToString();
			bool shortTest_Enable = Settings.Default.ShortTest_Enable;
			if (shortTest_Enable)
			{
				this.ckbShortTest.Checked = true;
			}
			else
			{
				this.ckbShortTest.Checked = false;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000022C4 File Offset: 0x000004C4
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00012098 File Offset: 0x00010298
		private void btnNewModel_Click(object sender, EventArgs e)
		{
			bool flag = this.txtNewModelName.Text != "" && this.txtNewModelName.Text + ".csv" != this.cbbSelectModel.Text;
			if (flag)
			{
				this.SaveSetupdata(VariableCommon.programPath + "\\" + this.txtNewModelName.Text + ".csv");
				this.cbbSelectModel.Items.Clear();
				MessageBox.Show("Tạo mới file chương trình thành công");
				this.GetListFileInFolder(VariableCommon.programPath);
				Application.Restart();
			}
			else
			{
				MessageBox.Show("Tạo mới file chương trình không thành công. Vui lòng nhập tên model");
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0001214C File Offset: 0x0001034C
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = this.txtNewModelName.Text != "" && this.txtNewModelName.Text == this.cbbSelectModel.Text;
			if (flag)
			{
				Settings.Default.OCP_LowerOffset = Convert.ToDouble(this.txtOCP_LowerOffset.Text);
				Settings.Default.OCP_HigherOffset = Convert.ToDouble(this.txtOCP_HigherOffset.Text);
				Settings.Default.OCP_CurrentStep = Convert.ToDouble(this.txtOCP_CurrentStep.Text);
				Settings.Default.OCP_StepDelay = (long)Convert.ToInt32(this.txtOCP_StepDelay.Text);
				Settings.Default.OCP_LowerLimit = Convert.ToDouble(this.txtOCP_LowerLimit.Text);
				Settings.Default.OCP_UpperLimit = Convert.ToDouble(this.txtOCP_UpperLimit.Text);
				Settings.Default.ShortTest_MaximumCurrent = Convert.ToDouble(this.txtShortTest_MaximumCurrent.Text);
				Settings.Default.ShortTest_Delay = (long)Convert.ToInt32(this.txtShortTest_Delay.Text);
				Settings.Default.ShortTest_JudgementVoltage = Convert.ToDouble(this.txtShortTest_JudgementVoltage.Text);
				bool @checked = this.ckbShortTest.Checked;
				if (@checked)
				{
					Settings.Default.ShortTest_Enable = true;
				}
				else
				{
					Settings.Default.ShortTest_Enable = false;
				}
				Settings.Default.Save();
				this.SaveSetupdata(VariableCommon.programPath + "\\" + this.txtNewModelName.Text + ".csv");
				this.cbbSelectModel.Items.Clear();
				this.GetListFileInFolder(VariableCommon.programPath);
				MessageBox.Show("Chỉnh sửa file chương trình thành công");
				Application.Restart();
			}
			else
			{
				MessageBox.Show("Sửa file chương trình không thành công. Vui lòng chọn lại model");
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00012324 File Offset: 0x00010524
		private void SaveSetupdata(string path)
		{
			using (StreamWriter streamWriter = new StreamWriter(path, false))
			{
				string value = string.Concat(new string[]
				{
					"EP-CODE",
					",",
					"TEMPLATE NAME",
					",",
					"VOLT TO POWER TEST",
					",",
					"Customer",
					",",
					"Line Name"
				});
				streamWriter.WriteLine(value);
				string value2 = string.Concat(new object[]
				{
					this.dataGridView1.Rows[0].Cells[0].Value,
					",",
					this.dataGridView1.Rows[0].Cells[1].Value,
					",",
					this.dataGridView1.Rows[0].Cells[2].Value,
					",",
					this.dataGridView1.Rows[0].Cells[3].Value,
					",",
					this.dataGridView1.Rows[0].Cells[4].Value
				});
				streamWriter.WriteLine(value2);
				string value3 = string.Concat(new string[]
				{
					"STEP 1-1 MIN",
					",",
					"STEP 1-1 MAX",
					",",
					"STEP 1-2 MIN",
					",",
					"STEP 1-2 MAX",
					",",
					"STEP 1-3 MIN",
					",",
					"STEP 1-3 MAX",
					",",
					"STEP 2-1 MIN",
					",",
					"STEP 2-1 MAX",
					",",
					"STEP 2-2 MIN",
					",",
					"STEP 2-2 MAX",
					",",
					"STEP 2-3 MIN",
					",",
					"STEP 2-3 MAX",
					",",
					"STEP 2-4 MIN",
					",",
					"STEP 2-4 MAX",
					",",
					"STEP 3-1 MIN",
					",",
					"STEP 3-1 MAX",
					",",
					"STEP 3-2 MIN",
					",",
					"STEP 3-2 MAX",
					",",
					"STEP 3-3 MIN",
					",",
					"STEP 3-3 MAX",
					",",
					"POWER VALUE",
					",",
					"OCP VALUE",
					",",
					"DIFFERENCE POWER"
				});
				streamWriter.WriteLine(value3);
				string value4 = string.Concat(new object[]
				{
					this.dataGridView2.Rows[0].Cells[0].Value,
					",",
					this.dataGridView2.Rows[0].Cells[1].Value,
					",",
					this.dataGridView2.Rows[0].Cells[2].Value,
					",",
					this.dataGridView2.Rows[0].Cells[3].Value,
					",",
					this.dataGridView2.Rows[0].Cells[4].Value,
					",",
					this.dataGridView2.Rows[0].Cells[5].Value,
					",",
					this.dataGridView2.Rows[0].Cells[6].Value,
					",",
					this.dataGridView2.Rows[0].Cells[7].Value,
					",",
					this.dataGridView2.Rows[0].Cells[8].Value,
					",",
					this.dataGridView2.Rows[0].Cells[9].Value,
					",",
					this.dataGridView2.Rows[0].Cells[10].Value,
					",",
					this.dataGridView2.Rows[0].Cells[11].Value,
					",",
					this.dataGridView2.Rows[0].Cells[12].Value,
					",",
					this.dataGridView2.Rows[0].Cells[13].Value,
					",",
					this.dataGridView2.Rows[0].Cells[14].Value,
					",",
					this.dataGridView2.Rows[0].Cells[15].Value,
					",",
					this.dataGridView2.Rows[0].Cells[16].Value,
					",",
					this.dataGridView2.Rows[0].Cells[17].Value,
					",",
					this.dataGridView2.Rows[0].Cells[18].Value,
					",",
					this.dataGridView2.Rows[0].Cells[19].Value,
					",",
					this.dataGridView2.Rows[0].Cells[20].Value,
					",",
					this.dataGridView2.Rows[0].Cells[21].Value,
					",",
					this.dataGridView2.Rows[0].Cells[22].Value
				});
				streamWriter.WriteLine(value4);
				string value5 = string.Concat(new string[]
				{
					this.ckbSTEP11.Text,
					",",
					this.ckbSTEP12.Text,
					",",
					this.ckbSTEP13.Text,
					",",
					this.ckbSTEP21.Text,
					",",
					this.ckbSTEP22.Text,
					",",
					this.ckbSTEP23.Text,
					",",
					this.ckbSTEP24.Text,
					",",
					this.ckbSTEP31.Text,
					",",
					this.ckbSTEP32.Text,
					",",
					this.ckbSTEP33.Text,
					",",
					this.ckbOCP.Text,
					",",
					this.ckbCCMODE.Text,
					",",
					this.ckbCRMODE.Text,
					",",
					this.ckbCVMODE.Text,
					",",
					this.ckbPowerMes.Text
				});
				streamWriter.WriteLine(value5);
				string value6 = string.Concat(new object[]
				{
					this.ckbSTEP11.Checked,
					",",
					this.ckbSTEP12.Checked,
					",",
					this.ckbSTEP13.Checked,
					",",
					this.ckbSTEP21.Checked,
					",",
					this.ckbSTEP22.Checked,
					",",
					this.ckbSTEP23.Checked,
					",",
					this.ckbSTEP24.Checked,
					",",
					this.ckbSTEP31.Checked,
					",",
					this.ckbSTEP32.Checked,
					",",
					this.ckbSTEP33.Checked,
					",",
					this.ckbOCP.Checked,
					",",
					this.ckbCCMODE.Checked,
					",",
					this.ckbCRMODE.Checked,
					",",
					this.ckbCVMODE.Checked,
					",",
					this.ckbPowerMes.Checked
				});
				streamWriter.WriteLine(value6);
				string value7 = string.Concat(new string[]
				{
					this.label3.Text,
					",",
					this.label4.Text,
					",",
					this.label5.Text
				});
				streamWriter.WriteLine(value7);
				string value8 = string.Concat(new object[]
				{
					this.nbrLow.Value,
					",",
					this.nbrNormal.Value,
					",",
					this.nbrHigh.Value
				});
				streamWriter.WriteLine(value8);
				string value9 = string.Concat(new string[]
				{
					"Name",
					",",
					"LOAD1 0.2A",
					",",
					"LOAD1 0.2A",
					",",
					"LOAD2 100%",
					",",
					"LOAD3 100%",
					",",
					"LOAD1 100%",
					",",
					"LOAD2 100%",
					",",
					"LOAD3 100%",
					",",
					"LOAD1 100%",
					",",
					"LOAD2 100%",
					",",
					"LOAD3 100%"
				});
				streamWriter.WriteLine(value9);
				string value10 = string.Concat(new object[]
				{
					this.dataGridView3.Rows[0].Cells[0].Value,
					",",
					this.dataGridView3.Rows[0].Cells[1].Value,
					",",
					this.dataGridView3.Rows[0].Cells[2].Value,
					",",
					this.dataGridView3.Rows[0].Cells[3].Value,
					",",
					this.dataGridView3.Rows[0].Cells[4].Value,
					",",
					this.dataGridView3.Rows[0].Cells[5].Value,
					",",
					this.dataGridView3.Rows[0].Cells[6].Value,
					",",
					this.dataGridView3.Rows[0].Cells[7].Value,
					",",
					this.dataGridView3.Rows[0].Cells[8].Value,
					",",
					this.dataGridView3.Rows[0].Cells[9].Value,
					",",
					this.dataGridView3.Rows[0].Cells[10].Value
				});
				streamWriter.WriteLine(value10);
				string value11 = string.Concat(new object[]
				{
					this.dataGridView3.Rows[1].Cells[0].Value,
					",",
					this.dataGridView3.Rows[1].Cells[1].Value,
					",",
					this.dataGridView3.Rows[1].Cells[2].Value,
					",",
					this.dataGridView3.Rows[1].Cells[3].Value,
					",",
					this.dataGridView3.Rows[1].Cells[4].Value,
					",",
					this.dataGridView3.Rows[1].Cells[5].Value,
					",",
					this.dataGridView3.Rows[1].Cells[6].Value,
					",",
					this.dataGridView3.Rows[1].Cells[7].Value,
					",",
					this.dataGridView3.Rows[1].Cells[8].Value,
					",",
					this.dataGridView3.Rows[1].Cells[9].Value,
					",",
					this.dataGridView3.Rows[1].Cells[10].Value
				});
				streamWriter.WriteLine(value11);
				string value12 = string.Concat(new object[]
				{
					this.dataGridView3.Rows[2].Cells[0].Value,
					",",
					this.dataGridView3.Rows[2].Cells[1].Value,
					",",
					this.dataGridView3.Rows[2].Cells[2].Value,
					",",
					this.dataGridView3.Rows[2].Cells[3].Value,
					",",
					this.dataGridView3.Rows[2].Cells[4].Value,
					",",
					this.dataGridView3.Rows[2].Cells[5].Value,
					",",
					this.dataGridView3.Rows[2].Cells[6].Value,
					",",
					this.dataGridView3.Rows[2].Cells[7].Value,
					",",
					this.dataGridView3.Rows[2].Cells[8].Value,
					",",
					this.dataGridView3.Rows[2].Cells[9].Value,
					",",
					this.dataGridView3.Rows[2].Cells[10].Value
				});
				streamWriter.WriteLine(value12);
				string value13 = string.Concat(new object[]
				{
					this.dataGridView3.Rows[3].Cells[0].Value,
					",",
					this.dataGridView3.Rows[3].Cells[1].Value,
					",",
					this.dataGridView3.Rows[3].Cells[2].Value,
					",",
					this.dataGridView3.Rows[3].Cells[3].Value,
					",",
					this.dataGridView3.Rows[3].Cells[4].Value,
					",",
					this.dataGridView3.Rows[3].Cells[5].Value,
					",",
					this.dataGridView3.Rows[3].Cells[6].Value,
					",",
					this.dataGridView3.Rows[3].Cells[7].Value,
					",",
					this.dataGridView3.Rows[3].Cells[8].Value,
					",",
					this.dataGridView3.Rows[3].Cells[9].Value,
					",",
					this.dataGridView3.Rows[3].Cells[10].Value
				});
				streamWriter.WriteLine(value13);
				string value14 = string.Concat(new object[]
				{
					this.dataGridView3.Rows[4].Cells[0].Value,
					",",
					this.dataGridView3.Rows[4].Cells[1].Value,
					",",
					this.dataGridView3.Rows[4].Cells[2].Value,
					",",
					this.dataGridView3.Rows[4].Cells[3].Value,
					",",
					this.dataGridView3.Rows[4].Cells[4].Value,
					",",
					this.dataGridView3.Rows[4].Cells[5].Value,
					",",
					this.dataGridView3.Rows[4].Cells[6].Value,
					",",
					this.dataGridView3.Rows[4].Cells[7].Value,
					",",
					this.dataGridView3.Rows[4].Cells[8].Value,
					",",
					this.dataGridView3.Rows[4].Cells[9].Value,
					",",
					this.dataGridView3.Rows[4].Cells[10].Value
				});
				streamWriter.WriteLine(value14);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00013928 File Offset: 0x00011B28
		private void LoadSetupData(string path)
		{
			bool flag = File.Exists(path);
			if (flag)
			{
				string text = ReadCsvFile.ReadTextFile(path, 10);
				VariableCommon.parameterSetupLoad3 = text.Split(new char[]
				{
					','
				});
				for (int i = 0; i < this.dataGridView3.Rows[0].Cells.Count; i++)
				{
					this.dataGridView3.Rows[0].Cells[i].Value = VariableCommon.parameterSetupLoad3[i];
				}
				string text2 = ReadCsvFile.ReadTextFile(path, 11);
				VariableCommon.parameterSetupLoad4 = text2.Split(new char[]
				{
					','
				});
				for (int j = 0; j < this.dataGridView3.Rows[1].Cells.Count; j++)
				{
					this.dataGridView3.Rows[1].Cells[j].Value = VariableCommon.parameterSetupLoad4[j];
				}
				string text3 = ReadCsvFile.ReadTextFile(path, 12);
				VariableCommon.parameterSetupLoad5 = text3.Split(new char[]
				{
					','
				});
				for (int k = 0; k < this.dataGridView3.Rows[2].Cells.Count; k++)
				{
					this.dataGridView3.Rows[2].Cells[k].Value = VariableCommon.parameterSetupLoad5[k];
				}
				string text4 = ReadCsvFile.ReadTextFile(path, 13);
				VariableCommon.parameterSetupLoad6 = text4.Split(new char[]
				{
					','
				});
				for (int l = 0; l < this.dataGridView3.Rows[3].Cells.Count; l++)
				{
					this.dataGridView3.Rows[3].Cells[l].Value = VariableCommon.parameterSetupLoad6[l];
				}
				string text5 = ReadCsvFile.ReadTextFile(path, 2);
				VariableCommon.parameterSetupLoad = text5.Split(new char[]
				{
					','
				});
				for (int m = 0; m < this.dataGridView1.Rows[0].Cells.Count; m++)
				{
					this.dataGridView1.Rows[0].Cells[m].Value = VariableCommon.parameterSetupLoad[m];
				}
				string text6 = ReadCsvFile.ReadTextFile(path, 14);
				VariableCommon.parameterSetupLoad7 = text6.Split(new char[]
				{
					','
				});
				for (int n = 0; n < this.dataGridView3.Rows[4].Cells.Count; n++)
				{
					this.dataGridView3.Rows[4].Cells[n].Value = VariableCommon.parameterSetupLoad7[n];
				}
				string text7 = ReadCsvFile.ReadTextFile(path, 4);
				VariableCommon.measureValueSetup = text7.Split(new char[]
				{
					','
				});
				for (int num = 0; num < this.dataGridView2.Rows[0].Cells.Count; num++)
				{
					this.dataGridView2.Rows[0].Cells[num].Value = VariableCommon.measureValueSetup[num];
				}
				string text8 = ReadCsvFile.ReadTextFile(path, 6);
				string[] array = new string[12];
				array = text8.Split(new char[]
				{
					','
				});
				for (int num2 = 0; num2 < VariableCommon.enableMeasurestep.Length; num2++)
				{
					bool flag2 = array[num2] == "True";
					if (flag2)
					{
						VariableCommon.enableMeasurestep[num2] = true;
					}
					else
					{
						VariableCommon.enableMeasurestep[num2] = false;
					}
				}
				this.ckbSTEP11.Checked = VariableCommon.enableMeasurestep[0];
				this.ckbSTEP12.Checked = VariableCommon.enableMeasurestep[1];
				this.ckbSTEP13.Checked = VariableCommon.enableMeasurestep[2];
				this.ckbSTEP21.Checked = VariableCommon.enableMeasurestep[3];
				this.ckbSTEP22.Checked = VariableCommon.enableMeasurestep[4];
				this.ckbSTEP23.Checked = VariableCommon.enableMeasurestep[5];
				this.ckbSTEP24.Checked = VariableCommon.enableMeasurestep[6];
				this.ckbSTEP31.Checked = VariableCommon.enableMeasurestep[7];
				this.ckbSTEP32.Checked = VariableCommon.enableMeasurestep[8];
				this.ckbSTEP33.Checked = VariableCommon.enableMeasurestep[9];
				this.ckbOCP.Checked = VariableCommon.enableMeasurestep[10];
				this.ckbCCMODE.Checked = VariableCommon.enableMeasurestep[11];
				this.ckbCRMODE.Checked = VariableCommon.enableMeasurestep[12];
				this.ckbCVMODE.Checked = VariableCommon.enableMeasurestep[13];
				this.ckbPowerMes.Checked = VariableCommon.enableMeasurestep[14];
				string text9 = ReadCsvFile.ReadTextFile(path, 8);
				string[] array2 = new string[12];
				array2 = text9.Split(new char[]
				{
					','
				});
				this.nbrLow.Value = (decimal)Convert.ToDouble(array2[0]);
				this.nbrNormal.Value = (decimal)Convert.ToDouble(array2[1]);
				this.nbrHigh.Value = (decimal)Convert.ToDouble(array2[2]);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00013EB8 File Offset: 0x000120B8
		private void GetListFileInFolder(string path)
		{
			FileInfo[] files = new DirectoryInfo(path).GetFiles("*.csv");
			string str = "";
			foreach (FileInfo fileInfo in files)
			{
				str = str + ", " + fileInfo.Name;
				this.cbbSelectModel.Items.Add(fileInfo.Name.Remove(fileInfo.Name.Length - 4));
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00013F34 File Offset: 0x00012134
		private void cbbSelectModel_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] array = this.cbbSelectModel.Text.Split(new char[]
			{
				'.'
			});
			this.txtNewModelName.Text = array[0];
			this.LoadSetupData(VariableCommon.programPath + "\\" + this.txtNewModelName.Text + ".csv");
			this.lblModelName.Text = this.txtNewModelName.Text;
		}

		// Token: 0x040000F1 RID: 241
		private TextBoxColumn Step12Min;

		// Token: 0x040000FB RID: 251
		private TextBoxColumn textBoxColumn1;
	}
}
