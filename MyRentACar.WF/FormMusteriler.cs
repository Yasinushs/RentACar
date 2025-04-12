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
    

    public partial class FormMusteriler: Form
    {
        private int musteriId;
       YasinRentACarEntities db = new YasinRentACarEntities();
        public FormMusteriler()
        {
            InitializeComponent();
        }
        private void FormMusteriler_Load_1(object sender, EventArgs e)
        {
           // YasinRentACarEntities db = new YasinRentACarEntities();
            dataGridView2.DataSource = db.Musteriler.ToList();
           




        }
        

        private void buttonEKLE_Click_1(object sender, EventArgs e)
        {
            try
            {
                string musteriAdSoyad = textBoxMusteriAdSoyad.Text.Trim(); // Boşlukları temizle
                DateTime eklenmeTarih = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")); // Tarih formatını belirt
                string musteriNo = textBoxMusteriTelNo.Text.Trim(); // Boşlukları temizle

                // Veritabanında aynı modelde bir araç olup olmadığını kontrol et
                var varmiKayit = db.Musteriler.Where(x => x.MusteriAdSoyad == musteriAdSoyad).FirstOrDefault();
                if (varmiKayit == null)
                {
                    // Hem model hem de tarih bilgisi boş değilse işlemi yap
                    if (!string.IsNullOrWhiteSpace(musteriAdSoyad) && eklenmeTarih != null)
                    {
                        Musteriler musteriEklenecekler = new Musteriler
                        {
                            MusteriAdSoyad = musteriAdSoyad,
                            MusteriNo = musteriNo,
                            MusteriEklenmeZamani = eklenmeTarih,
                            İsActive = true,

                        };

                        // Veritabanına ekleme işlemi
                        db.Musteriler.Add(musteriEklenecekler);
                        int kayitSonuc = db.SaveChanges();

                        if (kayitSonuc > 0)
                        {
                            dataGridView2.DataSource = db.Musteriler.ToList();
                            MessageBox.Show("Kayıt Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Başarısız");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
                    }
                }
                else
                {
                    MessageBox.Show(musteriAdSoyad + " adında bir kayıt zaten var.");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını daha ayrıntılı olarak göster
                MessageBox.Show("Ekleme esnasında hata oluştu: " + ex.Message + "\nHata Türü: " + ex.GetType().ToString());
            }
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMusteriAdSoyad.Text = dataGridView2.CurrentRow.Cells["MusteriAdSoyad"].Value.ToString();
            textBoxMusteriTelNo.Text = dataGridView2.CurrentRow.Cells["MusteriNo"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells["MusteriEklenmeZamani"].Value);
            musteriId = Convert.ToInt16(dataGridView2.CurrentRow.Cells["MusteriId"].Value);
        }

      

        public void Temizle()
        {
            dataGridView2.DataSource = db.Araclar.Where(x => x.IsActive == true).ToList();
            textBoxMusteriAdSoyad.Clear();
            textBoxMusteriTelNo.Clear();
            dateTimePicker1.Value = DateTime.Now;
            musteriId = 0;
        }

        private void buttonGUNCELLE_Click(object sender, EventArgs e)
        {
            if (musteriId > 0)
            {
                var musteriGuncelle = db.Musteriler.Where(x => x.MusteriId == musteriId).FirstOrDefault();
                var varmiKayit = db.Musteriler.Where(x => x.MusteriAdSoyad == textBoxMusteriAdSoyad.Text.Trim()).FirstOrDefault();
                var varmiKayit2 = db.Musteriler.Where(x => x.MusteriNo == textBoxMusteriTelNo.Text.Trim()).FirstOrDefault();
                if (varmiKayit != null)
                {
                    MessageBox.Show(textBoxMusteriAdSoyad + "' adında araç vardır.");
                    return;

                }
                musteriGuncelle.MusteriAdSoyad = textBoxMusteriAdSoyad.Text.Trim();
                musteriGuncelle.MusteriEklenmeZamani = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                musteriGuncelle.MusteriNo = textBoxMusteriTelNo.Text.Trim();
                int guncelleSonuc = db.SaveChanges();
                if (guncelleSonuc > 0)
                {
                    MessageBox.Show("Başarılı bir şekilde güncellendi");
                    Temizle();

                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız");
                }

            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz müşteriyi seçiniz");
            }
        }

        private void buttonSIL_Click(object sender, EventArgs e)
        {
            if (musteriId == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz aracı seçiniz");
                return;
            }
            var aracSil = db.Musteriler.Where(x => x.MusteriId == musteriId).FirstOrDefault();
            aracSil.İsActive = false;


            int silSonuc = db.SaveChanges();
            if (silSonuc > 0)
            {
                dataGridView2.DataSource = db.Araclar.ToList();
                MessageBox.Show("Başarılı bir şekilde silindi");
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız");
            }
        }

        private void buttonTEMİZLE_Click(object sender, EventArgs e)
        {
            Temizle();
        }

       
    }

}
