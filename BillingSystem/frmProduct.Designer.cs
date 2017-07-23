namespace BillingSystem
{
    partial class frmProduct
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_PrdNm = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(81, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Product Name";
            // 
            // txt_PrdNm
            // 
            // 
            // 
            // 
            this.txt_PrdNm.CustomButton.Image = null;
            this.txt_PrdNm.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txt_PrdNm.CustomButton.Name = "";
            this.txt_PrdNm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_PrdNm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PrdNm.CustomButton.TabIndex = 1;
            this.txt_PrdNm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PrdNm.CustomButton.UseSelectable = true;
            this.txt_PrdNm.CustomButton.Visible = false;
            this.txt_PrdNm.Lines = new string[0];
            this.txt_PrdNm.Location = new System.Drawing.Point(182, 60);
            this.txt_PrdNm.MaxLength = 32767;
            this.txt_PrdNm.Name = "txt_PrdNm";
            this.txt_PrdNm.PasswordChar = '\0';
            this.txt_PrdNm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PrdNm.SelectedText = "";
            this.txt_PrdNm.SelectionLength = 0;
            this.txt_PrdNm.SelectionStart = 0;
            this.txt_PrdNm.ShortcutsEnabled = true;
            this.txt_PrdNm.Size = new System.Drawing.Size(279, 23);
            this.txt_PrdNm.TabIndex = 8;
            this.txt_PrdNm.UseSelectable = true;
            this.txt_PrdNm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PrdNm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PrdNm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PrdNm_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 310);
            this.dataGridView1.TabIndex = 12;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(478, 415);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(124, 30);
            this.metroButton4.TabIndex = 56;
            this.metroButton4.Text = "Clear";
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(348, 415);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(124, 30);
            this.metroButton2.TabIndex = 55;
            this.metroButton2.Text = "Save";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 539);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_PrdNm);
            this.Name = "frmProduct";
            this.Text = "Create Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProduct_FormClosed);
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_PrdNm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}