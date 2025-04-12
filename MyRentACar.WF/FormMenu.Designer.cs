namespace MyRentACar.WF
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAracKayit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMusteriKayit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonKiralama = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAracKayit,
            this.toolStripButtonMusteriKayit,
            this.toolStripButtonKiralama});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAracKayit
            // 
            this.toolStripButtonAracKayit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAracKayit.Image")));
            this.toolStripButtonAracKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAracKayit.Name = "toolStripButtonAracKayit";
            this.toolStripButtonAracKayit.Size = new System.Drawing.Size(80, 22);
            this.toolStripButtonAracKayit.Text = "Araç Kayıt";
            this.toolStripButtonAracKayit.Click += new System.EventHandler(this.toolStripButtonAracKayit_Click);
            // 
            // toolStripButtonMusteriKayit
            // 
            this.toolStripButtonMusteriKayit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMusteriKayit.Image")));
            this.toolStripButtonMusteriKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMusteriKayit.Name = "toolStripButtonMusteriKayit";
            this.toolStripButtonMusteriKayit.Size = new System.Drawing.Size(96, 22);
            this.toolStripButtonMusteriKayit.Text = "Müşteri Kayıt";
            this.toolStripButtonMusteriKayit.Click += new System.EventHandler(this.toolStripButtonMusteriKayit_Click);
            // 
            // toolStripButtonKiralama
            // 
            this.toolStripButtonKiralama.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKiralama.Image")));
            this.toolStripButtonKiralama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKiralama.Name = "toolStripButtonKiralama";
            this.toolStripButtonKiralama.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonKiralama.Text = "Kiralama";
            this.toolStripButtonKiralama.Click += new System.EventHandler(this.toolStripButtonKiralama_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 632);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAracKayit;
        private System.Windows.Forms.ToolStripButton toolStripButtonMusteriKayit;
        private System.Windows.Forms.ToolStripButton toolStripButtonKiralama;
    }
}