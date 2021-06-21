
namespace HastaneOtomasyonu.FormUI
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnPatient = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDoctor = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPatient.BackColor = System.Drawing.SystemColors.Control;
            this.btnPatient.Depth = 0;
            this.btnPatient.DrawShadows = true;
            this.btnPatient.HighEmphasis = true;
            this.btnPatient.Icon = null;
            this.btnPatient.Location = new System.Drawing.Point(402, 299);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPatient.MaximumSize = new System.Drawing.Size(300, 0);
            this.btnPatient.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnPatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(200, 36);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Hasta";
            this.btnPatient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPatient.UseAccentColor = false;
            this.btnPatient.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(700, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnDoctor
            // 
            this.btnDoctor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDoctor.Depth = 0;
            this.btnDoctor.DrawShadows = true;
            this.btnDoctor.HighEmphasis = true;
            this.btnDoctor.Icon = null;
            this.btnDoctor.Location = new System.Drawing.Point(194, 299);
            this.btnDoctor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDoctor.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(200, 36);
            this.btnDoctor.TabIndex = 7;
            this.btnDoctor.Text = "Doktor";
            this.btnDoctor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDoctor.UseAccentColor = false;
            this.btnDoctor.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(311, 233);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(191, 41);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Sistem Girişi";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPatient);
            this.Name = "HomePage";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton btnDoctor;
        private MaterialSkin.Controls.MaterialButton btnPatient;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}