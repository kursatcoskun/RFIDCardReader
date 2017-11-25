namespace CardReader
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yOKLAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yoklamaAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yARDIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartSistemiHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlarHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sinifbilgitx = new System.Windows.Forms.TextBox();
            this.bolumbilgitx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numbilgitx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mailbilgitx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isimbilgitx = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.kartnumtx = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.kartnumctrl = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sinifctrl = new System.Windows.Forms.TextBox();
            this.bolumctrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numctrl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mailctrl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.isimctrl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAĞLANTI";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Bağlantıyı Kes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Noktası";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITLARToolStripMenuItem,
            this.yOKLAMAToolStripMenuItem,
            this.yARDIMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kAYITLARToolStripMenuItem
            // 
            this.kAYITLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlarıGörüntüleToolStripMenuItem,
            this.kayıtlarıDüzenleToolStripMenuItem});
            this.kAYITLARToolStripMenuItem.Name = "kAYITLARToolStripMenuItem";
            this.kAYITLARToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.kAYITLARToolStripMenuItem.Text = "KAYITLAR";
            // 
            // kayıtlarıGörüntüleToolStripMenuItem
            // 
            this.kayıtlarıGörüntüleToolStripMenuItem.Name = "kayıtlarıGörüntüleToolStripMenuItem";
            this.kayıtlarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.kayıtlarıGörüntüleToolStripMenuItem.Text = "Kayıtları Görüntüle";
            this.kayıtlarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.kayıtlarıGörüntüleToolStripMenuItem_Click);
            // 
            // kayıtlarıDüzenleToolStripMenuItem
            // 
            this.kayıtlarıDüzenleToolStripMenuItem.Name = "kayıtlarıDüzenleToolStripMenuItem";
            this.kayıtlarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.kayıtlarıDüzenleToolStripMenuItem.Text = "Kayıtları Düzenle";
            // 
            // yOKLAMAToolStripMenuItem
            // 
            this.yOKLAMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yoklamaAlToolStripMenuItem});
            this.yOKLAMAToolStripMenuItem.Name = "yOKLAMAToolStripMenuItem";
            this.yOKLAMAToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.yOKLAMAToolStripMenuItem.Text = "YOKLAMA";
            // 
            // yoklamaAlToolStripMenuItem
            // 
            this.yoklamaAlToolStripMenuItem.Name = "yoklamaAlToolStripMenuItem";
            this.yoklamaAlToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.yoklamaAlToolStripMenuItem.Text = "Yoklama Al";
            // 
            // yARDIMToolStripMenuItem
            // 
            this.yARDIMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartSistemiHakkındaToolStripMenuItem,
            this.kayıtlarHakkındaToolStripMenuItem});
            this.yARDIMToolStripMenuItem.Name = "yARDIMToolStripMenuItem";
            this.yARDIMToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.yARDIMToolStripMenuItem.Text = "YARDIM";
            // 
            // kartSistemiHakkındaToolStripMenuItem
            // 
            this.kartSistemiHakkındaToolStripMenuItem.Name = "kartSistemiHakkındaToolStripMenuItem";
            this.kartSistemiHakkındaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kartSistemiHakkındaToolStripMenuItem.Text = "Kart Sistemi Hakkında";
            // 
            // kayıtlarHakkındaToolStripMenuItem
            // 
            this.kayıtlarHakkındaToolStripMenuItem.Name = "kayıtlarHakkındaToolStripMenuItem";
            this.kayıtlarHakkındaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kayıtlarHakkındaToolStripMenuItem.Text = "Kayıtlar Hakkında";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sinifbilgitx);
            this.groupBox2.Controls.Add(this.bolumbilgitx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numbilgitx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mailbilgitx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.isimbilgitx);
            this.groupBox2.Location = new System.Drawing.Point(22, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 346);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BİLGİLER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sınıfı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bölümü";
            // 
            // sinifbilgitx
            // 
            this.sinifbilgitx.Location = new System.Drawing.Point(151, 209);
            this.sinifbilgitx.Name = "sinifbilgitx";
            this.sinifbilgitx.Size = new System.Drawing.Size(100, 20);
            this.sinifbilgitx.TabIndex = 7;
            // 
            // bolumbilgitx
            // 
            this.bolumbilgitx.Location = new System.Drawing.Point(151, 174);
            this.bolumbilgitx.Name = "bolumbilgitx";
            this.bolumbilgitx.Size = new System.Drawing.Size(100, 20);
            this.bolumbilgitx.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon Numarası";
            // 
            // numbilgitx
            // 
            this.numbilgitx.Location = new System.Drawing.Point(151, 138);
            this.numbilgitx.Name = "numbilgitx";
            this.numbilgitx.Size = new System.Drawing.Size(100, 20);
            this.numbilgitx.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-Mail";
            // 
            // mailbilgitx
            // 
            this.mailbilgitx.Location = new System.Drawing.Point(151, 100);
            this.mailbilgitx.Name = "mailbilgitx";
            this.mailbilgitx.Size = new System.Drawing.Size(100, 20);
            this.mailbilgitx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "İsim Soyisim";
            // 
            // isimbilgitx
            // 
            this.isimbilgitx.Location = new System.Drawing.Point(151, 64);
            this.isimbilgitx.Name = "isimbilgitx";
            this.isimbilgitx.Size = new System.Drawing.Size(100, 20);
            this.isimbilgitx.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.kartnumtx);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(513, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 203);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KART KAYDETME";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Kart Numarası";
            // 
            // kartnumtx
            // 
            this.kartnumtx.Location = new System.Drawing.Point(149, 69);
            this.kartnumtx.Name = "kartnumtx";
            this.kartnumtx.Size = new System.Drawing.Size(160, 20);
            this.kartnumtx.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kart Numarası";
            // 
            // kartnumctrl
            // 
            this.kartnumctrl.Location = new System.Drawing.Point(159, 72);
            this.kartnumctrl.Name = "kartnumctrl";
            this.kartnumctrl.Size = new System.Drawing.Size(177, 20);
            this.kartnumctrl.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.kartnumctrl);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.sinifctrl);
            this.groupBox4.Controls.Add(this.bolumctrl);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.numctrl);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.mailctrl);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.isimctrl);
            this.groupBox4.Location = new System.Drawing.Point(513, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 346);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kontrol";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(192, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "İptal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Onayla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sınıfı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Bölümü";
            // 
            // sinifctrl
            // 
            this.sinifctrl.Location = new System.Drawing.Point(159, 251);
            this.sinifctrl.Name = "sinifctrl";
            this.sinifctrl.Size = new System.Drawing.Size(177, 20);
            this.sinifctrl.TabIndex = 7;
            // 
            // bolumctrl
            // 
            this.bolumctrl.Location = new System.Drawing.Point(159, 216);
            this.bolumctrl.Name = "bolumctrl";
            this.bolumctrl.Size = new System.Drawing.Size(177, 20);
            this.bolumctrl.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Telefon Numarası";
            // 
            // numctrl
            // 
            this.numctrl.Location = new System.Drawing.Point(159, 180);
            this.numctrl.Name = "numctrl";
            this.numctrl.Size = new System.Drawing.Size(177, 20);
            this.numctrl.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "E-Mail";
            // 
            // mailctrl
            // 
            this.mailctrl.Location = new System.Drawing.Point(159, 142);
            this.mailctrl.Name = "mailctrl";
            this.mailctrl.Size = new System.Drawing.Size(177, 20);
            this.mailctrl.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "İsim Soyisim";
            // 
            // isimctrl
            // 
            this.isimctrl.Location = new System.Drawing.Point(159, 106);
            this.isimctrl.Name = "isimctrl";
            this.isimctrl.Size = new System.Drawing.Size(177, 20);
            this.isimctrl.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IEEE ESOGU OTOMASYON";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yOKLAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yoklamaAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yARDIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartSistemiHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlarHakkındaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sinifbilgitx;
        private System.Windows.Forms.TextBox bolumbilgitx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numbilgitx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailbilgitx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isimbilgitx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox kartnumctrl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sinifctrl;
        private System.Windows.Forms.TextBox bolumctrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numctrl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mailctrl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox isimctrl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox kartnumtx;
    }
}