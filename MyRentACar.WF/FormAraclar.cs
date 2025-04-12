using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRentACar.WF
{
    public partial class FormAraclar : Form
    {
        private int araclarıd;
        YasinRentACarEntities db = new YasinRentACarEntities();
        public FormAraclar()
        {
            InitializeComponent();
        }
        private void FormAraclar_Load(object sender, EventArgs e)
        {
            YasinRentACarEntities db = new YasinRentACarEntities();
            dataGridView1.DataSource = db.Araclar.ToList();

            
            

        }

        private void buttonEKLE_Click(object sender, EventArgs e)
        {
            try
            {
                string aracModel = textBoxAracModel.Text.Trim(); // Boşlukları temizle
                DateTime eklenmeTarih = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")); // Tarih formatını belirt

                // Veritabanında aynı modelde bir araç olup olmadığını kontrol et
                var varmiKayit = db.Araclar.Where(x => x.AracModel == aracModel).FirstOrDefault();
                if (varmiKayit == null)
                {
                    // Hem model hem de tarih bilgisi boş değilse işlemi yap
                    if (!string.IsNullOrWhiteSpace(aracModel) && eklenmeTarih != null)
                    {
                        Araclar aracEklenecekler = new Araclar
                        {
                            AracModel = aracModel,
                            AracEklenmeTarih = eklenmeTarih,
                            IsActive = true,
                            AracMusaitlik = "1"
                        };

                        // Veritabanına ekleme işlemi
                        db.Araclar.Add(aracEklenecekler);
                        int kayitSonuc = db.SaveChanges();

                        if (kayitSonuc > 0)
                        {
                            dataGridView1.DataSource = db.Araclar.ToList();
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
                    MessageBox.Show(aracModel + " adında bir kayıt zaten var.");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını daha ayrıntılı olarak göster
                MessageBox.Show("Ekleme esnasında hata oluştu: " + ex.Message + "\nHata Türü: " + ex.GetType().ToString());
            }
        }



        public void Temizle()
        {
            dataGridView1.DataSource = db.Araclar.Where(x => x.IsActive == true).ToList();
            textBoxAracModel.Clear();
            dateTimePicker1.Value = DateTime.Now;
            araclarıd = 0;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBoxAracModel.Text = dataGridView1.CurrentRow.Cells["AracModel"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["AracEklenmeTarih"].Value);
            araclarıd = Convert.ToInt16(dataGridView1.CurrentRow.Cells["AracId"].Value);

        }

        private void buttonGUNCELLE_Click(object sender, EventArgs e)
        {
            if (araclarıd > 0)
            {
                var aracGuncelle = db.Araclar.Where(x => x.AracId == araclarıd).FirstOrDefault();
                var varmiKayit = db.Araclar.Where(x => x.AracModel == textBoxAracModel.Text.Trim()).FirstOrDefault();
                if (varmiKayit != null)
                {
                    MessageBox.Show(textBoxAracModel + "' adında araç vardır.");
                    return;

                }
                aracGuncelle.AracModel = textBoxAracModel.Text.Trim();
                aracGuncelle.AracEklenmeTarih = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
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
                MessageBox.Show("Lütfen güncellemek istediğiniz aracı seçiniz");
            }
        }

        private void buttonSIL_Click(object sender, EventArgs e)
        {
            if (araclarıd == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz aracı seçiniz");
                return;
            }
            var aracSil = db.Araclar.Where(x => x.AracId == araclarıd).FirstOrDefault();
            aracSil.IsActive = false;
            
               
                int silSonuc = db.SaveChanges();
                if (silSonuc > 0)
                {
                    dataGridView1.DataSource = db.Araclar.ToList();
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








