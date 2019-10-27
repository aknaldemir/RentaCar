namespace RentACar.WinFormUI
{
    partial class FormAnasayfa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAlisTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDetaylar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alış Tarihi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.dtpTeslimTarihi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpAlisTarihi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAÇ KİRALAMA BİLGİLERİ";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(143, 158);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(99, 38);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(143, 100);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpTeslimTarihi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teslim Tarihi";
            // 
            // dtpAlisTarihi
            // 
            this.dtpAlisTarihi.Location = new System.Drawing.Point(143, 49);
            this.dtpAlisTarihi.Name = "dtpAlisTarihi";
            this.dtpAlisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpAlisTarihi.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKirala);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lblDetaylar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(426, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 228);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAÇLAR";
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(156, 174);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(99, 38);
            this.btnKirala.TabIndex = 3;
            this.btnKirala.Text = "KİRALA";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lblDetaylar
            // 
            this.lblDetaylar.AutoSize = true;
            this.lblDetaylar.Location = new System.Drawing.Point(141, 100);
            this.lblDetaylar.Name = "lblDetaylar";
            this.lblDetaylar.Size = new System.Drawing.Size(83, 13);
            this.lblDetaylar.TabIndex = 1;
            this.lblDetaylar.Text = "LBLDETAYLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ARAÇ BİLGİSİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ARAÇLAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 283);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAlisTarihi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDetaylar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

