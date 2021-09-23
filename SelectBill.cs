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
    public partial class SelectBill : Form
    {
        Int32 _index = -1;
        public event ChooseEventHandler OnChoose;
        DataGridViewRow row = new DataGridViewRow();
        String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/db.accdb;Persist Security Info=False;";
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd;
        public SelectBill()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (_index >= 0 )
            {
                row = this.DataGridView1.Rows[_index];
                String _id = row.Cells[0].Value.ToString();
                String _name = row.Cells[1].Value.ToString();
                if (OnChoose != null)
                {
                    OnChoose(this, new ChooseEventArgs(_id,_name));
                }
                this.Close();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;
        }

        private void SelectBill_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connection;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd = new OleDbCommand("SELECT ID,Name FROM tbl_bill ORDER BY LogTime DESC", con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable reader = new DataTable();
                    da.Fill(reader);
                    DataGridView1.DataSource = reader;
                    DataGridView1.Columns[0].HeaderText = "รหัสบิล";
                    DataGridView1.Columns[1].HeaderText = "ชื่อรอบบิล";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ผิดพลาดเนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/db.accdb;Persist Security Info=False;";
                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd;
                con.ConnectionString = connection;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    CultureInfo culture = new CultureInfo("th-TH");
                    cmd = new OleDbCommand("Insert Into tbl_bill ([Name],[LogTime]) Values ('" + txt_name.Text.Trim() + "','" + DateTime.Now.ToString(culture) + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("ผิดพลาดเนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            SelectBill_Load(sender,e);
        }
    }
}
