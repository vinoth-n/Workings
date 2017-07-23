using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmReport : MetroForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        DataSet HdrXML;

        private void frmReports_Load(object sender, EventArgs e)
        {
            dtp_FrmDt.Format = DateTimePickerFormat.Custom;
            dtp_FrmDt.CustomFormat = "dd/MM/yyyy";

            dtp_ToDt.Format = DateTimePickerFormat.Custom;
            dtp_ToDt.CustomFormat = "dd/MM/yyyy";

            cmb_Report.Items.Add("Order Details");
            cmb_Report.Items.Add("Collection Report");
            cmb_Report.Items.Add("Printing Report");
            cmb_Report.Items.Add("Order Report");
            cmb_Report.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _Action = "";
            if (cmb_Report.SelectedIndex == 0)
                _Action = "ORDDTL";            
            else if (cmb_Report.SelectedIndex == 1)            
                _Action = "COLRPT";
            else if (cmb_Report.SelectedIndex == 2)
                _Action = "PRNT_RPT";
            else if (cmb_Report.SelectedIndex == 3)
                _Action = "ORD_RPT";

            HdrXML = new DataSet();
            OleDbCommand OledbCmd = new OleDbCommand();
            OleDbDataAdapter OledbAdp = new OleDbDataAdapter();


            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            try
            {
                OledbCmd.Connection = CommonClass.fnGetConnection();
                OledbCmd.CommandTimeout = 0;

                OledbCmd.CommandType = CommandType.StoredProcedure;
                OledbCmd.CommandText = "PrcBillRpt";

                OledbCmd.Parameters.Add("@Action", _Action);
                OledbCmd.Parameters.Add("@FDt", dtp_FrmDt.Text);
                OledbCmd.Parameters.Add("@TDt", dtp_ToDt.Text);

                OledbAdp.SelectCommand = OledbCmd;
                OledbAdp.Fill(HdrXML);

                dataGridView1.DataSource = HdrXML.Tables[0].DefaultView;
                dataGridView1.Refresh();

            }
            catch
            { }
            finally
            {
                OledbCmd.Dispose(); OledbCmd = null;
                OledbAdp.Dispose(); OledbAdp = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (HdrXML != null)
            {
                string fileName = string.Format(@"{1}\Report_{0}.xlsx", DateTime.Now.ToString("yyyyMMddHHMMss"), CommonClass.BasePath);
                using (ExcelPackage Exl = new ExcelPackage())
                {
                    var xlBook = Exl.Workbook.Worksheets.Add("Report");
                    xlBook.Cells["A1"].Value = cmb_Report.Text;
                    xlBook.Cells["A2"].Value = string.Format("From Date : {0}", dtp_FrmDt.Text);
                    xlBook.Cells["A3"].Value = string.Format("To Date : {0}", dtp_ToDt.Text);

                    xlBook.Cells["A5"].LoadFromDataTable(HdrXML.Tables[0], true);                    
                    FileInfo file = new FileInfo(fileName);
                    Exl.SaveAs(file);
                }
                System.Diagnostics.Process.Start(fileName);
            }
        }

        private void frmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }
    }
}
