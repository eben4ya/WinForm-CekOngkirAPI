namespace Ongkir_Form
{
    partial class Form1
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
            this.lbtitle = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.tbAsal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.rbPOS = new System.Windows.Forms.RadioButton();
            this.rbJNE = new System.Windows.Forms.RadioButton();
            this.rbTIKI = new System.Windows.Forms.RadioButton();
            this.btnPrice = new System.Windows.Forms.Button();
            this.gbDetailServices = new System.Windows.Forms.GroupBox();
            this.tbTujuan = new System.Windows.Forms.TextBox();
            this.lbTujuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Location = new System.Drawing.Point(42, 50);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(92, 13);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Cek Harga Ongkir";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(42, 86);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(92, 13);
            this.lbCity.TabIndex = 1;
            this.lbCity.Text = "Kota / Kabupaten";
            // 
            // tbAsal
            // 
            this.tbAsal.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.tbAsal.Location = new System.Drawing.Point(45, 113);
            this.tbAsal.Name = "tbAsal";
            this.tbAsal.Size = new System.Drawing.Size(100, 20);
            this.tbAsal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Berat (gram)";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(47, 235);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 4;
            // 
            // rbPOS
            // 
            this.rbPOS.AutoSize = true;
            this.rbPOS.Location = new System.Drawing.Point(47, 278);
            this.rbPOS.Name = "rbPOS";
            this.rbPOS.Size = new System.Drawing.Size(47, 17);
            this.rbPOS.TabIndex = 5;
            this.rbPOS.TabStop = true;
            this.rbPOS.Text = "POS";
            this.rbPOS.UseVisualStyleBackColor = true;
            // 
            // rbJNE
            // 
            this.rbJNE.AutoSize = true;
            this.rbJNE.Location = new System.Drawing.Point(100, 278);
            this.rbJNE.Name = "rbJNE";
            this.rbJNE.Size = new System.Drawing.Size(45, 17);
            this.rbJNE.TabIndex = 6;
            this.rbJNE.TabStop = true;
            this.rbJNE.Text = "JNE";
            this.rbJNE.UseVisualStyleBackColor = true;
            // 
            // rbTIKI
            // 
            this.rbTIKI.AutoSize = true;
            this.rbTIKI.Location = new System.Drawing.Point(151, 278);
            this.rbTIKI.Name = "rbTIKI";
            this.rbTIKI.Size = new System.Drawing.Size(45, 17);
            this.rbTIKI.TabIndex = 7;
            this.rbTIKI.TabStop = true;
            this.rbTIKI.Text = "TIKI";
            this.rbTIKI.UseVisualStyleBackColor = true;
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(47, 321);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(149, 28);
            this.btnPrice.TabIndex = 8;
            this.btnPrice.Text = "Cek Harga Layanan";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // gbDetailServices
            // 
            this.gbDetailServices.Location = new System.Drawing.Point(292, 86);
            this.gbDetailServices.Name = "gbDetailServices";
            this.gbDetailServices.Size = new System.Drawing.Size(199, 263);
            this.gbDetailServices.TabIndex = 9;
            this.gbDetailServices.TabStop = false;
            this.gbDetailServices.Text = "Detail Layanan";
            // 
            // tbTujuan
            // 
            this.tbTujuan.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.tbTujuan.Location = new System.Drawing.Point(47, 175);
            this.tbTujuan.Name = "tbTujuan";
            this.tbTujuan.Size = new System.Drawing.Size(100, 20);
            this.tbTujuan.TabIndex = 11;
            // 
            // lbTujuan
            // 
            this.lbTujuan.AutoSize = true;
            this.lbTujuan.Location = new System.Drawing.Point(44, 150);
            this.lbTujuan.Name = "lbTujuan";
            this.lbTujuan.Size = new System.Drawing.Size(43, 13);
            this.lbTujuan.TabIndex = 10;
            this.lbTujuan.Text = "Tujuan ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTujuan);
            this.Controls.Add(this.lbTujuan);
            this.Controls.Add(this.gbDetailServices);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.rbTIKI);
            this.Controls.Add(this.rbJNE);
            this.Controls.Add(this.rbPOS);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAsal);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbtitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox tbAsal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.RadioButton rbPOS;
        private System.Windows.Forms.RadioButton rbJNE;
        private System.Windows.Forms.RadioButton rbTIKI;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.GroupBox gbDetailServices;
        private System.Windows.Forms.TextBox tbTujuan;
        private System.Windows.Forms.Label lbTujuan;
    }
}

