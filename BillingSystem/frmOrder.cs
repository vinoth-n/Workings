using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmOrder : MetroForm
    {
        private DataSet OrderDtls_DS;
        private DataSet PrdXML = new DataSet();
        private bool _GridEdit = false;
        private int _SerialNo = 0, _GridIndex = 0;
        private int _RefKey = 0;
        private bool isOrderClosed = false;
        private decimal taxPercentage = 0;
        private decimal TotaltaxPercentage = 0;
        PaymentDetails paymnt;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            txt_Discount.Text = "0.00";
            taxPercentage = Convert.ToDecimal(Math.Round((6.00 / 100.00), 2));
            TotaltaxPercentage = Convert.ToDecimal(Math.Round((12.00/ 100.00), 2));
            lbl_Balance.Visible = false;

            ddl_Category.ItemHeight = 20;

            lbl_Taxable.UseCustomForeColor = true;
            lbl_Taxable.ForeColor = Color.Blue;

            lbl_Tax.UseCustomForeColor = true;
            lbl_Tax.ForeColor = Color.Orange;

            lbl_Gst.UseCustomForeColor = true;
            lbl_Gst.ForeColor = Color.Red;

            lbl_Total.UseCustomForeColor = true;
            lbl_Total.ForeColor = Color.Green;

            lbl_Name.UseCustomForeColor = true;
            lbl_Name.ForeColor = Color.Red;
            lbl_MobileNo.UseCustomForeColor = true;
            lbl_MobileNo.ForeColor = Color.Red;

            dat_ProofDate.Format = DateTimePickerFormat.Custom;
            dat_ProofDate.CustomFormat = "dd/MM/yyyy";

            dat_BillDate.Format = DateTimePickerFormat.Custom;
            dat_BillDate.CustomFormat = "dd/MM/yyyy";

            dat_DeliveryDate.Format = DateTimePickerFormat.Custom;
            dat_DeliveryDate.CustomFormat = "dd/MM/yyyy";

            dat_DeliveredDate.Format = DateTimePickerFormat.Custom;
            dat_DeliveredDate.CustomFormat = "dd/MM/yyyy";

            dat_BillDate.Text = DateTime.Now.ToString(); //.ToString("dd/MM/yyyy");
            dat_ProofDate.Text = DateTime.Now.AddDays(1).ToString(); // DateTime.Now.ToString("dd/MM/yyyy");
            dat_DeliveryDate.Text = DateTime.Now.AddDays(7).ToString(); //.ToString("dd/MM/yyyy");
            dat_DeliveredDate.Text = DateTime.Now.ToString();

            fnDatagrid_Design();
            fnGetBilNo();
        }

        private void fnGetBilNo()
        {
            OleDbDataReader OledbRdr;
            OleDbCommand OledbCmd = new OleDbCommand();

            try
            {
                OledbCmd.Connection = CommonClass.fnGetConnection();
                OledbCmd.CommandTimeout = 0;

                OledbCmd.CommandType = CommandType.StoredProcedure;
                OledbCmd.CommandText = "PrcBillSystem";

                OledbCmd.Parameters.Add("@Action", "BILNO");

                OledbRdr = OledbCmd.ExecuteReader();

                if (OledbRdr.HasRows == true)
                {
                    while (OledbRdr.Read())
                    {
                        txt_BillNo.Text = OledbRdr.GetValue(0).ToString();
                    }
                }

            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            finally
            { OledbCmd.Dispose(); OledbCmd = null; }

        }

        private void frmOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void fnNumberValidation(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 46 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            fnNumberValidation(sender, e);
        }

        private void txt_Rate_Leave(object sender, EventArgs e)
        {
            if (txt_Qty.Text == "" || txt_Qty.Text == "0" || txt_Qty.Text == "0.00")
            {
                MetroMessageBox.Show(this, "Qty. Cannot be Empty / Zero", "Validation - Billing System");
                return;
            }
            try
            {
                txt_Value.Text = Convert.ToString(Convert.ToDouble(txt_Qty.Text) * Convert.ToDouble(txt_Rate.Text));
            }
            catch { txt_Value.Text = "0.00"; }
        }

        private void txt_Value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fnAdd2Grid();
            }
        }

        private void fnDatagrid_Design()
        {
            if (OrderDtls_DS != null)
            { OrderDtls_DS = null; }

            OrderDtls_DS = new DataSet();

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            OrderDtls_DS.Tables.Add(new DataTable());
            OrderDtls_DS.Tables[0].Columns.Add("SNo", typeof(int));
            OrderDtls_DS.Tables[0].Columns.Add("Part", typeof(string));
            OrderDtls_DS.Tables[0].Columns.Add("Qty", typeof(decimal));
            OrderDtls_DS.Tables[0].Columns.Add("Rate", typeof(decimal));
            OrderDtls_DS.Tables[0].Columns.Add("Value", typeof(decimal));
            OrderDtls_DS.Tables[0].Columns.Add("CGST", typeof(decimal));
            OrderDtls_DS.Tables[0].Columns.Add("SGST", typeof(decimal));
            OrderDtls_DS.Tables[0].Columns.Add("Pk", typeof(int));
            OrderDtls_DS.Tables[0].Columns.Add("TotAmt", typeof(decimal));
            OrderDtls_DS.Tables[0].Columns.Add("Amount", typeof(decimal));
            OrderDtls_DS.Tables[0].Columns.Add("PrdCat", typeof(string));
            dataGridView1.DataSource = OrderDtls_DS.Tables[0].DefaultView;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "SNo";
            dataGridView1.Columns[0].HeaderText = "SNo.";
            dataGridView1.Columns[0].Width = 50;

            dataGridView1.Columns[1].DataPropertyName = "Part";
            dataGridView1.Columns[1].HeaderText = "Particulars";
            dataGridView1.Columns[1].Width = 250;

            dataGridView1.Columns[2].DataPropertyName = "PrdCat";
            dataGridView1.Columns[2].HeaderText = "Category";
            dataGridView1.Columns[2].Width = 120;

            dataGridView1.Columns[3].DataPropertyName = "Qty";
            dataGridView1.Columns[3].HeaderText = "Qty";
            dataGridView1.Columns[3].Width = 80;

            dataGridView1.Columns[4].DataPropertyName = "Rate";
            dataGridView1.Columns[4].HeaderText = "Rate";
            dataGridView1.Columns[4].Width = 100;

            dataGridView1.Columns[5].DataPropertyName = "Value";
            dataGridView1.Columns[5].HeaderText = "Value";
            dataGridView1.Columns[5].Width = 100;

            dataGridView1.Columns[6].DataPropertyName = "Pk";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[6].Width = -1;

            dataGridView1.Columns[7].DataPropertyName = "CGST";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[7].Width = -1;

            dataGridView1.Columns[8].DataPropertyName = "SGST";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[8].Width = -1;

            dataGridView1.Columns[9].DataPropertyName = "TotAmt";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[9].Width = -1;

            dataGridView1.Columns[10].DataPropertyName = "Amount";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[10].Width = -1;
        }

        private void fnAdd2Grid()
        {
            if (string.IsNullOrEmpty(txt_PrdNm.Text))
            {
                MetroMessageBox.Show(this, "Particulars Cannot be Empty / Zero", "Validation - Billing System");
                txt_PrdNm.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_Value.Text) || txt_Value.Text == "0" || txt_Value.Text == "0.00")
            {
                MetroMessageBox.Show(this, "Value Cannot be Empty / Zero", "Validation - Billing System");
                txt_Value.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ddl_Category.Text))
            {
                MetroMessageBox.Show(this, "Product Category cannot be empty.", "Validation - Billing System");
                return;
            }

            int SlNo = 0, Pk = 0;
            string Part = "";
            decimal Qty = 0, Rate = 0, Value = 0, CGST = 0, SGST = 0;

            if (_GridEdit == false)
            { _SerialNo = _SerialNo + 1; }
            else { _SerialNo = _GridIndex; }

            SlNo = _SerialNo;
            Part = txt_PrdNm.Text;
            Qty = Convert.ToDecimal(txt_Qty.Text);
            if (txt_Rate.Text != "")
            { Rate = Convert.ToDecimal(txt_Rate.Text); }

            Value = ProductCalculation(CalculationType.TaxableValue);
            CGST = ProductCalculation(CalculationType.Tax);
            SGST = ProductCalculation(CalculationType.Tax);

            if (OrderDtls_DS != null)
            {
                OrderDtls_DS.Tables[0].Rows.Add(SlNo, Part, Qty, Rate, Value, CGST, SGST, Pk, (Value + CGST + SGST), Convert.ToDecimal(txt_Value.Text), ddl_Category.Text);
                fnCalculateTotalValue();
            }

            // Clearing GRID Data
            txt_PrdNm.Text = string.Empty; txt_Qty.Text = string.Empty; txt_Rate.Text = string.Empty; txt_Value.Text = string.Empty;
            txt_PrdNm.Focus();
        }

        private decimal ProductCalculation(CalculationType typ)
        {
            decimal qty = string.IsNullOrEmpty(txt_Qty.Text) ? 0 : Convert.ToDecimal(txt_Qty.Text);
            decimal rate = string.IsNullOrEmpty(txt_Rate.Text) ? 0 : Convert.ToDecimal(txt_Rate.Text);
            decimal value = string.IsNullOrEmpty(txt_Value.Text) ? 0 : Convert.ToDecimal(txt_Value.Text);

            if (typ == CalculationType.TaxableValue)            
                return GetProductTaxableAmount(qty, rate, value);            
            else if (typ == CalculationType.Tax)            
                return GetProductTaxAmount(qty, rate, value);            
            return 0;
        }

        private decimal GetProductTaxableAmount(decimal qty, decimal rate, decimal value)
        {
            if (rate == 0 && value != 0)
                return Math.Round((value / (1 + TotaltaxPercentage)), 2);
            else
                return Math.Round(((qty * rate) / (1 + TotaltaxPercentage)), 2);
        }

        private decimal GetProductTaxAmount(decimal qty, decimal rate, decimal value)
        {
            if (rate == 0 && value != 0)
                return Math.Round(((value / (1 + TotaltaxPercentage)) * taxPercentage), 2);
            else
                return Math.Round((((qty * rate) / (1 + TotaltaxPercentage)) * taxPercentage), 2);
        }

        private void fnCalculateTotalValue()
        {
            lbl_Taxable.Text = Convert.ToString(OrderDtls_DS.Tables[0].AsEnumerable().Sum(row => Convert.ToDecimal(row["Value"])));
            decimal cgst = OrderDtls_DS.Tables[0].AsEnumerable().Sum(row => Convert.ToDecimal(row["CGST"]));
            decimal sgst = OrderDtls_DS.Tables[0].AsEnumerable().Sum(row => Convert.ToDecimal(row["SGST"]));

            lbl_Gst.Text = Convert.ToString(cgst + sgst);

            decimal totalAmt = Convert.ToDecimal(OrderDtls_DS.Tables[0].AsEnumerable().Sum(row => Convert.ToDecimal(row["TotAmt"])));
            lbl_RoundOff.Text = Convert.ToString(Math.Round((Math.Round(totalAmt, 0) - totalAmt), 2));
            lbl_Total.Text = Convert.ToString(Math.Round(totalAmt, 0));
        }

        private void txt_Discount_Leave(object sender, EventArgs e)
        {
            CalculateDiscountAmount();
        }

        private void CalculateDiscountAmount()
        {
            decimal discountAmt = string.IsNullOrEmpty(txt_Discount.Text) ? 0 : Convert.ToDecimal(txt_Discount.Text);
            bool discountExists = discountAmt != 0 ? true : false;

            var tmp = OrderDtls_DS.Tables[0].AsEnumerable().ToList();

            if (discountExists)
            {
                decimal amount = 0;
                decimal discountPer = 0;
                decimal productdiscountAmount = 0;
                decimal newAmount = 0;
                decimal totalAmt = Convert.ToDecimal(OrderDtls_DS.Tables[0].AsEnumerable().Sum(row => Convert.ToDecimal(row["TotAmt"])));
                tmp.ForEach(x =>
                {

                    amount = Convert.ToDecimal(x["TotAmt"]);
                    discountPer = Math.Round((amount / totalAmt * 100), 2);
                    productdiscountAmount = Math.Round((discountAmt * (discountPer / 100)), 2);
                    newAmount = Math.Round(((amount - productdiscountAmount) / (1 + TotaltaxPercentage)), 2);

                    x["Value"] = newAmount;
                    x["CGST"] = Math.Round((newAmount * taxPercentage), 2);
                    x["SGST"] = Math.Round((newAmount * taxPercentage), 2);
                    x["TotAmt"] = Convert.ToDecimal(x["Value"]) + Convert.ToDecimal(x["CGST"]) + Convert.ToDecimal(x["SGST"]);
                });
            }
            else
            {
                decimal qty = 0;
                decimal rate = 0;
                decimal value = 0;
                tmp.ForEach(x =>
                {
                    qty = Convert.ToDecimal(x["Qty"]);
                    rate = Convert.ToDecimal(x["Rate"]);
                    value = Convert.ToDecimal(x["Amount"]);

                    x["Value"] = GetProductTaxableAmount(qty, rate, value);
                    x["CGST"] = GetProductTaxAmount(qty, rate, value);
                    x["SGST"] = GetProductTaxAmount(qty, rate, value);
                    x["TotAmt"] = Convert.ToDecimal(x["Value"]) + Convert.ToDecimal(x["CGST"]) + Convert.ToDecimal(x["SGST"]);
                });
            }
            fnCalculateTotalValue();
        }

        private void txt_PrdNm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmPrdLst frm = new frmPrdLst();
                frm.ShowDialog();
                if (frm.__PrdNm != "")
                {
                    txt_PrdNm.Text = "";
                    txt_PrdNm.Text = frm.__PrdNm;
                    txt_Qty.Focus();
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            String ErrMsg = "";

            if (txt_Name.Text == "")
                ErrMsg = ErrMsg + "Customer Name Cannot be Empty. \n";
            if (txt_MobilNo.Text == "")
                ErrMsg = ErrMsg + "Mobile No Cannot be Empty. \n";
            if (txt_BillNo.Text == "")
                ErrMsg = ErrMsg + "Bill No Cannot be Empty. \n";
            if (OrderDtls_DS.Tables[0].Rows.Count == 0)
                ErrMsg = ErrMsg + "Product Details Cannot be Empty. \n";
            if(isOrderClosed && _RefKey != 0 )
                ErrMsg = ErrMsg + "Cannot update the deliverd orders, Contact Administrator. \n";

            if (!string.IsNullOrEmpty(ErrMsg))
            {
                MetroMessageBox.Show(this, ErrMsg, "Error - Billing System");
                return;
            }

            frmReceiveAmount frm = new frmReceiveAmount();
            if (paymnt == null)
                paymnt = new PaymentDetails();
            paymnt.AmountReceived = 0;
            paymnt.TotalAmount = string.IsNullOrEmpty(lbl_Total.Text) ? 0 : Convert.ToDecimal(lbl_Total.Text);
            frm.paymentDetails = paymnt;
            frm.ShowDialog();
            if (frm == null || frm.paymentDetails == null)
                return;
            paymnt = frm.paymentDetails;

            DataSet HdrXML = new DataSet();
            OleDbCommand OledbCmd = new OleDbCommand();

            try
            {
                HdrXML.Tables.Add();

                HdrXML.Tables.Add(new DataTable());
                HdrXML.Tables[0].Columns.Add("CusNm", typeof(string));
                HdrXML.Tables[0].Columns.Add("MobNo", typeof(string));
                HdrXML.Tables[0].Columns.Add("EmailId", typeof(string));
                HdrXML.Tables[0].Columns.Add("OrdNo", typeof(string));
                HdrXML.Tables[0].Columns.Add("ProfDt", typeof(string));
                HdrXML.Tables[0].Columns.Add("DelDt", typeof(string));
                HdrXML.Tables[0].Columns.Add("BilNo", typeof(string));
                HdrXML.Tables[0].Columns.Add("BilDt", typeof(string));
                HdrXML.Tables[0].Columns.Add("Rmks", typeof(string));
                HdrXML.Tables[0].Columns.Add("AmntRcvd", typeof(decimal));
                HdrXML.Tables[0].Columns.Add("DelySts", typeof(int));
                HdrXML.Tables[0].Columns.Add("DelyDt", typeof(string));
                HdrXML.Tables[0].Columns.Add("Add", typeof(string));
                HdrXML.Tables[0].Columns.Add("Dis", typeof(decimal));
                HdrXML.Tables[0].Columns.Add("CGST", typeof(decimal));
                HdrXML.Tables[0].Columns.Add("SGST", typeof(decimal));
                HdrXML.Tables[0].Columns.Add("Rnd", typeof(decimal));
                HdrXML.Tables[0].Columns.Add("CashAmnt", typeof(decimal));
                HdrXML.Tables[0].Columns.Add("CardAmnt", typeof(decimal));
                HdrXML.Tables[0].Columns.Add("Transfer", typeof(decimal));
                HdrXML.Tables[0].Columns.Add("WriteOff", typeof(decimal));


                //txt_AmtRcvd

                String CusNm = "", MobNo = "", EmailId = "", OrdNo = "", ProfDt = "", DelDt = "", BilNo = "", BilDt = "", Rmks = "", DelyDt = "", Address = "";
                decimal AmntRcvd = 0, Discount = 0, CGST = 0, SGST = 0, Rnd = 0, CashAmnt = 0, CardAmnt = 0, Transfer = 0, WriteOff = 0;
                int DelySts = 0;

                CusNm = txt_Name.Text;
                MobNo = txt_MobilNo.Text;
                EmailId = txt_EmailAddress.Text;
                OrdNo = txt_OrderNo.Text;
                BilNo = txt_BillNo.Text;
                Rmks = txt_Remarks.Text;
                ProfDt = dat_ProofDate.Text;
                DelDt = dat_DeliveryDate.Text;
                BilDt = dat_BillDate.Text;
                DelyDt = dat_DeliveredDate.Text;
                Address = txt_Address.Text;
                DelySts = (Chk_Delivered.Checked == true ? 1 : 0);
                CashAmnt = paymnt.Cash;
                CardAmnt = paymnt.Card;
                Transfer = paymnt.NetTransfer;
                WriteOff = paymnt.WriteOff;
                AmntRcvd = paymnt.AmountReceived;
                Discount = string.IsNullOrEmpty(txt_Discount.Text) ? 0 : Math.Round(Convert.ToDecimal(txt_Discount.Text), 2);
                Rnd = string.IsNullOrEmpty(lbl_RoundOff.Text) ? 0 : Math.Round(Convert.ToDecimal(lbl_RoundOff.Text), 2);
                CGST = Convert.ToDecimal(OrderDtls_DS.Tables[0].AsEnumerable().Sum(row => Convert.ToDecimal(row["CGST"])));
                SGST = Convert.ToDecimal(OrderDtls_DS.Tables[0].AsEnumerable().Sum(row => Convert.ToDecimal(row["SGST"])));

                if (DelySts == 1 && paymnt.Balance > 0)
                {
                    MetroMessageBox.Show(this, "Delivered Order Needs to pay the full amount", "Error - Billing System");
                    return;
                }

                // Header Details        
                if (HdrXML != null)
                {
                    HdrXML.Tables[0].Rows.Add(CusNm, MobNo, EmailId, OrdNo, ProfDt, DelDt, BilNo, BilDt, Rmks, AmntRcvd, DelySts, DelyDt, Address, Discount, CGST, SGST, Rnd, CashAmnt, CardAmnt, Transfer, WriteOff);
                }

                foreach (DataColumn dCol in HdrXML.Tables[0].Columns)
                {
                    dCol.ColumnMapping = MappingType.Attribute;
                }

                // GridDetails
                foreach (DataColumn dCol in OrderDtls_DS.Tables[0].Columns)
                {
                    dCol.ColumnMapping = MappingType.Attribute;
                }

                OledbCmd.Connection = CommonClass.fnGetConnection();
                OledbCmd.CommandTimeout = 0;

                OledbCmd.CommandType = CommandType.StoredProcedure;
                OledbCmd.CommandText = "PrcBillSystem";
                if (_RefKey == 0)
                {
                    OledbCmd.Parameters.Add("@Action", "A");
                }
                else
                {
                    OledbCmd.Parameters.Add("@Action", "E");
                }
                OledbCmd.Parameters.Add("@HdrXML", HdrXML.GetXml());
                OledbCmd.Parameters.Add("@GrdXML", OrderDtls_DS.GetXml());
                OledbCmd.Parameters.Add("@DocPk", _RefKey);

                _RefKey = Convert.ToInt32(OledbCmd.ExecuteScalar());

                if (MetroMessageBox.Show(this, "Saved Sucessfully, You want to generate Invoice Print", "Billing System", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fnPrint();
                }
                fnClear();
                _RefKey = 0;
            }
            catch (Exception E)
            {
                MetroMessageBox.Show(this, E.Message, "Error - Billing System");
            }
            finally
            {
                HdrXML.Dispose(); HdrXML = null; OledbCmd.Dispose(); OledbCmd = null;

            }
        }

        private void fnClear()
        {
            txt_BillNo.Text = "";
            txt_EmailAddress.Text = "";
            txt_MobilNo.Text = "";
            txt_Name.Text = "";
            txt_OrderNo.Text = "";
            txt_PrdNm.Text = "";
            txt_Qty.Text = "";
            txt_Rate.Text = "";
            txt_Value.Text = "";
            txt_Remarks.Text = "";
            Chk_Delivered.Checked = false;
            txt_Address.Text = "";

            lbl_Gst.Text = "0.00";
            lbl_RoundOff.Text = "0.00";
            lbl_Taxable.Text = "0.00";
            //lbl_Advance.Text = "Advance Received : 0.00";
            lbl_Total.Text = "0.00";
            txt_Discount.Text = "0.00";

            dat_BillDate.Text = DateTime.Now.ToString(); //.ToString("dd/MM/yyyy");
            dat_ProofDate.Text = DateTime.Now.AddDays(1).ToString(); // DateTime.Now.ToString("dd/MM/yyyy");
            dat_DeliveryDate.Text = DateTime.Now.AddDays(7).ToString(); //.ToString("dd/MM/yyyy");
            dat_DeliveredDate.Text = DateTime.Now.ToString();
            paymnt = new PaymentDetails();

            fnGetBilNo();
            OrderDtls_DS.Clear();
            _RefKey = 0;
            isOrderClosed = false;
            lbl_Balance.Visible = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            fnClear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frmOrderSearch frm = new frmOrderSearch();
            frm.ShowDialog();
            _RefKey = frm.RefKey;
            fnGetData();
        }

        private void fnGetData()
        {
            DataSet HdrXML = new DataSet();
            OleDbCommand OledbCmd = new OleDbCommand();
            OleDbDataAdapter OledbAdp = new OleDbDataAdapter();

            try
            {
                OledbCmd.Connection = CommonClass.fnGetConnection();
                OledbCmd.CommandTimeout = 0;

                OledbCmd.CommandType = CommandType.StoredProcedure;
                OledbCmd.CommandText = "PrcBillSystem";

                OledbCmd.Parameters.Add("@Action", "S");
                OledbCmd.Parameters.Add("@HdrXML", DBNull.Value);
                OledbCmd.Parameters.Add("@GrdXML", DBNull.Value);
                OledbCmd.Parameters.Add("@DocPk", _RefKey);
                OledbAdp.SelectCommand = OledbCmd;
                OledbAdp.Fill(HdrXML);
                int docRef = _RefKey;

                fnClear();

                _RefKey = docRef;
                txt_BillNo.Text = HdrXML.Tables[0].Rows[0]["InvBilNo"].ToString();
                txt_EmailAddress.Text = HdrXML.Tables[0].Rows[0]["InvEmailId"].ToString();
                txt_MobilNo.Text = HdrXML.Tables[0].Rows[0]["InvMobNo"].ToString();
                txt_Name.Text = HdrXML.Tables[0].Rows[0]["InvCusNm"].ToString();
                txt_OrderNo.Text = HdrXML.Tables[0].Rows[0]["InvOrdNo"].ToString();
                txt_Remarks.Text = HdrXML.Tables[0].Rows[0]["InvRmks"].ToString();
                txt_Address.Text = HdrXML.Tables[0].Rows[0]["Add"].ToString();

                lbl_Gst.Text = HdrXML.Tables[0].Rows[0]["InvVAT"].ToString();
                txt_Discount.Text = HdrXML.Tables[0].Rows[0]["Dis"].ToString();
                lbl_RoundOff.Text = HdrXML.Tables[0].Rows[0]["Rnd"].ToString();
                lbl_Taxable.Text = HdrXML.Tables[0].Rows[0]["InvGross"].ToString();
                lbl_Total.Text = HdrXML.Tables[0].Rows[0]["InvNett"].ToString();
                
                dat_ProofDate.Text = HdrXML.Tables[0].Rows[0]["InvProfDt"].ToString();
                dat_BillDate.Text = HdrXML.Tables[0].Rows[0]["InvBilDt"].ToString();
                dat_DeliveryDate.Text = HdrXML.Tables[0].Rows[0]["InvDelDt"].ToString();
                dat_DeliveredDate.Text = HdrXML.Tables[0].Rows[0]["DelyDt"].ToString();

                isOrderClosed = Convert.ToBoolean(HdrXML.Tables[0].Rows[0]["DelySt"]);
                if (isOrderClosed == true)                
                    Chk_Delivered.Checked = true;                
                else               
                    Chk_Delivered.Checked = false;

                lbl_Balance.Text = string.Format("Balance Amount : {0}", HdrXML.Tables[0].Rows[0]["Bal"].ToString());
                lbl_Balance.Visible = true;

                paymnt = new PaymentDetails();
                paymnt.AmountPaid = Convert.ToDecimal(HdrXML.Tables[0].Rows[0]["InvAmntRcvd"].ToString());
                //txt_Bal.Text = HdrXML.Tables[0].Rows[0]["Bal"].ToString();

                foreach (DataRow dRow in HdrXML.Tables[1].Rows)
                {
                    OrderDtls_DS.Tables[0].ImportRow(dRow);
                }

                dataGridView1.DataSource = OrderDtls_DS.Tables[0].DefaultView;
                dataGridView1.Refresh();

            }
            catch { }
            finally
            {
                HdrXML.Dispose(); HdrXML = null; OledbCmd.Dispose(); OledbCmd = null;
                OledbAdp.Dispose(); OledbAdp = null;
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            fnPrint();
        }

        private enum CalculationType
        {
            TaxableValue,
            Tax,
            Discount
        }

        BaseFont fb_cb = BaseFont.CreateFont(string.Format(@"{0}\calibrib.ttf", CommonClass.ResourcePath), BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        BaseFont fb_cn = BaseFont.CreateFont(string.Format(@"{0}\calibri.ttf", CommonClass.ResourcePath), BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

        private void fnPrint()
        {
            if (_RefKey == 0)
            {
                MessageBox.Show("Select Any Bill For Print.", "Billing System");
                return;
            }
          
            System.Data.DataSet GrpDtls = fnExecuteDB(string.Format("EXEC PrcInvPrint {0}", _RefKey));

            Document doc = new Document(PageSize.A4, 25, 25, 30, 1);
            string fileName = string.Format(@"{1}\{0}.pdf", DateTime.Now.ToString("yyyyMMddHHMMss"), CommonClass.BasePath);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
            doc.Open();

            PdfContentByte cb = writer.DirectContent;
            cb.BeginText();

            int lblfontSize = 10, valuefontSize = 10;
            int yname = 750, ymobileNo = 735, yEmailId = 720, yAddress = 705;
            int xCont1Lbl = 80, xCont1Data = 90;
            // Content1
            WriteText(cb, "Name :", xCont1Lbl, yname, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Mobile # :", xCont1Lbl, ymobileNo, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Email Id :", xCont1Lbl, yEmailId, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Address :", xCont1Lbl, yAddress, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["CusNm"].ToString(), xCont1Data, yname, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["MobNo"].ToString(), xCont1Data, ymobileNo, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["EmailId"].ToString(), xCont1Data, yEmailId, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["CusAdd"].ToString(), xCont1Data, yAddress, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);

            // Content2
            int yOrdNo = 750, yProfDate = 735, yDeliveryDate = 720;
            int xCont2Lbl = 350, xCont2Data = 360;
            WriteText(cb, "Order # :", xCont2Lbl, yOrdNo, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Proof Date :", xCont2Lbl, yProfDate, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Delivery Date :", xCont2Lbl, yDeliveryDate, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["OrdNo"].ToString(), xCont2Data, yOrdNo, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["ProofDt"].ToString(), xCont2Data, yProfDate, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["DelDt"].ToString(), xCont2Data, yDeliveryDate, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);

            // Content3
            int yTinNo = 750, yBillNo = 735, yBillDate = 720;
            int xCont3Lbl = 500, xCont3Data = 510;
            WriteText(cb, "TIN # :", xCont3Lbl, yTinNo, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Bill # :", xCont3Lbl, yBillNo, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Bill Date :", xCont3Lbl, yBillDate, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "33801392232", xCont3Data, yTinNo, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["BilNo"].ToString(), xCont3Data, yBillNo, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["BilDt"].ToString(), xCont3Data, yBillDate, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            cb.EndText();

            iTextSharp.text.Font hdrFont = new iTextSharp.text.Font(fb_cb, 12);
            iTextSharp.text.Font dataFont = new iTextSharp.text.Font(fb_cn, 10);

            PdfPTable table = new PdfPTable(5);            
            table.AddCell(new Phrase("#", hdrFont));
            table.AddCell(new Phrase("Particulars", hdrFont));
            table.AddCell(new Phrase("Quantity", hdrFont));
            table.AddCell(new Phrase("Rate", hdrFont));
            table.AddCell(new Phrase("Amount", hdrFont));
            
            for (int iLoop = 0; iLoop < GrpDtls.Tables[1].Rows.Count; iLoop++)
            {
                table.AddCell(new Phrase(GrpDtls.Tables[1].Rows[iLoop][0].ToString(), dataFont));
                table.AddCell(new Phrase(GrpDtls.Tables[1].Rows[iLoop][1].ToString(), dataFont));
                table.AddCell(new Phrase(GrpDtls.Tables[1].Rows[iLoop][2].ToString(), dataFont));
                table.AddCell(new Phrase(GrpDtls.Tables[1].Rows[iLoop][3].ToString(), dataFont));
                table.AddCell(new Phrase(GrpDtls.Tables[1].Rows[iLoop][4].ToString(), dataFont));             
            }
            doc.Add(table);

            // Content6
            int yGross = 630, yCST = 615, ySGST = 600, yRoundOff = 585, yTotal = 570, yBalance = 555;
            int xCont6Lbl = 500, xCont6Data = 510;
            cb.BeginText();
            WriteText(cb, "Gross :", xCont6Lbl, yGross, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "CGST (6%) :", xCont6Lbl, yCST, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "SGST (6%) :", xCont6Lbl, ySGST, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Round Off :", xCont6Lbl, yRoundOff, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Total :", xCont6Lbl, yTotal, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Balance :", xCont6Lbl, yBalance, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);

            WriteText(cb, GrpDtls.Tables[0].Rows[0]["TotAmt"].ToString(), xCont6Data, yGross, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["CGST"].ToString(), xCont6Data, yCST, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["SGST"].ToString(), xCont6Data, ySGST, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["RndOff"].ToString(), xCont6Data, yRoundOff, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["Nett"].ToString(), xCont6Data, yTotal, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["Bal"].ToString(), xCont6Data, yBalance, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            cb.EndText();




            /// Customer - Copy
            int ynameCopy = 350, ymobileNoCopy = 335, yEmailIdCopy = 320, yAddressCopy = 305;
            int xCont1LblCopy = 80, xCont1DataCopy = 90;
            cb.BeginText();
            // Content1
            WriteText(cb, "Name :", xCont1Lbl, yname, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Mobile # :", xCont1LblCopy, ymobileNoCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Email Id :", xCont1LblCopy, yEmailIdCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Address :", xCont1LblCopy, yAddressCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["CusNm"].ToString(), xCont1DataCopy, ynameCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["MobNo"].ToString(), xCont1DataCopy, ymobileNoCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["EmailId"].ToString(), xCont1DataCopy, yEmailIdCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["CusAdd"].ToString(), xCont1DataCopy, yAddressCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);

            // Content2
            int yOrdNoCopy = 350, yProfDateCopy = 335, yDeliveryDateCopy = 320;
            int xCont2LblCopy = 350, xCont2DataCopy = 360;
            WriteText(cb, "Order # :", xCont2LblCopy, yOrdNoCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Proof Date :", xCont2LblCopy, yProfDateCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Delivery Date :", xCont2LblCopy, yDeliveryDateCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["OrdNo"].ToString(), xCont2DataCopy, yOrdNoCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["ProofDt"].ToString(), xCont2DataCopy, yProfDateCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["DelDt"].ToString(), xCont2DataCopy, yDeliveryDateCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);

            // Content3
            int yTinNoCopy = 350, yBillNoCopy = 335, yBillDateCopy = 320;
            int xCont3LblCopy = 500, xCont3DataCopy = 510;
            WriteText(cb, "TIN # :", xCont3LblCopy, yTinNoCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Bill # :", xCont3LblCopy, yBillNoCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Bill Date :", xCont3LblCopy, yBillDateCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "33801392232", xCont3DataCopy, yTinNoCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["BilNo"].ToString(), xCont3DataCopy, yBillNoCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["BilDt"].ToString(), xCont3DataCopy, yBillDateCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            cb.EndText();

            //PdfPTable tableCopy = new PdfPTable(5);
            //tableCopy.AddCell("#");
            //tableCopy.AddCell("Particulars");
            //tableCopy.AddCell("Quantity");
            //tableCopy.AddCell("Rate");
            //tableCopy.AddCell("Amount");

            //for (int iLoop = 0; iLoop < GrpDtls.Tables[1].Rows.Count; iLoop++)
            //{
            //    tableCopy.AddCell(GrpDtls.Tables[1].Rows[iLoop][0].ToString());
            //    tableCopy.AddCell(GrpDtls.Tables[1].Rows[iLoop][1].ToString());
            //    tableCopy.AddCell(GrpDtls.Tables[1].Rows[iLoop][2].ToString());
            //    tableCopy.AddCell(GrpDtls.Tables[1].Rows[iLoop][3].ToString());
            //    tableCopy.AddCell(GrpDtls.Tables[1].Rows[iLoop][4].ToString());
            //}
            //doc.Add(tableCopy);

            // Content6
            int yGrossCopy = 230, yCSTCopy = 215, ySGSTCopy = 200, yRoundOffCopy = 185, yTotalCopy = 170, yBalanceCopy = 155;
            int xCont6LblCopy = 500, xCont6DataCopy = 510;
            cb.BeginText();
            WriteText(cb, "Gross :", xCont6LblCopy, yGrossCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "CGST (6%) :", xCont6LblCopy, yCSTCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "SGST (6%) :", xCont6LblCopy, ySGSTCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Round Off :", xCont6LblCopy, yRoundOffCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Total :", xCont6LblCopy, yTotalCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);
            WriteText(cb, "Balance :", xCont6LblCopy, yBalanceCopy, fb_cb, lblfontSize, PdfContentByte.ALIGN_RIGHT);

            WriteText(cb, GrpDtls.Tables[0].Rows[0]["TotAmt"].ToString(), xCont6DataCopy, yGrossCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["CGST"].ToString(), xCont6DataCopy, yCSTCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["SGST"].ToString(), xCont6DataCopy, ySGSTCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["RndOff"].ToString(), xCont6DataCopy, yRoundOffCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["Nett"].ToString(), xCont6DataCopy, yTotalCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            WriteText(cb, GrpDtls.Tables[0].Rows[0]["Bal"].ToString(), xCont6DataCopy, yBalanceCopy, fb_cn, valuefontSize, PdfContentByte.ALIGN_LEFT);
            cb.EndText();

            doc.Close();
            writer.Close();
            System.Diagnostics.Process.Start(fileName);

        }

        

        private void WriteText(PdfContentByte cb, string text, int x, int y, BaseFont font, int size, int align)
        {
            cb.SetFontAndSize(font, size);
            cb.ShowTextAligned(align, text, x, y, 0);
        }

        private void txt_BillNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure need to Delete the Row.", "Billing System", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dRow in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(dRow.Index);
                        _SerialNo = _SerialNo - 1;
                        CalculateDiscountAmount();
                    }
                }
            }
        }

        public System.Data.DataSet fnExecuteDB(String Qry)
        {
            OleDbCommand Cmd = new OleDbCommand();
            OleDbDataAdapter Adp = new OleDbDataAdapter();
            System.Data.DataSet Ds = new System.Data.DataSet();

            try
            {

                Cmd.Connection = CommonClass.fnGetConnection();
                Cmd.CommandTimeout = 0;
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = Qry;
                Adp.SelectCommand = Cmd;
                Adp.Fill(Ds);
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message.ToString(), "DAIM", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {

                Cmd.Dispose(); Adp.Dispose(); Cmd = null; Adp = null;
            }
            return Ds;
        }

    }
}
