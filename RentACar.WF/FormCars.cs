﻿using System;
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

        private void toolStripButtonAddCar_Click(object sender, EventArgs e)
        {
            CarsManager carsManager = new CarsManager();
            carsManager.CreateCar("","", "");

        }
    }
}
