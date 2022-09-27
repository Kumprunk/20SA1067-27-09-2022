namespace _20SA1057
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbYa = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sop_ayam = new System.Windows.Forms.CheckBox();
            this.ayam_rica = new System.Windows.Forms.CheckBox();
            this.es_teh = new System.Windows.Forms.CheckBox();
            this.txtsop = new System.Windows.Forms.TextBox();
            this.txtrica = new System.Windows.Forms.TextBox();
            this.txtteh = new System.Windows.Forms.TextBox();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(86, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(167, 20);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pelanggan";
            // 
            // rbYa
            // 
            this.rbYa.AutoSize = true;
            this.rbYa.Location = new System.Drawing.Point(86, 40);
            this.rbYa.Name = "rbYa";
            this.rbYa.Size = new System.Drawing.Size(38, 17);
            this.rbYa.TabIndex = 3;
            this.rbYa.TabStop = true;
            this.rbYa.Text = "Ya";
            this.rbYa.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(149, 40);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(52, 17);
            this.rbNo.TabIndex = 4;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Tidak";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu Pilihan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jumlah";
            // 
            // sop_ayam
            // 
            this.sop_ayam.AutoSize = true;
            this.sop_ayam.Location = new System.Drawing.Point(16, 98);
            this.sop_ayam.Name = "sop_ayam";
            this.sop_ayam.Size = new System.Drawing.Size(127, 17);
            this.sop_ayam.TabIndex = 7;
            this.sop_ayam.Text = "Sop Ayam (Rp. 9000)";
            this.sop_ayam.UseVisualStyleBackColor = true;
            this.sop_ayam.CheckedChanged += new System.EventHandler(this.sop_ayam_CheckedChanged);
            // 
            // ayam_rica
            // 
            this.ayam_rica.AutoSize = true;
            this.ayam_rica.Location = new System.Drawing.Point(16, 122);
            this.ayam_rica.Name = "ayam_rica";
            this.ayam_rica.Size = new System.Drawing.Size(155, 17);
            this.ayam_rica.TabIndex = 8;
            this.ayam_rica.Text = "Ayam Rica Rica (Rp. 8500)";
            this.ayam_rica.UseVisualStyleBackColor = true;
            this.ayam_rica.CheckedChanged += new System.EventHandler(this.ayam_rica_CheckedChanged);
            // 
            // es_teh
            // 
            this.es_teh.AutoSize = true;
            this.es_teh.Location = new System.Drawing.Point(16, 146);
            this.es_teh.Name = "es_teh";
            this.es_teh.Size = new System.Drawing.Size(115, 17);
            this.es_teh.TabIndex = 9;
            this.es_teh.Text = "ES Teh (Rp. 2000)";
            this.es_teh.UseVisualStyleBackColor = true;
            this.es_teh.CheckedChanged += new System.EventHandler(this.es_teh_CheckedChanged);
            // 
            // txtsop
            // 
            this.txtsop.Location = new System.Drawing.Point(200, 98);
            this.txtsop.Name = "txtsop";
            this.txtsop.Size = new System.Drawing.Size(72, 20);
            this.txtsop.TabIndex = 10;
            // 
            // txtrica
            // 
            this.txtrica.Location = new System.Drawing.Point(200, 120);
            this.txtrica.Name = "txtrica";
            this.txtrica.Size = new System.Drawing.Size(72, 20);
            this.txtrica.TabIndex = 11;
            // 
            // txtteh
            // 
            this.txtteh.Location = new System.Drawing.Point(200, 143);
            this.txtteh.Name = "txtteh";
            this.txtteh.Size = new System.Drawing.Size(72, 20);
            this.txtteh.TabIndex = 12;
            // 
            // btn_hitung
            // 
            this.btn_hitung.Location = new System.Drawing.Point(61, 182);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(148, 23);
            this.btn_hitung.TabIndex = 13;
            this.btn_hitung.Text = "Hitung";
            this.btn_hitung.UseVisualStyleBackColor = true;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Rp";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(200, 229);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(72, 20);
            this.txttotal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_hitung);
            this.Controls.Add(this.txtteh);
            this.Controls.Add(this.txtrica);
            this.Controls.Add(this.txtsop);
            this.Controls.Add(this.es_teh);
            this.Controls.Add(this.ayam_rica);
            this.Controls.Add(this.sop_ayam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi GUEH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbYa;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sop_ayam;
        private System.Windows.Forms.CheckBox ayam_rica;
        private System.Windows.Forms.CheckBox es_teh;
        private System.Windows.Forms.TextBox txtsop;
        private System.Windows.Forms.TextBox txtrica;
        private System.Windows.Forms.TextBox txtteh;
        private System.Windows.Forms.Button btn_hitung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotal;
    }
}

