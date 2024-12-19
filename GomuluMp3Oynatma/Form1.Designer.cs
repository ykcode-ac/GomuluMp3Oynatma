namespace GomuluMp3Oynatma
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
            this.btnBaslaDur = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaslaDur
            // 
            this.btnBaslaDur.Location = new System.Drawing.Point(51, 40);
            this.btnBaslaDur.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBaslaDur.Name = "btnBaslaDur";
            this.btnBaslaDur.Size = new System.Drawing.Size(165, 111);
            this.btnBaslaDur.TabIndex = 0;
            this.btnBaslaDur.Text = "Başlat";
            this.btnBaslaDur.UseVisualStyleBackColor = true;
            this.btnBaslaDur.Click += new System.EventHandler(this.btnBaslaDur_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(228, 40);
            this.btnDurdur.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(165, 111);
            this.btnDurdur.TabIndex = 1;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(467, 198);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaslaDur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "yazilimkodlama.com";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaslaDur;
        private System.Windows.Forms.Button btnDurdur;
    }
}

