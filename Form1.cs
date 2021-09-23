using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_List
{
    public partial class Form1 : Form
    {
        public String _id = "";
        CrystalReport1 cs = new CrystalReport1();
        String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/db.accdb;Persist Security Info=False;";
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT tbl_bill.ID, tbl_bill.Name, tbl_tmp.Values, Sum(tbl_tmp.Price) AS Price FROM tbl_bill, tbl_tmp WHERE  tbl_bill.ID = " + _id + " GROUP BY tbl_bill.ID, tbl_bill.Name, tbl_tmp.Values ORDER BY tbl_tmp.Values DESC";
                con.ConnectionString = connection;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd = new OleDbCommand(sql, con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable reader = new DataTable();
                    da.Fill(reader);
                    cs.SetDataSource(reader);
                    crystalReportViewer1.ReportSource = cs;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ผิดพลาดเนื่องจาก " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
