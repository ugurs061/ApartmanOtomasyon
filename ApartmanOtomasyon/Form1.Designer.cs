namespace ApartmanOtomasyon
{
    partial class Form1
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
            this.btnGelirler = new System.Windows.Forms.Button();
            this.btnGiderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGelirler
            // 
            this.btnGelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirler.Location = new System.Drawing.Point(53, 54);
            this.btnGelirler.Name = "btnGelirler";
            this.btnGelirler.Size = new System.Drawing.Size(172, 311);
            this.btnGelirler.TabIndex = 0;
            this.btnGelirler.Text = "Gelirler";
            this.btnGelirler.UseVisualStyleBackColor = true;
            this.btnGelirler.Click += new System.EventHandler(this.btnGelirler_Click);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.Location = new System.Drawing.Point(564, 54);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(172, 311);
            this.btnGiderler.TabIndex = 1;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.UseVisualStyleBackColor = true;
            this.btnGiderler.Click += new System.EventHandler(this.btnGiderler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiderler);
            this.Controls.Add(this.btnGelirler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartman Otomasyon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGelirler;
        private System.Windows.Forms.Button btnGiderler;
    }
}

