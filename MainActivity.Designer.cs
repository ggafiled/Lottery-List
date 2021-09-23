namespace Lottery_List
{
    partial class MainActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainActivity));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripdate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.รอบบิลที่ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.หมายเลข = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.จำนวนเงิน = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgExit = new System.Windows.Forms.PictureBox();
            this.ToolStrip1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("TH SarabunPSK", 30F);
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(256, 53);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ระบบคำนวณยอดหวย";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripdate,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 417);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(800, 33);
            this.ToolStrip1.TabIndex = 26;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripdate
            // 
            this.ToolStripdate.Font = new System.Drawing.Font("TH SarabunPSK", 16.25F);
            this.ToolStripdate.Name = "ToolStripdate";
            this.ToolStripdate.Size = new System.Drawing.Size(117, 30);
            this.ToolStripdate.Text = "ToolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("TH SarabunPSK", 16.25F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Firebrick;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 30);
            this.toolStripLabel1.Text = "กรุณาเลือกรอบบิล";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("TH SarabunPSK", 16.25F);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(82, 30);
            this.toolStripLabel2.Text = "ปริ้นรายงาน";
            this.toolStripLabel2.Click += new System.EventHandler(this.ToolStripLabel2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.bunifuThinButton22);
            this.GroupBox2.Controls.Add(this.bunifuThinButton21);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.textBox1);
            this.GroupBox2.Controls.Add(this.checkBox1);
            this.GroupBox2.Controls.Add(this.txt_name);
            this.GroupBox2.Controls.Add(this.txt_id);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.label3);
            this.GroupBox2.Font = new System.Drawing.Font("TH SarabunPSK", 18F);
            this.GroupBox2.Location = new System.Drawing.Point(21, 68);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox2.Size = new System.Drawing.Size(754, 149);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ข้อมูลตัวเลขที่จะเพิ่มเข้า";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Navy;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Navy;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "เลือกรอบบิล";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DarkBlue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkBlue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(568, 35);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(168, 51);
            this.bunifuThinButton22.TabIndex = 10;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "บันทึก หรือ กดปุ่ม F2";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(346, 35);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(209, 51);
            this.bunifuThinButton21.TabIndex = 9;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "บาท";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "บาท";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 39);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(392, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 37);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "ต้องการซื้อโต้ดด้วย";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(185, 92);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(138, 39);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("TH SarabunPSK", 25F);
            this.txt_id.Location = new System.Drawing.Point(185, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(138, 51);
            this.txt_id.TabIndex = 2;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(49, 95);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(130, 33);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "จำนวนเงิน (ตรง) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "หมายเลขที่ต้องการซื้อ :";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.รอบบิลที่,
            this.หมายเลข,
            this.จำนวนเงิน});
            this.DataGridView1.Location = new System.Drawing.Point(21, 223);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(754, 183);
            this.DataGridView1.TabIndex = 29;
            // 
            // รอบบิลที่
            // 
            this.รอบบิลที่.HeaderText = "รอบบิลที่";
            this.รอบบิลที่.Name = "รอบบิลที่";
            this.รอบบิลที่.ReadOnly = true;
            // 
            // หมายเลข
            // 
            this.หมายเลข.HeaderText = "หมายเลข";
            this.หมายเลข.Name = "หมายเลข";
            this.หมายเลข.ReadOnly = true;
            // 
            // จำนวนเงิน
            // 
            this.จำนวนเงิน.HeaderText = "จำนวนเงิน";
            this.จำนวนเงิน.Name = "จำนวนเงิน";
            this.จำนวนเงิน.ReadOnly = true;
            // 
            // imgExit
            // 
            this.imgExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgExit.Image = global::Lottery_List.Properties.Resources.remove;
            this.imgExit.Location = new System.Drawing.Point(760, 12);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(28, 27);
            this.imgExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgExit.TabIndex = 27;
            this.imgExit.TabStop = false;
            this.imgExit.Click += new System.EventHandler(this.ImgExit_Click);
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.imgExit);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainActivity_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripLabel ToolStripdate;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox imgExit;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.TextBox txt_id;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.DataGridViewTextBoxColumn รอบบิลที่;
        private System.Windows.Forms.DataGridViewTextBoxColumn หมายเลข;
        private System.Windows.Forms.DataGridViewTextBoxColumn จำนวนเงิน;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

