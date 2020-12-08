
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.spnlLayouts = new MassData.Views.Classes.ShadowPanel();
            this.spnlSearch = new MassData.Views.Classes.ShadowPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvLayouts = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLayoutTitle = new System.Windows.Forms.Label();
            this.spnlForms = new MassData.Views.Classes.ShadowPanel();
            this.pnlLineBottomSearch = new System.Windows.Forms.Panel();
            this.spnlLayouts.SuspendLayout();
            this.spnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayouts)).BeginInit();
            this.SuspendLayout();
            // 
            // spnlLayouts
            // 
            this.spnlLayouts.BackColor = System.Drawing.Color.White;
            this.spnlLayouts.Controls.Add(this.spnlSearch);
            this.spnlLayouts.Controls.Add(this.dgvLayouts);
            this.spnlLayouts.Controls.Add(this.btnNew);
            this.spnlLayouts.Controls.Add(this.btnEdit);
            this.spnlLayouts.Controls.Add(this.btnDel);
            this.spnlLayouts.Controls.Add(this.panel1);
            this.spnlLayouts.Controls.Add(this.lblLayoutTitle);
            this.spnlLayouts.Location = new System.Drawing.Point(12, 43);
            this.spnlLayouts.Name = "spnlLayouts";
            this.spnlLayouts.Size = new System.Drawing.Size(314, 519);
            this.spnlLayouts.TabIndex = 3;
            // 
            // spnlSearch
            // 
            this.spnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.spnlSearch.Controls.Add(this.pnlLineBottomSearch);
            this.spnlSearch.Controls.Add(this.btnSearch);
            this.spnlSearch.Controls.Add(this.txtSearch);
            this.spnlSearch.Location = new System.Drawing.Point(15, 52);
            this.spnlSearch.Name = "spnlSearch";
            this.spnlSearch.Size = new System.Drawing.Size(284, 47);
            this.spnlSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(241, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(10, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvLayouts
            // 
            this.dgvLayouts.AllowUserToAddRows = false;
            this.dgvLayouts.AllowUserToDeleteRows = false;
            this.dgvLayouts.BackgroundColor = System.Drawing.Color.White;
            this.dgvLayouts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLayouts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLayouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayouts.Location = new System.Drawing.Point(15, 105);
            this.dgvLayouts.MultiSelect = false;
            this.dgvLayouts.Name = "dgvLayouts";
            this.dgvLayouts.ReadOnly = true;
            this.dgvLayouts.RowHeadersVisible = false;
            this.dgvLayouts.RowTemplate.Height = 25;
            this.dgvLayouts.ShowEditingIcon = false;
            this.dgvLayouts.Size = new System.Drawing.Size(284, 399);
            this.dgvLayouts.TabIndex = 5;
            this.dgvLayouts.SelectionChanged += new System.EventHandler(this.dgvLayouts_SelectionChanged);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(187, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 36);
            this.btnNew.TabIndex = 4;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(225, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(263, 7);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(36, 36);
            this.btnDel.TabIndex = 2;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Location = new System.Drawing.Point(15, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 1);
            this.panel1.TabIndex = 1;
            // 
            // lblLayoutTitle
            // 
            this.lblLayoutTitle.AutoSize = true;
            this.lblLayoutTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLayoutTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLayoutTitle.Location = new System.Drawing.Point(12, 10);
            this.lblLayoutTitle.Name = "lblLayoutTitle";
            this.lblLayoutTitle.Size = new System.Drawing.Size(75, 25);
            this.lblLayoutTitle.TabIndex = 0;
            this.lblLayoutTitle.Text = "Layouts";
            // 
            // spnlForms
            // 
            this.spnlForms.BackColor = System.Drawing.Color.White;
            this.spnlForms.Location = new System.Drawing.Point(337, 43);
            this.spnlForms.Name = "spnlForms";
            this.spnlForms.Size = new System.Drawing.Size(897, 519);
            this.spnlForms.TabIndex = 4;
            this.spnlForms.Paint += new System.Windows.Forms.PaintEventHandler(this.shadowPanel2_Paint);
            // 
            // pnlLineBottomSearch
            // 
            this.pnlLineBottomSearch.BackColor = System.Drawing.Color.White;
            this.pnlLineBottomSearch.Location = new System.Drawing.Point(10, 37);
            this.pnlLineBottomSearch.Name = "pnlLineBottomSearch";
            this.pnlLineBottomSearch.Size = new System.Drawing.Size(262, 1);
            this.pnlLineBottomSearch.TabIndex = 4;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1246, 574);
            this.Controls.Add(this.spnlForms);
            this.Controls.Add(this.spnlLayouts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.Shown += new System.EventHandler(this.FMain_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FMain_Paint);
            this.Resize += new System.EventHandler(this.FMain_Resize);
            this.Controls.SetChildIndex(this.spnlLayouts, 0);
            this.Controls.SetChildIndex(this.spnlForms, 0);
            this.spnlLayouts.ResumeLayout(false);
            this.spnlLayouts.PerformLayout();
            this.spnlSearch.ResumeLayout(false);
            this.spnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayouts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Classes.ShadowPanel spnlLayouts;
        private Classes.ShadowPanel spnlForms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLayoutTitle;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvLayouts;
        private Classes.ShadowPanel spnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlLineBottomSearch;
    }
}