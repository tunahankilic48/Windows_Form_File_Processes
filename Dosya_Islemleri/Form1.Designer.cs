namespace Dosya_Islemleri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_KonumSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtBelgeYolu = new System.Windows.Forms.TextBox();
            this.lblBelgeYolu = new System.Windows.Forms.Label();
            this.btnKonumSec = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lblBelgeAdi = new System.Windows.Forms.Label();
            this.txtBelgeAdi = new System.Windows.Forms.TextBox();
            this.btnOku = new System.Windows.Forms.Button();
            this.lsbOkunanDeger = new System.Windows.Forms.ListBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_KonumSec
            // 
            this.btn_KonumSec.Location = new System.Drawing.Point(748, 13);
            this.btn_KonumSec.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KonumSec.Name = "btn_KonumSec";
            this.btn_KonumSec.Size = new System.Drawing.Size(239, 58);
            this.btn_KonumSec.TabIndex = 0;
            this.btn_KonumSec.Text = "Folder Browser Diyalog";
            this.btn_KonumSec.UseVisualStyleBackColor = true;
            this.btn_KonumSec.Click += new System.EventHandler(this.btn_KonumSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(748, 96);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(239, 63);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(748, 177);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(239, 55);
            this.btnSaveFileDialog.TabIndex = 3;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // txtBelgeYolu
            // 
            this.txtBelgeYolu.Location = new System.Drawing.Point(141, 34);
            this.txtBelgeYolu.Name = "txtBelgeYolu";
            this.txtBelgeYolu.Size = new System.Drawing.Size(308, 32);
            this.txtBelgeYolu.TabIndex = 4;
            // 
            // lblBelgeYolu
            // 
            this.lblBelgeYolu.AutoSize = true;
            this.lblBelgeYolu.Location = new System.Drawing.Point(26, 34);
            this.lblBelgeYolu.Name = "lblBelgeYolu";
            this.lblBelgeYolu.Size = new System.Drawing.Size(104, 25);
            this.lblBelgeYolu.TabIndex = 5;
            this.lblBelgeYolu.Text = "Belge Yolu:";
            // 
            // btnKonumSec
            // 
            this.btnKonumSec.Location = new System.Drawing.Point(748, 255);
            this.btnKonumSec.Name = "btnKonumSec";
            this.btnKonumSec.Size = new System.Drawing.Size(239, 51);
            this.btnKonumSec.TabIndex = 6;
            this.btnKonumSec.Text = "Konum Seç";
            this.btnKonumSec.UseVisualStyleBackColor = true;
            this.btnKonumSec.Click += new System.EventHandler(this.btnKonumSec_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(748, 327);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(239, 59);
            this.btnOlustur.TabIndex = 7;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lblBelgeAdi
            // 
            this.lblBelgeAdi.AutoSize = true;
            this.lblBelgeAdi.Location = new System.Drawing.Point(26, 96);
            this.lblBelgeAdi.Name = "lblBelgeAdi";
            this.lblBelgeAdi.Size = new System.Drawing.Size(96, 25);
            this.lblBelgeAdi.TabIndex = 8;
            this.lblBelgeAdi.Text = "Belge Adı:";
            // 
            // txtBelgeAdi
            // 
            this.txtBelgeAdi.Location = new System.Drawing.Point(141, 93);
            this.txtBelgeAdi.Name = "txtBelgeAdi";
            this.txtBelgeAdi.Size = new System.Drawing.Size(308, 32);
            this.txtBelgeAdi.TabIndex = 9;
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(748, 404);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(239, 54);
            this.btnOku.TabIndex = 10;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // lsbOkunanDeger
            // 
            this.lsbOkunanDeger.FormattingEnabled = true;
            this.lsbOkunanDeger.ItemHeight = 25;
            this.lsbOkunanDeger.Location = new System.Drawing.Point(26, 144);
            this.lsbOkunanDeger.Name = "lsbOkunanDeger";
            this.lsbOkunanDeger.Size = new System.Drawing.Size(276, 379);
            this.lsbOkunanDeger.TabIndex = 11;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(748, 476);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(239, 47);
            this.btnYazdir.TabIndex = 12;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(340, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 379);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lsbOkunanDeger);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.txtBelgeAdi);
            this.Controls.Add(this.lblBelgeAdi);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnKonumSec);
            this.Controls.Add(this.lblBelgeYolu);
            this.Controls.Add(this.txtBelgeYolu);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btn_KonumSec);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button btn_KonumSec;
        private OpenFileDialog openFileDialog1;
        private Button btnOpenFileDialog;
        private Button btnSaveFileDialog;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtBelgeYolu;
        private Label lblBelgeYolu;
        private Button btnKonumSec;
        private Button btnOlustur;
        private Label lblBelgeAdi;
        private TextBox txtBelgeAdi;
        private Button btnOku;
        private ListBox lsbOkunanDeger;
        private Button btnYazdir;
        private RichTextBox richTextBox1;
    }
}