namespace ApartmanOtomasyon
{
    partial class Giderler
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
            this.cbElektrik = new System.Windows.Forms.CheckBox();
            this.cbSu = new System.Windows.Forms.CheckBox();
            this.cbAsansor = new System.Windows.Forms.CheckBox();
            this.cbTemizlik = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimeGiderTarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lBoxGider = new System.Windows.Forms.ListBox();
            this.lBoxTutar = new System.Windows.Forms.ListBox();
            this.lBoxTarih = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbElektrik
            // 
            this.cbElektrik.AutoSize = true;
            this.cbElektrik.Location = new System.Drawing.Point(74, 36);
            this.cbElektrik.Name = "cbElektrik";
            this.cbElektrik.Size = new System.Drawing.Size(127, 33);
            this.cbElektrik.TabIndex = 0;
            this.cbElektrik.Text = "Elektrik";
            this.cbElektrik.UseVisualStyleBackColor = true;
            // 
            // cbSu
            // 
            this.cbSu.AutoSize = true;
            this.cbSu.Location = new System.Drawing.Point(74, 81);
            this.cbSu.Name = "cbSu";
            this.cbSu.Size = new System.Drawing.Size(70, 33);
            this.cbSu.TabIndex = 1;
            this.cbSu.Text = "Su";
            this.cbSu.UseVisualStyleBackColor = true;
            // 
            // cbAsansor
            // 
            this.cbAsansor.AutoSize = true;
            this.cbAsansor.Location = new System.Drawing.Point(74, 126);
            this.cbAsansor.Name = "cbAsansor";
            this.cbAsansor.Size = new System.Drawing.Size(133, 33);
            this.cbAsansor.TabIndex = 2;
            this.cbAsansor.Text = "Asansör";
            this.cbAsansor.UseVisualStyleBackColor = true;
            // 
            // cbTemizlik
            // 
            this.cbTemizlik.AutoSize = true;
            this.cbTemizlik.Location = new System.Drawing.Point(74, 170);
            this.cbTemizlik.Name = "cbTemizlik";
            this.cbTemizlik.Size = new System.Drawing.Size(138, 33);
            this.cbTemizlik.TabIndex = 3;
            this.cbTemizlik.Text = "Temizlik";
            this.cbTemizlik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(428, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(231, 35);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dateTimeGiderTarih
            // 
            this.dateTimeGiderTarih.Location = new System.Drawing.Point(428, 94);
            this.dateTimeGiderTarih.Name = "dateTimeGiderTarih";
            this.dateTimeGiderTarih.Size = new System.Drawing.Size(230, 35);
            this.dateTimeGiderTarih.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbElektrik);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbSu);
            this.groupBox1.Controls.Add(this.dateTimeGiderTarih);
            this.groupBox1.Controls.Add(this.cbAsansor);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.cbTemizlik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(71, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 230);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giderler";
            // 
            // lBoxGider
            // 
            this.lBoxGider.FormattingEnabled = true;
            this.lBoxGider.ItemHeight = 20;
            this.lBoxGider.Location = new System.Drawing.Point(5, 25);
            this.lBoxGider.Name = "lBoxGider";
            this.lBoxGider.Size = new System.Drawing.Size(191, 224);
            this.lBoxGider.TabIndex = 10;
            // 
            // lBoxTutar
            // 
            this.lBoxTutar.FormattingEnabled = true;
            this.lBoxTutar.ItemHeight = 20;
            this.lBoxTutar.Location = new System.Drawing.Point(11, 25);
            this.lBoxTutar.Name = "lBoxTutar";
            this.lBoxTutar.Size = new System.Drawing.Size(185, 224);
            this.lBoxTutar.TabIndex = 11;
            // 
            // lBoxTarih
            // 
            this.lBoxTarih.FormattingEnabled = true;
            this.lBoxTarih.ItemHeight = 20;
            this.lBoxTarih.Location = new System.Drawing.Point(11, 25);
            this.lBoxTarih.Name = "lBoxTarih";
            this.lBoxTarih.Size = new System.Drawing.Size(185, 224);
            this.lBoxTarih.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBoxGider);
            this.groupBox2.Location = new System.Drawing.Point(37, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 263);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gider İsmi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lBoxTutar);
            this.groupBox3.Location = new System.Drawing.Point(340, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 263);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tutar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lBoxTarih);
            this.groupBox4.Location = new System.Drawing.Point(646, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 263);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tarih";
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(887, 530);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Giderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbElektrik;
        private System.Windows.Forms.CheckBox cbSu;
        private System.Windows.Forms.CheckBox cbAsansor;
        private System.Windows.Forms.CheckBox cbTemizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimeGiderTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lBoxGider;
        private System.Windows.Forms.ListBox lBoxTutar;
        private System.Windows.Forms.ListBox lBoxTarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}