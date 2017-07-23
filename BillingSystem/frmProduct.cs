using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmProduct : MetroForm
    {
        private DataSet PrdDtls_DS;
        int SlNo = 0;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            fnDatagrid_Design();
            LoadDataGrid();
        }

        private void frmProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string ErrMsg = "";
            if (PrdDtls_DS.Tables[0].Rows.Count == 0)
            { ErrMsg = ErrMsg + "Product Details Cannot be Empty. \n"; }

            if (ErrMsg != "")
            {
                MetroMessageBox.Show(this, ErrMsg, "Error - Billing System");
                return;
            }

            OleDbCommand OledbCmd = new OleDbCommand();

            try
            {
                // GridDetails
                foreach (DataColumn dCol in PrdDtls_DS.Tables[0].Columns)
                {
                    dCol.ColumnMapping = MappingType.Attribute;
                }

                OledbCmd.Connection = CommonClass.fnGetConnection();
                OledbCmd.CommandTimeout = 0;

                OledbCmd.CommandType = CommandType.StoredProcedure;
                OledbCmd.CommandText = "PrcPrdMas";
                OledbCmd.Parameters.Add("@Action", "A");
                OledbCmd.Parameters.Add("@GrdXML", PrdDtls_DS.GetXml());
                OledbCmd.ExecuteNonQuery();

                MetroMessageBox.Show(this, "Saved Sucessfully", "Billing System");
                LoadDataGrid();

            }
            catch (Exception Ex)
            { MetroMessageBox.Show(this, Ex.Message.ToString()); }
            finally
            { }
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

        private void fnAdd2Grid()
        {
            if (txt_PrdNm.Text == "")
            {
                MessageBox.Show("Product Name Cannot be Empty.", "Validation - Billing System");
                txt_PrdNm.Focus();
                return;
            }

            String PrdNm = txt_PrdNm.Text.Trim();
            SlNo = SlNo + 1;
            if (PrdDtls_DS != null)
            {
                PrdDtls_DS.Tables[0].Rows.Add(SlNo, PrdNm, 0);
            }

            // Clearing GRID Data
            txt_PrdNm.Text = ""; txt_PrdNm.Focus();
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            txt_PrdNm.Text = ""; txt_PrdNm.Focus();
        }

        private void txt_PrdNm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fnAdd2Grid();
            }
        }
    }
}
