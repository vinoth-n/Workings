using MetroFramework.Forms;
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

namespace BillingSystem
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrder frm = new frmOrder();
            frm.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReport frm = new frmReport();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            try
            {
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(CommonClass.BasePath);
                foreach (var file in dir.GetFiles())
                {
                    System.IO.File.Delete(file.FullName);
                }
            }
            catch { }

            DataSet HdrXML = new DataSet();
            OleDbCommand OledbCmd = new OleDbCommand();
            OleDbDataAdapter OledbAdp = new OleDbDataAdapter();

            try
            {
                OledbCmd.Connection = CommonClass.fnGetConnection();
                OledbCmd.CommandTimeout = 0;
                OledbCmd.CommandType = CommandType.StoredProcedure;
                OledbCmd.CommandText = "PrcBillRpt";
                OledbCmd.Parameters.Add("@Action", "DSHBRD");
                OledbAdp.SelectCommand = OledbCmd;
                OledbAdp.Fill(HdrXML);

                chart1.DataSource = HdrXML.Tables[0];
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart1.Series[0].XValueMember = "PaymentTyp";
                chart1.Series[0].YValueMembers = "Amount";
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Titles.Add("Todays Collection");

                chart2.DataSource = HdrXML.Tables[1];
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart2.Series[0].XValueMember = "Category";
                chart2.Series[0].YValueMembers = "Amount";
                chart2.Series[0].IsValueShownAsLabel = true;
                chart2.Series[0].IsVisibleInLegend = false;
                chart2.Titles.Add("Todays Sales");

                chart3.DataSource = HdrXML.Tables[2];
                chart3.Titles.Add("Last 7 Days Sales by Category");

                chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart3.Series[0].XValueMember = "RptDate";
                chart3.Series[0].YValueMembers = "Cards";
                chart3.Series[0].IsValueShownAsLabel = true;
                chart3.Series[0].LegendText = "Cards";
                chart3.Series[0].BorderWidth = 2;

                chart3.Series.Add("Print");
                chart3.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart3.Series[1].XValueMember = "RptDate";
                chart3.Series[1].YValueMembers = "Printing";
                chart3.Series[1].IsValueShownAsLabel = true;
                chart3.Series[1].BorderWidth = 2;

                chart3.Series.Add("Gift");
                chart3.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart3.Series[2].XValueMember = "RptDate";
                chart3.Series[2].YValueMembers = "Gifts";
                chart3.Series[2].IsValueShownAsLabel = true;
                chart3.Series[2].BorderWidth = 2;

                chart3.Series.Add("Other");
                chart3.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart3.Series[3].XValueMember = "RptDate";
                chart3.Series[3].YValueMembers = "Others";
                chart3.Series[3].IsValueShownAsLabel = true;
                chart3.Series[3].BorderWidth = 2;

            }
            catch
            { }
            finally
            {
                HdrXML.Dispose(); HdrXML = null;
                OledbCmd.Dispose(); OledbCmd = null;
                OledbAdp.Dispose(); OledbAdp = null;
            }
        }
    }
}
