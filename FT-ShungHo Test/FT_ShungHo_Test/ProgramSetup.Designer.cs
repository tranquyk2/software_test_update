namespace FT_ShungHo_Test
{
	// Token: 0x02000008 RID: 8
	public partial class ProgramSetup : global::System.Windows.Forms.Form
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00013FAC File Offset: 0x000121AC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00013FE4 File Offset: 0x000121E4
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.txtShortTest_Delay = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.txtShortTest_JudgementVoltage = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.txtShortTest_MaximumCurrent = new global::System.Windows.Forms.TextBox();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.txtOCP_UpperLimit = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtOCP_StepDelay = new global::System.Windows.Forms.TextBox();
			this.txtOCP_LowerLimit = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtOCP_CurrentStep = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.txtOCP_HigherOffset = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.txtOCP_LowerOffset = new global::System.Windows.Forms.TextBox();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.ckbCVMODE = new global::System.Windows.Forms.RadioButton();
			this.ckbCCMODE = new global::System.Windows.Forms.RadioButton();
			this.ckbCRMODE = new global::System.Windows.Forms.RadioButton();
			this.nbrHigh = new global::System.Windows.Forms.NumericUpDown();
			this.nbrNormal = new global::System.Windows.Forms.NumericUpDown();
			this.nbrLow = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.ckbShortTest = new global::System.Windows.Forms.CheckBox();
			this.ckbPowerMes = new global::System.Windows.Forms.CheckBox();
			this.ckbOCP = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP22 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP33 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP21 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP32 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP13 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP31 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP12 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP24 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP23 = new global::System.Windows.Forms.CheckBox();
			this.ckbSTEP11 = new global::System.Windows.Forms.CheckBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.cbbSelectModel = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtNewModelName = new global::System.Windows.Forms.TextBox();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnNewModel = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dataGridView3 = new global::System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.EPCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TemplateName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ACVoltageMesPower = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.lblModelName = new global::System.Windows.Forms.Label();
			this.dataGridView2 = new global::System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn33 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn34 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxColumn2 = new global::System.Windows.Forms.TextBoxColumn();
			this.dataGridViewTextBoxColumn35 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn36 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn37 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn38 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn39 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn40 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn41 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn42 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn43 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn44 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn45 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn46 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn47 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn48 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn49 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn50 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn51 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn52 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn53 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn54 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrHigh).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrNormal).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrLow).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView2).BeginInit();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.groupBox7);
			this.panel1.Controls.Add(this.groupBox6);
			this.panel1.Controls.Add(this.groupBox5);
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new global::System.Drawing.Point(4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1315, 664);
			this.panel1.TabIndex = 0;
			this.groupBox7.Controls.Add(this.label12);
			this.groupBox7.Controls.Add(this.txtShortTest_Delay);
			this.groupBox7.Controls.Add(this.label16);
			this.groupBox7.Controls.Add(this.txtShortTest_JudgementVoltage);
			this.groupBox7.Controls.Add(this.label17);
			this.groupBox7.Controls.Add(this.txtShortTest_MaximumCurrent);
			this.groupBox7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox7.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox7.Location = new global::System.Drawing.Point(904, 319);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(407, 132);
			this.groupBox7.TabIndex = 6;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "SHORT TEST setting:";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(97, 61);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(98, 13);
			this.label12.TabIndex = 11;
			this.label12.Text = "Step delay (ms):";
			this.txtShortTest_Delay.Location = new global::System.Drawing.Point(196, 54);
			this.txtShortTest_Delay.Multiline = true;
			this.txtShortTest_Delay.Name = "txtShortTest_Delay";
			this.txtShortTest_Delay.Size = new global::System.Drawing.Size(86, 29);
			this.txtShortTest_Delay.TabIndex = 10;
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(11, 96);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(184, 13);
			this.label16.TabIndex = 5;
			this.label16.Text = "Judgement voltage (Under) (V):";
			this.txtShortTest_JudgementVoltage.Location = new global::System.Drawing.Point(196, 89);
			this.txtShortTest_JudgementVoltage.Multiline = true;
			this.txtShortTest_JudgementVoltage.Name = "txtShortTest_JudgementVoltage";
			this.txtShortTest_JudgementVoltage.Size = new global::System.Drawing.Size(86, 29);
			this.txtShortTest_JudgementVoltage.TabIndex = 4;
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(17, 26);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(178, 13);
			this.label17.TabIndex = 3;
			this.label17.Text = "DC Load maximum current (A):";
			this.txtShortTest_MaximumCurrent.Location = new global::System.Drawing.Point(196, 19);
			this.txtShortTest_MaximumCurrent.Multiline = true;
			this.txtShortTest_MaximumCurrent.Name = "txtShortTest_MaximumCurrent";
			this.txtShortTest_MaximumCurrent.Size = new global::System.Drawing.Size(86, 29);
			this.txtShortTest_MaximumCurrent.TabIndex = 2;
			this.groupBox6.Controls.Add(this.label11);
			this.groupBox6.Controls.Add(this.txtOCP_UpperLimit);
			this.groupBox6.Controls.Add(this.label10);
			this.groupBox6.Controls.Add(this.label9);
			this.groupBox6.Controls.Add(this.txtOCP_StepDelay);
			this.groupBox6.Controls.Add(this.txtOCP_LowerLimit);
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Controls.Add(this.txtOCP_CurrentStep);
			this.groupBox6.Controls.Add(this.label7);
			this.groupBox6.Controls.Add(this.txtOCP_HigherOffset);
			this.groupBox6.Controls.Add(this.label6);
			this.groupBox6.Controls.Add(this.txtOCP_LowerOffset);
			this.groupBox6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox6.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox6.Location = new global::System.Drawing.Point(904, 187);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(407, 126);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "OCP setting:";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(224, 97);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(91, 13);
			this.label11.TabIndex = 13;
			this.label11.Text = "Upper limit (A):";
			this.txtOCP_UpperLimit.Location = new global::System.Drawing.Point(316, 90);
			this.txtOCP_UpperLimit.Multiline = true;
			this.txtOCP_UpperLimit.Name = "txtOCP_UpperLimit";
			this.txtOCP_UpperLimit.Size = new global::System.Drawing.Size(86, 29);
			this.txtOCP_UpperLimit.TabIndex = 12;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(224, 61);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(91, 13);
			this.label10.TabIndex = 11;
			this.label10.Text = "Lower limit (A):";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(217, 26);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(98, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Step delay (ms):";
			this.txtOCP_StepDelay.Location = new global::System.Drawing.Point(316, 19);
			this.txtOCP_StepDelay.Multiline = true;
			this.txtOCP_StepDelay.Name = "txtOCP_StepDelay";
			this.txtOCP_StepDelay.Size = new global::System.Drawing.Size(86, 29);
			this.txtOCP_StepDelay.TabIndex = 8;
			this.txtOCP_LowerLimit.Location = new global::System.Drawing.Point(316, 54);
			this.txtOCP_LowerLimit.Multiline = true;
			this.txtOCP_LowerLimit.Name = "txtOCP_LowerLimit";
			this.txtOCP_LowerLimit.Size = new global::System.Drawing.Size(86, 29);
			this.txtOCP_LowerLimit.TabIndex = 10;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(14, 97);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(100, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Current step (A):";
			this.txtOCP_CurrentStep.Location = new global::System.Drawing.Point(115, 90);
			this.txtOCP_CurrentStep.Multiline = true;
			this.txtOCP_CurrentStep.Name = "txtOCP_CurrentStep";
			this.txtOCP_CurrentStep.Size = new global::System.Drawing.Size(86, 29);
			this.txtOCP_CurrentStep.TabIndex = 6;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(10, 61);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(104, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Higher offset (A):";
			this.txtOCP_HigherOffset.Location = new global::System.Drawing.Point(115, 54);
			this.txtOCP_HigherOffset.Multiline = true;
			this.txtOCP_HigherOffset.Name = "txtOCP_HigherOffset";
			this.txtOCP_HigherOffset.Size = new global::System.Drawing.Size(86, 29);
			this.txtOCP_HigherOffset.TabIndex = 4;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(13, 26);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(101, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Lower offset (A):";
			this.txtOCP_LowerOffset.Location = new global::System.Drawing.Point(115, 19);
			this.txtOCP_LowerOffset.Multiline = true;
			this.txtOCP_LowerOffset.Name = "txtOCP_LowerOffset";
			this.txtOCP_LowerOffset.Size = new global::System.Drawing.Size(86, 29);
			this.txtOCP_LowerOffset.TabIndex = 2;
			this.groupBox5.Controls.Add(this.ckbCVMODE);
			this.groupBox5.Controls.Add(this.ckbCCMODE);
			this.groupBox5.Controls.Add(this.ckbCRMODE);
			this.groupBox5.Controls.Add(this.nbrHigh);
			this.groupBox5.Controls.Add(this.nbrNormal);
			this.groupBox5.Controls.Add(this.nbrLow);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox5.Location = new global::System.Drawing.Point(904, 72);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(407, 109);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Mode setting:";
			this.ckbCVMODE.AutoSize = true;
			this.ckbCVMODE.Location = new global::System.Drawing.Point(10, 62);
			this.ckbCVMODE.Name = "ckbCVMODE";
			this.ckbCVMODE.Size = new global::System.Drawing.Size(76, 17);
			this.ckbCVMODE.TabIndex = 3;
			this.ckbCVMODE.TabStop = true;
			this.ckbCVMODE.Text = "CV-Mode";
			this.ckbCVMODE.UseVisualStyleBackColor = true;
			this.ckbCCMODE.AutoSize = true;
			this.ckbCCMODE.Location = new global::System.Drawing.Point(10, 39);
			this.ckbCCMODE.Name = "ckbCCMODE";
			this.ckbCCMODE.Size = new global::System.Drawing.Size(76, 17);
			this.ckbCCMODE.TabIndex = 3;
			this.ckbCCMODE.TabStop = true;
			this.ckbCCMODE.Text = "CC-Mode";
			this.ckbCCMODE.UseVisualStyleBackColor = true;
			this.ckbCRMODE.AutoSize = true;
			this.ckbCRMODE.Location = new global::System.Drawing.Point(10, 17);
			this.ckbCRMODE.Name = "ckbCRMODE";
			this.ckbCRMODE.Size = new global::System.Drawing.Size(77, 17);
			this.ckbCRMODE.TabIndex = 3;
			this.ckbCRMODE.TabStop = true;
			this.ckbCRMODE.Text = "CR-Mode";
			this.ckbCRMODE.UseVisualStyleBackColor = true;
			this.nbrHigh.DecimalPlaces = 1;
			this.nbrHigh.Location = new global::System.Drawing.Point(343, 65);
			this.nbrHigh.Name = "nbrHigh";
			this.nbrHigh.Size = new global::System.Drawing.Size(59, 20);
			this.nbrHigh.TabIndex = 1;
			this.nbrHigh.Visible = false;
			this.nbrNormal.DecimalPlaces = 1;
			this.nbrNormal.Location = new global::System.Drawing.Point(343, 40);
			this.nbrNormal.Name = "nbrNormal";
			this.nbrNormal.Size = new global::System.Drawing.Size(59, 20);
			this.nbrNormal.TabIndex = 1;
			this.nbrNormal.Visible = false;
			this.nbrLow.DecimalPlaces = 1;
			this.nbrLow.Location = new global::System.Drawing.Point(343, 16);
			this.nbrLow.Name = "nbrLow";
			this.nbrLow.Size = new global::System.Drawing.Size(59, 20);
			this.nbrLow.TabIndex = 1;
			this.nbrLow.Visible = false;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(234, 67);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(85, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "High level(%):";
			this.label5.Visible = false;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(234, 42);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(98, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Normal level(%):";
			this.label4.Visible = false;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(234, 19);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(82, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Low level(%):";
			this.label3.Visible = false;
			this.groupBox4.Controls.Add(this.ckbShortTest);
			this.groupBox4.Controls.Add(this.ckbPowerMes);
			this.groupBox4.Controls.Add(this.ckbOCP);
			this.groupBox4.Controls.Add(this.ckbSTEP22);
			this.groupBox4.Controls.Add(this.ckbSTEP33);
			this.groupBox4.Controls.Add(this.ckbSTEP21);
			this.groupBox4.Controls.Add(this.ckbSTEP32);
			this.groupBox4.Controls.Add(this.ckbSTEP13);
			this.groupBox4.Controls.Add(this.ckbSTEP31);
			this.groupBox4.Controls.Add(this.ckbSTEP12);
			this.groupBox4.Controls.Add(this.ckbSTEP24);
			this.groupBox4.Controls.Add(this.ckbSTEP23);
			this.groupBox4.Controls.Add(this.ckbSTEP11);
			this.groupBox4.Location = new global::System.Drawing.Point(4, 542);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(894, 119);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Test state";
			this.ckbShortTest.AutoSize = true;
			this.ckbShortTest.Location = new global::System.Drawing.Point(645, 84);
			this.ckbShortTest.Name = "ckbShortTest";
			this.ckbShortTest.Size = new global::System.Drawing.Size(75, 17);
			this.ckbShortTest.TabIndex = 1;
			this.ckbShortTest.Text = "Short Test";
			this.ckbShortTest.UseVisualStyleBackColor = true;
			this.ckbPowerMes.AutoSize = true;
			this.ckbPowerMes.Location = new global::System.Drawing.Point(506, 84);
			this.ckbPowerMes.Name = "ckbPowerMes";
			this.ckbPowerMes.Size = new global::System.Drawing.Size(100, 17);
			this.ckbPowerMes.TabIndex = 0;
			this.ckbPowerMes.Text = "Power Measure";
			this.ckbPowerMes.UseVisualStyleBackColor = true;
			this.ckbOCP.AutoSize = true;
			this.ckbOCP.Location = new global::System.Drawing.Point(375, 84);
			this.ckbOCP.Name = "ckbOCP";
			this.ckbOCP.Size = new global::System.Drawing.Size(48, 17);
			this.ckbOCP.TabIndex = 0;
			this.ckbOCP.Text = "OCP";
			this.ckbOCP.UseVisualStyleBackColor = true;
			this.ckbSTEP22.AutoSize = true;
			this.ckbSTEP22.Location = new global::System.Drawing.Point(506, 19);
			this.ckbSTEP22.Name = "ckbSTEP22";
			this.ckbSTEP22.Size = new global::System.Drawing.Size(84, 17);
			this.ckbSTEP22.TabIndex = 0;
			this.ckbSTEP22.Text = "LOAD2 50%";
			this.ckbSTEP22.UseVisualStyleBackColor = true;
			this.ckbSTEP33.AutoSize = true;
			this.ckbSTEP33.Location = new global::System.Drawing.Point(252, 84);
			this.ckbSTEP33.Name = "ckbSTEP33";
			this.ckbSTEP33.Size = new global::System.Drawing.Size(90, 17);
			this.ckbSTEP33.TabIndex = 0;
			this.ckbSTEP33.Text = "LOAD3 100%";
			this.ckbSTEP33.UseVisualStyleBackColor = true;
			this.ckbSTEP21.AutoSize = true;
			this.ckbSTEP21.Location = new global::System.Drawing.Point(375, 19);
			this.ckbSTEP21.Name = "ckbSTEP21";
			this.ckbSTEP21.Size = new global::System.Drawing.Size(84, 17);
			this.ckbSTEP21.TabIndex = 0;
			this.ckbSTEP21.Text = "LOAD1 50%";
			this.ckbSTEP21.UseVisualStyleBackColor = true;
			this.ckbSTEP32.AutoSize = true;
			this.ckbSTEP32.Location = new global::System.Drawing.Point(129, 84);
			this.ckbSTEP32.Name = "ckbSTEP32";
			this.ckbSTEP32.Size = new global::System.Drawing.Size(90, 17);
			this.ckbSTEP32.TabIndex = 0;
			this.ckbSTEP32.Text = "LOAD2 100%";
			this.ckbSTEP32.UseVisualStyleBackColor = true;
			this.ckbSTEP13.AutoSize = true;
			this.ckbSTEP13.Location = new global::System.Drawing.Point(252, 19);
			this.ckbSTEP13.Name = "ckbSTEP13";
			this.ckbSTEP13.Size = new global::System.Drawing.Size(78, 17);
			this.ckbSTEP13.TabIndex = 0;
			this.ckbSTEP13.Text = "LOAD3 0%";
			this.ckbSTEP13.UseVisualStyleBackColor = true;
			this.ckbSTEP31.AutoSize = true;
			this.ckbSTEP31.Location = new global::System.Drawing.Point(6, 84);
			this.ckbSTEP31.Name = "ckbSTEP31";
			this.ckbSTEP31.Size = new global::System.Drawing.Size(90, 17);
			this.ckbSTEP31.TabIndex = 0;
			this.ckbSTEP31.Text = "LOAD1 100%";
			this.ckbSTEP31.UseVisualStyleBackColor = true;
			this.ckbSTEP12.AutoSize = true;
			this.ckbSTEP12.Location = new global::System.Drawing.Point(129, 19);
			this.ckbSTEP12.Name = "ckbSTEP12";
			this.ckbSTEP12.Size = new global::System.Drawing.Size(78, 17);
			this.ckbSTEP12.TabIndex = 0;
			this.ckbSTEP12.Text = "LOAD2 0%";
			this.ckbSTEP12.UseVisualStyleBackColor = true;
			this.ckbSTEP24.AutoSize = true;
			this.ckbSTEP24.Location = new global::System.Drawing.Point(764, 19);
			this.ckbSTEP24.Name = "ckbSTEP24";
			this.ckbSTEP24.Size = new global::System.Drawing.Size(84, 17);
			this.ckbSTEP24.TabIndex = 0;
			this.ckbSTEP24.Text = "LOAD4 50%";
			this.ckbSTEP24.UseVisualStyleBackColor = true;
			this.ckbSTEP23.AutoSize = true;
			this.ckbSTEP23.Location = new global::System.Drawing.Point(645, 19);
			this.ckbSTEP23.Name = "ckbSTEP23";
			this.ckbSTEP23.Size = new global::System.Drawing.Size(84, 17);
			this.ckbSTEP23.TabIndex = 0;
			this.ckbSTEP23.Text = "LOAD3 50%";
			this.ckbSTEP23.UseVisualStyleBackColor = true;
			this.ckbSTEP11.AutoSize = true;
			this.ckbSTEP11.Location = new global::System.Drawing.Point(6, 19);
			this.ckbSTEP11.Name = "ckbSTEP11";
			this.ckbSTEP11.Size = new global::System.Drawing.Size(78, 17);
			this.ckbSTEP11.TabIndex = 0;
			this.ckbSTEP11.Text = "LOAD1 0%";
			this.ckbSTEP11.UseVisualStyleBackColor = true;
			this.groupBox3.Controls.Add(this.cbbSelectModel);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.txtNewModelName);
			this.groupBox3.Controls.Add(this.btnExit);
			this.groupBox3.Controls.Add(this.btnSave);
			this.groupBox3.Controls.Add(this.btnNewModel);
			this.groupBox3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox3.Location = new global::System.Drawing.Point(904, 457);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(407, 187);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Control";
			this.cbbSelectModel.FormattingEnabled = true;
			this.cbbSelectModel.Location = new global::System.Drawing.Point(223, 152);
			this.cbbSelectModel.Name = "cbbSelectModel";
			this.cbbSelectModel.Size = new global::System.Drawing.Size(176, 21);
			this.cbbSelectModel.TabIndex = 3;
			this.cbbSelectModel.SelectedIndexChanged += new global::System.EventHandler(this.cbbSelectModel_SelectedIndexChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(6, 153);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(118, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Select Model:";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(6, 117);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(150, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "New model name:";
			this.txtNewModelName.Location = new global::System.Drawing.Point(223, 106);
			this.txtNewModelName.Multiline = true;
			this.txtNewModelName.Name = "txtNewModelName";
			this.txtNewModelName.Size = new global::System.Drawing.Size(176, 31);
			this.txtNewModelName.TabIndex = 1;
			this.btnExit.Location = new global::System.Drawing.Point(7, 69);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(94, 31);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnSave.Location = new global::System.Drawing.Point(107, 20);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(94, 31);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnNewModel.Location = new global::System.Drawing.Point(7, 20);
			this.btnNewModel.Name = "btnNewModel";
			this.btnNewModel.Size = new global::System.Drawing.Size(94, 31);
			this.btnNewModel.TabIndex = 0;
			this.btnNewModel.Text = "New model";
			this.btnNewModel.UseVisualStyleBackColor = true;
			this.btnNewModel.Click += new global::System.EventHandler(this.btnNewModel_Click);
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox2.Location = new global::System.Drawing.Point(4, 418);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(894, 118);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Measure Value";
			this.groupBox1.Controls.Add(this.dataGridView3);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox1.Location = new global::System.Drawing.Point(4, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(894, 340);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Setting Input Value";
			this.dataGridView3.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView3.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView3.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn1,
				this.dataGridViewTextBoxColumn2,
				this.dataGridViewTextBoxColumn3,
				this.dataGridViewTextBoxColumn4,
				this.dataGridViewTextBoxColumn5,
				this.dataGridViewTextBoxColumn6,
				this.dataGridViewTextBoxColumn7,
				this.Column3,
				this.dataGridViewTextBoxColumn8,
				this.dataGridViewTextBoxColumn9,
				this.dataGridViewTextBoxColumn10
			});
			this.dataGridView3.Location = new global::System.Drawing.Point(4, 169);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.RowHeadersWidth = 51;
			this.dataGridView3.Size = new global::System.Drawing.Size(881, 165);
			this.dataGridView3.TabIndex = 2;
			this.dataGridViewTextBoxColumn1.HeaderText = "NAME";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 67;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.White;
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewTextBoxColumn2.HeaderText = "LOAD1 0%";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 85;
			this.dataGridViewTextBoxColumn3.HeaderText = "LOAD2 0%";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 85;
			this.dataGridViewTextBoxColumn4.HeaderText = "LOAD3 0%";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 85;
			this.dataGridViewTextBoxColumn5.HeaderText = "LOAD1 50%";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 91;
			this.dataGridViewTextBoxColumn6.HeaderText = "LOAD2 50%";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 91;
			this.dataGridViewTextBoxColumn7.HeaderText = "LOAD3 50%";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.Width = 91;
			this.Column3.HeaderText = "LOAD4 50%";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 91;
			this.dataGridViewTextBoxColumn8.HeaderText = "LOAD1 100%";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Width = 97;
			this.dataGridViewTextBoxColumn9.HeaderText = "LOAD2 100%";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Width = 97;
			this.dataGridViewTextBoxColumn10.HeaderText = "LOAD3 100%";
			this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 97;
			this.dataGridView1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.EPCode,
				this.TemplateName,
				this.ACVoltageMesPower,
				this.Column1,
				this.Column2
			});
			this.dataGridView1.Location = new global::System.Drawing.Point(6, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new global::System.Drawing.Size(881, 138);
			this.dataGridView1.TabIndex = 2;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.White;
			this.EPCode.DefaultCellStyle = dataGridViewCellStyle2;
			this.EPCode.HeaderText = "EP-CODE";
			this.EPCode.MinimumWidth = 6;
			this.EPCode.Name = "EPCode";
			this.EPCode.Width = 86;
			this.TemplateName.HeaderText = "TEMPLATE NAME";
			this.TemplateName.MinimumWidth = 6;
			this.TemplateName.Name = "TemplateName";
			this.TemplateName.Width = 124;
			this.ACVoltageMesPower.HeaderText = "VOLT SET TO MEASURE POWER(VAC)";
			this.ACVoltageMesPower.MinimumWidth = 6;
			this.ACVoltageMesPower.Name = "ACVoltageMesPower";
			this.ACVoltageMesPower.Width = 165;
			this.Column1.HeaderText = "Customer";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 84;
			this.Column2.HeaderText = "Line Name";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 85;
			this.panel2.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.lblModelName);
			this.panel2.Location = new global::System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(1308, 61);
			this.panel2.TabIndex = 0;
			this.lblModelName.AutoSize = true;
			this.lblModelName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblModelName.ForeColor = global::System.Drawing.Color.Red;
			this.lblModelName.Location = new global::System.Drawing.Point(6, 15);
			this.lblModelName.Name = "lblModelName";
			this.lblModelName.Size = new global::System.Drawing.Size(176, 31);
			this.lblModelName.TabIndex = 0;
			this.lblModelName.Text = "Model Name";
			this.lblModelName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.dataGridView2.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView2.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView2.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn33,
				this.dataGridViewTextBoxColumn34,
				this.textBoxColumn2,
				this.dataGridViewTextBoxColumn35,
				this.dataGridViewTextBoxColumn36,
				this.dataGridViewTextBoxColumn37,
				this.dataGridViewTextBoxColumn38,
				this.dataGridViewTextBoxColumn39,
				this.dataGridViewTextBoxColumn40,
				this.dataGridViewTextBoxColumn41,
				this.dataGridViewTextBoxColumn42,
				this.dataGridViewTextBoxColumn43,
				this.dataGridViewTextBoxColumn44,
				this.dataGridViewTextBoxColumn45,
				this.dataGridViewTextBoxColumn46,
				this.dataGridViewTextBoxColumn47,
				this.dataGridViewTextBoxColumn48,
				this.dataGridViewTextBoxColumn49,
				this.dataGridViewTextBoxColumn50,
				this.dataGridViewTextBoxColumn51,
				this.dataGridViewTextBoxColumn52,
				this.dataGridViewTextBoxColumn53,
				this.dataGridViewTextBoxColumn54
			});
			this.dataGridView2.Location = new global::System.Drawing.Point(4, 19);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.Size = new global::System.Drawing.Size(881, 93);
			this.dataGridView2.TabIndex = 4;
			this.dataGridViewTextBoxColumn33.HeaderText = "LOAD1 0% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn33.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
			this.dataGridViewTextBoxColumn33.Width = 217;
			this.dataGridViewTextBoxColumn34.HeaderText = "LOAD1 0% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn34.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
			this.dataGridViewTextBoxColumn34.Width = 220;
			this.textBoxColumn2.HeaderText = "LOAD2 0% MIN(VDC(CC,CR)/W(CV))";
			this.textBoxColumn2.MinimumWidth = 6;
			this.textBoxColumn2.Name = "textBoxColumn2";
			this.textBoxColumn2.Width = 217;
			this.dataGridViewTextBoxColumn35.HeaderText = "LOAD2 0% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn35.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
			this.dataGridViewTextBoxColumn35.Width = 220;
			this.dataGridViewTextBoxColumn36.HeaderText = "LOAD3 0% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn36.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
			this.dataGridViewTextBoxColumn36.Width = 217;
			this.dataGridViewTextBoxColumn37.HeaderText = "LOAD3 0% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn37.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
			this.dataGridViewTextBoxColumn37.Width = 220;
			this.dataGridViewTextBoxColumn38.HeaderText = "LOAD1 50% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn38.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
			this.dataGridViewTextBoxColumn38.Width = 223;
			this.dataGridViewTextBoxColumn39.HeaderText = "LOAD1 50% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn39.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
			this.dataGridViewTextBoxColumn39.Width = 226;
			this.dataGridViewTextBoxColumn40.HeaderText = "LOAD2 50% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn40.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
			this.dataGridViewTextBoxColumn40.Width = 223;
			this.dataGridViewTextBoxColumn41.HeaderText = "LOAD2 50% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn41.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
			this.dataGridViewTextBoxColumn41.Width = 226;
			this.dataGridViewTextBoxColumn42.HeaderText = "LOAD3 50% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn42.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
			this.dataGridViewTextBoxColumn42.Width = 223;
			this.dataGridViewTextBoxColumn43.HeaderText = "LOAD3 50% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn43.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
			this.dataGridViewTextBoxColumn43.Width = 226;
			this.dataGridViewTextBoxColumn44.HeaderText = "LOAD4 50% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn44.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
			this.dataGridViewTextBoxColumn44.Width = 223;
			this.dataGridViewTextBoxColumn45.HeaderText = "LOAD4 50% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn45.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
			this.dataGridViewTextBoxColumn45.Width = 226;
			this.dataGridViewTextBoxColumn46.HeaderText = "LOAD1 100% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn46.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
			this.dataGridViewTextBoxColumn46.Width = 230;
			this.dataGridViewTextBoxColumn47.HeaderText = "LOAD1 100% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn47.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
			this.dataGridViewTextBoxColumn47.Width = 232;
			this.dataGridViewTextBoxColumn48.HeaderText = "LOAD2 100% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn48.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
			this.dataGridViewTextBoxColumn48.Width = 230;
			this.dataGridViewTextBoxColumn49.HeaderText = "LOAD2 100% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn49.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
			this.dataGridViewTextBoxColumn49.Width = 232;
			this.dataGridViewTextBoxColumn50.HeaderText = "LOAD3 100% MIN(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn50.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
			this.dataGridViewTextBoxColumn50.Width = 230;
			this.dataGridViewTextBoxColumn51.HeaderText = "LOAD3 100% MAX(VDC(CC,CR)/W(CV))";
			this.dataGridViewTextBoxColumn51.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
			this.dataGridViewTextBoxColumn51.Width = 232;
			this.dataGridViewTextBoxColumn52.HeaderText = "POWER VALUE(WAT)";
			this.dataGridViewTextBoxColumn52.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
			this.dataGridViewTextBoxColumn52.Width = 144;
			this.dataGridViewTextBoxColumn53.HeaderText = "OCP VALUE(Amp)";
			this.dataGridViewTextBoxColumn53.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
			this.dataGridViewTextBoxColumn53.Width = 122;
			this.dataGridViewTextBoxColumn54.HeaderText = "OFFSET-POWER(%)";
			this.dataGridViewTextBoxColumn54.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
			this.dataGridViewTextBoxColumn54.Width = 146;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ControlDark;
			base.ClientSize = new global::System.Drawing.Size(1320, 671);
			base.Controls.Add(this.panel1);
			base.Name = "ProgramSetup";
			this.Text = "ProgramSetup-2";
			base.Load += new global::System.EventHandler(this.ProgramSetup_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrHigh).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrNormal).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrLow).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000BA RID: 186
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.Label lblModelName;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Button btnNewModel;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.ComboBox cbbSelectModel;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.TextBox txtNewModelName;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.CheckBox ckbOCP;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.CheckBox ckbSTEP22;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.CheckBox ckbSTEP33;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.CheckBox ckbSTEP21;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.CheckBox ckbSTEP32;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.CheckBox ckbSTEP13;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.CheckBox ckbSTEP31;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.CheckBox ckbSTEP12;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.CheckBox ckbSTEP23;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.CheckBox ckbSTEP11;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.CheckBox ckbPowerMes;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.RadioButton ckbCVMODE;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.RadioButton ckbCCMODE;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.RadioButton ckbCRMODE;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.NumericUpDown nbrHigh;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.NumericUpDown nbrNormal;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.NumericUpDown nbrLow;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.DataGridView dataGridView3;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.DataGridViewTextBoxColumn EPCode;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.DataGridViewTextBoxColumn TemplateName;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.DataGridViewTextBoxColumn ACVoltageMesPower;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.CheckBox ckbSTEP24;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column3;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

		// Token: 0x040000F2 RID: 242
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x040000F3 RID: 243
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000F4 RID: 244
		private global::System.Windows.Forms.TextBox txtOCP_HigherOffset;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.TextBox txtOCP_LowerOffset;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.TextBox txtOCP_StepDelay;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.TextBox txtOCP_CurrentStep;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.TextBox txtOCP_LowerLimit;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.TextBox txtOCP_UpperLimit;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.TextBox txtShortTest_JudgementVoltage;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.TextBox txtShortTest_MaximumCurrent;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.CheckBox ckbShortTest;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.TextBox txtShortTest_Delay;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.DataGridView dataGridView2;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.TextBoxColumn textBoxColumn2;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
	}
}
