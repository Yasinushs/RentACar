using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRentACar.WF
{
    public partial class FormKiralama : Form
    {
        public FormKiralama()
        {
            InitializeComponent();
        }


        private int kiralamaId;
        YasinRentACarEntities db = new YasinRentACarEntities();
        private void FormKiralama_Load_1(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = db.sp_KiralananAraclar1().ToList();

            comboBoxAdSoyad.DisplayMember = "MusteriAdSoyad";
            comboBoxAdSoyad.ValueMember = "MusteriId";
            comboBoxAdSoyad.DataSource = db.Musteriler.ToList();

            comboBoxAracModel.DataSource = db.Araclar.ToList();
            comboBoxAracModel.DisplayMember = "AracModel";
            comboBoxAracModel.ValueMember = "AracId";



            dateTimePicker2.Value = DateTime.Now.AddDays(7);

        }

        private void buttonEKLE_Click(object sender, EventArgs e)

        {
            try
            {
                string musteriAd = comboBoxAracModel.Text.Trim(); // Boşlukları temizle
                string aracModel = comboBoxAdSoyad.Text.Trim(); // Boşlukları temizle
                DateTime kiralamaTarihi = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")); // Tarih formatını belirt
                DateTime iadeTarihi = Convert.ToDateTime(dateTimePicker2.Value.ToString("yyyy-MM-dd")); // Tarih formatını belirt


                var varmiKayit = db.Kiralama.Where(x => x.MusteriId == kiralamaId).FirstOrDefault();
                if (varmiKayit == null)
                {
                    if (!string.IsNullOrEmpty(musteriAd) && !string.IsNullOrEmpty(aracModel) && kiralamaTarihi != null && iadeTarihi != null)
                    {
                        Kiralama kiralamaEklenecekler = new Kiralama
                        {
                            AracId = (int)comboBoxAracModel.SelectedValue,
                            MusteriId = Convert.ToInt32(comboBoxAdSoyad.SelectedValue),
                            AlinisTarihi = kiralamaTarihi,
                            IadeTarihi = iadeTarihi,
                            TeslimTarihi = iadeTarihi,
                            IsActive = true
                        };
                        // Veritabanına ekleme işlemi
                        db.Kiralama.Add(kiralamaEklenecekler);
                        int kayitSonuc = db.SaveChanges();
                        if (kayitSonuc > 0)
                        {
                            dataGridView1.DataSource = db.sp_KiralananAraclar1().ToList();
                            MessageBox.Show("Kayıt Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Başarısız");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurun.");
                    }

                }
                else
                {
                    MessageBox.Show("Bu müşterinin aynı araçla zaten kiralama kaydı var.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kiralama Sırasında Hata Oluştu: " + ex.Message);
            }
        }

        private void Temizle()
        {
            dataGridView1.DataSource = db.Kiralama.Where(x => x.IsActive == true).ToList();
            comboBoxAdSoyad.Text = "";
            comboBoxAracModel.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddDays(7);
            kiralamaId = 0;
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxAdSoyad.Text = dataGridView1.CurrentRow.Cells["MusteriAdSoyad"].Value.ToString();
            comboBoxAracModel.Text = dataGridView1.CurrentRow.Cells["AracModel"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["AlinisTarihi"].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["IadeTarihi"].Value);
            kiralamaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KiralamalarId"].Value);

        }

        private void buttonGUNCELLE_Click(object sender, EventArgs e)
        {
            if (kiralamaId > 0)
            {
                var guncellenecekKayit = db.Kiralama.Where(x => x.AracId == kiralamaId).FirstOrDefault();

                var varmiKayit = db.Kiralama.Where(x => x.MusteriId == Convert.ToInt32(comboBoxAdSoyad.ValueMember)).FirstOrDefault();
                var varmiKayit2 = db.Kiralama.Where(x => x.AracId == Convert.ToInt32(comboBoxAracModel.ValueMember)).FirstOrDefault();
                var varmiKayit3 = db.Kiralama.Where(x => x.AlinisTarihi == dateTimePicker1.Value).FirstOrDefault();
                var varmiKayit4 = db.Kiralama.Where(x => x.IadeTarihi == dateTimePicker2.Value).FirstOrDefault();
                if (true)
                {

                }

            }
        }

        private void buttonSIL_Click(object sender, EventArgs e)
        {
            if (kiralamaId == 0)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz KayıdI Seçin");
                return;
            }
            var silinecekKayit = db.Kiralama.Where(x => x.AracId == kiralamaId).FirstOrDefault();
            silinecekKayit.IsActive = false;
            int silSonuc = db.SaveChanges();
            if (silSonuc > 0)
            {
                dataGridView1.DataSource = db.Kiralama.Where(x => x.IsActive == true).ToList();
                MessageBox.Show("Silme İşlemi Başarılı");
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız");
            }
        }

        private void buttonTEMİZLE_Click(object sender, EventArgs e)
        {
            Temizle();
        }


    }
}
