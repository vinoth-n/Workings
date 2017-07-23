namespace BillingSystem
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.txt_OrderNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Name = new MetroFramework.Controls.MetroLabel();
            this.txt_Name = new MetroFramework.Controls.MetroTextBox();
            this.lbl_MobileNo = new MetroFramework.Controls.MetroLabel();
            this.txt_MobilNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_EmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_Address = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Taxable = new MetroFramework.Controls.MetroLabel();
            this.lbl_Tax = new MetroFramework.Controls.MetroLabel();
            this.lbl_Gst = new MetroFramework.Controls.MetroLabel();
            this.lbl_RoundOff = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Total = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dat_ProofDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dat_DeliveryDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.dat_BillDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txt_BillNo = new MetroFramework.Controls.MetroTextBox();
            this.txt_PrdNm = new MetroFramework.Controls.MetroTextBox();
            this.txt_Qty = new MetroFramework.Controls.MetroTextBox();
            this.txt_Rate = new MetroFramework.Controls.MetroTextBox();
            this.txt_Value = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txt_Remarks = new MetroFramework.Controls.MetroTextBox();
            this.Chk_Delivered = new MetroFramework.Controls.MetroCheckBox();
            this.dat_DeliveredDate = new MetroFramework.Controls.MetroDateTime();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Discount = new MetroFramework.Controls.MetroTextBox();
            this.ddl_Category = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Balance = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(472, 573);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 30);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(567, 573);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(77, 30);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseSelectable = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(650, 573);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(73, 30);
            this.metroButton3.TabIndex = 20;
            this.metroButton3.Text = "Delete";
            this.metroButton3.UseSelectable = true;
            // 
            // txt_OrderNo
            // 
            // 
            // 
            // 
            this.txt_OrderNo.CustomButton.Image = null;
            this.txt_OrderNo.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txt_OrderNo.CustomButton.Name = "";
            this.txt_OrderNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_OrderNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_OrderNo.CustomButton.TabIndex = 1;
            this.txt_OrderNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_OrderNo.CustomButton.UseSelectable = true;
            this.txt_OrderNo.CustomButton.Visible = false;
            this.txt_OrderNo.Lines = new string[0];
            this.txt_OrderNo.Location = new System.Drawing.Point(527, 73);
            this.txt_OrderNo.MaxLength = 32767;
            this.txt_OrderNo.Name = "txt_OrderNo";
            this.txt_OrderNo.PasswordChar = '\0';
            this.txt_OrderNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_OrderNo.SelectedText = "";
            this.txt_OrderNo.SelectionLength = 0;
            this.txt_OrderNo.SelectionStart = 0;
            this.txt_OrderNo.ShortcutsEnabled = true;
            this.txt_OrderNo.Size = new System.Drawing.Size(128, 23);
            this.txt_OrderNo.TabIndex = 5;
            this.txt_OrderNo.UseSelectable = true;
            this.txt_OrderNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_OrderNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(463, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Order #";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(84, 73);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 19);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Name
            // 
            // 
            // 
            // 
            this.txt_Name.CustomButton.Image = null;
            this.txt_Name.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_Name.CustomButton.Name = "";
            this.txt_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Name.CustomButton.TabIndex = 1;
            this.txt_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Name.CustomButton.UseSelectable = true;
            this.txt_Name.CustomButton.Visible = false;
            this.txt_Name.Lines = new string[0];
            this.txt_Name.Location = new System.Drawing.Point(135, 73);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Name.SelectedText = "";
            this.txt_Name.SelectionLength = 0;
            this.txt_Name.SelectionStart = 0;
            this.txt_Name.ShortcutsEnabled = true;
            this.txt_Name.Size = new System.Drawing.Size(279, 23);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.UseSelectable = true;
            this.txt_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.ForeColor = System.Drawing.Color.Red;
            this.lbl_MobileNo.Location = new System.Drawing.Point(67, 104);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(62, 19);
            this.lbl_MobileNo.TabIndex = 9;
            this.lbl_MobileNo.Text = "Mobile #";
            // 
            // txt_MobilNo
            // 
            // 
            // 
            // 
            this.txt_MobilNo.CustomButton.Image = null;
            this.txt_MobilNo.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_MobilNo.CustomButton.Name = "";
            this.txt_MobilNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_MobilNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MobilNo.CustomButton.TabIndex = 1;
            this.txt_MobilNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MobilNo.CustomButton.UseSelectable = true;
            this.txt_MobilNo.CustomButton.Visible = false;
            this.txt_MobilNo.Lines = new string[0];
            this.txt_MobilNo.Location = new System.Drawing.Point(135, 102);
            this.txt_MobilNo.MaxLength = 32767;
            this.txt_MobilNo.Name = "txt_MobilNo";
            this.txt_MobilNo.PasswordChar = '\0';
            this.txt_MobilNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MobilNo.SelectedText = "";
            this.txt_MobilNo.SelectionLength = 0;
            this.txt_MobilNo.SelectionStart = 0;
            this.txt_MobilNo.ShortcutsEnabled = true;
            this.txt_MobilNo.Size = new System.Drawing.Size(279, 23);
            this.txt_MobilNo.TabIndex = 2;
            this.txt_MobilNo.UseSelectable = true;
            this.txt_MobilNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MobilNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 131);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Email Address";
            // 
            // txt_EmailAddress
            // 
            // 
            // 
            // 
            this.txt_EmailAddress.CustomButton.Image = null;
            this.txt_EmailAddress.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_EmailAddress.CustomButton.Name = "";
            this.txt_EmailAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_EmailAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_EmailAddress.CustomButton.TabIndex = 1;
            this.txt_EmailAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_EmailAddress.CustomButton.UseSelectable = true;
            this.txt_EmailAddress.CustomButton.Visible = false;
            this.txt_EmailAddress.Lines = new string[0];
            this.txt_EmailAddress.Location = new System.Drawing.Point(135, 131);
            this.txt_EmailAddress.MaxLength = 32767;
            this.txt_EmailAddress.Name = "txt_EmailAddress";
            this.txt_EmailAddress.PasswordChar = '\0';
            this.txt_EmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_EmailAddress.SelectedText = "";
            this.txt_EmailAddress.SelectionLength = 0;
            this.txt_EmailAddress.SelectionStart = 0;
            this.txt_EmailAddress.ShortcutsEnabled = true;
            this.txt_EmailAddress.Size = new System.Drawing.Size(279, 23);
            this.txt_EmailAddress.TabIndex = 3;
            this.txt_EmailAddress.UseSelectable = true;
            this.txt_EmailAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_EmailAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(73, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Address";
            // 
            // txt_Address
            // 
            // 
            // 
            // 
            this.txt_Address.CustomButton.Image = null;
            this.txt_Address.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_Address.CustomButton.Name = "";
            this.txt_Address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Address.CustomButton.TabIndex = 1;
            this.txt_Address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Address.CustomButton.UseSelectable = true;
            this.txt_Address.CustomButton.Visible = false;
            this.txt_Address.Lines = new string[0];
            this.txt_Address.Location = new System.Drawing.Point(135, 160);
            this.txt_Address.MaxLength = 32767;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Address.SelectedText = "";
            this.txt_Address.SelectionLength = 0;
            this.txt_Address.SelectionStart = 0;
            this.txt_Address.ShortcutsEnabled = true;
            this.txt_Address.Size = new System.Drawing.Size(279, 23);
            this.txt_Address.TabIndex = 4;
            this.txt_Address.UseSelectable = true;
            this.txt_Address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Taxable
            // 
            this.lbl_Taxable.AutoSize = true;
            this.lbl_Taxable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Taxable.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Taxable.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Taxable.Location = new System.Drawing.Point(95, 520);
            this.lbl_Taxable.Name = "lbl_Taxable";
            this.lbl_Taxable.Size = new System.Drawing.Size(47, 25);
            this.lbl_Taxable.TabIndex = 19;
            this.lbl_Taxable.Text = "0.00";
            // 
            // lbl_Tax
            // 
            this.lbl_Tax.AutoSize = true;
            this.lbl_Tax.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Tax.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Tax.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Tax.Location = new System.Drawing.Point(247, 520);
            this.lbl_Tax.Name = "lbl_Tax";
            this.lbl_Tax.Size = new System.Drawing.Size(47, 25);
            this.lbl_Tax.TabIndex = 21;
            this.lbl_Tax.Text = "0.00";
            // 
            // lbl_Gst
            // 
            this.lbl_Gst.AutoSize = true;
            this.lbl_Gst.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Gst.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Gst.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Gst.Location = new System.Drawing.Point(407, 520);
            this.lbl_Gst.Name = "lbl_Gst";
            this.lbl_Gst.Size = new System.Drawing.Size(47, 25);
            this.lbl_Gst.TabIndex = 23;
            this.lbl_Gst.Text = "0.00";
            // 
            // lbl_RoundOff
            // 
            this.lbl_RoundOff.AutoSize = true;
            this.lbl_RoundOff.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_RoundOff.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_RoundOff.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_RoundOff.Location = new System.Drawing.Point(557, 520);
            this.lbl_RoundOff.Name = "lbl_RoundOff";
            this.lbl_RoundOff.Size = new System.Drawing.Size(47, 25);
            this.lbl_RoundOff.TabIndex = 25;
            this.lbl_RoundOff.Text = "0.00";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel11.Location = new System.Drawing.Point(60, 489);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(119, 19);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "Taxable Amount";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel12.Location = new System.Drawing.Point(407, 489);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(35, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "GST";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel13.Location = new System.Drawing.Point(247, 489);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(66, 19);
            this.metroLabel13.TabIndex = 28;
            this.metroLabel13.Text = "Discount";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel14.Location = new System.Drawing.Point(540, 489);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(77, 19);
            this.metroLabel14.TabIndex = 29;
            this.metroLabel14.Text = "Round Off";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel15.Location = new System.Drawing.Point(685, 489);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(84, 19);
            this.metroLabel15.TabIndex = 32;
            this.metroLabel15.Text = "Total Value";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Total.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Total.Location = new System.Drawing.Point(697, 520);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(47, 25);
            this.lbl_Total.TabIndex = 31;
            this.lbl_Total.Text = "0.00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(123, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(711, 150);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // dat_ProofDate
            // 
            this.dat_ProofDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_ProofDate.Location = new System.Drawing.Point(527, 102);
            this.dat_ProofDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dat_ProofDate.Name = "dat_ProofDate";
            this.dat_ProofDate.Size = new System.Drawing.Size(128, 29);
            this.dat_ProofDate.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(447, 104);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 19);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "Proof Date";
            // 
            // dat_DeliveryDate
            // 
            this.dat_DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_DeliveryDate.Location = new System.Drawing.Point(527, 137);
            this.dat_DeliveryDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dat_DeliveryDate.Name = "dat_DeliveryDate";
            this.dat_DeliveryDate.Size = new System.Drawing.Size(128, 29);
            this.dat_DeliveryDate.TabIndex = 7;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(434, 137);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(86, 19);
            this.metroLabel17.TabIndex = 36;
            this.metroLabel17.Text = "Delivery Date";
            // 
            // dat_BillDate
            // 
            this.dat_BillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_BillDate.Location = new System.Drawing.Point(758, 104);
            this.dat_BillDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dat_BillDate.Name = "dat_BillDate";
            this.dat_BillDate.Size = new System.Drawing.Size(128, 29);
            this.dat_BillDate.TabIndex = 41;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(695, 110);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(57, 19);
            this.metroLabel18.TabIndex = 40;
            this.metroLabel18.Text = "Bill Date";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(714, 77);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(38, 19);
            this.metroLabel19.TabIndex = 39;
            this.metroLabel19.Text = "Bill #";
            // 
            // txt_BillNo
            // 
            // 
            // 
            // 
            this.txt_BillNo.CustomButton.Image = null;
            this.txt_BillNo.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txt_BillNo.CustomButton.Name = "";
            this.txt_BillNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_BillNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_BillNo.CustomButton.TabIndex = 1;
            this.txt_BillNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BillNo.CustomButton.UseSelectable = true;
            this.txt_BillNo.CustomButton.Visible = false;
            this.txt_BillNo.Lines = new string[0];
            this.txt_BillNo.Location = new System.Drawing.Point(758, 73);
            this.txt_BillNo.MaxLength = 32767;
            this.txt_BillNo.Name = "txt_BillNo";
            this.txt_BillNo.PasswordChar = '\0';
            this.txt_BillNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_BillNo.SelectedText = "";
            this.txt_BillNo.SelectionLength = 0;
            this.txt_BillNo.SelectionStart = 0;
            this.txt_BillNo.ShortcutsEnabled = true;
            this.txt_BillNo.Size = new System.Drawing.Size(128, 23);
            this.txt_BillNo.TabIndex = 38;
            this.txt_BillNo.UseSelectable = true;
            this.txt_BillNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_BillNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_BillNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BillNo_KeyPress);
            // 
            // txt_PrdNm
            // 
            // 
            // 
            // 
            this.txt_PrdNm.CustomButton.Image = null;
            this.txt_PrdNm.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txt_PrdNm.CustomButton.Name = "";
            this.txt_PrdNm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_PrdNm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PrdNm.CustomButton.TabIndex = 1;
            this.txt_PrdNm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PrdNm.CustomButton.UseSelectable = true;
            this.txt_PrdNm.CustomButton.Visible = false;
            this.txt_PrdNm.Lines = new string[0];
            this.txt_PrdNm.Location = new System.Drawing.Point(123, 221);
            this.txt_PrdNm.MaxLength = 32767;
            this.txt_PrdNm.Name = "txt_PrdNm";
            this.txt_PrdNm.PasswordChar = '\0';
            this.txt_PrdNm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PrdNm.SelectedText = "";
            this.txt_PrdNm.SelectionLength = 0;
            this.txt_PrdNm.SelectionStart = 0;
            this.txt_PrdNm.ShortcutsEnabled = true;
            this.txt_PrdNm.Size = new System.Drawing.Size(240, 23);
            this.txt_PrdNm.TabIndex = 8;
            this.txt_PrdNm.UseSelectable = true;
            this.txt_PrdNm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PrdNm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PrdNm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PrdNm_KeyDown);
            // 
            // txt_Qty
            // 
            // 
            // 
            // 
            this.txt_Qty.CustomButton.Image = null;
            this.txt_Qty.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.txt_Qty.CustomButton.Name = "";
            this.txt_Qty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Qty.CustomButton.TabIndex = 1;
            this.txt_Qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Qty.CustomButton.UseSelectable = true;
            this.txt_Qty.CustomButton.Visible = false;
            this.txt_Qty.Lines = new string[0];
            this.txt_Qty.Location = new System.Drawing.Point(526, 221);
            this.txt_Qty.MaxLength = 32767;
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.PasswordChar = '\0';
            this.txt_Qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Qty.SelectedText = "";
            this.txt_Qty.SelectionLength = 0;
            this.txt_Qty.SelectionStart = 0;
            this.txt_Qty.ShortcutsEnabled = true;
            this.txt_Qty.Size = new System.Drawing.Size(88, 23);
            this.txt_Qty.TabIndex = 10;
            this.txt_Qty.UseSelectable = true;
            this.txt_Qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            // 
            // txt_Rate
            // 
            // 
            // 
            // 
            this.txt_Rate.CustomButton.Image = null;
            this.txt_Rate.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txt_Rate.CustomButton.Name = "";
            this.txt_Rate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Rate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Rate.CustomButton.TabIndex = 1;
            this.txt_Rate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Rate.CustomButton.UseSelectable = true;
            this.txt_Rate.CustomButton.Visible = false;
            this.txt_Rate.Lines = new string[0];
            this.txt_Rate.Location = new System.Drawing.Point(621, 221);
            this.txt_Rate.MaxLength = 32767;
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.PasswordChar = '\0';
            this.txt_Rate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Rate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Rate.SelectedText = "";
            this.txt_Rate.SelectionLength = 0;
            this.txt_Rate.SelectionStart = 0;
            this.txt_Rate.ShortcutsEnabled = true;
            this.txt_Rate.Size = new System.Drawing.Size(95, 23);
            this.txt_Rate.TabIndex = 11;
            this.txt_Rate.UseSelectable = true;
            this.txt_Rate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Rate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            this.txt_Rate.Leave += new System.EventHandler(this.txt_Rate_Leave);
            // 
            // txt_Value
            // 
            // 
            // 
            // 
            this.txt_Value.CustomButton.Image = null;
            this.txt_Value.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txt_Value.CustomButton.Name = "";
            this.txt_Value.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Value.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Value.CustomButton.TabIndex = 1;
            this.txt_Value.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Value.CustomButton.UseSelectable = true;
            this.txt_Value.CustomButton.Visible = false;
            this.txt_Value.Lines = new string[0];
            this.txt_Value.Location = new System.Drawing.Point(722, 221);
            this.txt_Value.MaxLength = 32767;
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.PasswordChar = '\0';
            this.txt_Value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Value.SelectedText = "";
            this.txt_Value.SelectionLength = 0;
            this.txt_Value.SelectionStart = 0;
            this.txt_Value.ShortcutsEnabled = true;
            this.txt_Value.Size = new System.Drawing.Size(95, 23);
            this.txt_Value.TabIndex = 12;
            this.txt_Value.UseSelectable = true;
            this.txt_Value.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Value.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Value_KeyDown);
            this.txt_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(206, 199);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(55, 19);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Product";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(551, 199);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(30, 19);
            this.metroLabel8.TabIndex = 47;
            this.metroLabel8.Text = "Qty";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(658, 199);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(35, 19);
            this.metroLabel9.TabIndex = 48;
            this.metroLabel9.Text = "Rate";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(747, 199);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(41, 19);
            this.metroLabel16.TabIndex = 49;
            this.metroLabel16.Text = "Value";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(28, 416);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(59, 19);
            this.metroLabel20.TabIndex = 51;
            this.metroLabel20.Text = "Remarks";
            // 
            // txt_Remarks
            // 
            // 
            // 
            // 
            this.txt_Remarks.CustomButton.Image = null;
            this.txt_Remarks.CustomButton.Location = new System.Drawing.Point(490, 1);
            this.txt_Remarks.CustomButton.Name = "";
            this.txt_Remarks.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_Remarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Remarks.CustomButton.TabIndex = 1;
            this.txt_Remarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Remarks.CustomButton.UseSelectable = true;
            this.txt_Remarks.CustomButton.Visible = false;
            this.txt_Remarks.Lines = new string[0];
            this.txt_Remarks.Location = new System.Drawing.Point(95, 416);
            this.txt_Remarks.MaxLength = 32767;
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.PasswordChar = '\0';
            this.txt_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Remarks.SelectedText = "";
            this.txt_Remarks.SelectionLength = 0;
            this.txt_Remarks.SelectionStart = 0;
            this.txt_Remarks.ShortcutsEnabled = true;
            this.txt_Remarks.Size = new System.Drawing.Size(524, 35);
            this.txt_Remarks.TabIndex = 13;
            this.txt_Remarks.UseSelectable = true;
            this.txt_Remarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Remarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Chk_Delivered
            // 
            this.Chk_Delivered.AutoSize = true;
            this.Chk_Delivered.Location = new System.Drawing.Point(644, 426);
            this.Chk_Delivered.Name = "Chk_Delivered";
            this.Chk_Delivered.Size = new System.Drawing.Size(72, 15);
            this.Chk_Delivered.TabIndex = 14;
            this.Chk_Delivered.Text = "Delivered";
            this.Chk_Delivered.UseSelectable = true;
            // 
            // dat_DeliveredDate
            // 
            this.dat_DeliveredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_DeliveredDate.Location = new System.Drawing.Point(722, 416);
            this.dat_DeliveredDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dat_DeliveredDate.Name = "dat_DeliveredDate";
            this.dat_DeliveredDate.Size = new System.Drawing.Size(128, 29);
            this.dat_DeliveredDate.TabIndex = 53;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(729, 573);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(73, 30);
            this.metroButton4.TabIndex = 18;
            this.metroButton4.Text = "Clear";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(808, 573);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(73, 30);
            this.metroButton5.TabIndex = 19;
            this.metroButton5.Text = "Print";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel21.Location = new System.Drawing.Point(6, 633);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(229, 19);
            this.metroLabel21.TabIndex = 56;
            this.metroLabel21.Text = "Press \"F2\" to get the product List";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(657, 475);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(134, 92);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(508, 475);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(134, 92);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(359, 475);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 92);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(206, 475);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 92);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(51, 475);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 92);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Discount
            // 
            // 
            // 
            // 
            this.txt_Discount.CustomButton.Image = null;
            this.txt_Discount.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txt_Discount.CustomButton.Name = "";
            this.txt_Discount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Discount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Discount.CustomButton.TabIndex = 1;
            this.txt_Discount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Discount.CustomButton.UseSelectable = true;
            this.txt_Discount.CustomButton.Visible = false;
            this.txt_Discount.Lines = new string[0];
            this.txt_Discount.Location = new System.Drawing.Point(223, 522);
            this.txt_Discount.MaxLength = 32767;
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.PasswordChar = '\0';
            this.txt_Discount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Discount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Discount.SelectedText = "";
            this.txt_Discount.SelectionLength = 0;
            this.txt_Discount.SelectionStart = 0;
            this.txt_Discount.ShortcutsEnabled = true;
            this.txt_Discount.Size = new System.Drawing.Size(104, 23);
            this.txt_Discount.TabIndex = 15;
            this.txt_Discount.UseSelectable = true;
            this.txt_Discount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Discount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            this.txt_Discount.Leave += new System.EventHandler(this.txt_Discount_Leave);
            // 
            // ddl_Category
            // 
            this.ddl_Category.FormattingEnabled = true;
            this.ddl_Category.ItemHeight = 23;
            this.ddl_Category.Items.AddRange(new object[] {
            "Invitation Cards",
            "Printing",
            "Gifts",
            "Others"});
            this.ddl_Category.Location = new System.Drawing.Point(370, 221);
            this.ddl_Category.Name = "ddl_Category";
            this.ddl_Category.Size = new System.Drawing.Size(150, 29);
            this.ddl_Category.TabIndex = 9;
            this.ddl_Category.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(418, 199);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Category";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Balance.Location = new System.Drawing.Point(60, 584);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(0, 0);
            this.lbl_Balance.TabIndex = 60;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 672);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ddl_Category);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.dat_DeliveredDate);
            this.Controls.Add(this.Chk_Delivered);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.txt_Remarks);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.txt_PrdNm);
            this.Controls.Add(this.dat_BillDate);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.txt_BillNo);
            this.Controls.Add(this.dat_DeliveryDate);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.dat_ProofDate);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.lbl_RoundOff);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_Gst);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_Tax);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Taxable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_EmailAddress);
            this.Controls.Add(this.lbl_MobileNo);
            this.Controls.Add(this.txt_MobilNo);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_OrderNo);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.metroButton1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaximizeBox = false;
            this.Name = "frmOrder";
            this.Text = "Create Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrder_FormClosed);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btn_Save;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox txt_OrderNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl_Name;
        private MetroFramework.Controls.MetroTextBox txt_Name;
        private MetroFramework.Controls.MetroLabel lbl_MobileNo;
        private MetroFramework.Controls.MetroTextBox txt_MobilNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_EmailAddress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_Address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lbl_Taxable;
        private MetroFramework.Controls.MetroLabel lbl_Tax;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel lbl_Gst;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel lbl_RoundOff;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel lbl_Total;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroDateTime dat_ProofDate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dat_DeliveryDate;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroDateTime dat_BillDate;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox txt_BillNo;
        private MetroFramework.Controls.MetroTextBox txt_PrdNm;
        private MetroFramework.Controls.MetroTextBox txt_Qty;
        private MetroFramework.Controls.MetroTextBox txt_Rate;
        private MetroFramework.Controls.MetroTextBox txt_Value;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txt_Remarks;
        private MetroFramework.Controls.MetroCheckBox Chk_Delivered;
        private MetroFramework.Controls.MetroDateTime dat_DeliveredDate;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox txt_Discount;
        private MetroFramework.Controls.MetroComboBox ddl_Category;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbl_Balance;
    }
}