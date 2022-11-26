using System.IO;
namespace Dosya_Islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_KonumSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
             

        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }


        string belgeYolu, belgeAdi;

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            belgeAdi = txtBelgeAdi.Text;
            StreamWriter sw = File.CreateText(belgeYolu + "\\" + belgeAdi + ".txt");
            MessageBox.Show("Belgeniz ba�ar�yla olu�turuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); 

        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string line = sr.ReadLine();
                while(line != null)
                {
                    lsbOkunanDeger.Items.Add(line);
                    line = sr.ReadLine();
                }
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "MEtin dosyas� |*.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            MessageBox.Show("Metin belgesine kay�t yap�ld�","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKonumSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeYolu = folderBrowserDialog1.SelectedPath;
                txtBelgeYolu.Text = belgeYolu;
            }
        }
    }
}