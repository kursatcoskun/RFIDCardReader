namespace CardReader
{
    partial class KayitGoruntule
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KartNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İsimsoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bölümü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sınıfı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.KartNo,
            this.İsimsoyisim,
            this.Mail,
            this.Telno,
            this.Bölümü,
            this.Sınıfı});
            this.listView1.Location = new System.Drawing.Point(6, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(893, 552);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 92;
            // 
            // KartNo
            // 
            this.KartNo.Text = "RFID";
            this.KartNo.Width = 124;
            // 
            // İsimsoyisim
            // 
            this.İsimsoyisim.Text = "İSİM";
            this.İsimsoyisim.Width = 163;
            // 
            // Mail
            // 
            this.Mail.Text = "MAİL";
            this.Mail.Width = 122;
            // 
            // Telno
            // 
            this.Telno.Text = "TEL NO";
            this.Telno.Width = 131;
            // 
            // Bölümü
            // 
            this.Bölümü.Text = "BÖLÜM";
            this.Bölümü.Width = 123;
            // 
            // Sınıfı
            // 
            this.Sınıfı.Text = "SINIF";
            this.Sınıfı.Width = 114;
            // 
            // KayitGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 576);
            this.Controls.Add(this.listView1);
            this.Name = "KayitGoruntule";
            this.Text = "KayitGoruntule";
            this.Load += new System.EventHandler(this.KayitGoruntule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader KartNo;
        private System.Windows.Forms.ColumnHeader İsimsoyisim;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Telno;
        private System.Windows.Forms.ColumnHeader Bölümü;
        private System.Windows.Forms.ColumnHeader Sınıfı;
    }
}