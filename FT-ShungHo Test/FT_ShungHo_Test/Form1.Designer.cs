namespace FT_ShungHo_Test
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFile = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbComport = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.label46 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lbProgramName = new System.Windows.Forms.Label();
            this.lbCycletime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtShortTestMeasured = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOCP_Measured = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManualCheck = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbResult1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSelectProgram = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberTest = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNoPass = new System.Windows.Forms.Label();
            this.lblNoFail = new System.Windows.Forms.Label();
            this.cboCOM = new System.Windows.Forms.ComboBox();
            this.txtBarcode1 = new System.Windows.Forms.TextBox();
            this.txtBarcode2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1157, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.fileToolStripMenuItem.Text = "File(F)";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thToolStripMenuItem});
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // thToolStripMenuItem
            // 
            this.thToolStripMenuItem.Name = "thToolStripMenuItem";
            this.thToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.thToolStripMenuItem.Text = "Thông tin";
            this.thToolStripMenuItem.Click += new System.EventHandler(this.thToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFile,
            this.tsbStop,
            this.tsbComport,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1157, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFile
            // 
            this.tsbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFile.Name = "tsbFile";
            this.tsbFile.Size = new System.Drawing.Size(29, 28);
            this.tsbFile.Text = "File";
            this.tsbFile.Click += new System.EventHandler(this.tsbFile_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(29, 28);
            this.tsbStop.Text = "Start-1";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbComport
            // 
            this.tsbComport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbComport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbComport.Name = "tsbComport";
            this.tsbComport.Size = new System.Drawing.Size(29, 28);
            this.tsbComport.Text = "Comport";
            this.tsbComport.Click += new System.EventHandler(this.tsbComport_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(29, 28);
            this.tsbExit.Text = "Exit";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.Red;
            this.label46.Location = new System.Drawing.Point(616, 27);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(165, 29);
            this.label46.TabIndex = 16;
            this.label46.Text = "Cycle time (s):";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Red;
            this.label41.Location = new System.Drawing.Point(367, 2);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(184, 29);
            this.label41.TabIndex = 17;
            this.label41.Text = "Program name: ";
            // 
            // lbProgramName
            // 
            this.lbProgramName.AutoSize = true;
            this.lbProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgramName.ForeColor = System.Drawing.Color.Red;
            this.lbProgramName.Location = new System.Drawing.Point(568, 11);
            this.lbProgramName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProgramName.Name = "lbProgramName";
            this.lbProgramName.Size = new System.Drawing.Size(75, 20);
            this.lbProgramName.TabIndex = 18;
            this.lbProgramName.Text = "Model 1";
            // 
            // lbCycletime
            // 
            this.lbCycletime.AutoSize = true;
            this.lbCycletime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCycletime.ForeColor = System.Drawing.Color.Red;
            this.lbCycletime.Location = new System.Drawing.Point(785, 30);
            this.lbCycletime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCycletime.Name = "lbCycletime";
            this.lbCycletime.Size = new System.Drawing.Size(26, 29);
            this.lbCycletime.TabIndex = 19;
            this.lbCycletime.Text = "0";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Blue;
            this.lbTime.Location = new System.Drawing.Point(884, 0);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(255, 29);
            this.lbTime.TabIndex = 20;
            this.lbTime.Text = "HH:mm:ss dd/MM/yyyy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtShortTestMeasured);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOCP_Measured);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnManualCheck);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.lbCycletime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(860, 815);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểm tra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(616, 277);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "SHORT Volt.";
            // 
            // txtShortTestMeasured
            // 
            this.txtShortTestMeasured.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShortTestMeasured.Location = new System.Drawing.Point(764, 268);
            this.txtShortTestMeasured.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtShortTestMeasured.Multiline = true;
            this.txtShortTestMeasured.Name = "txtShortTestMeasured";
            this.txtShortTestMeasured.Size = new System.Drawing.Size(83, 37);
            this.txtShortTestMeasured.TabIndex = 29;
            this.txtShortTestMeasured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "OCP Measured";
            // 
            // txtOCP_Measured
            // 
            this.txtOCP_Measured.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOCP_Measured.Location = new System.Drawing.Point(764, 223);
            this.txtOCP_Measured.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOCP_Measured.Multiline = true;
            this.txtOCP_Measured.Name = "txtOCP_Measured";
            this.txtOCP_Measured.Size = new System.Drawing.Size(83, 37);
            this.txtOCP_Measured.TabIndex = 27;
            this.txtOCP_Measured.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 70);
            this.button1.TabIndex = 26;
            this.button1.Text = "1 Cycle Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManualCheck
            // 
            this.btnManualCheck.Location = new System.Drawing.Point(616, 351);
            this.btnManualCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManualCheck.Name = "btnManualCheck";
            this.btnManualCheck.Size = new System.Drawing.Size(100, 70);
            this.btnManualCheck.TabIndex = 25;
            this.btnManualCheck.Text = "Single Step";
            this.btnManualCheck.UseVisualStyleBackColor = true;
            this.btnManualCheck.Click += new System.EventHandler(this.btnManualCheck_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Minute:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Number label:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(764, 113);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(73, 26);
            this.numericUpDown3.TabIndex = 23;
            this.numericUpDown3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(764, 148);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(73, 26);
            this.numericUpDown2.TabIndex = 23;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(764, 185);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 26);
            this.numericUpDown1.TabIndex = 23;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(616, 314);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 28);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 377);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(621, 80);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 24);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Auto Test";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(17, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(591, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Step Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Input voltage(VAC)";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Output";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // lbResult1
            // 
            this.lbResult1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResult1.AutoSize = true;
            this.lbResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult1.Location = new System.Drawing.Point(8, 27);
            this.lbResult1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResult1.Name = "lbResult1";
            this.lbResult1.Size = new System.Drawing.Size(80, 39);
            this.lbResult1.TabIndex = 0;
            this.lbResult1.Text = "O/N";
            this.lbResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbResult1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(868, 292);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(289, 622);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(868, 103);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(297, 188);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tỷ lệ PASS";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 31);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Green,
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Label = "#PERCENT";
            series1.LabelForeColor = System.Drawing.Color.Yellow;
            series1.Legend = "Legend1";
            series1.Name = "PassRate2";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(281, 150);
            this.chart1.TabIndex = 46;
            this.chart1.Text = "Chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Program Select :";
            // 
            // cbbSelectProgram
            // 
            this.cbbSelectProgram.FormattingEnabled = true;
            this.cbbSelectProgram.Location = new System.Drawing.Point(711, 41);
            this.cbbSelectProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbSelectProgram.Name = "cbbSelectProgram";
            this.cbbSelectProgram.Size = new System.Drawing.Size(283, 24);
            this.cbbSelectProgram.TabIndex = 25;
            this.cbbSelectProgram.SelectedIndexChanged += new System.EventHandler(this.cbbSelectProgram_SelectedIndexChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 300;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(424, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total: ";
            // 
            // lblNumberTest
            // 
            this.lblNumberTest.AutoSize = true;
            this.lblNumberTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTest.ForeColor = System.Drawing.Color.Red;
            this.lblNumberTest.Location = new System.Drawing.Point(512, 50);
            this.lblNumberTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberTest.Name = "lblNumberTest";
            this.lblNumberTest.Size = new System.Drawing.Size(30, 31);
            this.lblNumberTest.TabIndex = 18;
            this.lblNumberTest.Text = "0";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(1009, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pass:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1009, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fail:";
            // 
            // lblNoPass
            // 
            this.lblNoPass.AutoSize = true;
            this.lblNoPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPass.ForeColor = System.Drawing.Color.Green;
            this.lblNoPass.Location = new System.Drawing.Point(1068, 50);
            this.lblNoPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoPass.Name = "lblNoPass";
            this.lblNoPass.Size = new System.Drawing.Size(17, 17);
            this.lblNoPass.TabIndex = 26;
            this.lblNoPass.Text = "0";
            // 
            // lblNoFail
            // 
            this.lblNoFail.AutoSize = true;
            this.lblNoFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFail.ForeColor = System.Drawing.Color.Red;
            this.lblNoFail.Location = new System.Drawing.Point(1068, 81);
            this.lblNoFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoFail.Name = "lblNoFail";
            this.lblNoFail.Size = new System.Drawing.Size(17, 17);
            this.lblNoFail.TabIndex = 26;
            this.lblNoFail.Text = "0";
            // 
            // cboCOM
            // 
            this.cboCOM.FormattingEnabled = true;
            this.cboCOM.Location = new System.Drawing.Point(0, 70);
            this.cboCOM.Name = "cboCOM";
            this.cboCOM.Size = new System.Drawing.Size(121, 24);
            this.cboCOM.TabIndex = 27;
            // 
            // txtBarcode1
            // 
            this.txtBarcode1.Location = new System.Drawing.Point(156, 77);
            this.txtBarcode1.Name = "txtBarcode1";
            this.txtBarcode1.Size = new System.Drawing.Size(261, 22);
            this.txtBarcode1.TabIndex = 28;
            // 
            // txtBarcode2
            // 
            this.txtBarcode2.Location = new System.Drawing.Point(156, 122);
            this.txtBarcode2.Name = "txtBarcode2";
            this.txtBarcode2.Size = new System.Drawing.Size(261, 22);
            this.txtBarcode2.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-3, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Select COM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(156, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Barcode 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(156, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Barcode 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 593);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBarcode2);
            this.Controls.Add(this.txtBarcode1);
            this.Controls.Add(this.cboCOM);
            this.Controls.Add(this.lblNoFail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNoPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbSelectProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lblNumberTest);
            this.Controls.Add(this.lbProgramName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Auto Test System-2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400006A RID: 106
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.ToolStrip toolStrip1;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.ToolStripButton tsbFile;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.ToolStripButton tsbStop;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.ToolStripButton tsbComport;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.ToolStripButton tsbExit;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label label46;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label label41;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Label lbProgramName;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label lbCycletime;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Label lbTime;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Label lbResult1;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x0400007E RID: 126
		internal global::System.Windows.Forms.DataVisualization.Charting.Chart chart1;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.ToolStripMenuItem thToolStripMenuItem;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.ComboBox cbbSelectProgram;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Timer timer3;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Label lblNumberTest;

		// Token: 0x04000087 RID: 135
		private global::System.Drawing.Printing.PrintDocument printDocument1;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Label lblNoPass;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label lblNoFail;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Button btnPrint;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.NumericUpDown numericUpDown3;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column4;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column3;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Button btnManualCheck;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.TextBox txtOCP_Measured;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.TextBox txtShortTestMeasured;
        private System.Windows.Forms.ComboBox cboCOM;
        private System.Windows.Forms.TextBox txtBarcode1;
        private System.Windows.Forms.TextBox txtBarcode2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
