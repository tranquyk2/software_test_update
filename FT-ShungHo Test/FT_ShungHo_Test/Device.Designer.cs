namespace FT_ShungHo_Test
{
    // Token: 0x02000003 RID: 3
    public partial class Device : global::System.Windows.Forms.Form
    {
        // Token: 0x06000012 RID: 18 RVA: 0x00002D29 File Offset: 0x00000F29
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000013 RID: 19 RVA: 0x00002D48 File Offset: 0x00000F48
        private void InitializeComponent()
        {
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FT_ShungHo_Test.Device));
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.groupBox3 = new global::System.Windows.Forms.GroupBox();
            this.comboBox4 = new global::System.Windows.Forms.ComboBox();
            this.comboBox3 = new global::System.Windows.Forms.ComboBox();
            this.label5 = new global::System.Windows.Forms.Label();
            this.label6 = new global::System.Windows.Forms.Label();
            this.groupBox8 = new global::System.Windows.Forms.GroupBox();
            this.btnDefaults = new global::System.Windows.Forms.Button();
            this.button3 = new global::System.Windows.Forms.Button();
            this.btnSave = new global::System.Windows.Forms.Button();
            this.groupBox7 = new global::System.Windows.Forms.GroupBox();
            this.comboBox13 = new global::System.Windows.Forms.ComboBox();
            this.comboBox14 = new global::System.Windows.Forms.ComboBox();
            this.label13 = new global::System.Windows.Forms.Label();
            this.label14 = new global::System.Windows.Forms.Label();
            this.groupBox5 = new global::System.Windows.Forms.GroupBox();
            this.comboBox9 = new global::System.Windows.Forms.ComboBox();
            this.comboBox10 = new global::System.Windows.Forms.ComboBox();
            this.label9 = new global::System.Windows.Forms.Label();
            this.label10 = new global::System.Windows.Forms.Label();
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.comboBox2 = new global::System.Windows.Forms.ComboBox();
            this.comboBox1 = new global::System.Windows.Forms.ComboBox();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label4 = new global::System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new global::System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size(958, 422);
            this.panel1.TabIndex = 0;
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new global::System.Drawing.Point(241, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new global::System.Drawing.Size(232, 200);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Power metter-1";
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15"
            });
            this.comboBox4.Location = new global::System.Drawing.Point(115, 64);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new global::System.Drawing.Size(82, 21);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.Text = "0";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[]
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10",
                "COM11",
                "COM12",
                "COM13",
                "COM14",
                "COM15",
                "COM16",
                "COM17",
                "COM18",
                "COM19",
                "COM20",
                "COM21",
                "COM22",
                "COM23",
                "COM24",
                "COM25",
                "COM26",
                "COM27",
                "COM28",
                "COM29",
                "COM30"
            });
            this.comboBox3.Location = new global::System.Drawing.Point(115, 29);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new global::System.Drawing.Size(82, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "COM2";
            this.label5.AutoSize = true;
            this.label5.Location = new global::System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            this.label6.AutoSize = true;
            this.label6.Location = new global::System.Drawing.Point(9, 32);
            this.label6.Name = "label6";
            this.label6.Size = new global::System.Drawing.Size(85, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cổng điều khiển";
            this.groupBox8.Controls.Add(this.btnDefaults);
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Controls.Add(this.btnSave);
            this.groupBox8.Location = new global::System.Drawing.Point(718, 209);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new global::System.Drawing.Size(232, 200);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tác vụ";
            this.btnDefaults.Location = new global::System.Drawing.Point(117, 61);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new global::System.Drawing.Size(105, 23);
            this.btnDefaults.TabIndex = 0;
            this.btnDefaults.Text = "Mặc định";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new global::System.EventHandler(this.btnDefaults_Click);
            this.button3.Location = new global::System.Drawing.Point(66, 118);
            this.button3.Name = "button3";
            this.button3.Size = new global::System.Drawing.Size(105, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new global::System.EventHandler(this.button3_Click);
            this.btnSave.Location = new global::System.Drawing.Point(6, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new global::System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
            this.groupBox7.Controls.Add(this.comboBox13);
            this.groupBox7.Controls.Add(this.comboBox14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new global::System.Drawing.Point(718, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new global::System.Drawing.Size(232, 200);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PLC-1";
            this.comboBox13.Enabled = false;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15"
            });
            this.comboBox13.Location = new global::System.Drawing.Point(112, 62);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new global::System.Drawing.Size(82, 21);
            this.comboBox13.TabIndex = 5;
            this.comboBox13.Text = "0";
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[]
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10",
                "COM11",
                "COM12",
                "COM13",
                "COM14",
                "COM15",
                "COM16",
                "COM17",
                "COM18",
                "COM19",
                "COM20",
                "COM21",
                "COM22",
                "COM23",
                "COM24",
                "COM25",
                "COM26",
                "COM27",
                "COM28",
                "COM29",
                "COM30"
            });
            this.comboBox14.Location = new global::System.Drawing.Point(112, 27);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new global::System.Drawing.Size(82, 21);
            this.comboBox14.TabIndex = 6;
            this.comboBox14.Text = "COM7";
            this.label13.AutoSize = true;
            this.label13.Location = new global::System.Drawing.Point(9, 65);
            this.label13.Name = "label13";
            this.label13.Size = new global::System.Drawing.Size(40, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Địa chỉ";
            this.label14.AutoSize = true;
            this.label14.Location = new global::System.Drawing.Point(6, 30);
            this.label14.Name = "label14";
            this.label14.Size = new global::System.Drawing.Size(85, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Cổng điều khiển";
            this.groupBox5.Controls.Add(this.comboBox9);
            this.groupBox5.Controls.Add(this.comboBox10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new global::System.Drawing.Point(480, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new global::System.Drawing.Size(232, 200);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ACSource-1";
            this.comboBox9.Enabled = false;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15"
            });
            this.comboBox9.Location = new global::System.Drawing.Point(112, 62);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new global::System.Drawing.Size(82, 21);
            this.comboBox9.TabIndex = 5;
            this.comboBox9.Text = "0";
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[]
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10",
                "COM11",
                "COM12",
                "COM13",
                "COM14",
                "COM15",
                "COM16",
                "COM17",
                "COM18",
                "COM19",
                "COM20",
                "COM21",
                "COM22",
                "COM23",
                "COM24",
                "COM25",
                "COM26",
                "COM27",
                "COM28",
                "COM29",
                "COM30"
            });
            this.comboBox10.Location = new global::System.Drawing.Point(112, 27);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new global::System.Drawing.Size(82, 21);
            this.comboBox10.TabIndex = 6;
            this.comboBox10.Text = "COM5";
            this.label9.AutoSize = true;
            this.label9.Location = new global::System.Drawing.Point(9, 65);
            this.label9.Name = "label9";
            this.label9.Size = new global::System.Drawing.Size(40, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Địa chỉ";
            this.label10.AutoSize = true;
            this.label10.Location = new global::System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new global::System.Drawing.Size(85, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cổng điều khiển";
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new global::System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new global::System.Drawing.Size(232, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Electrical load-1";
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15"
            });
            this.comboBox2.Location = new global::System.Drawing.Point(112, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new global::System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10",
                "COM11",
                "COM12",
                "COM13",
                "COM14",
                "COM15",
                "COM16",
                "COM17",
                "COM18",
                "COM19",
                "COM20",
                "COM21",
                "COM22",
                "COM23",
                "COM24",
                "COM25",
                "COM26",
                "COM27",
                "COM28",
                "COM29",
                "COM30"
            });
            this.comboBox1.Location = new global::System.Drawing.Point(112, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new global::System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "COM1";
            this.label3.AutoSize = true;
            this.label3.Location = new global::System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            this.label4.AutoSize = true;
            this.label4.Location = new global::System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cổng điều khiển";
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.SystemColors.ScrollBar;
            base.ClientSize = new global::System.Drawing.Size(963, 431);
            base.Controls.Add(this.panel1);
            //base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            base.Name = "Device";
            this.Text = "Thiết lập thiết bị kiểm tra-2";
            base.Load += new global::System.EventHandler(this.Device_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        // Token: 0x0400000B RID: 11
        private global::System.ComponentModel.IContainer components;

        // Token: 0x0400000C RID: 12
        private global::System.Windows.Forms.Panel panel1;

        // Token: 0x0400000D RID: 13
        private global::System.Windows.Forms.GroupBox groupBox3;

        // Token: 0x0400000E RID: 14
        private global::System.Windows.Forms.GroupBox groupBox1;

        // Token: 0x0400000F RID: 15
        private global::System.Windows.Forms.GroupBox groupBox8;

        // Token: 0x04000010 RID: 16
        private global::System.Windows.Forms.Button btnDefaults;

        // Token: 0x04000011 RID: 17
        private global::System.Windows.Forms.Button button3;

        // Token: 0x04000012 RID: 18
        private global::System.Windows.Forms.Button btnSave;

        // Token: 0x04000013 RID: 19
        private global::System.Windows.Forms.GroupBox groupBox7;

        // Token: 0x04000014 RID: 20
        private global::System.Windows.Forms.GroupBox groupBox5;

        // Token: 0x04000015 RID: 21
        private global::System.Windows.Forms.ComboBox comboBox4;

        // Token: 0x04000016 RID: 22
        private global::System.Windows.Forms.ComboBox comboBox3;

        // Token: 0x04000017 RID: 23
        private global::System.Windows.Forms.Label label5;

        // Token: 0x04000018 RID: 24
        private global::System.Windows.Forms.Label label6;

        // Token: 0x04000019 RID: 25
        private global::System.Windows.Forms.ComboBox comboBox13;

        // Token: 0x0400001A RID: 26
        private global::System.Windows.Forms.ComboBox comboBox14;

        // Token: 0x0400001B RID: 27
        private global::System.Windows.Forms.Label label13;

        // Token: 0x0400001C RID: 28
        private global::System.Windows.Forms.Label label14;

        // Token: 0x0400001D RID: 29
        private global::System.Windows.Forms.ComboBox comboBox9;

        // Token: 0x0400001E RID: 30
        private global::System.Windows.Forms.ComboBox comboBox10;

        // Token: 0x0400001F RID: 31
        private global::System.Windows.Forms.Label label9;

        // Token: 0x04000020 RID: 32
        private global::System.Windows.Forms.Label label10;

        // Token: 0x04000021 RID: 33
        private global::System.Windows.Forms.ComboBox comboBox2;

        // Token: 0x04000022 RID: 34
        private global::System.Windows.Forms.ComboBox comboBox1;

        // Token: 0x04000023 RID: 35
        private global::System.Windows.Forms.Label label3;

        // Token: 0x04000024 RID: 36
        private global::System.Windows.Forms.Label label4;
    }
}
