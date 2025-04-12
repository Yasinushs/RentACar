namespace MyRentACar.WF
{
    partial class FormAraclar
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
            this.buttonEKLE = new System.Windows.Forms.Button();
            this.buttonGUNCELLE = new System.Windows.Forms.Button();
            this.buttonSIL = new System.Windows.Forms.Button();
            this.buttonTEMİZLE = new System.Windows.Forms.Button();
            this.textBoxAracModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEKLE
            // 
            this.buttonEKLE.Location = new System.Drawing.Point(6, 106);
            this.buttonEKLE.Name = "buttonEKLE";
            this.buttonEKLE.Size = new System.Drawing.Size(77, 33);
            this.buttonEKLE.TabIndex = 0;
            this.buttonEKLE.Text = "EKLE";
            this.buttonEKLE.UseVisualStyleBackColor = true;
            this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click);
            // 
            // buttonGUNCELLE
            // 
            this.buttonGUNCELLE.Location = new System.Drawing.Point(89, 106);
            this.buttonGUNCELLE.Name = "buttonGUNCELLE";
            this.buttonGUNCELLE.Size = new System.Drawing.Size(77, 33);
            this.buttonGUNCELLE.TabIndex = 1;
            this.buttonGUNCELLE.Text = "GÜNCELLE";
            this.buttonGUNCELLE.UseVisualStyleBackColor = true;
            this.buttonGUNCELLE.Click += new System.EventHandler(this.buttonGUNCELLE_Click);
            // 
            // buttonSIL
            // 
            this.buttonSIL.Location = new System.Drawing.Point(6, 145);
            this.buttonSIL.Name = "buttonSIL";
            this.buttonSIL.Size = new System.Drawing.Size(77, 33);
            this.buttonSIL.TabIndex = 2;
            this.buttonSIL.Text = "SİL";
            this.buttonSIL.UseVisualStyleBackColor = true;
            this.buttonSIL.Click += new System.EventHandler(this.buttonSIL_Click);
            // 
            // buttonTEMİZLE
            // 
            this.buttonTEMİZLE.Location = new System.Drawing.Point(89, 145);
            this.buttonTEMİZLE.Name = "buttonTEMİZLE";
            this.buttonTEMİZLE.Size = new System.Drawing.Size(77, 33);
            this.buttonTEMİZLE.TabIndex = 3;
            this.buttonTEMİZLE.Text = "TEMİZLE";
            this.buttonTEMİZLE.UseVisualStyleBackColor = true;
            this.buttonTEMİZLE.Click += new System.EventHandler(this.buttonTEMİZLE_Click);
            // 
            // textBoxAracModel
            // 
            this.textBoxAracModel.Location = new System.Drawing.Point(6, 41);
            this.textBoxAracModel.Name = "textBoxAracModel";
            this.textBoxAracModel.Size = new System.Drawing.Size(169, 20);
            this.textBoxAracModel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Araç Modeli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eklenme Tarihi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAracModel);
            this.groupBox1.Controls.Add(this.buttonTEMİZLE);
            this.groupBox1.Controls.Add(this.buttonSIL);
            this.groupBox1.Controls.Add(this.buttonGUNCELLE);
            this.groupBox1.Controls.Add(this.buttonEKLE);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Kayıt";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 219);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Araç Listesi:";
            // 
            // FormAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAraclar";
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.FormAraclar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEKLE;
        private System.Windows.Forms.Button buttonGUNCELLE;
        private System.Windows.Forms.Button buttonSIL;
        private System.Windows.Forms.Button buttonTEMİZLE;
        private System.Windows.Forms.TextBox textBoxAracModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}

