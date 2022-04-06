namespace ApartmanOtomasyon
{
    partial class Gelirler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDaireNo = new System.Windows.Forms.ComboBox();
            this.numericUDTutar = new System.Windows.Forms.NumericUpDown();
            this.dateTimeGelirlerTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lBoxDaireNo = new System.Windows.Forms.ListBox();
            this.lBoxTutar = new System.Windows.Forms.ListBox();
            this.lBoxTarih = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDTutar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daire No: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(59, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(454, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih: ";
            // 
            // comboBoxDaireNo
            // 
            this.comboBoxDaireNo.FormattingEnabled = true;
            this.comboBoxDaireNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxDaireNo.Location = new System.Drawing.Point(169, 48);
            this.comboBoxDaireNo.Name = "comboBoxDaireNo";
            this.comboBoxDaireNo.Size = new System.Drawing.Size(213, 37);
            this.comboBoxDaireNo.TabIndex = 3;
            // 
            // numericUDTutar
            // 
            this.numericUDTutar.Location = new System.Drawing.Point(169, 109);
            this.numericUDTutar.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUDTutar.Name = "numericUDTutar";
            this.numericUDTutar.Size = new System.Drawing.Size(213, 35);
            this.numericUDTutar.TabIndex = 4;
            // 
            // dateTimeGelirlerTarih
            // 
            this.dateTimeGelirlerTarih.Location = new System.Drawing.Point(551, 48);
            this.dateTimeGelirlerTarih.Name = "dateTimeGelirlerTarih";
            this.dateTimeGelirlerTarih.Size = new System.Drawing.Size(237, 35);
            this.dateTimeGelirlerTarih.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(529, 122);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(280, 63);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeGelirlerTarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUDTutar);
            this.groupBox1.Controls.Add(this.comboBoxDaireNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 230);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelirler";
            // 
            // lBoxDaireNo
            // 
            this.lBoxDaireNo.FormattingEnabled = true;
            this.lBoxDaireNo.ItemHeight = 20;
            this.lBoxDaireNo.Location = new System.Drawing.Point(0, 26);
            this.lBoxDaireNo.Name = "lBoxDaireNo";
            this.lBoxDaireNo.Size = new System.Drawing.Size(183, 204);
            this.lBoxDaireNo.TabIndex = 8;
            // 
            // lBoxTutar
            // 
            this.lBoxTutar.FormattingEnabled = true;
            this.lBoxTutar.ItemHeight = 20;
            this.lBoxTutar.Location = new System.Drawing.Point(8, 26);
            this.lBoxTutar.Name = "lBoxTutar";
            this.lBoxTutar.Size = new System.Drawing.Size(186, 204);
            this.lBoxTutar.TabIndex = 9;
            // 
            // lBoxTarih
            // 
            this.lBoxTarih.FormattingEnabled = true;
            this.lBoxTarih.ItemHeight = 20;
            this.lBoxTarih.Location = new System.Drawing.Point(6, 32);
            this.lBoxTarih.Name = "lBoxTarih";
            this.lBoxTarih.Size = new System.Drawing.Size(189, 204);
            this.lBoxTarih.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBoxDaireNo);
            this.groupBox2.Location = new System.Drawing.Point(31, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 242);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daire No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lBoxTutar);
            this.groupBox3.Location = new System.Drawing.Point(351, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 242);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tutar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lBoxTarih);
            this.groupBox4.Location = new System.Drawing.Point(667, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 242);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tarih";
            // 
            // Gelirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(905, 526);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Gelirler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelirler";
            this.Load += new System.EventHandler(this.Gelirler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUDTutar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDaireNo;
        private System.Windows.Forms.NumericUpDown numericUDTutar;
        private System.Windows.Forms.DateTimePicker dateTimeGelirlerTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lBoxDaireNo;
        private System.Windows.Forms.ListBox lBoxTutar;
        private System.Windows.Forms.ListBox lBoxTarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}