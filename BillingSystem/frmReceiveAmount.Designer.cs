namespace BillingSystem
{
    partial class frmReceiveAmount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_Cash = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_Card = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_Transfer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_WriteOff = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbl_AmountReceived = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lbl_TotalAmount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lbl_AmountPaid = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Balance = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(83, 26);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(37, 19);
            this.metroLabel9.TabIndex = 50;
            this.metroLabel9.Text = "Cash";
            // 
            // txt_Cash
            // 
            // 
            // 
            // 
            this.txt_Cash.CustomButton.Image = null;
            this.txt_Cash.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txt_Cash.CustomButton.Name = "";
            this.txt_Cash.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Cash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Cash.CustomButton.TabIndex = 1;
            this.txt_Cash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Cash.CustomButton.UseSelectable = true;
            this.txt_Cash.CustomButton.Visible = false;
            this.txt_Cash.Lines = new string[0];
            this.txt_Cash.Location = new System.Drawing.Point(126, 26);
            this.txt_Cash.MaxLength = 32767;
            this.txt_Cash.Name = "txt_Cash";
            this.txt_Cash.PasswordChar = '\0';
            this.txt_Cash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Cash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Cash.SelectedText = "";
            this.txt_Cash.SelectionLength = 0;
            this.txt_Cash.SelectionStart = 0;
            this.txt_Cash.ShortcutsEnabled = true;
            this.txt_Cash.Size = new System.Drawing.Size(113, 23);
            this.txt_Cash.TabIndex = 49;
            this.txt_Cash.UseSelectable = true;
            this.txt_Cash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Cash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Cash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Balance_KeyPress);
            this.txt_Cash.Leave += new System.EventHandler(this.txt_Cash_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(82, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 52;
            this.metroLabel1.Text = "Card";
            // 
            // txt_Card
            // 
            // 
            // 
            // 
            this.txt_Card.CustomButton.Image = null;
            this.txt_Card.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txt_Card.CustomButton.Name = "";
            this.txt_Card.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Card.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Card.CustomButton.TabIndex = 1;
            this.txt_Card.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Card.CustomButton.UseSelectable = true;
            this.txt_Card.CustomButton.Visible = false;
            this.txt_Card.Lines = new string[0];
            this.txt_Card.Location = new System.Drawing.Point(126, 55);
            this.txt_Card.MaxLength = 32767;
            this.txt_Card.Name = "txt_Card";
            this.txt_Card.PasswordChar = '\0';
            this.txt_Card.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Card.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Card.SelectedText = "";
            this.txt_Card.SelectionLength = 0;
            this.txt_Card.SelectionStart = 0;
            this.txt_Card.ShortcutsEnabled = true;
            this.txt_Card.Size = new System.Drawing.Size(113, 23);
            this.txt_Card.TabIndex = 51;
            this.txt_Card.UseSelectable = true;
            this.txt_Card.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Card.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Balance_KeyPress);
            this.txt_Card.Leave += new System.EventHandler(this.txt_Cash_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "Net Transfer";
            // 
            // txt_Transfer
            // 
            // 
            // 
            // 
            this.txt_Transfer.CustomButton.Image = null;
            this.txt_Transfer.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txt_Transfer.CustomButton.Name = "";
            this.txt_Transfer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Transfer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Transfer.CustomButton.TabIndex = 1;
            this.txt_Transfer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Transfer.CustomButton.UseSelectable = true;
            this.txt_Transfer.CustomButton.Visible = false;
            this.txt_Transfer.Lines = new string[0];
            this.txt_Transfer.Location = new System.Drawing.Point(126, 84);
            this.txt_Transfer.MaxLength = 32767;
            this.txt_Transfer.Name = "txt_Transfer";
            this.txt_Transfer.PasswordChar = '\0';
            this.txt_Transfer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Transfer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Transfer.SelectedText = "";
            this.txt_Transfer.SelectionLength = 0;
            this.txt_Transfer.SelectionStart = 0;
            this.txt_Transfer.ShortcutsEnabled = true;
            this.txt_Transfer.Size = new System.Drawing.Size(113, 23);
            this.txt_Transfer.TabIndex = 53;
            this.txt_Transfer.UseSelectable = true;
            this.txt_Transfer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Transfer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Transfer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Balance_KeyPress);
            this.txt_Transfer.Leave += new System.EventHandler(this.txt_Cash_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(56, 113);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 56;
            this.metroLabel3.Text = "Write Off";
            // 
            // txt_WriteOff
            // 
            // 
            // 
            // 
            this.txt_WriteOff.CustomButton.Image = null;
            this.txt_WriteOff.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txt_WriteOff.CustomButton.Name = "";
            this.txt_WriteOff.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_WriteOff.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_WriteOff.CustomButton.TabIndex = 1;
            this.txt_WriteOff.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_WriteOff.CustomButton.UseSelectable = true;
            this.txt_WriteOff.CustomButton.Visible = false;
            this.txt_WriteOff.Lines = new string[0];
            this.txt_WriteOff.Location = new System.Drawing.Point(126, 113);
            this.txt_WriteOff.MaxLength = 32767;
            this.txt_WriteOff.Name = "txt_WriteOff";
            this.txt_WriteOff.PasswordChar = '\0';
            this.txt_WriteOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_WriteOff.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_WriteOff.SelectedText = "";
            this.txt_WriteOff.SelectionLength = 0;
            this.txt_WriteOff.SelectionStart = 0;
            this.txt_WriteOff.ShortcutsEnabled = true;
            this.txt_WriteOff.Size = new System.Drawing.Size(113, 23);
            this.txt_WriteOff.TabIndex = 55;
            this.txt_WriteOff.UseSelectable = true;
            this.txt_WriteOff.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_WriteOff.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_WriteOff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Balance_KeyPress);
            this.txt_WriteOff.Leave += new System.EventHandler(this.txt_Cash_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 57;
            this.metroLabel4.Text = "Amount Received";
            // 
            // lbl_AmountReceived
            // 
            this.lbl_AmountReceived.AutoSize = true;
            this.lbl_AmountReceived.Location = new System.Drawing.Point(127, 196);
            this.lbl_AmountReceived.Name = "lbl_AmountReceived";
            this.lbl_AmountReceived.Size = new System.Drawing.Size(33, 19);
            this.lbl_AmountReceived.TabIndex = 58;
            this.lbl_AmountReceived.Text = "0.00";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(182, 253);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(41, 30);
            this.metroButton2.TabIndex = 60;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(135, 253);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(41, 30);
            this.metroButton1.TabIndex = 61;
            this.metroButton1.Text = "OK";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.AutoSize = true;
            this.lbl_TotalAmount.Location = new System.Drawing.Point(127, 147);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(33, 19);
            this.lbl_TotalAmount.TabIndex = 63;
            this.lbl_TotalAmount.Text = "0.00";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(31, 147);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 19);
            this.metroLabel6.TabIndex = 62;
            this.metroLabel6.Text = "Total Amount";
            // 
            // lbl_AmountPaid
            // 
            this.lbl_AmountPaid.AutoSize = true;
            this.lbl_AmountPaid.Location = new System.Drawing.Point(127, 170);
            this.lbl_AmountPaid.Name = "lbl_AmountPaid";
            this.lbl_AmountPaid.Size = new System.Drawing.Size(33, 19);
            this.lbl_AmountPaid.TabIndex = 65;
            this.lbl_AmountPaid.Text = "0.00";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(34, 170);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 19);
            this.metroLabel8.TabIndex = 64;
            this.metroLabel8.Text = "Amount Paid";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Location = new System.Drawing.Point(127, 224);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(33, 19);
            this.lbl_Balance.TabIndex = 67;
            this.lbl_Balance.Text = "0.00";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(66, 224);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(54, 19);
            this.metroLabel11.TabIndex = 66;
            this.metroLabel11.Text = "Balance";
            // 
            // frmReceiveAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 297);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.lbl_AmountPaid);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lbl_TotalAmount);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.lbl_AmountReceived);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_WriteOff);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_Transfer);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_Card);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_Cash);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceiveAmount";
            this.Load += new System.EventHandler(this.frmReceiveAmount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_Cash;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_Card;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_Transfer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_WriteOff;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbl_AmountReceived;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lbl_TotalAmount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lbl_AmountPaid;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lbl_Balance;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}