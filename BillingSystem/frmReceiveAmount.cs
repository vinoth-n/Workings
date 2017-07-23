using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmReceiveAmount : MetroForm
    {

        public PaymentDetails paymentDetails;

        public frmReceiveAmount()
        {
            InitializeComponent();
        }

        private void frmReceiveAmount_Load(object sender, EventArgs e)
        {
            if (this.paymentDetails != null)
            {                
                lbl_TotalAmount.Text = Convert.ToString(this.paymentDetails.TotalAmount);
                lbl_AmountPaid.Text = Convert.ToString(this.paymentDetails.AmountPaid);
                lbl_Balance.Text = Convert.ToString((this.paymentDetails.TotalAmount - this.paymentDetails.AmountPaid) );
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Balance_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            fnNumberValidation(sender, e);
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.paymentDetails = null;
            this.Close();
        }

        private void txt_Cash_Leave(object sender, EventArgs e)
        {
            if (paymentDetails != null)
            {
                paymentDetails.Cash = string.IsNullOrEmpty(txt_Cash.Text) ? 0 : Convert.ToDecimal(txt_Cash.Text);
                paymentDetails.Card = string.IsNullOrEmpty(txt_Card.Text) ? 0 : Convert.ToDecimal(txt_Card.Text);
                paymentDetails.NetTransfer = string.IsNullOrEmpty(txt_Transfer.Text) ? 0 : Convert.ToDecimal(txt_Transfer.Text);
                paymentDetails.WriteOff = string.IsNullOrEmpty(txt_WriteOff.Text) ? 0 : Convert.ToDecimal(txt_WriteOff.Text);

                paymentDetails.AmountReceived = (paymentDetails.Cash + paymentDetails.Card + paymentDetails.NetTransfer + paymentDetails.WriteOff);
                paymentDetails.Balance = paymentDetails.TotalAmount - (paymentDetails.AmountPaid + paymentDetails.AmountReceived);
                lbl_AmountReceived.Text = Convert.ToString(paymentDetails.AmountReceived);
                lbl_Balance.Text = Convert.ToString(paymentDetails.Balance);
            }
        }
    }
}
