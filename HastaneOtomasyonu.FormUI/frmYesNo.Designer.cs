
namespace HastaneOtomasyonu.FormUI
{
    partial class frmYesNo
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
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.btnYes = new MaterialSkin.Controls.MaterialButton();
            this.btnNo = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessage.Location = new System.Drawing.Point(13, 79);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(227, 208);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "materialLabel1";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYes.Depth = 0;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.DrawShadows = true;
            this.btnYes.HighEmphasis = true;
            this.btnYes.Icon = null;
            this.btnYes.Location = new System.Drawing.Point(13, 293);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnYes.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 36);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Evet";
            this.btnYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnYes.UseAccentColor = false;
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNo.Depth = 0;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.DrawShadows = true;
            this.btnNo.HighEmphasis = true;
            this.btnNo.Icon = null;
            this.btnNo.Location = new System.Drawing.Point(140, 293);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNo.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 36);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Hayır";
            this.btnNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNo.UseAccentColor = false;
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // frmYesNo
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 344);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYesNo";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.frmYesNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblMessage;
        private MaterialSkin.Controls.MaterialButton btnYes;
        private MaterialSkin.Controls.MaterialButton btnNo;
    }
}