using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_List
{
    public partial class MainActivity : Form
    {

        public String billName = "";
        public String billId = "";
        String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/db.accdb;Persist Security Info=False;";
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd;
        CultureInfo culture = new CultureInfo("th-TH");
        public MainActivity()
        {
            InitializeComponent();
        }

        private void MainActivity_Load(object sender, EventArgs e)
        {
            Bunifu.Framework.Lib.Elipse.Apply(this, 10);
            textBox1.Enabled = false;
            toolStripLabel1.ForeColor = Color.Firebrick;
            toolStripLabel1.Text = "กรุณาเลือกรอบบิล";
        }

        private void SetTime()
        {
            DateTime localTime = DateTime.Now;
            ToolStripdate.Text = "วันที่ : " + localTime.ToString(culture);
        }

        private void ImgExit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SetTime();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox1.Checked;
            if(checkBox1.Checked == true)
            {
                textBox1.Focus();
            }
        }

        private void _clear()
        {
            txt_id.Clear();
            txt_name.Clear();
            textBox1.Clear();
            checkBox1.Checked = false;
            txt_id.Focus();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
           if(toolStripLabel1.Text.Trim() != "กรุณาเลือกรอบบิล")
            {
                if (txt_name.Text.Trim() != "")
                {
                    if (!checkBox1.Checked)
                    {
                        DataGridView1.Rows.Add(toolStripLabel1.Text.Trim(), txt_id.Text.Trim(), txt_name.Text.Trim());
                    }
                    else
                    {
                        if (textBox1.Text.Trim() != "")
                        {
                            DataGridView1.Rows.Add(toolStripLabel1.Text.Trim(), txt_id.Text.Trim(), txt_name.Text.Trim());
                            Permutations ps = new Permutations();
                            ps.permute(txt_id.Text.Trim(), 0, txt_id.Text.Trim().Length - 1);
                            String[] tmp = ps.get().Split(',');
                            foreach (String _i in tmp)
                            {
                                if (_i.Trim() != "" && _i.Trim() != txt_id.Text.Trim())
                                {
                                    DataGridView1.Rows.Add(toolStripLabel1.Text.Trim(), _i, textBox1.Text.Trim());
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("กรุณากรอกจำนวนเงินให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    try
                    {
                        con.ConnectionString = connection;
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                            Int32 _i = -1;
                            DataGridViewRow _row;
                            while (DataGridView1.Rows.Count > 0)
                            {
                                _i = 0;
                                if (_i >= 0)
                                {
                                    _row = DataGridView1.Rows[_i];
                                    cmd = new OleDbCommand("Insert Into tbl_tmp ([ID],[Values],[Price],[LogTime]) Values ('" + billId +
                                        "','" + _row.Cells[1].Value.ToString() + "',"+ Int32.Parse(_row.Cells[2].Value.ToString()) +
                                        ",'"+ DateTime.Now.ToString(culture) + "')", con);
                                    Console.WriteLine(cmd.CommandText);
                                    cmd.ExecuteNonQuery();
                                    DataGridView1.Rows.RemoveAt(_i);
                                    _i += 1;
                                }
                            }
                        }
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("ผิดพลาดเนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    _clear();
                }
                else
                {
                    MessageBox.Show("กรุณากรอกจำนวนเงินให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรอบบิลที่ต้องการบันทึก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                SelectBill sb = new SelectBill();
                sb.OnChoose += new ChooseEventHandler(choose_OnChoose);
                sb.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ผิดพลาดเนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void choose_OnChoose(object sender, ChooseEventArgs e)
        {
            billId = e.Cell0Value;
            billName = e.Cell1Value;
            toolStripLabel1.Text = e.Cell1Value;
            toolStripLabel1.ForeColor = Color.Lime;
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm._id = billId;
            fm.ShowDialog();
        }
    }
}
