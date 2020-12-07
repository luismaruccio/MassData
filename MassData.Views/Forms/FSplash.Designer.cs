
namespace MassData.Views.Forms
{
    partial class FSplash
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
            this.picbxLoading = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblbStatus = new System.Windows.Forms.Label();
            this.picbcLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxLoading
            // 
            this.picbxLoading.Location = new System.Drawing.Point(281, 154);
            this.picbxLoading.Name = "picbxLoading";
            this.picbxLoading.Size = new System.Drawing.Size(200, 200);
            this.picbxLoading.TabIndex = 0;
            this.picbxLoading.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(99)))));
            this.lblTitle.Location = new System.Drawing.Point(297, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MassData";
            // 
            // lblbStatus
            // 
            this.lblbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.lblbStatus.Location = new System.Drawing.Point(12, 376);
            this.lblbStatus.Name = "lblbStatus";
            this.lblbStatus.Size = new System.Drawing.Size(745, 47);
            this.lblbStatus.TabIndex = 2;
            this.lblbStatus.Text = "Gerando Dados X";
            this.lblbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbcLogo
            // 
            this.picbcLogo.Location = new System.Drawing.Point(225, 45);
            this.picbcLogo.Name = "picbcLogo";
            this.picbcLogo.Size = new System.Drawing.Size(66, 66);
            this.picbcLogo.TabIndex = 3;
            this.picbcLogo.TabStop = false;
            // 
            // FSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 432);
            this.Controls.Add(this.picbcLogo);
            this.Controls.Add(this.lblbStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picbxLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSplash";
            this.Load += new System.EventHandler(this.FSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbcLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxLoading;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblbStatus;
        private System.Windows.Forms.PictureBox picbcLogo;
    }
}