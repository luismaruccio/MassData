
namespace MassData.Views.Forms
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
            this.spnlLayouts = new MassData.Views.Classes.ShadowPanel();
            this.shadowPanel2 = new MassData.Views.Classes.ShadowPanel();
            this.lblLayoutTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spnlLayouts.SuspendLayout();
            this.SuspendLayout();
            // 
            // spnlLayouts
            // 
            this.spnlLayouts.BackColor = System.Drawing.Color.White;
            this.spnlLayouts.Controls.Add(this.panel1);
            this.spnlLayouts.Controls.Add(this.lblLayoutTitle);
            this.spnlLayouts.Location = new System.Drawing.Point(12, 43);
            this.spnlLayouts.Name = "spnlLayouts";
            this.spnlLayouts.Size = new System.Drawing.Size(314, 519);
            this.spnlLayouts.TabIndex = 3;
            // 
            // shadowPanel2
            // 
            this.shadowPanel2.BackColor = System.Drawing.Color.White;
            this.shadowPanel2.Location = new System.Drawing.Point(337, 43);
            this.shadowPanel2.Name = "shadowPanel2";
            this.shadowPanel2.Size = new System.Drawing.Size(891, 519);
            this.shadowPanel2.TabIndex = 4;
            this.shadowPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.shadowPanel2_Paint);
            // 
            // lblLayoutTitle
            // 
            this.lblLayoutTitle.AutoSize = true;
            this.lblLayoutTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLayoutTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLayoutTitle.Location = new System.Drawing.Point(15, 10);
            this.lblLayoutTitle.Name = "lblLayoutTitle";
            this.lblLayoutTitle.Size = new System.Drawing.Size(75, 25);
            this.lblLayoutTitle.TabIndex = 0;
            this.lblLayoutTitle.Text = "Layouts";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Location = new System.Drawing.Point(15, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 1);
            this.panel1.TabIndex = 1;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1246, 574);
            this.Controls.Add(this.shadowPanel2);
            this.Controls.Add(this.spnlLayouts);
            this.Name = "FMain";
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FMain_Paint);
            this.Controls.SetChildIndex(this.spnlLayouts, 0);
            this.Controls.SetChildIndex(this.shadowPanel2, 0);
            this.spnlLayouts.ResumeLayout(false);
            this.spnlLayouts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Classes.ShadowPanel spnlLayouts;
        private Classes.ShadowPanel shadowPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLayoutTitle;
    }
}