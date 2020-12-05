
namespace MassData.Forms
{
    partial class FMain
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
            this.shadowPanel1 = new MassData.Classes.ShadowPanel();
            this.shadowPanel2 = new MassData.Classes.ShadowPanel();
            this.SuspendLayout();
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BackColor = System.Drawing.Color.White;
            this.shadowPanel1.Location = new System.Drawing.Point(12, 43);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.Size = new System.Drawing.Size(314, 519);
            this.shadowPanel1.TabIndex = 3;
            // 
            // shadowPanel2
            // 
            this.shadowPanel2.BackColor = System.Drawing.Color.White;
            this.shadowPanel2.Location = new System.Drawing.Point(337, 48);
            this.shadowPanel2.Name = "shadowPanel2";
            this.shadowPanel2.Size = new System.Drawing.Size(891, 514);
            this.shadowPanel2.TabIndex = 4;
            this.shadowPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.shadowPanel2_Paint);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1246, 574);
            this.Controls.Add(this.shadowPanel2);
            this.Controls.Add(this.shadowPanel1);
            this.Name = "FMain";
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FMain_Paint);
            this.Controls.SetChildIndex(this.shadowPanel1, 0);
            this.Controls.SetChildIndex(this.shadowPanel2, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Classes.ShadowPanel shadowPanel1;
        private Classes.ShadowPanel shadowPanel2;
    }
}