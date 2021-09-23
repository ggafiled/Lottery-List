namespace Lottery_List
{
    partial class SelectBill
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ToolStripHeader = new System.Windows.Forms.ToolStrip();
            this.btn_close = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.txt_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.ToolStripHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(12, 148);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(379, 290);
            this.DataGridView1.TabIndex = 5;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ToolStripHeader
            // 
            this.ToolStripHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_close,
            this.ToolStripButton1,
            this.toolStripButton2});
            this.ToolStripHeader.Location = new System.Drawing.Point(0, 0);
            this.ToolStripHeader.Name = "ToolStripHeader";
            this.ToolStripHeader.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStripHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripHeader.Size = new System.Drawing.Size(403, 105);
            this.ToolStripHeader.Stretch = true;
            this.ToolStripHeader.TabIndex = 6;
            this.ToolStripHeader.Text = "ToolStrip1";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("TH SarabunPSK", 18F);
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Image = global::Lottery_List.Properties.Resources.close48px;
            this.btn_close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.btn_close.Name = "btn_close";
            this.btn_close.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btn_close.Padding = new System.Windows.Forms.Padding(10);
            this.btn_close.Size = new System.Drawing.Size(72, 105);
            this.btn_close.Text = "ปิด";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Font = new System.Drawing.Font("TH SarabunPSK", 18F);
            this.ToolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripButton1.Image = global::Lottery_List.Properties.Resources.correct48px;
            this.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ToolStripButton1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ToolStripButton1.Padding = new System.Windows.Forms.Padding(10);
            this.ToolStripButton1.Size = new System.Drawing.Size(72, 105);
            this.ToolStripButton1.Text = "เลือก";
            this.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("TH SarabunPSK", 18F);
            this.toolStripButton2.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton2.Image = global::Lottery_List.Properties.Resources.clear48px;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButton2.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripButton2.Size = new System.Drawing.Size(91, 105);
            this.toolStripButton2.Text = "เพิ่มใหม่";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("TH SarabunPSK", 18F);
            this.txt_name.Location = new System.Drawing.Point(12, 103);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(379, 39);
            this.txt_name.TabIndex = 7;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.ToolStripHeader);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SelectBill";
            this.Text = "เลือกรอบบิล หรือสร้างรอบบิลใหม่";
            this.Load += new System.EventHandler(this.SelectBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ToolStripHeader.ResumeLayout(false);
            this.ToolStripHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ToolStrip ToolStripHeader;
        internal System.Windows.Forms.ToolStripButton btn_close;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripButton toolStripButton2;
        internal System.Windows.Forms.TextBox txt_name;
    }
}