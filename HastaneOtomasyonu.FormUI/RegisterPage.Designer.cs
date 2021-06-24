
namespace HastaneOtomasyonu.FormUI
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.txtId = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegis = new MaterialSkin.Controls.MaterialButton();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSurname = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.rbMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.cmbCity = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBday = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtId.Hint = "Tc Kimlik Numaranız";
            this.txtId.Location = new System.Drawing.Point(69, 228);
            this.txtId.MaxLength = 50;
            this.txtId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(328, 50);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "";
            // 
            // btnRegis
            // 
            this.btnRegis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegis.Depth = 0;
            this.btnRegis.DrawShadows = true;
            this.btnRegis.HighEmphasis = true;
            this.btnRegis.Icon = null;
            this.btnRegis.Location = new System.Drawing.Point(403, 377);
            this.btnRegis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegis.MinimumSize = new System.Drawing.Size(328, 0);
            this.btnRegis.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(328, 36);
            this.btnRegis.TabIndex = 8;
            this.btnRegis.Text = "Kayıt Ol";
            this.btnRegis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegis.UseAccentColor = false;
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtName.Hint = "Adınız";
            this.txtName.Location = new System.Drawing.Point(69, 172);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 50);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Depth = 0;
            this.txtSurname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSurname.Hint = "Soyadınız";
            this.txtSurname.Location = new System.Drawing.Point(403, 172);
            this.txtSurname.MaxLength = 50;
            this.txtSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(328, 50);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Text = "";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPhone.Hint = "Telefon Numaranız";
            this.txtPhone.Location = new System.Drawing.Point(403, 228);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(328, 50);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Depth = 0;
            this.rbMale.Location = new System.Drawing.Point(71, 337);
            this.rbMale.Margin = new System.Windows.Forms.Padding(0);
            this.rbMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMale.Name = "rbMale";
            this.rbMale.Ripple = true;
            this.rbMale.Size = new System.Drawing.Size(73, 37);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Erkek";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Depth = 0;
            this.rbFemale.Location = new System.Drawing.Point(169, 337);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Ripple = true;
            this.rbFemale.Size = new System.Drawing.Size(76, 37);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Kadın";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // cmbCity
            // 
            this.cmbCity.AutoResize = false;
            this.cmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCity.Depth = 0;
            this.cmbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCity.DropDownHeight = 174;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.DropDownWidth = 121;
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Hint = "Şehir";
            this.cmbCity.IntegralHeight = false;
            this.cmbCity.ItemHeight = 43;
            this.cmbCity.Location = new System.Drawing.Point(403, 284);
            this.cmbCity.MaxDropDownItems = 4;
            this.cmbCity.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(328, 49);
            this.cmbCity.TabIndex = 5;
            // 
            // txtBday
            // 
            this.txtBday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBday.Depth = 0;
            this.txtBday.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBday.Hint = "Doğum Tarihiniz (01.01.2021)";
            this.txtBday.Location = new System.Drawing.Point(69, 284);
            this.txtBday.MaxLength = 50;
            this.txtBday.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBday.Multiline = false;
            this.txtBday.Name = "txtBday";
            this.txtBday.Size = new System.Drawing.Size(328, 50);
            this.txtBday.TabIndex = 4;
            this.txtBday.Text = "";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(69, 377);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(179, 1);
            this.materialDivider1.TabIndex = 24;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(11, 439);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(776, 1);
            this.materialDivider2.TabIndex = 25;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(403, 449);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MinimumSize = new System.Drawing.Size(328, 0);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(328, 36);
            this.materialButton1.TabIndex = 26;
            this.materialButton1.Text = "Girişe Dön";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtBday);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.txtId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Sayfası";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialButton btnRegis;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtSurname;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialRadioButton rbMale;
        private MaterialSkin.Controls.MaterialRadioButton rbFemale;
        private MaterialSkin.Controls.MaterialComboBox cmbCity;
        private MaterialSkin.Controls.MaterialTextBox txtBday;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}