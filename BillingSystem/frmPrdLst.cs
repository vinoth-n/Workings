using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmPrdLst : MetroForm
    {
        private DataSet PrdDtls_DS;
        public string __PrdNm = "";
        int SlNo = 0;

        public frmPrdLst()
        {
            InitializeComponent();
        }

        private void frmPrdLst_Load(object sender, EventArgs e)
        {
            fnDatagrid_Design();
            LoadDataGrid();
        }

        private void fnDatagrid_Design()
        {
            if (PrdDtls_DS != null)
            { PrdDtls_DS = null; }

            PrdDtls_DS = new DataSet();

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            PrdDtls_DS.Tables.Add(new DataTable());
            PrdDtls_DS.Tables[0].Columns.Add("SNo", typeof(int));
            PrdDtls_DS.Tables[0].Columns.Add("PrdNm", typeof(String));
            PrdDtls_DS.Tables[0].Columns.Add("Pk", typeof(int));

            dataGridView1.DataSource = PrdDtls_DS.Tables[0].DefaultView;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "SNo";
            dataGridView1.Columns[0].HeaderText = "SNo.";
            dataGridView1.Columns[0].Width = 50;

            dataGridView1.Columns[1].DataPropertyName = "PrdNm";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns[1].Width = 410;

            dataGridView1.Columns[2].DataPropertyName = "Pk";
            dataGridView1.Columns[2].Width = -1;

        }

        private void LoadDataGrid()
        {
            DataSet HdrXML = new DataSet();
            OleDbCommand OledbCmd = new OleDbCommand();
            OleDbDataAdapter OledbAdp = new OleDbDataAdapter();

            try
            {
                OledbCmd.Connection = CommonClass.fnGetConnection();
                OledbCmd.CommandTimeout = 0;

                OledbCmd.CommandType = CommandType.StoredProcedure;
                OledbCmd.CommandText = "PrcPrdMas";

                OledbCmd.Parameters.Add("@Action", "S");
                OledbAdp.SelectCommand = OledbCmd;
                OledbAdp.Fill(HdrXML);

                PrdDtls_DS.Tables[0].Clear();
                foreach (DataRow dRow in HdrXML.Tables[0].Rows)
                {
                    PrdDtls_DS.Tables[0].ImportRow(dRow);
                    SlNo = Convert.ToInt16(dRow["SNo"].ToString());
                }
                dataGridView1.DataSource = PrdDtls_DS.Tables[0].DefaultView;
                dataGridView1.Refresh();
            }
            catch { }
            finally
            {
                HdrXML.Dispose(); HdrXML = null;
                OledbCmd.Dispose(); OledbCmd = null; OledbAdp.Dispose(); OledbAdp = null;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDtls(e.RowIndex);
        }

        private void txt_PrdNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dataGridView1 != null && txt_Filter.Text != null && txt_Filter.Text != "" && this.PrdDtls_DS != null && this.PrdDtls_DS.Tables.Count > 0)
            {
                DataView Dv = new DataView();
                Dv.Table = this.PrdDtls_DS.Tables[0];
                Dv.RowFilter = this.PrdDtls_DS.Tables[0].Columns[1].ColumnName.Trim() + " like '%" + this.txt_Filter.Text.Trim() + "%'";
                this.dataGridView1.DataSource = Dv;
                this.dataGridView1.Refresh();
                //Dv.Dispose(); Dv = null; 
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow dRow in dataGridView1.SelectedRows)
                {
                    GetDtls(dRow.Index);
                }
            }
        }

        private void GetDtls(int _RowIndx)
        {
            if (_RowIndx >= 0)
            {
                this.__PrdNm = Convert.ToString(dataGridView1.Rows[_RowIndx].Cells["PrdNm"].FormattedValue);
                this.Close();
            }
        }
    }
}
