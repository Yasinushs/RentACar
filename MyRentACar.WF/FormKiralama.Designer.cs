namespace MyRentACar.WF
{
    partial class FormKiralama
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
            this.buttonTEMİZLE = new System.Windows.Forms.Button();
            this.buttonSIL = new System.Windows.Forms.Button();
            this.buttonGUNCELLE = new System.Windows.Forms.Button();
            this.buttonEKLE = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAracModel = new System.Windows.Forms.ComboBox();
            this.comboBoxAdSoyad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTEMİZLE
            // 
            this.buttonTEMİZLE.Location = new System.Drawing.Point(87, 227);
            this.buttonTEMİZLE.Name = "buttonTEMİZLE";
            this.buttonTEMİZLE.Size = new System.Drawing.Size(77, 33);
            this.buttonTEMİZLE.TabIndex = 7;
            this.buttonTEMİZLE.Text = "TEMİZLE";
            this.buttonTEMİZLE.UseVisualStyleBackColor = true;
            this.buttonTEMİZLE.Click += new System.EventHandler(this.buttonTEMİZLE_Click);
            // 
            // buttonSIL
            // 
            this.buttonSIL.Location = new System.Drawing.Point(4, 227);
            this.buttonSIL.Name = "buttonSIL";
            this.buttonSIL.Size = new System.Drawing.Size(77, 33);
            this.buttonSIL.TabIndex = 6;
            this.buttonSIL.Text = "SİL";
            this.buttonSIL.UseVisualStyleBackColor = true;
            this.buttonSIL.Click += new System.EventHandler(this.buttonSIL_Click);
            // 
            // buttonGUNCELLE
            // 
            this.buttonGUNCELLE.Location = new System.Drawing.Point(87, 188);
            this.buttonGUNCELLE.Name = "buttonGUNCELLE";
            this.buttonGUNCELLE.Size = new System.Drawing.Size(77, 33);
            this.buttonGUNCELLE.TabIndex = 5;
            this.buttonGUNCELLE.Text = "GÜNCELLE";
            this.buttonGUNCELLE.UseVisualStyleBackColor = true;
            this.buttonGUNCELLE.Click += new System.EventHandler(this.buttonGUNCELLE_Click);
            // 
            // buttonEKLE
            // 
            this.buttonEKLE.Location = new System.Drawing.Point(4, 188);
            this.buttonEKLE.Name = "buttonEKLE";
            this.buttonEKLE.Size = new System.Drawing.Size(77, 33);
            this.buttonEKLE.TabIndex = 4;
            this.buttonEKLE.Text = "EKLE";
            this.buttonEKLE.UseVisualStyleBackColor = true;
            this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(4, 159);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // comboBoxAracModel
            // 
            this.comboBoxAracModel.FormattingEnabled = true;
            this.comboBoxAracModel.Location = new System.Drawing.Point(7, 80);
            this.comboBoxAracModel.Name = "comboBoxAracModel";
            this.comboBoxAracModel.Size = new System.Drawing.Size(166, 21);
            this.comboBoxAracModel.TabIndex = 12;
            // 
            // comboBoxAdSoyad
            // 
            this.comboBoxAdSoyad.FormattingEnabled = true;
            this.comboBoxAdSoyad.Location = new System.Drawing.Point(4, 40);
            this.comboBoxAdSoyad.Name = "comboBoxAdSoyad";
            this.comboBoxAdSoyad.Size = new System.Drawing.Size(169, 21);
            this.comboBoxAdSoyad.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Araç Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Alınış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "İade Tarihi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSIL);
            this.groupBox1.Controls.Add(this.buttonTEMİZLE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxAdSoyad);
            this.groupBox1.Controls.Add(this.comboBoxAracModel);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.buttonGUNCELLE);
            this.groupBox1.Controls.Add(this.buttonEKLE);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 264);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralama Kayıt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 225);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            // 
            // FormKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKiralama";
            this.Text = "FormKiralama";
            this.Load += new System.EventHandler(this.FormKiralama_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTEMİZLE;
        private System.Windows.Forms.Button buttonSIL;
        private System.Windows.Forms.Button buttonGUNCELLE;
        private System.Windows.Forms.Button buttonEKLE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBoxAracModel;
        private System.Windows.Forms.ComboBox comboBoxAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}