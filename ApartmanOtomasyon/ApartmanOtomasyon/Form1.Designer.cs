
namespace ApartmanOtomasyon
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
            this.btnGelirler = new System.Windows.Forms.Button();
            this.btnGiderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGelirler
            // 
            this.btnGelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirler.Location = new System.Drawing.Point(131, 165);
            this.btnGelirler.Name = "btnGelirler";
            this.btnGelirler.Size = new System.Drawing.Size(128, 134);
            this.btnGelirler.TabIndex = 0;
            this.btnGelirler.Text = "Gelirler";
            this.btnGelirler.UseVisualStyleBackColor = true;
            this.btnGelirler.Click += new System.EventHandler(this.btnGelirler_Click);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.Location = new System.Drawing.Point(346, 165);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(128, 134);
            this.btnGiderler.TabIndex = 1;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.UseVisualStyleBackColor = true;
            this.btnGiderler.Click += new System.EventHandler(this.btnGiderler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiderler);
            this.Controls.Add(this.btnGelirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGelirler;
        private System.Windows.Forms.Button btnGiderler;
    }
}

