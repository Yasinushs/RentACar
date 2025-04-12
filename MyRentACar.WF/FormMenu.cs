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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripButtonAracKayit_Click(object sender, EventArgs e)
        {
            FormAraclar araclar = new FormAraclar();
           
            araclar.Show();


        }

        private void toolStripButtonMusteriKayit_Click(object sender, EventArgs e)
        {
            FormMusteriler musteriler = new FormMusteriler();
          
            musteriler.Show();
        }

        private void toolStripButtonKiralama_Click(object sender, EventArgs e)
        {
            FormKiralama kiralama = new FormKiralama();
            kiralama.Show();
        }
    }
}
