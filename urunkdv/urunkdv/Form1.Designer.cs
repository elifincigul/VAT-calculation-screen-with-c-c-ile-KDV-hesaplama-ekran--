namespace urunkdv
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmerhaba = new System.Windows.Forms.Button();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txturunfiyati = new System.Windows.Forms.TextBox();
            this.txtkdv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmerhaba
            // 
            this.btnmerhaba.Location = new System.Drawing.Point(514, 102);
            this.btnmerhaba.Name = "btnmerhaba";
            this.btnmerhaba.Size = new System.Drawing.Size(157, 74);
            this.btnmerhaba.TabIndex = 0;
            this.btnmerhaba.Text = "merhaba dünya";
            this.btnmerhaba.UseVisualStyleBackColor = true;
            this.btnmerhaba.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(96, 179);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(151, 53);
            this.btnhesapla.TabIndex = 0;
            this.btnhesapla.Text = "hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Kdv";
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(127, 66);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(100, 20);
            this.txturunadi.TabIndex = 2;
            // 
            // txturunfiyati
            // 
            this.txturunfiyati.Location = new System.Drawing.Point(127, 90);
            this.txturunfiyati.Name = "txturunfiyati";
            this.txturunfiyati.Size = new System.Drawing.Size(100, 20);
            this.txturunfiyati.TabIndex = 2;
            this.txturunfiyati.TextChanged += new System.EventHandler(this.txtürünfiyati_TextChanged);
            // 
            // txtkdv
            // 
            this.txtkdv.Location = new System.Drawing.Point(127, 118);
            this.txtkdv.Name = "txtkdv";
            this.txtkdv.Size = new System.Drawing.Size(100, 20);
            this.txtkdv.TabIndex = 2;
            this.txtkdv.TextChanged += new System.EventHandler(this.txtkdv_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkdv);
            this.Controls.Add(this.txturunfiyati);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.btnmerhaba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmerhaba;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txturunfiyati;
        private System.Windows.Forms.TextBox txtkdv;
    }
}

