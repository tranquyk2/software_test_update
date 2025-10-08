namespace FT_ShungHo_Test
{
	// Token: 0x02000006 RID: 6
	public partial class Parameter : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FT_ShungHo_Test.Parameter));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.nbrMaxValuePW2 = new global::System.Windows.Forms.NumericUpDown();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.nbrMinValuePW2 = new global::System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.nbrMaxValueLoad2 = new global::System.Windows.Forms.NumericUpDown();
			this.label2 = new global::System.Windows.Forms.Label();
			this.nbrMinValueLoad2 = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.nbrMaxValuePW1 = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.nbrMinValuePW1 = new global::System.Windows.Forms.NumericUpDown();
			this.label6 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.nbrMaxValueLoad1 = new global::System.Windows.Forms.NumericUpDown();
			this.nbrMinValueLoad1 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMaxValuePW2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMinValuePW2).BeginInit();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMaxValueLoad2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMinValueLoad2).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMaxValuePW1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMinValuePW1).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMaxValueLoad1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMinValueLoad1).BeginInit();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new global::System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(776, 426);
			this.panel1.TabIndex = 1;
			this.panel3.Controls.Add(this.groupBox4);
			this.panel3.Controls.Add(this.groupBox3);
			this.panel3.Location = new global::System.Drawing.Point(396, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(385, 419);
			this.panel3.TabIndex = 1;
			this.groupBox4.BackColor = global::System.Drawing.SystemColors.ScrollBar;
			this.groupBox4.Controls.Add(this.nbrMaxValuePW2);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.nbrMinValuePW2);
			this.groupBox4.Location = new global::System.Drawing.Point(5, 211);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(375, 202);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Power Metter - 2";
			this.nbrMaxValuePW2.DecimalPlaces = 2;
			this.nbrMaxValuePW2.Location = new global::System.Drawing.Point(182, 110);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nbrMaxValuePW2;
			int[] array = new int[4];
			array[0] = 200;
			numericUpDown.Maximum = new decimal(array);
			this.nbrMaxValuePW2.Name = "nbrMaxValuePW2";
			this.nbrMaxValuePW2.Size = new global::System.Drawing.Size(120, 20);
			this.nbrMaxValuePW2.TabIndex = 1;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(6, 27);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(160, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Giá trị đo thấp nhất (Min Value) :";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(6, 117);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(157, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Giá trị đo cao nhất (Max Value):";
			this.nbrMinValuePW2.DecimalPlaces = 2;
			this.nbrMinValuePW2.Location = new global::System.Drawing.Point(182, 20);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nbrMinValuePW2;
			int[] array2 = new int[4];
			array2[0] = 200;
			numericUpDown2.Maximum = new decimal(array2);
			this.nbrMinValuePW2.Name = "nbrMinValuePW2";
			this.nbrMinValuePW2.Size = new global::System.Drawing.Size(120, 20);
			this.nbrMinValuePW2.TabIndex = 1;
			this.groupBox3.BackColor = global::System.Drawing.SystemColors.ScrollBar;
			this.groupBox3.Controls.Add(this.nbrMaxValueLoad2);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.nbrMinValueLoad2);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new global::System.Drawing.Point(5, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(375, 202);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Electrical Load - 2";
			this.nbrMaxValueLoad2.DecimalPlaces = 2;
			this.nbrMaxValueLoad2.Location = new global::System.Drawing.Point(182, 103);
			this.nbrMaxValueLoad2.Name = "nbrMaxValueLoad2";
			this.nbrMaxValueLoad2.Size = new global::System.Drawing.Size(120, 20);
			this.nbrMaxValueLoad2.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 20);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(160, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Giá trị đo thấp nhất (Min Value) :";
			this.nbrMinValueLoad2.DecimalPlaces = 2;
			this.nbrMinValueLoad2.Location = new global::System.Drawing.Point(182, 13);
			this.nbrMinValueLoad2.Name = "nbrMinValueLoad2";
			this.nbrMinValueLoad2.Size = new global::System.Drawing.Size(120, 20);
			this.nbrMinValueLoad2.TabIndex = 1;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(6, 110);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(157, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Giá trị đo cao nhất (Max Value):";
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Location = new global::System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(385, 419);
			this.panel2.TabIndex = 0;
			this.groupBox2.BackColor = global::System.Drawing.SystemColors.ScrollBar;
			this.groupBox2.Controls.Add(this.nbrMaxValuePW1);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.nbrMinValuePW1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new global::System.Drawing.Point(3, 211);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(375, 202);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Power Metter - 1";
			this.nbrMaxValuePW1.DecimalPlaces = 2;
			this.nbrMaxValuePW1.Location = new global::System.Drawing.Point(183, 110);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nbrMaxValuePW1;
			int[] array3 = new int[4];
			array3[0] = 200;
			numericUpDown3.Maximum = new decimal(array3);
			this.nbrMaxValuePW1.Name = "nbrMaxValuePW1";
			this.nbrMaxValuePW1.Size = new global::System.Drawing.Size(120, 20);
			this.nbrMaxValuePW1.TabIndex = 1;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(7, 27);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(160, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Giá trị đo thấp nhất (Min Value) :";
			this.nbrMinValuePW1.DecimalPlaces = 2;
			this.nbrMinValuePW1.Location = new global::System.Drawing.Point(183, 20);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nbrMinValuePW1;
			int[] array4 = new int[4];
			array4[0] = 200;
			numericUpDown4.Maximum = new decimal(array4);
			this.nbrMinValuePW1.Name = "nbrMinValuePW1";
			this.nbrMinValuePW1.Size = new global::System.Drawing.Size(120, 20);
			this.nbrMinValuePW1.TabIndex = 1;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(7, 117);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(157, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Giá trị đo cao nhất (Max Value):";
			this.groupBox1.BackColor = global::System.Drawing.SystemColors.ScrollBar;
			this.groupBox1.Controls.Add(this.nbrMaxValueLoad1);
			this.groupBox1.Controls.Add(this.nbrMinValueLoad1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(375, 202);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Electrical Load - 1";
			this.nbrMaxValueLoad1.DecimalPlaces = 2;
			this.nbrMaxValueLoad1.Location = new global::System.Drawing.Point(183, 103);
			this.nbrMaxValueLoad1.Name = "nbrMaxValueLoad1";
			this.nbrMaxValueLoad1.Size = new global::System.Drawing.Size(120, 20);
			this.nbrMaxValueLoad1.TabIndex = 1;
			this.nbrMinValueLoad1.DecimalPlaces = 2;
			this.nbrMinValueLoad1.Location = new global::System.Drawing.Point(183, 13);
			this.nbrMinValueLoad1.Name = "nbrMinValueLoad1";
			this.nbrMinValueLoad1.Size = new global::System.Drawing.Size(120, 20);
			this.nbrMinValueLoad1.TabIndex = 1;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(7, 110);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(157, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Giá trị đo cao nhất (Max Value):";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(160, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Giá trị đo thấp nhất (Min Value) :";
			this.panel4.Controls.Add(this.btnExit);
			this.panel4.Controls.Add(this.btnSave);
			this.panel4.Location = new global::System.Drawing.Point(800, 12);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(172, 100);
			this.panel4.TabIndex = 2;
			this.btnExit.Location = new global::System.Drawing.Point(85, 7);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnSave.Location = new global::System.Drawing.Point(4, 7);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ScrollBar;
			base.ClientSize = new global::System.Drawing.Size(974, 450);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Parameter";
			this.Text = "Thiết lập tham số kiểm tra ";
			base.Load += new global::System.EventHandler(this.Parameter_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMaxValuePW2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMinValuePW2).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMaxValueLoad2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMinValueLoad2).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMaxValuePW1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMinValuePW1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMaxValueLoad1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nbrMinValueLoad1).EndInit();
			this.panel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400009F RID: 159
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.NumericUpDown nbrMaxValuePW2;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.NumericUpDown nbrMinValuePW2;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.NumericUpDown nbrMaxValueLoad2;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.NumericUpDown nbrMinValueLoad2;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.NumericUpDown nbrMaxValuePW1;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.NumericUpDown nbrMinValuePW1;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.NumericUpDown nbrMaxValueLoad1;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.NumericUpDown nbrMinValueLoad1;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Button btnSave;
	}
}
