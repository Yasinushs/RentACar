namespace MyRentACar.WF
{
    partial class FormMusteriler
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
            this.textBoxMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxMusteriTelNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTEMİZLE = new System.Windows.Forms.Button();
            this.buttonSIL = new System.Windows.Forms.Button();
            this.buttonGUNCELLE = new System.Windows.Forms.Button();
            this.buttonEKLE = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMusteriAdSoyad
            // 
            this.textBoxMusteriAdSoyad.Location = new System.Drawing.Point(9, 41);
            this.textBoxMusteriAdSoyad.Name = "textBoxMusteriAdSoyad";
            this.textBoxMusteriAdSoyad.Size = new System.Drawing.Size(200, 20);
            this.textBoxMusteriAdSoyad.TabIndex = 0;
            // 
            // textBoxMusteriTelNo
            // 
            this.textBoxMusteriTelNo.Location = new System.Drawing.Point(9, 85);
            this.textBoxMusteriTelNo.Name = "textBoxMusteriTelNo";
            this.textBoxMusteriTelNo.Size = new System.Drawing.Size(200, 20);
            this.textBoxMusteriTelNo.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Ad-Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Telefon Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Müşteri Kayıt Tarihi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTEMİZLE);
            this.groupBox1.Controls.Add(this.buttonSIL);
            this.groupBox1.Controls.Add(this.buttonGUNCELLE);
            this.groupBox1.Controls.Add(this.buttonEKLE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxMusteriTelNo);
            this.groupBox1.Controls.Add(this.textBoxMusteriAdSoyad);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 237);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kayıt";
            // 
            // buttonTEMİZLE
            // 
            this.buttonTEMİZLE.Location = new System.Drawing.Point(92, 194);
            this.buttonTEMİZLE.Name = "buttonTEMİZLE";
            this.buttonTEMİZLE.Size = new System.Drawing.Size(77, 33);
            this.buttonTEMİZLE.TabIndex = 9;
            this.buttonTEMİZLE.Text = "TEMİZLE";
            this.buttonTEMİZLE.UseVisualStyleBackColor = true;
            this.buttonTEMİZLE.Click += new System.EventHandler(this.buttonTEMİZLE_Click);
            // 
            // buttonSIL
            // 
            this.buttonSIL.Location = new System.Drawing.Point(9, 194);
            this.buttonSIL.Name = "buttonSIL";
            this.buttonSIL.Size = new System.Drawing.Size(77, 33);
            this.buttonSIL.TabIndex = 8;
            this.buttonSIL.Text = "SİL";
            this.buttonSIL.UseVisualStyleBackColor = true;
            this.buttonSIL.Click += new System.EventHandler(this.buttonSIL_Click);
            // 
            // buttonGUNCELLE
            // 
            this.buttonGUNCELLE.Location = new System.Drawing.Point(92, 155);
            this.buttonGUNCELLE.Name = "buttonGUNCELLE";
            this.buttonGUNCELLE.Size = new System.Drawing.Size(77, 33);
            this.buttonGUNCELLE.TabIndex = 7;
            this.buttonGUNCELLE.Text = "GÜNCELLE";
            this.buttonGUNCELLE.UseVisualStyleBackColor = true;
            this.buttonGUNCELLE.Click += new System.EventHandler(this.buttonGUNCELLE_Click);
            // 
            // buttonEKLE
            // 
            this.buttonEKLE.Location = new System.Drawing.Point(9, 155);
            this.buttonEKLE.Name = "buttonEKLE";
            this.buttonEKLE.Size = new System.Drawing.Size(77, 33);
            this.buttonEKLE.TabIndex = 6;
            this.buttonEKLE.Text = "EKLE";
            this.buttonEKLE.UseVisualStyleBackColor = true;
            this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 258);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 267);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Müşteri Listesi";
            // 
            // FormMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMusteriler";
            this.Text = "FormMusteriler";
            this.Load += new System.EventHandler(this.FormMusteriler_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMusteriAdSoyad;
        private System.Windows.Forms.TextBox textBoxMusteriTelNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTEMİZLE;
        private System.Windows.Forms.Button buttonSIL;
        private System.Windows.Forms.Button buttonGUNCELLE;
        private System.Windows.Forms.Button buttonEKLE;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
    }
}