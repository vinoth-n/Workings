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
    public partial class frmOrderSearch : MetroForm
    {
        public frmOrderSearch()
        {
            InitializeComponent();
        }

        DataSet HdrXML = new DataSet();       

        public int RefKey = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            fnLoadData();
        }

        private void fnLoadData()
        {

            OleDbCommand OledbCmd = new OleDbCommand();
            OleDbDataAdapter OledbAdp = new OleDbDataAdapter();

            try
            {
                HdrXML.Clear();

                OledbCmd.Connection = CommonClass.fnGetConnection();
                OledbCmd.CommandTimeout = 0;

                OledbCmd.CommandType = CommandType.StoredProcedure;
                OledbCmd.CommandText = "PrcBillSystem";

                OledbCmd.Parameters.Add("@Action", "SEL");
                OledbAdp.SelectCommand = OledbCmd;
                OledbAdp.Fill(HdrXML);


                this.dataGridView1.AllowUserToAddRows = false;
                this.dataGridView1.AllowUserToDeleteRows = false;
                this.dataGridView1.AllowUserToOrderColumns = false;
                this.dataGridView1.AllowUserToResizeRows = false;
                this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
                this.dataGridView1.RowHeadersVisible = false;
                this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                dataGridView1.DataSource = HdrXML.Tables[0].DefaultView;

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns[0].DataPropertyName = "BilNo";
                dataGridView1.Columns[0].HeaderText = "Bill No.";
                dataGridView1.Columns[0].Width = 100;

                dataGridView1.Columns[1].DataPropertyName = "BilDt";
                dataGridView1.Columns[1].HeaderText = "Bill Date";
                dataGridView1.Columns[1].Width = 80;

                dataGridView1.Columns[2].DataPropertyName = "CusNm";
                dataGridView1.Columns[2].HeaderText = "Customer Name";
                dataGridView1.Columns[2].Width = 250;

                dataGridView1.Columns[3].DataPropertyName = "MobNo";
                dataGridView1.Columns[3].HeaderText = "Mobile No.";
                dataGridView1.Columns[3].Width = 150;

                dataGridView1.Columns[4].DataPropertyName = "Nett";
                dataGridView1.Columns[4].HeaderText = "Total Amount";
                dataGridView1.Columns[4].Width = 100;

                dataGridView1.Columns[5].DataPropertyName = "Ref";
                dataGridView1.Columns[5].HeaderText = "";
                dataGridView1.Columns[5].Width = -1;

                Cmb_FltrBy.Items.Add("Bill No.");
                Cmb_FltrBy.Items.Add("Bill Date");
                Cmb_FltrBy.Items.Add("Customer Name");
                Cmb_FltrBy.Items.Add("Mobile No.");
                Cmb_FltrBy.Items.Add("Amount");

                Cmb_FltrBy.SelectedIndex = 0;

            }
            catch { }
            finally
            {
                OledbCmd.Dispose(); OledbCmd = null; OledbAdp.Dispose(); OledbAdp = null;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.RefKey = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Ref"].FormattedValue);
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dataGridView1 != null && txt_Filter.Text != null && txt_Filter.Text != "" && this.HdrXML != null && this.HdrXML.Tables.Count > 0)
            {
                DataView Dv = new DataView();
                Dv.Table = this.HdrXML.Tables[0];
                Dv.RowFilter = this.HdrXML.Tables[0].Columns[this.Cmb_FltrBy.SelectedIndex].ColumnName.Trim() + " like '%" + this.txt_Filter.Text.Trim() + "%'";
                this.dataGridView1.DataSource = Dv;
                this.dataGridView1.Refresh();                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnLoadData();
        }
    }
}
