using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.BLL;

namespace RentACar.WF
{
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
        }
        CarsManager carsManager = new CarsManager();

        private void toolStripButtonAddCar_Click(object sender, EventArgs e)
        {
          string result=  carsManager.CreateCar("Volswogen California","bla", "1250");
            CarsListDataGridView();
            MessageBox.Show(result);

        }

        private void FormCars_Load(object sender, EventArgs e)
        {
            CarsListDataGridView();
        }

        private void CarsListDataGridView()
        {
            dataGridView1.DataSource = carsManager.CarList();
        }
    }
}
