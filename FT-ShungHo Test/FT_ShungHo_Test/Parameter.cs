using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FT_ShungHo_Test
{
	// Token: 0x02000006 RID: 6
	public partial class Parameter : Form
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00010AC7 File Offset: 0x0000ECC7
		public Parameter()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000022C4 File Offset: 0x000004C4
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.SaveConfigProgram(VariableCommon.programPath + "\\ProgramFile.csv");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		public void SaveConfigProgram(string pathsave)
		{
			try
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
					string value2 = string.Concat(new string[]
					{
						this.nbrMaxValueLoad1.Value.ToString(),
						",",
						this.nbrMinValueLoad1.Value.ToString(),
						",",
						this.nbrMaxValuePW1.Value.ToString(),
						",",
						this.nbrMinValuePW1.Value.ToString(),
						",",
						this.nbrMaxValueLoad2.Value.ToString(),
						",",
						this.nbrMinValueLoad2.Value.ToString(),
						",",
						this.nbrMaxValuePW2.Value.ToString(),
						",",
						this.nbrMinValuePW2.Value.ToString()
					});
					streamWriter.WriteLine(value2);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Thử lại");
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		private void Parameter_Load(object sender, EventArgs e)
		{
			this.nbrMaxValueLoad1.Value = Convert.ToDecimal(VariableCommon.LOAD1VALUEMAX);
			this.nbrMaxValueLoad2.Value = Convert.ToDecimal(VariableCommon.LOAD2VALUEMAX);
			this.nbrMinValueLoad1.Value = Convert.ToDecimal(VariableCommon.LOAD1VALUEMIN);
			this.nbrMinValueLoad2.Value = Convert.ToDecimal(VariableCommon.LOAD2VALUEMIN);
			this.nbrMaxValuePW1.Value = Convert.ToDecimal(VariableCommon.PW1VALUEMAX);
			this.nbrMaxValuePW2.Value = Convert.ToDecimal(VariableCommon.PW2VALUEMAX);
			this.nbrMinValuePW1.Value = Convert.ToDecimal(VariableCommon.PW1VALUEMIN);
			this.nbrMinValuePW2.Value = Convert.ToDecimal(VariableCommon.PW2VALUEMIN);
		}
	}
}
